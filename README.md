## Blindando Seu Código com TDD e Testes Unitários Usando .NET Core

---

![WexQA](https://github.com/user-attachments/assets/962b6f87-6b2c-43c8-a87b-76dab92abd7c)


**Bootcamp WEX - Desenvolvimento .NET e QA**

---


calculadoraTDDTestes.
Calculadora com TDD e Testes Unitários em .NET 8
Este projeto é uma demonstração prática do Desenvolvimento Orientado a Testes (TDD), utilizando a plataforma .NET 8 e o framework xUnit para a criação de testes unitários. O objetivo principal foi desenvolver uma calculadora com funcionalidades básicas e um histórico de operações, garantindo a robustez do código através da escrita de testes antes da implementação da funcionalidade.

🚀 Tecnologias Utilizadas
 * Linguagem: C#
 * Plataforma: .NET 8
 * Framework de Testes: xUnit
 * Gerenciamento de Código: Git e GitHub

   
📐 Regras de Negócio Implementadas
A calculadora foi desenvolvida para atender às seguintes regras de negócio, que foram todas validadas por testes unitários:

 * Operações: Suporta as quatro operações básicas: Soma, Subtração, Multiplicação e Divisão.
 * Parâmetros: Cada operação aceita dois números inteiros.
   
 * Divisão por Zero: Lança uma exceção específica (ArgumentException) se houver tentativa de divisão por zero, garantindo a integridade do sistema.
 * Histórico de Operações: Mantém um histórico das últimas três operações realizadas.

   
⚙️ Como o TDD Foi Aplicado
O desenvolvimento seguiu o ciclo Red-Green-Refactor do TDD em cada funcionalidade:
 * 🔴 RED: Primeiro, um teste unitário foi escrito para uma funcionalidade ainda não implementada (ex: Subtrair). Ao rodar o teste, ele falhou, confirmando que a lógica necessária ainda não existia.

   
 * 🟢 GREEN: Em seguida, o código mínimo e necessário foi escrito para que o teste recém-criado passasse. O foco foi apenas em fazer o teste funcionar, sem preocupações com a elegância do código.

   
 * ♻️ REFACTOR: Com o teste passando, o código foi analisado e refatorado para melhorar sua legibilidade, performance ou estrutura, sem alterar seu comportamento. Como a nossa implementação foi simples, esta etapa não exigiu grandes mudanças.

   
📁 Estrutura do Projeto
O projeto é uma solução em .NET 8 com dois projetos principais:

 * Calculadora/: Projeto de produção, contendo a classe Calculadora.cs com toda a lógica das operações.
   
 * Calculadora.Testes/: Projeto de testes, contendo a classe CalculadoraTests.cs com todos os testes unitários que validam a lógica do projeto principal.
   
Essa separação garante que o código de teste e o código de produção estejam em pacotes distintos, facilitando a organização e o gerenciamento.

/calculadoraTDDTestes
|
├── Calculadora/
|   ├── Calculadora.csproj
|   └── Calculadora.cs
|
├── Calculadora.Testes/
|   ├── Calculadora.Testes.csproj
|   └── CalculadoraTests.cs
|
├── Calculadora.sln
└── README.md

▶️ Como Executar o Projeto
Para rodar o projeto, você precisa ter o SDK do .NET 8 instalado.

 * Clone o repositório:
   git clone https://github.com/Santosdevbjj/calculadoraTDDTestes.git
cd calculadoraTDDTestes

 * Execute os testes unitários:
   No terminal, a partir do diretório raiz do projeto, execute o comando:
   dotnet test

   Isso compilará a solução e executará todos os testes definidos, confirmando que todas as regras de negócio estão sendo seguidas corretamente.
   
📝 Contribuição
Sinta-se à vontade para contribuir com este projeto! Se encontrar bugs ou tiver sugestões de melhoria, abra uma issue ou envie um pull request.

Este README.md oferece uma visão clara do projeto, sua motivação e como ele foi desenvolvido, sendo um recurso valioso para qualquer um que visite o repositório.




 
