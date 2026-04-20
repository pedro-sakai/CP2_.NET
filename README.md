# EletronicosStore 

## 🎯 Objetivo do Projeto
Este projeto tem como objetivo implementar a camada de persistência e infraestrutura para um sistema de gerenciamento de loja de equipamentos eletrônicos. A solução segue os princípios de **Clean Architecture**, utilizando **.NET 10** e **Entity Framework Core** com o provider para **Oracle Database**.

---

## 👥 Integrantes do Grupo
* **Nome:** Pedro Sakai - **RM:** 565956


---

## 🏗️ Estrutura do Projeto (Clean Architecture)
O projeto está dividido em 4 camadas para garantir o desacoplamento e a testabilidade:

1.  **EletronicosStore.Domain**: Contém as entidades de negócio (`Produto`, `Categoria`, `Cliente`, `Pedido`, `ItemPedido`) e é independente de qualquer framework.
2.  **EletronicosStore.Application**: Define as interfaces de repositório e contratos de abstração.
3.  **EletronicosStore.Infrastructure**: Implementa a persistência, o `AppDbContext`, as configurações de **Fluent API** e as **Migrations**.
4.  **EletronicosStore.API**: Camada de entrada, configuração da Injeção de Dependência e controllers para exposição dos endpoints.

---

## 🛠️ Tecnologias Utilizadas
* .NET 10
* Entity Framework Core
* Oracle Entity Framework Core Provider
* Padrão Repository

---

## ⚙️ Como Executar o Projeto

### 1. Configuração da Connection String
Antes de rodar as migrations, abra o arquivo `appsettings.json` no projeto **EletronicosStore.API** e atualize a string de conexão com suas credenciais do Oracle:

```json
"ConnectionStrings": {
  "OracleConnection": "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=SEU_USUARIO;Password=SUA_SENHA;"
}
