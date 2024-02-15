
class Program
    // Override: Türetilmiş sınıfta,üst sınıfta tanımlanan bir metodu aynı isim ve imza ile tekrar tanımlanması
{
    static void Main(string[] args)
    {
        //Bir sınıfta tanımlanmış olan herhangi bir memberın kendisinde türeyen alt sınıflarda Name Hiding durumuna düşmeksizin
        // ezilip yeniden yapılandırması durumuna "override" denir.

        ozden o1 = new ozden();
        o1.konus();

        cagri c1 = new cagri();
        c1.konus();

        gozde g1 = new gozde();
        g1.konus();

        //----------------------------------------------

        // Overloading örneği
        Calculator calculator = new Calculator();
        int result1 = calculator.Add(10, 11);
        Console.WriteLine("Result 1: " + result1);

        int result2=calculator.Add(10, 11,12);
        Console.WriteLine("Result 2: " + result2);

        double result3 = calculator.Add(10.5, 20.7);
        Console.WriteLine("Result 3: " + result3);



    }

    // Base class olarak ozden classımızdan child classlara miras durumu belirtilmiştir.
    // Bu sayede fonksiyonumuzun override durumunu kullanabiliriz.
    class ozden
    {
      // Fonksiyonumuzun override edilebileceğinin belirlenmesi "virtual" ile yapıldı 
      virtual public void konus()
        {
           Console.WriteLine("Ben Ozden ailesi adına konusuyorum");
        }
    }

    class cagri:ozden
    {
        override public void konus()
        { 
            Console.WriteLine("Ben Cagri adına konusuyorum");
        }
        
    }

    class gozde : ozden
    {
        public override void konus()
        {
            Console.WriteLine("Ben Gozde adına konusuyorum");
        }
    }

    //Bu örnekte, Calculator sınıfı içinde farklı parametre listelerine sahip üç Add metodu tanımlanmıştır. Bu metotlar aynı adı taşıdığından, ancak farklı parametre listeleri ile çağrılabilirler. 
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    
    }
}



