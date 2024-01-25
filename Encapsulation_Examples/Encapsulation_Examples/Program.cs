// Seeusing System;

class Program
{
    static void Main(string[] args)
    {
        cagri c=new cagri();

        c.MyProperty = 12; // set kısmında atamanın yapılması

        Console.WriteLine(c.MyProperty); // get kısmında atanan değerin okunması
    }

    class cagri
    {
        private int sayi1;
        // Kapsüllemenin yapıldığı field private olarak belirtilmiştir.

        public int MyProperty
        {
            get 
            {
                return sayi1;
            }
            set 
            {
                sayi1 = value;  
            }
        }

    }
}




