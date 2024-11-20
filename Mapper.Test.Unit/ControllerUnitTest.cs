
using Mapper.Plotting;
using Mapper.SerialTransfer;
using NUnit.Framework;
using NSubstitute;

namespace Mapper.Test.Unit
{
    public class Tests
    {

        [TestFixture]
        public class ControllerUnitTest
        {
            private Controller _uut;

            private IWriter _writer;
            private IPlotter _plotter;


            [SetUp]
            public void Setup()
            {
                _writer = Substitute.For<IWriter>();
                _plotter = Substitute.For<IPlotter>();

                _uut = new Controller(_writer, _plotter);
            }


            [Test]
            public void ThisTestWillPass_True()
            {
                Assert.Pass();
            }
        }
               
    }
}