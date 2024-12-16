
namespace Tyuiu.KoninDP.Lab1.V13.Lib
{
    public class DataService
    {
        public double func1(double a, double x, double y)
        {
            double res = (2 * y) + ((2 * 3 * a) / ((10 * x) - (3 * a))) + 2 * a;
            res = Math.Round(res, 2);
            return res;
        }
        public double func2(double a, double x, double y)
        {
            double res = 7 + (((a * x) / (2 * y)) / ((3 + a) / x)) * y - ((2 * x) + y + x - (3 * a)) / (a + x - (8 * y));
            res = Math.Round(res, 2);
            return res;
        }
    }
}