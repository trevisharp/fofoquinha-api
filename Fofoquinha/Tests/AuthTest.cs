using Fofoquinha.UseCases;
using Xunit;

namespace Fofoquinha.Tests;

public class SomaFoda
{
    public int Somar(int a, int b)
        => a + b;
}

public class AuthTest
{
    [Fact]
    public void TestSoma()
    {
        var soma = new SomaFoda();
        Assert.Equal(5, soma.Somar(2, 3));
        Assert.Equal(0, soma.Somar(-4, 4));
        Assert.Equal(5, soma.Somar(5, 0));
        Assert.Equal(-3, soma.Somar(3, -6));
    }

    // [Fact]
    // public void TestCreateAccount()
    // {
    //     var useCase = new CreateProfileUseCase();
    // }
}