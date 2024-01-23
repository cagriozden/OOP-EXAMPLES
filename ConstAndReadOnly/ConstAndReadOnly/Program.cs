using System;


using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System;

class Program
{
    // const tanımlandığı yerde değer ataması yapılmalıdır. (Constructor içerisinde bile değer ataması YAPILMAZ!)
    const int FixedNumber = 1;

    static void Main(string[] args)
    {
        Console.WriteLine(FixedNumber);

        Cagri m1 = new Cagri();
        Console.WriteLine(m1.GetFixedNumber1());
        Console.WriteLine(m1.GetFixedNumber2());

    }

    class Cagri
    {
        // readonly ile tanımlanan yerde değer atamasının yapılması
        readonly int number1 = 15;

        // readonly ile sabit bir değeri Constructor tarafından atanması
        readonly int FixedNumber2;

        public Cagri()
        {
            FixedNumber2 = 10;
        }
        public int GetFixedNumber1()
        {
            return FixedNumber2;
        }
        public int GetFixedNumber2()
        {
            return number1;
        }

    }
}



  









