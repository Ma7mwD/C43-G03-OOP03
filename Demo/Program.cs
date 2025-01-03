using OOP.Interfaces;
using OOP.Interfaces.Example_03;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Binding

            //What is binding ?
            //binding Is a behaviour
            //Is Refernce from parent and The object from Chiled


            #endregion

            #region Example 01

            MyType x = new MyType();
            x.Salary = 500;
            Console.WriteLine(x.Salary);
            x.MyFunction();
            #endregion

            #region

            Series series = new Series();
            print10NumberFromSeries(series);

            SeriesByTen seriesByTen = new SeriesByTen();
            print10NumberFromSeries(seriesByTen);

            #endregion

            #region Example 03
            IMove Move = new AirPlane();
            Move.Backward();
            IFly Fly = new AirPlane();
            Fly.Backward();

             

            #endregion


        }

        #region Example 02
        public static void print10NumberFromSeries(ISeries series)
        {
            if (series == null) return;

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{series.Current}\t");
                series.getNext();
            }

            series.reset();
            Console.WriteLine();
        }

        #endregion
    }
}
