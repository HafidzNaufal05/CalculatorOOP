using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
                Penjumlahan tambah = new Penjumlahan(1, 2);
                Pengurangan kurang = new Pengurangan(1, 2);
                Perkalian kali = new Perkalian(1, 2);
                Pembagian bagi = new Pembagian(1, 2);
                Console.WriteLine(tambah.Proccess());
                Console.WriteLine(kurang.Proccess());
                Console.WriteLine(kali.Proccess());
                Console.WriteLine(bagi.Proccess());
                tambah.Display();

                Console.Read();

         }
        class Penjumlahan : AbstractCalculate
        {
            public Penjumlahan(double a, double b)
            {
                A = a;
                B = b;
            }

            public double A { get; private set; }
            public double B { get; private set; }

            public override double Proccess()
            {
                return A + B;
            }
        }

        class Pengurangan : AbstractCalculate
        {
            public double A { get; private set; }
            public double B { get; private set; }
            public Pengurangan(double a, double b)
            {
                A = a;
                B = b;
            }
            public override double Proccess()
            {
                return A - B;
            }
        }

        class Perkalian : AbstractCalculate
        {
            public Perkalian(double a, double b)
            {

                A = a;
                B = b;
            }
            public double A { get; private set; }
            public double B { get; private set; }

            public override double Proccess()
            {
                return A * B;
            }
        }
        class Pembagian : AbstractCalculate
        {
            public Pembagian(double a, double b)
            {

                A = a;
                B = b;
            }
            public double A { get; private set; }
            public double B { get; private set; }

            public override double Proccess()
            {
                return A / B;
            }
        }
    }
}
