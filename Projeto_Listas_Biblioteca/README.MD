# 📚 Projeto Biblioteca (C# Console Application)

Este projeto é um sistema simples de gerenciamento de biblioteca desenvolvido em **C# Console Application**, utilizando conceitos de **Programação Orientada a Objetos (POO)**.  

O sistema permite cadastrar livros, controlar exemplares, registrar empréstimos e devoluções, além de consultar informações detalhadas sobre os títulos disponíveis.

---

## 🚀 Funcionalidades

O menu principal oferece as seguintes opções:

--------------------------------------
| 0. Sair                            |
| 1. Adicionar livro                 |
| 2. Pesquisar livro (sintético)     |
| 3. Pesquisar livro (analítico)     |
| 4. Adicionar exemplar              |
| 5. Registrar empréstimo            |
| 6. Registrar devolução             |
--------------------------------------

### 🔎 Detalhes das opções
- **Adicionar livro:** cadastra um novo livro no acervo informando ISBN, título, autor e editora.  
- **Pesquisar livro (sintético):** exibe dados básicos do livro, total de exemplares, disponíveis, empréstimos e percentual de disponibilidade.  
- **Pesquisar livro (analítico):** exibe as informações sintéticas + detalhes de cada exemplar e seu histórico de empréstimos.  
- **Adicionar exemplar:** insere um exemplar físico associado a um livro já cadastrado.  
- **Registrar empréstimo:** marca um exemplar disponível como emprestado.  
- **Registrar devolução:** finaliza um empréstimo em aberto de um exemplar.  

---

## 🛠️ Estrutura do Projeto

O projeto é composto pelas seguintes classes:

- **Livro** → representa um livro, contendo ISBN, título, autor, editora e sua lista de exemplares.  
- **Exemplar** → representa um exemplar físico de um livro, com seu histórico de empréstimos.  
- **Emprestimo** → armazena as datas de empréstimo e devolução de um exemplar.  
- **Livros** → gerencia a coleção de todos os livros do acervo.  
- **Program** → ponto de entrada, com o menu principal e a interação com o usuário.  

---

## 🖼️ Exemplo de uso

### Cadastro de livro
Digite o ISBN: 123  
Digite o título: C# Essencial  
Digite o autor: Matheus Penteado  
Digite a editora: OpenAI Books  
Livro adicionado com sucesso!  

### Pesquisa sintética
C# Essencial (ISBN 123) - Total: 2, Disponíveis: 1, Empr.: 1, %Disp: 50%  

### Pesquisa analítica
Livro: C# Essencial (ISBN 123)  
Autor: Matheus Penteado | Editora: OpenAI Books  
Exemplares:  
- Tombo: 1 | Empréstimos: 1 | Disponível: Não  
- Tombo: 2 | Empréstimos: 0 | Disponível: Sim  

---

## 📦 Como executar

1. Clone este repositório:  
   git clone https://github.com/seu-usuario/projeto-biblioteca.git  

2. Abra o projeto no **Visual Studio** ou **VS Code**.  

3. Compile e execute a aplicação.  

4. Utilize o menu para interagir com o sistema.  

---

## ✨ Tecnologias utilizadas
- C#  
- .NET (Console Application)  
- Programação Orientada a Objetos (POO)  

---

## 📌 Autor
Desenvolvido por **Matheus Penteado de Barros Pantojo** 👨‍💻
