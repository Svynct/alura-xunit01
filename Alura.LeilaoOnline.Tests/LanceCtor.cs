using Alura.LeilaoOnline.Core;
using System;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Arrange
            var valorNegativo = -100;

            //Assert
            var excecaoObtida = Assert.Throws<ArgumentException>(
                //Act
                () => new Lance(null, valorNegativo)
            );

            var msgEsperada = "Valor do lance deve ser igual ou maior que zero.";
            Assert.Equal(msgEsperada, excecaoObtida.Message);
        }
    }
}
