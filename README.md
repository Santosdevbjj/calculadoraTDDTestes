## Blindando Seu Código com TDD e Testes Unitários Usando .NET Core

---

![WexQA](https://github.com/user-attachments/assets/962b6f87-6b2c-43c8-a87b-76dab92abd7c)


**Bootcamp WEX - Desenvolvimento .NET e QA**

---


**Calculadora com TDD e Testes Unitários em .NET 8**

Este projeto é uma demonstração prática do Desenvolvimento Orientado a Testes (TDD), utilizando a plataforma .NET 8 e o framework xUnit para a criação de testes unitários.

O objetivo principal foi desenvolver uma calculadora com funcionalidades básicas e um histórico de operações, garantindo a robustez do código através da escrita de testes antes da implementação da funcionalidade.

🚀 **Tecnologias Utilizadas**
 * **Linguagem:** C#
 * **Plataforma:** .NET 8
 * **Framework de Testes:** xUnit
 * **Gerenciamento de Código:** Git e GitHub

   
📐 **Regras de Negócio Implementadas** 
A calculadora foi desenvolvida para atender às seguintes regras de negócio, que foram todas validadas por testes unitários:

 * **Operações:** Suporta as quatro operações básicas: Soma, Subtração, Multiplicação e Divisão.
   
 * **Parâmetros:** Cada operação aceita dois números inteiros.
   
 * **Divisão por Zero:** Lança uma exceção específica (ArgumentException) se houver tentativa de divisão por zero, garantindo a integridade do sistema.
   
 * **Histórico de Operações:** Mantém um histórico das últimas três operações realizadas.

   
⚙️ **Como o TDD Foi Aplicado**
O desenvolvimento seguiu o ciclo Red-Green-Refactor do TDD em cada funcionalidade:
 * 🔴 **RED:** Primeiro, um teste unitário foi escrito para uma funcionalidade ainda não implementada (ex: Subtrair). Ao rodar o teste, ele falhou, confirmando que a lógica necessária ainda não existia.

   
 * 🟢 **GREEN:** Em seguida, o código mínimo e necessário foi escrito para que o teste recém-criado passasse. O foco foi apenas em fazer o teste funcionar, sem preocupações com a elegância do código.

   
 * ♻️ **REFACTOR:** Com o teste passando, o código foi analisado e refatorado para melhorar sua legibilidade, performance ou estrutura, sem alterar seu comportamento. Como a nossa implementação foi simples, esta etapa não exigiu grandes mudanças.

   
📁 **Estrutura do Projeto** 
O projeto é uma solução em .NET 8 com dois projetos principais:

 * **Calculadora/:** Projeto de produção, contendo a classe Calculadora.cs com toda a lógica das operações.
   
 * **Calculadora.Testes/:** Projeto de testes, contendo a classe CalculadoraTests.cs com todos os testes unitários que validam a lógica do projeto principal.
   
Essa separação garante que o código de teste e o código de produção estejam em pacotes distintos, facilitando a organização e o gerenciamento.


<img width="777" height="610" alt="Screenshot_20250902-203506" src="https://github.com/user-attachments/assets/3b964525-6046-4063-a207-414a186950e1" />



▶️ **Como Executar o Projeto**
Para rodar o projeto, você precisa ter o SDK do .NET 8 instalado.

 * **Clone o repositório:**
   **git clone** https://github.com/Santosdevbjj/calculadoraTDDTestes.git
cd calculadoraTDDTestes

 * **Execute os testes unitários:**
   No terminal, a partir do diretório raiz do projeto, execute o comando:
   **dotnet test**

   Isso compilará a solução e executará todos os testes definidos, confirmando que todas as regras de negócio estão sendo seguidas corretamente.

   ---


O foco em TDD (Desenvolvimento Orientado a Testes), Programação Orientada a Objetos (POO) e testes unitários é fundamental para entregar um produto de alta qualidade.



O projeto de uma calculadora com histórico é um excelente ponto de partida para demonstrar a aplicação desses conceitos.



Estrutura do Projeto
​O projeto será organizado em uma solução com dois projetos distintos, o que é uma prática recomendada para separar o código de produção do código de teste.


​Calculadora.cs: Este será o projeto principal em .NET Core que conterá a classe Calculadora e a lógica das operações.
​Calculadora.Testes.cs: Este será o projeto de testes, utilizando a biblioteca xUnit para escrever e executar os testes unitários. Ele terá uma referência ao projeto Calculadora.cs. 


Essa separação garante que o código de teste não seja incluído na aplicação final, mantendo o pacote de produção leve e focado.

​Parte 1: Configuração Inicial
​A primeira etapa será a configuração do ambiente de desenvolvimento.

​Criação da Solução: Usarei o comando dotnet new sln -n Calculadora para criar a solução.
​Criação do Projeto Principal: Dentro da solução, criarei o projeto de biblioteca de classes com o comando dotnet new classlib -n Calculadora.
​Criação do Projeto de Testes: Em seguida, criarei o projeto de testes xUnit com o comando dotnet new xunit -n Calculadora.Testes.
​Conexão dos Projetos: Adicionarei uma referência do projeto de testes para o projeto principal usando o comando dotnet add Calculadora.Testes/ reference Calculadora/Calculadora.csproj. Isso permitirá que o projeto de testes acesse o código da Calculadora. 

Parte 2: TDD - O Ciclo Red-Green-Refactor
​Seguindo a filosofia do TDD, a implementação da calculadora será guiada pelos testes.

​Desenvolvimento da Classe Calculadora

​A classe Calculadora será criada no projeto principal e terá os seguintes métodos e propriedades:

​Propriedade _historico: Uma lista para armazenar as operações mais recentes.
​Métodos Somar, Subtrair, Multiplicar e Dividir: Cada um receberá dois parâmetros inteiros e retornará um int.
​Método Historico: Retornará uma lista com as últimas 3 operações. 


Aplicação do TDD na Prática

​O desenvolvimento seguirá o ciclo do TDD:

​RED (Escrever um Teste que Falha): Começarei escrevendo um teste para a função Somar. Por exemplo, [Fact] public void Deve_Somar_Dois_Numeros(). Este teste será escrito antes mesmo do método Somar existir na classe Calculadora. Quando executado, ele falhará (RED) porque o método ainda não foi implementado.
​GREEN (Escrever o Mínimo de Código para o Teste Passar): Implementarei o método Somar na classe Calculadora, retornando a soma dos dois parâmetros. Reexecutarei o teste, que agora deve passar (GREEN).
​REFACTOR (Refatorar o Código): Após o teste passar, farei uma breve análise do código para ver se ele pode ser melhorado sem alterar sua funcionalidade. Por exemplo, garantindo que a lógica esteja clara e concisa.
​Este ciclo será repetido para as outras operações (Subtrair, Multiplicar, Dividir) e para a funcionalidade do histórico.



Testes a serem criados:


​Testes para as operações:
​Somar: Testar a soma de números positivos e negativos.
​Subtrair: Testar a subtração de números positivos e negativos.
​Multiplicar: Testar a multiplicação por zero e números negativos.
​Dividir: Testar a divisão por zero (com tratamento de exceção adequado, como um ArgumentException ou um retorno de valor específico).
​Testes para o Histórico:
​Garantir que o histórico armazene as operações corretamente.
​Garantir que a lista retornada pelo método Historico contenha apenas as 3 últimas operações.  


Parte 3: Codificação e Refatoração
​Nesta etapa, a implementação do código será feita em conjunto com a execução constante dos testes.


​Desenvolvimento do Histórico: A lógica para adicionar operações ao histórico será criada. Cada vez que uma operação for concluída (somar, subtrair, etc.), a operação e seu resultado serão adicionados à lista _historico. A lista será mantida com no máximo 3 itens, removendo o mais antigo quando um novo for adicionado.
​Execução Contínua de Testes: Usarei o comando dotnet test para rodar os testes após cada pequena alteração. Isso me dará feedback imediato e garantirá que nenhuma funcionalidade existente foi quebrada.
​Refatoração: Com os testes unitários garantindo a funcionalidade, terei a liberdade de refatorar o código para melhorar a legibilidade e a manutenibilidade. Isso pode incluir a renomeação de variáveis, a extração de métodos ou a otimização da lógica, sempre com a segurança de que os testes validarão a correta execução.


Início do Desenvolvimento: Passo a Passo
​Criação da Solução e Projetos:
​No terminal, navegue até a pasta do projeto.
​dotnet new sln -n Calculadora
​dotnet new classlib -n Calculadora
​dotnet new xunit -n Calculadora.Testes
​Adição dos Projetos à Solução:
​dotnet sln Calculadora.sln add Calculadora/Calculadora.csproj
​dotnet sln Calculadora.sln add Calculadora.Testes/Calculadora.Testes.csproj
​Referência do Projeto de Testes:
​dotnet add Calculadora.Testes/Calculadora.Testes.csproj reference Calculadora/Calculadora.csproj
​Agora a estrutura de arquivos está pronta para o desenvolvimento. O próximo passo é começar a aplicar o TDD, iniciando pelo teste de adição.

​Vamos para a primeira parte do ciclo RED: escrever o teste que falhará.



Vamos começar com o primeiro teste, focando na função de soma.

​Passo 1: Escrevendo o Teste (RED)
​No arquivo Calculadora.Testes/CalculadoraTests.cs, vamos criar a classe de teste e o primeiro método, que deve falhar, pois a funcionalidade ainda não existe. 



Análise do Teste
​[Fact]: Este é um atributo do xUnit que marca um método como um teste.
​Arrange: Nesta seção, preparamos o ambiente para o teste. Criamos uma instância da nossa classe Calculadora e definimos os valores de entrada (num1, num2) e o resultado esperado.
​Act: Aqui, executamos a ação que queremos testar, chamando o método Somar da nossa classe.
​Assert: Esta é a etapa de verificação. Usamos o Assert.Equal para comparar o resultado obtido com o resultado que esperamos.

​Ao executar este teste agora, ele falhará (RED). O motivo é que a classe Calculadora e o método Somar ainda não existem.



Agora, vamos para o GREEN, que é escrever o código mínimo necessário para fazer este teste passar.



Passo 2: Escrevendo o Código para Passar no Teste (GREEN)
​Nosso objetivo agora é escrever a menor quantidade de código possível para fazer o teste que criamos (Somar_DeveRetornarASomaDeDoisInteiros()) passar.


​No arquivo Calculadora/Calculadora.cs, vamos criar a classe Calculadora e o método Somar.





Análise do Código
​public class Calculadora: A classe precisa ser public para ser acessada pelo projeto de testes.
​public int Somar(int num1, int num2): O método também é public, aceita dois parâmetros inteiros (num1 e num2) e retorna um int, conforme a regra de negócio.
​return num1 + num2;: Esta é a lógica mínima e direta para que o nosso teste passe.
​Agora, se você rodar o comando dotnet test no terminal, o teste que antes falhou agora deve passar com sucesso!


​Com o teste passando (GREEN), a próxima etapa do TDD é a Refatoração. Analisaremos o código para ver se podemos melhorá-lo, mas neste caso, a implementação é tão simples que não há necessidade de refatorar.



Passo 1: Escrevendo o Teste para Subtração (RED)

​No arquivo Calculadora.Testes/CalculadoraTests.cs, adicione o seguinte método de teste. Ele seguirá a mesma estrutura de Arrange, Act, e Assert.





Análise do Novo Teste
​[Fact]: Marca o método como um novo teste unitário.
​Subtrair_DeveRetornarASubtracaoDeDoisInteiros(): Nome descritivo que indica a funcionalidade sendo testada.
​Arrange: Preparamos a instância da calculadora e os valores de entrada (10 e 5) e o resultado esperado (5).
​Act: Tentamos chamar o método Subtrair, que ainda não existe na nossa classe Calculadora.
​Assert: Comparamos o resultado com o valor esperado.

​Ao executar o comando dotnet test agora, você verá que um teste passará (o de soma) e um teste falhará (RED), pois o método Subtrair não está implementado.







Passo 2: Codificando a Subtração (GREEN)

​No arquivo Calculadora/Calculadora.cs, vamos adicionar o método Subtrair à classe Calculadora.





Análise do Código
​public int Subtrair(int num1, int num2): Assim como o método Somar, ele é público e aceita dois parâmetros inteiros, retornando um inteiro.
​return num1 - num2;: Esta é a lógica direta e suficiente para que o teste de subtração seja aprovado.
​Agora, se você executar dotnet test no terminal, verá que os dois testes, o de soma e o de subtração, passarão com sucesso (GREEN).


​O próximo passo no ciclo TDD é a Refatoração. Neste caso, o código ainda é simples e não exige refatoração.



Passo 1: Escrevendo o Teste para Multiplicação (RED)

​No arquivo Calculadora.Testes/CalculadoraTests.cs, adicione o seguinte método de teste. Ele verificará se a multiplicação de dois números inteiros funciona corretamente.



Análise do Novo Teste
​[Fact]: Marca o método como um novo teste unitário.
​Multiplicar_DeveRetornarAMultiplicacaoDeDoisInteiros(): Nome claro para a funcionalidade que estamos testando.
​Arrange: Preparamos a instância da calculadora e os valores de entrada (5 e 4) com o resultado esperado (20).
​Act: Tentamos chamar o método Multiplicar, que ainda não existe na nossa classe Calculadora.
​Assert: Comparamos o resultado obtido com o resultado esperado.

​Ao rodar o comando dotnet test agora, o teste de multiplicação falhará (RED), indicando que a funcionalidade precisa ser implementada.



Passo 2: Codificando a Multiplicação (GREEN)

​No arquivo Calculadora/Calculadora.cs, adicione o método Multiplicar à classe Calculadora.





Análise do Código

​public int Multiplicar(int num1, int num2): O método é público e segue a mesma assinatura dos anteriores, recebendo dois inteiros e retornando um inteiro.
​return num1 * num2;: A lógica é simples e direta, fazendo a multiplicação e retornando o resultado.


Agora, ao executar dotnet test no terminal, todos os três testes passarão com sucesso!



A divisão exige um cuidado especial: a divisão por zero. Uma boa calculadora deve lidar com esse cenário de forma segura.



Passo 1: Escrevendo os Testes para Divisão (RED)
​Precisamos de dois testes para a divisão: um para um caso de sucesso e outro para a regra de negócio da divisão por zero.


​No arquivo Calculadora.Testes/CalculadoraTests.cs, adicione os seguintes métodos:



Análise dos Novos Testes
​Dividir_DeveRetornarADivisaoDeDoisInteiros(): Este é o caso feliz. Ele testa a divisão de dois números inteiros, verificando se o resultado está correto.
​Dividir_PorZero_DeveLancarArgumentException(): Este é o teste mais importante para a divisão.
​Assert.Throws<ArgumentException>(...): Este método do xUnit é perfeito para verificar se um trecho de código lança uma exceção específica.
​() => calc.Dividir(num1, num2): Usamos uma expressão lambda para envolver a chamada ao método. Isso permite que o xUnit "capture" a exceção se ela for lançada.

​Ao executar o comando dotnet test agora, os dois testes de divisão falharão (RED), já que o método ainda não foi implementado.



Passo 2: Codificando a Divisão (GREEN)

​No arquivo Calculadora/Calculadora.cs, adicione o método Dividir à classe Calculadora. É aqui que implementaremos a lógica para a divisão, incluindo o tratamento para a divisão por zero.



Análise do Código
​public int Dividir(int num1, int num2): O método é público e recebe os dois parâmetros inteiros.
​if (num2 == 0): Aqui está a regra de negócio mais importante. Antes de realizar a divisão, verificamos se o segundo parâmetro (num2) é zero.
​throw new ArgumentException(...): Se for zero, lançamos uma exceção do tipo ArgumentException. A mensagem de erro e o nome do parâmetro (nameof(num2)) são passados para dar um feedback claro ao desenvolvedor.
​return num1 / num2;: Se a condição do if não for atendida (ou seja, num2 não é zero), a divisão é executada e o resultado é retornado.

​Agora, se você executar dotnet test no terminal, todos os testes, incluindo os de divisão, passarão com sucesso (GREEN).



O histórico de operações é a próxima grande regra de negócio. Ele nos permitirá exercitar ainda mais o TDD e os princípios de Programação Orientada a Objetos (POO), como o encapsulamento.



Passo 1: Escrevendo o Teste para o Histórico (RED)
​A regra de negócio diz que devemos retornar as últimas 3 operações. Nosso teste, portanto, precisa verificar se, após realizar 4 ou mais operações, o método de histórico retorna apenas as 3 mais recentes.


​No arquivo Calculadora.Testes/CalculadoraTests.cs, adicione o seguinte método de teste.



Análise do Novo Teste

​Historico_DeveRetornarAsUltimasTresOperacoes(): Um nome de teste que descreve exatamente o que estamos validando.
​Arrange: Criamos a instância da Calculadora e executamos quatro operações. Isso garante que a funcionalidade de histórico seja "forçada" a remover a operação mais antiga.
​Act: Chamamos o método Historico(), que ainda não existe, para obter a lista de operações.
​Assert:
​Assert.NotEmpty(historico): Verifica se a lista não está vazia.
​Assert.Equal(3, historico.Count): Confirma que o histórico contém exatamente 3 itens, conforme a regra de negócio.
​Assert.Contains(...): Verifica se as três últimas operações (Divisão, Multiplicação e Subtração) estão presentes na lista.
​Assert.DoesNotContain(...): Verifica que a primeira operação (1 + 2 = 3) foi removida do histórico, provando que a lógica de "últimas 3" está funcionando. 


Ao rodar dotnet test agora, o teste de histórico falhará (RED), já que a classe Calculadora não possui um método Historico() nem armazena as operações. 



É hora de fazer o teste do histórico passar!


​Para isso, vamos modificar a classe Calculadora.cs para incluir a lógica de armazenamento e recuperação das operações. A melhor forma de fazer isso é usando uma List<string>.



Passo 2: Codificando a Lógica do Histórico (GREEN)
​No arquivo Calculadora/Calculadora.cs, faça as seguintes alterações:

​Crie a Lista de Histórico: Adicione um campo privado _historico na classe Calculadora.
​Adicione a Lógica em Cada Operação: Em cada método de cálculo (Somar, Subtrair, Multiplicar, Dividir), adicione uma linha de código para registrar a operação.
​Crie o Método Historico(): Implemente o método Historico() para retornar a lista de operações, garantindo que contenha no máximo 3 itens.


Análise do Código
​private List<string> _historico: Usamos um campo privado para encapsular a lista de histórico. Apenas a própria classe pode manipulá-la. Isso é uma boa prática de POO.
​public Calculadora(): O construtor é o lugar ideal para inicializar a lista, garantindo que ela esteja pronta para uso assim que a classe for instanciada.
​AdicionarAoHistorico(...): Criamos um método privado auxiliar. A lógica de adicionar e limitar o histórico é encapsulada aqui, mantendo os métodos de cálculo limpos. Usamos Insert(0, ...) para adicionar a nova operação no início da lista, garantindo que as mais recentes estejam sempre no topo.


​if (_historico.Count > 3): Essa é a lógica para limitar a lista. Se o número de itens exceder 3, removemos os elementos mais antigos, que estarão do índice 3 em diante.
​public List<string> Historico(): Este método público permite que o "mundo externo" acesse o histórico, mas apenas para leitura.
​Agora, se você executar dotnet test no terminal, todos os testes, incluindo o do histórico, passarão com sucesso (GREEN).


Com todas as funcionalidades básicas da calculadora e o histórico implementados e testados, a etapa final do nosso ciclo de TDD seria a Refatoração. Neste ponto, o código está bem organizado, mas sempre podemos buscar melhorias, como otimizar a lógica de histórico ou adicionar mais testes de cobertura. 






ll

   ---
   
   
📝 **Contribuição**
Sinta-se à vontade para contribuir com este projeto! Se encontrar bugs ou tiver sugestões de melhoria, abra uma issue ou envie um pull request.

Este **README.md** oferece uma visão clara do projeto, sua motivação e como ele foi desenvolvido, sendo um recurso valioso para qualquer um que visite o repositório.




 
