# Sistema de Controle de Medicamentos com Filas em C#

Projeto desenvolvido em C# utilizando estruturas de dados como **List** e **Queue** para gerenciar medicamentos, seus lotes, quantidades disponíveis, compras e vendas.  
O sistema funciona via console, exibindo um menu interativo com todas as operações solicitadas no enunciado do exercício.

---

## 🧪 Tecnologias utilizadas
- Linguagem: **C#**
- Plataforma: **.NET Framework / Console Application**
- Estruturas de dados:  
  - `List<Medicamento>`  
  - `Queue<Lote>`

---

## 📌 Funcionalidades do Sistema

### **1️⃣ Cadastrar medicamento**
- Insere um medicamento na lista principal.
- Dados: **id**, **nome**, **laboratório**.

---

### **2️⃣ Consultar medicamento (sintético)**
- Pesquisa um medicamento pelo ID.
- Retorna: **id, nome, laboratório e quantidade total disponível**.

---

### **3️⃣ Consultar medicamento (analítico)**
- Pesquisa um medicamento pelo ID.
- Exibe também todos os **lotes cadastrados**, com:
  - id do lote  
  - quantidade  
  - data de vencimento  

---

### **4️⃣ Comprar medicamento (cadastrar lote)**
- Solicita os dados do lote:
  - id do lote  
  - quantidade  
  - data de vencimento  
- Insere o lote na fila do medicamento (FIFO).

---

### **5️⃣ Vender medicamento**
- Solicita quantidade a vender.  
- A venda é realizada retirando dos **lotes mais antigos primeiro** (Queue).  
- Se não houver quantidade suficiente, informa erro.  
- Retira lotes da fila quando ficarem com quantidade zero.

---

### **6️⃣ Listar medicamentos (dados sintéticos)**
- Lista todos os medicamentos cadastrados no sistema.

---

## 📦 Estrutura das Classes

### **Classe Lote**
- id  
- quantidade  
- vencimento  
- ToString customizado

---

### **Classe Medicamento**
- id  
- nome  
- laboratório  
- fila de lotes (`Queue<Lote>`)  
- qtdeDisponivel() soma todos os lotes  
- comprar(): adiciona na fila  
- vender(): abate do lote mais antigo  
- Equals(): compara medicamentos pelo ID  

---

### **Classe Medicamentos**
- Lista de Medicamento  
- adicionar()  
- deletar()  
- pesquisar()  

---

## ▶️ Execução
Basta compilar e executar no console.  
O menu será exibido automaticamente:

```
0. Finalizar processo
1. Cadastrar medicamento
2. Consultar medicamento (sintético)
3. Consultar medicamento (analítico)
4. Comprar medicamento (cadastrar lote)
5. Vender medicamento (abater do lote mais antigo)
6. Listar medicamentos (dados sintéticos)
```

---

## 📚 Objetivo Educacional
Este projeto foi desenvolvido para treinar:
- Manipulação de listas e filas  
- Encapsulamento e orientação a objetos  
- Estruturas FIFO  
- Tratamento de dados no console  
- Implementação de Equals  
- Regras de negócio envolvendo estoque  

---

## 👤 Autor
**Matheus Penteado de Barros Pantojo**
