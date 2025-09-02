using Xunit;
using Calculadora;
using System;
using System.Collections.Generic;

public class CalculadoraTests
{
    [Fact]
    public void Somar_DeveRetornarASomaDeDoisInteiros()
    {
        // Arrange
        var calc = new Calculadora.Calculadora();
        int num1 = 5;
        int num2 = 10;
        int resultadoEsperado = 15;

        // Act
        int resultado = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Fact]
    public void Subtrair_DeveRetornarASubtracaoDeDoisInteiros()
    {
        // Arrange
        var calc = new Calculadora.Calculadora();
        int num1 = 10;
        int num2 = 5;
        int resultadoEsperado = 5;

        // Act
        int resultado = calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Multiplicar_DeveRetornarAMultiplicacaoDeDoisInteiros()
    {
        // Arrange
        var calc = new Calculadora.Calculadora();
        int num1 = 5;
        int num2 = 4;
        int resultadoEsperado = 20;

        // Act
        int resultado = calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Fact]
    public void Dividir_DeveRetornarADivisaoDeDoisInteiros()
    {
        // Arrange
        var calc = new Calculadora.Calculadora();
        int num1 = 10;
        int num2 = 2;
        int resultadoEsperado = 5;

        // Act
        int resultado = calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Fact]
    public void Dividir_PorZero_DeveLancarArgumentException()
    {
        // Arrange
        var calc = new Calculadora.Calculadora();
        int num1 = 10;
        int num2 = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calc.Dividir(num1, num2));
    }

    [Fact]
    public void Historico_DeveRetornarAsUltimasTresOperacoes()
    {
        // Arrange
        var calc = new Calculadora.Calculadora();
        
        // Realizando 4 operações para testar a regra de 3
        calc.Somar(1, 2);
        calc.Subtrair(5, 3);
        calc.Multiplicar(2, 4);
        calc.Dividir(10, 5);

        // Act
        List<string> historico = calc.Historico();

        // Assert
        Assert.NotEmpty(historico);
        Assert.Equal(3, historico.Count);
        Assert.Contains("10 / 5 = 2", historico);
        Assert.Contains("2 * 4 = 8", historico);
        Assert.Contains("5 - 3 = 2", historico);
        Assert.DoesNotContain("1 + 2 = 3", historico);
    }
}
