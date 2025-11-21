# Sistema de Controle de Acessos

## Descrição
Este projeto é um sistema de controle de acessos desenvolvido em **C#** com **Windows Forms**, utilizando **SQLite** como banco de dados. Ele permite gerenciar usuários, ambientes, permissões de acesso e registros de log de acessos.  

O sistema foi desenvolvido como projeto acadêmico, mas possui funcionalidades práticas para controle de acessos simples.

---

## Funcionalidades
- Adicionar, remover e pesquisar usuários
- Adicionar, remover e pesquisar ambientes
- Gerenciar permissões de acesso entre usuários e ambientes
- Registrar logs de acessos com data, hora e tipo de acesso
- Persistência de dados em banco SQLite (`controle_acesso.db`)
- Métodos de upload/download para sincronizar listas locais com o banco

---

## Estrutura do Projeto
- **Cadastro.cs**: Classe principal que gerencia usuários, ambientes, permissões e logs.
- **Usuario.cs**: Representa os usuários do sistema.
- **Ambiente.cs**: Representa os ambientes disponíveis.
- **Log.cs**: Representa os registros de acesso de cada usuário a um ambiente.
- **controle_acesso.db**: Banco de dados SQLite que armazena usuários, ambientes, logs e permissões.

---

## Tecnologias Utilizadas
- **C#** (.NET Framework / Windows Forms)
- **SQLite** (via pacote `Microsoft.Data.Sqlite` e `SQLitePCLRaw.bundle_e_sqlite3`)
- **Visual Studio** (IDE recomendada)

---

## Como Usar
1. Clonar o repositório:
   ```bash
   git clone <URL_DO_REPOSITORIO>
