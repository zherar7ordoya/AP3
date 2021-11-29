using System;
using Xunit;
using App.Core;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void SumTwoAndTwo()
        {
            // ARRANGUE (Arreglar)
            var view = new StubView();
            var sut = new Presenter(view); // System Under Test

            // ACT      (Actuar)
            sut.NumberButtonPressed("2");
            sut.OperatorButtonClicked("+ / =");
            sut.NumberButtonPressed("2");
            sut.OperatorButtonClicked("+ / =");

            // ASSERT   (Afirmar)
            Assert.Equal("4", view.ScreenDisplay);
        }
    }
}
