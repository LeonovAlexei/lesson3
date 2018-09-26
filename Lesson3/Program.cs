using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    struct Complex
    {
        public double im;
        public double re;
        // в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        // Пример произведения двух комплексных чисел//
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        // разность двух комплексных чисел
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        // деление двух комплексных чисел
        public Complex Divide(Complex x)
        {
            Complex y;
            y.re = ((re * x.re) + (im * x.im)) / (Math.Pow(x.re,2) + Math.Pow(x.im,2));
            y.im = ((im * x.re) - (re * x.im)) / (Math.Pow(x.re,2) + Math.Pow(x.im,2));
          
            return y;
        }
            public string ToString()
        {
            return im > 0 ? re + "+" + im + "i" : im < 0 ? re + "" + im + "i":re+"";
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            result = complex2.Minus(complex1);
            Console.WriteLine(result.ToString());
            result = complex1.Divide(complex2);
            Console.WriteLine(result.ToString());
            result = complex2.Divide(complex1);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
