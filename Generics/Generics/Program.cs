using System;

namespace Generics
{
    class PairInt
    {
        public int X;
        public int Y;
    }

    class PairFloat
    {
        public double X;
        public double Y; 
    }

    class PairString
    {
        public string X;
        public string Y;
    }

    class Pair<TX,TY>
    {
        public TX X; 
        public TY Y;
    }
    class A : ISomething
    {
        public string Name;
        public class classA
        {

        }
        public class classB
        {

        }
        public class classC
        {
             
        }

    }
    class B : A
    {
        public string City;

        public void Bear()
        {

        }
    }

    interface ISomething
    {

    }

    class GenericClass<T, U> where T : A ,ISomething, new()
    {
        //public A X;
    }

    class GenericClass2<T, U> where T : A
    {
        public void DoSomething<X>(X x, X y, U z) where X : struct
        {
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(y.ToString());

            x = default(X);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            PairFloat i = new PairFloat();
            i.X = 5;
            i.Y = 10;

            PairFloat f = new PairFloat();
            f.X = 5.5;
            f.Y = 10.1;

            PairString str = new PairString();
            str.X = "Rabbi";
            str.Y = "Robin";

            Pair<int, string> p = new Pair<int, string>();
            p.X = 01;
            p.Y = "Rabbi";

            Pair<A, B> p2 = new Pair<A, B>();
            p2.X = new A();
            p2.Y = new B();

            p2.X.Name = "Rabbi";
            p2.Y.City = "Dhaka";

            GenericClass<A, int> a = new GenericClass<A, int>();
            GenericClass<B, int> b = new GenericClass<B, int>();

            GenericClass2<A, int> a1 = new GenericClass2<A, int>();
            a1.DoSomething(5, 2.5, 7);
            GenericClass2<B, int> b1 = new GenericClass2<B, int>();
        }
    }
}
