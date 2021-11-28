using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reshenie lineinogo uravneniy 0=kx+b");
            try
            {
                Console.WriteLine("Vvedite znachenie b");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Vvedite znachenie k");
                double n = Convert.ToDouble(Console.ReadLine());
                Equation root = new Equation { b = a, k = n };
                root.Root();
            }
            catch
            {
                Console.WriteLine("VVedeno necorrectnoe znachenie");
            }
            Console.ReadKey();
        }
        struct Equation
        {
            public double b, k;
            public double K
            {
                set
                {
                    if (value!=0)
                    {
                        k = value;
                    }
                    else
                    {
                        Console.WriteLine("VVedeno necorrectnoe znachenie");
                    }
                }
                get
                {
                    return k;
                }
            }
            public void Root()
            {
                Console.WriteLine("x={0:0.00}", -b/k);
            }
        }
        
    }
}
