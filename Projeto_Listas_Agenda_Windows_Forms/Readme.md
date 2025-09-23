# Projeto Agenda de Contatos - Windows Forms

![Banner](./imagens/banner.png)  
*Interface principal do sistema*

Este projeto é uma **Agenda de Contatos** desenvolvida em **C# com Windows Forms**, permitindo gerenciar contatos com dados pessoais e telefones de forma prática e visual.

---

## Funcionalidades

### Adicionar Contato
- Cadastro de nome, email, data de nascimento e telefone principal.
- Validação para não permitir emails duplicados.

![Adicionar Contato](./imagens/adicionar_contato.png)

---

### Alterar Contato
- Atualização de informações do contato, inclusive definir um telefone como principal.
- Permite adicionar novos telefones e alterar a data de nascimento.

![Alterar Contato](./imagens/alterar_contato.png)

---

### Remover Contato
- Remoção de contatos pelo email.
- Confirmação de sucesso após exclusão.

![Remover Contato](./imagens/remover_contato.png)

---

### Pesquisar Contato
- Localiza contatos pelo email.
- Exibe todas as informações do contato, incluindo telefone principal.

![Pesquisar Contato](./imagens/pesquisar_contato.png)

---

### Listar Contatos
- Mostra todos os contatos cadastrados em uma lista.
- Exibe email, nome, data de nascimento, idade e telefone principal.

![Listar Contatos](./imagens/listar_contatos.png)

---

## Tecnologias

- **Linguagem:** C#  
- **Plataforma:** Windows Forms  
- **IDE recomendada:** Visual Studio

---

## Estrutura do Projeto

- **Form1.cs**: Interface principal e lógica do usuário  
- **Contato.cs**: Classe que representa um contato  
- **Telefone.cs**: Classe que representa um telefone  
- **Data.cs**: Classe auxiliar para manipulação de datas  
- **Contatos.cs**: Classe que gerencia a lista de contatos  

---

## Como Usar

1. Clone o repositório:
```bash
git clone <URL_DO_REPOSITORIO>
