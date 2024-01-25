// Seeusing System;

using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        cagri c = new cagri();  
        // öncelikle static constructor çalışır arkasıdnan constructor çalışır

        cagri c2= new cagri();  
        // sadece constructor çalışır - static constructor ilk defa nesne oluşturulurken çalışır)
        

    }

    class cagri
    {
        public cagri()
        {
            //Constructor 
            // Bir sınıfta nesne oluşrulurken ilk tetiklenen fonksiyondur.
            // ilgili sınıftan her nesne üretilirken tetiklenme durumu olur.

            Console.WriteLine("Constructor Çalıştı");
        
        }

        static cagri()
        {
            //Static Constructor bir sınıftan ilk nesne oluştuğunda çalışan fonksiyondur
            //Static Constructor geri dönüş değeri ve erişim belirleyecisi bildirmez.
            //Parametre almaz

            Console.WriteLine("Static Constructor Çalıştı");
        }

    }

}


