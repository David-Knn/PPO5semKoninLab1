using Tyuiu.KoninDP.Lab1.V13.Lib;


namespace Tyuiu.KoninDP.Lab1.V13.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            DataService ds = new DataService();
            double a = 1;
            double x = 2;
            double y = 3;
            var res = ds.func1(a, x, y);
            double wait = 8.35;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SecondTestMethod()
        {
            DataService ds = new DataService();
            double a = 1;
            double x = 2;
            double y = 3;
            var res = ds.func2(a, x, y);
            double wait = 7.79;
            Assert.AreEqual(wait, res);
        }
    }
}