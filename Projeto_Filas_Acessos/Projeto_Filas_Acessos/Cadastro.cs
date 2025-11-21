using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;//Isso permite que você use todos os recursos do SQLite.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Acessos
{
    internal class Cadastro
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Ambiente> ambientes = new List<Ambiente>();

        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }
        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public void adicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public bool removerUsuario(Usuario usuario)
        {
            if(usuario.Ambientes.Count > 0)
            {
                return false;
            }

            return Usuarios.Remove(usuario);
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            foreach (Usuario usuario1 in Usuarios)
            {
                if(usuario1.Id == usuario.Id)
                {
                    return usuario1;
                }
            }
            return null;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            Ambientes.Add(ambiente);
        }

        public bool removerAmbiente(Ambiente ambiente)
        {
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.Ambientes.Contains(ambiente))
                {
                    return false;
                }
            }

            return Ambientes.Remove(ambiente);
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente ambiente1 in Ambientes)
            {
                if (ambiente1.Id == ambiente.Id)
                {
                    return ambiente1;
                }
            }
            return null;
        }

        public void upload()// Aqui vamos colocar o código para criar o banco e as tabelas
        {
            //Vamos criar uma conexão com o arquivo controle_acesso.db.
            string conexaoString = "Data Source=controle_acesso.db;";//aponta para o arquivo que você criou //Version=3 → é a versão do SQLite
            using (var conexao = new SqliteConnection(conexaoString)) //using garante que a conexão será fechada automaticamente
            {
                conexao.Open();

                // Aqui vamos colocar os comandos SQL para criar as tabelas

                string sqlUsuario = @"
                CREATE TABLE IF NOT EXISTS usuario(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL);";

                //SQLiteCommand
                //Prepara o comando SQL.
                //ExecuteNonQuery() executa comandos que NÃO retornam dados.

                using (var cmd = new SqliteCommand(sqlUsuario, conexao))
                {
                    cmd.ExecuteNonQuery();
                }

                string sqlAmbiente = @"
                CREATE TABLE IF NOT EXISTS ambiente(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL
                );";

                using (var cmd = new SqliteCommand(sqlAmbiente, conexao))
                {
                    cmd.ExecuteNonQuery();
                }

                string sqlLog = @"
                CREATE TABLE IF NOT EXISTS log(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                dtAcesso TEXT NOT NULL,
                tipoAcesso INTEGER NOT NULL,
                usuario_id INTEGER NOT NULL,
                ambiente_id INTEGER NOT NULL,

                FOREIGN KEY(usuario_id) REFERENCES usuario(id),
                FOREIGN KEY(ambiente_id) REFERENCES ambiente(id)
                );";

                using (var cmd = new SqliteCommand(sqlLog, conexao))
                {
                    cmd.ExecuteNonQuery();
                }

                string sqlUsuarioAmbiente = @"
                CREATE TABLE IF NOT EXISTS usuario_ambiente(
                    usuario_id INTEGER NOT NULL,
                    ambiente_id INTEGER NOT NULL,
                    PRIMARY KEY(usuario_id, ambiente_id),
                    FOREIGN KEY(usuario_id) REFERENCES usuario(id),
                    FOREIGN KEY(ambiente_id) REFERENCES ambiente(id)
                );";

                using (var cmd = new SqliteCommand(sqlUsuarioAmbiente, conexao))
                {
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void download()
        {
            string conexaoString = "Data Source=controle_acesso.db;";
            using (var conexao = new SqliteConnection(conexaoString))
            {
                conexao.Open();

                
                Usuarios.Clear();
                Ambientes.Clear();

                // 2) BAIXAR USUÁRIOS
                using (var cmd = new SqliteCommand("SELECT id, name FROM usuario", conexao))
                using (var reader = cmd.ExecuteReader())//cmd.ExecuteReader() executa o SELECT.
                {
                    // --- LIMPAR LISTAS LOCAIS ---
                    // garante que estamos carregando do zero
                    Usuarios.Clear();

                    while (reader.Read())//Vai lendo linha por linha do resultado. Cada vez que chama Read(), ele vai para a próxima linha do SELECT.
                    {
                        Usuario u = new Usuario();
                        u.Id = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        Usuarios.Add(u);
                    }

                }

                // 3) BAIXAR AMBIENTES
                using (var cmd = new SqliteCommand("SELECT id, name FROM ambiente", conexao))
                using (var reader = cmd.ExecuteReader())//cmd.ExecuteReader() executa o SELECT.
                {
                    // --- LIMPAR LISTAS LOCAIS ---
                    // garante que estamos carregando do zero
                    Ambientes.Clear();

                    while (reader.Read())//Vai lendo linha por linha do resultado. Cada vez que chama Read(), ele vai para a próxima linha do SELECT.
                    {
                        Ambiente a = new Ambiente();
                        a.Id = reader.GetInt32(0);
                        a.Name = reader.GetString(1);
                        Ambientes.Add(a);
                    }
                }

                // 3) BAIXAR LOGS
                using (var cmd = new SqliteCommand("SELECT dtAcesso, tipoAcesso, usuario_id, ambiente_id FROM log", conexao))
                using (var reader = cmd.ExecuteReader())//cmd.ExecuteReader() executa o SELECT.
                {
                    // --- LIMPAR LISTAS LOCAIS ---
                    // garante que estamos carregando do zero
                    foreach(var amb in Ambientes)
                    {
                        amb.Logs.Clear();
                    }

                    while (reader.Read())//Vai lendo linha por linha do resultado. Cada vez que chama Read(), ele vai para a próxima linha do SELECT.
                    {
                        // criar log
                        Log log = new Log();
                        log.DtAcesso = DateTime.Parse(reader.GetString(0));
                        log.TipoAcesso = reader.GetInt32(1) == 1;
                        
                        int usuarioId = reader.GetInt32(2);                        
                        int ambienteId = reader.GetInt32(3);

                        // achar o usuário pelo ID
                        Usuario usuario = Usuarios.FirstOrDefault(u => u.Id == usuarioId);
                        // achar o ambiente pelo ID
                        Ambiente ambiente = Ambientes.FirstOrDefault(a => a.Id == ambienteId);

                        // associar usuário ao log
                        log.Usuario = usuario;

                        // colocar o log dentro da fila do ambiente correto
                        if (ambiente != null)
                        {
                            ambiente.Logs.Enqueue(log);
                        }                        
                    }
                }
            }
        }

        public void SalvarUsuario(Usuario usuario)
        {
            string conexaoString = "Data Source=controle_acesso.db;";
            using (var conexao = new SqliteConnection(conexaoString))
            {
                conexao.Open();

                string sql = "INSERT INTO usuario (name) VALUES (@name); SELECT last_insert_rowid();";
                using (var cmd = new SqliteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@name", usuario.Name);
                    usuario.Id = Convert.ToInt32(cmd.ExecuteScalar()); // pega o ID gerado pelo banco
                }
            }
        }

        public void SalvarAmbiente(Ambiente ambiente)
        {
            string conexaoString = "Data Source=controle_acesso.db;";
            using (var conexao = new SqliteConnection(conexaoString))
            {
                conexao.Open();

                string sql = "INSERT INTO ambiente (name) VALUES (@name); SELECT last_insert_rowid();";
                using (var cmd = new SqliteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@name", ambiente.Name);
                    ambiente.Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void SalvarLog(Log log, Ambiente ambiente)
        {
            string conexaoString = "Data Source=controle_acesso.db;";
            using (var conexao = new SqliteConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"INSERT INTO log (dtAcesso, tipoAcesso, usuario_id, ambiente_id)
                       VALUES (@dtAcesso, @tipoAcesso, @usuarioId, @ambienteId)";
                using (var cmd = new SqliteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@dtAcesso", log.DtAcesso.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@tipoAcesso", log.TipoAcesso ? 1 : 0);
                    cmd.Parameters.AddWithValue("@usuarioId", log.Usuario.Id);
                    cmd.Parameters.AddWithValue("@ambienteId", ambiente.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SalvarPermissao(Usuario usuario, Ambiente ambiente)
        {
            string conexaoString = "Data Source=controle_acesso.db;";
            using (var conexao = new SqliteConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
        INSERT OR IGNORE INTO usuario_ambiente(usuario_id, ambiente_id)
        VALUES(@usuario_id, @ambiente_id);";

                using (var cmd = new SqliteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario.Id);
                    cmd.Parameters.AddWithValue("@ambiente_id", ambiente.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoverPermissao(Usuario usuario, Ambiente ambiente)
        {
            string conexaoString = "Data Source=controle_acesso.db;";
            using (var conexao = new SqliteConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
        DELETE FROM usuario_ambiente 
        WHERE usuario_id = @usuario_id AND ambiente_id = @ambiente_id;";

                using (var cmd = new SqliteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuario.Id);
                    cmd.Parameters.AddWithValue("@ambiente_id", ambiente.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
