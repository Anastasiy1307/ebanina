using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ebanina
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            int x = 30;
            Program program   = new Program();
            double sin = program.Sinus(x);
            double cos = program.Cosinus(x);
            double tan = program.Tangens(sin,cos);
            double ctan = program.Ctangens(sin, cos);
            double sec = program.Sec(cos);
            double ln = program.Ln(x);
            double result;
            if (x<=0)
            {
           
                result = (((((ctan / sec) - tan) * sin) / cos) * (Math.Pow((sin + cos) + cos, 2)));

            }
            else
            {
                result = (((((program.Log(5, Math.Pow(x, 3)) * program.Log(10, x)) + program.Log(3, x)) / ln) + (ln * program.Log(5, x))));
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public double Sinus(double x)
        {
            double sin2 = ((1 - Math.Cos(2 * x))/2);
            if (x <= 90)
            {
                return -Math.Sqrt(sin2);
            }
            else if(x>90 && x<=180)
            {
                return Math.Sqrt(sin2);
            }
            else if (x > 180 && x <=270)
            {
                return -Math.Sqrt(sin2);
            }
            else if(x > 270 && x <= 360)
            {
                return Math.Sqrt(sin2);
            }
            else
            {
                return 0;
            }
        }
        public double Cosinus(double x)
        {
            double cos2 = 1 - Math.Pow(Sinus(x), 2);
            if (x <= 90)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 90 && x <= 180)
            {
                return -Math.Sqrt(cos2);
            }
            else if (x > 180 && x <= 270)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 270 && x <= 360)
            {
                return -Math.Sqrt(cos2);
            }
            else
            {
                return 0;
            }

        }
        public double Tangens(double s, double c)
        {
            return s / c;
        }
        public double Ctangens(double s, double c)
        {
            return c / s;
        }
        public double Sec(double c)
        {
            return Math.Pow(c, -1);
        }
        public double Log(double ocn, double chicl)
        {
            {
                double stepen = 0.1;
                while (Math.Pow(ocn, stepen) <= chicl)
                    stepen += 0.001;
                return stepen;
            }
        }       
        public double Ln( double chicl)
        {
            double stepen = 0.1;
            while (Math.Pow(Math.E, stepen) <= chicl)
                stepen += 0.001;
            return stepen;
        }
    }
    
}
