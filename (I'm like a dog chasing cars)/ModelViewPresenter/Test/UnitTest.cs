using System;
using Xunit;
using App.Core;

namespace Test
{
    public class UnitTest
    {
		[Fact]
		public void MultiplyThreeAndThree()
		{
			// arrange
			var view = new StubView();
			var sut = new CPresentador(view);

			// act
			sut.PresionaBotonNumero("3");
			sut.PresionaBotonOperacion("x");
			sut.PresionaBotonNumero("3");
			sut.PresionaBotonOperacion("+ / =");

			// assert
			Assert.Equal("9", view.TextoPantalla);
		}

		[Fact]
		public void SumTwoAndTwo()
		{
			// arrange
			var view = new StubView();
			var sut = new CPresentador(view);

			// act
			sut.PresionaBotonNumero("2");
			sut.PresionaBotonOperacion("+ / =");
			sut.PresionaBotonNumero("2");
			sut.PresionaBotonOperacion("+ / =");

			// assert
			Assert.Equal("4", view.TextoPantalla);
		}

		[Fact]
		public void AddThreeNumbers()
		{
			// arrange
			var view = new StubView();
			var sut = new CPresentador(view);

			// act
			sut.PresionaBotonNumero("2");
			sut.PresionaBotonOperacion("+ / =");
			sut.PresionaBotonNumero("3");
			sut.PresionaBotonOperacion("+ / =");
			sut.PresionaBotonNumero("4");
			sut.PresionaBotonOperacion("+ / =");

			// assert
			Assert.Equal("9", view.TextoPantalla);
		}
	}
}
