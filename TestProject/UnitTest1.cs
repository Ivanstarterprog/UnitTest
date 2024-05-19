using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;
namespace TestProject
{
    [TestClass]
    public class MatrixCalculatorTests
    {

        private SquareMatrix _matrixOne;
        private SquareMatrix _matrixTwo;
        [TestInitialize]
        public void Initialize()
        {
            _matrixOne = new SquareMatrix(3, new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } });
            _matrixTwo = new SquareMatrix(3, new int[3, 3] { { 10, 9, 8 }, { 7, 6, 5 }, { 4, 3, 2 } });
        }

        public void TestAdditionMethod()
        {
            SquareMatrix expectedResult = new SquareMatrix(3, new int[3, 3] { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } });
            SquareMatrix actualResult = _matrixOne + _matrixTwo;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplicationMethod()
        {
            SquareMatrix expectedResult = new SquareMatrix(3, new int[3, 3] { { 0, 9, 16 }, { 21, 24, 25 }, { 24, 21, 16 } });
            SquareMatrix actualResult = _matrixOne * _matrixTwo;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinusMethod()
        {
            SquareMatrix expectedResult = new SquareMatrix(3, new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } });
            SquareMatrix actualResult = _matrixOne + _matrixTwo;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestLargerMethod()
        {
            bool actualResult = _matrixOne > _matrixTwo;
            Assert.AreEqual(expectedResult, false);
        }

        [TestMethod]
        public void TestLargerOrEqualMethod()
        {
            bool actualResult = _matrixOne >= _matrixTwo;
            Assert.AreEqual(expectedResult, false);
        }

        [TestMethod]
        public void TestSmallerMethod()
        {
            bool actualResult = _matrixOne < _matrixTwo;
            Assert.AreEqual(expectedResult, true);
        }

        [TestMethod]
        public void TestLargerOrEqualMethod()
        {
            bool actualResult = _matrixOne <= _matrixTwo;
            Assert.AreEqual(expectedResult, true);
        }

        [TestMethod]
        public void TestEqualMethod()
        {
            bool actualResult = _matrixOne == _matrixTwo;
            Assert.AreEqual(expectedResult, false);
        }

        [TestMethod]
        public void TestNotEqualMethod()
        {
            bool actualResult = _matrixOne != _matrixTwo;
            Assert.AreEqual(expectedResult, true);
        }

        [TestMethod]
        public void TestDeterminantMethod()
        {
            int expectedResult = _matrixOne.GetDeterminant(_matrixOne)
            int actualResult = 9237;
            Assert.AreEqual(expectedResult, false);
        }

        [TestMethod]
        public void TestReverseMethod()
        {
            SquareMatrix expectedResult = new SquareMatrix(3, new int[3, 3] { { 0, -3162, -6324 }, { -9486, -12648, -15810 }, { -18972, -22134, -25296 } });
            SquareMatrix actualResult = _matrixOne.ReverseMatrix();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCloneMethod()
        {
            SquareMatrix clonedMatrix = _matrixOne.Clone();
            bool expectedResult = true;
            bool actualResult = clonedMatrix != _matrixOne;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}