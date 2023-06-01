using System;

namespace Assignment3
{
    internal class Program
    {
        public abstract class clothing
        {
            public abstract void sales();

            public abstract void materials();

            public abstract void commonwear();
        }

        public class trendsetting : clothing
        {
            public override void sales()
            {
                Console.WriteLine("sales ");

            }

            public override void materials()
            {
                Console.WriteLine("materials");

            }

            public override void commonwear()
            {
                Console.WriteLine("common wear ");

            }
        }

        public class climatecontrol : clothing
        {
            public override void sales()
            {
                Console.WriteLine("sales by region for climatecontrol clothing:");
            }

            public override void materials()
            {
                Console.WriteLine("materials");

            }

            public override void commonwear()
            {
                Console.WriteLine("common wear");

            }
        }

        public class sports : clothing
        {
            public override void sales()
            {
                Console.WriteLine("sales");

            }

            public override void materials()
            {
                Console.WriteLine("materials");

            }

            public override void commonwear()
            {
                Console.WriteLine("common wear");

            }
        }

        class program
        {
            static void main(string[] args)
            {
                trendsetting trendsetting = new trendsetting();
                trendsetting.sales();
                trendsetting.materials();
                trendsetting.commonwear();

                climatecontrol climatecontrol = new climatecontrol();
                climatecontrol.sales();
                climatecontrol.materials();
                climatecontrol.commonwear();

                sports sports = new sports();
                sports.sales();
                sports.materials();
                sports.commonwear();
                Console.ReadLine();
            }
        }


    }
}





