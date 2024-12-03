using Calculadora.Models;

namespace CalculadoraTestes;

public class CalcTestes
{
    private Metodo _metodo;

    public CalcTestes()
    {
        _metodo = new Metodo();
    }

    //criação de valores aleatórios para testes
    private int ValoresPseudoUsuario()
    {
        Random random = new Random();
        return random.Next(-200, 200);
    }


    [Fact] //Soma
    public void SomarERetornarValorCorreto()
    {
        //Arrange
        int valor1 = ValoresPseudoUsuario();
        int valor2 = ValoresPseudoUsuario();

        //Act
        int resultado = _metodo.Somar(valor1, valor2);

        //Assert
        Assert.Equal(valor1 + valor2, resultado);

    }

    [Fact] //Subtração
    public void SubtrairERetornarValorCorreto()
    {
        // Given
        int valor1 = ValoresPseudoUsuario();
        int valor2 = ValoresPseudoUsuario();
        // When
        int resultado = _metodo.Subtrair(valor1, valor2);

        // Then
        Assert.Equal(valor1 - valor2, resultado);
    }

    [Fact] // Multiplicação
    public void MultiplicarERetornarValorCorreto()
    {
        // Given
        int valor1 = ValoresPseudoUsuario();
        int valor2 = ValoresPseudoUsuario();
        // When
        int resultado = _metodo.Multiplicar(valor1, valor2);
        // Then
        Assert.Equal(valor1 * valor2, resultado);
    }

    [Fact] // Divisão
    public void DividirERetornarValorCorreto()
    {
        // Given
        int valor1 = ValoresPseudoUsuario();
        int valor2 = ValoresPseudoUsuario();
        // When
        int resultado = _metodo.Dividir(valor1, valor2);
        // Then
        Assert.Equal(valor1 / valor2, resultado);
    }

    [Fact] // Resto da Divisão
    public void VerificarRestoDaDivisaoERetornarValorCorreto()
    {
        // Given
        int valor1 = ValoresPseudoUsuario();
        int valor2 = ValoresPseudoUsuario();
        // When
        int resultado = _metodo.RestoDaDivisao(valor1, valor2);
        // Then
        Assert.Equal(valor1 % valor2, resultado);
    }

    [Fact] // Potenciação
    public void PotenciacaoERetornarValorCorreto()
    {
        // Given
        int valor1 = ValoresPseudoUsuario();
        int valor2 = ValoresPseudoUsuario();
        // When
        var resultado = _metodo.Potenciacao(valor1, valor2);
        double potencia = Math.Pow(valor1, valor2);
        // Then
        Assert.Equal(potencia, resultado);
    }

    [Fact] // Lista Histórico
    public void CapturarHistorico_Retornar_UltimaOperacao()
    {
        // Given

        // When

        // Then
    }

}