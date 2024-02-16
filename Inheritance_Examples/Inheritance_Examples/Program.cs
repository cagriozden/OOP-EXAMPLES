
class Program
{
    static void Main(string[] args)
    {
       //Nesne üretimimizi yaptık ve f1 referansı ile işaretledik 
       Ford f1=new Ford();
        // f1 uzerinden aslında ford classına ait olamayn memberlarada erişebiliyoruz bunun sebebi inheritance yapısıdır
        f1.KM_Yap();

        Peugeot p1= new Peugeot();
        p1.PlakaNo = 12345;
        
       
    }

    //Inheritanca Nedir?

    // Var olan bir yapıyı tekrar tekrar yazmaktansa Miras alınarak ilerlenebilir bir avantaj sunar.
    // Kalıtımsal bir ilişki kurulmalıdır. Tekrar eden memberlar için düşünülür
    // Bir sınıfın başka bir sınıftan özellikler ve davranışlar miras alması anlamına gelir
    class Araba
    {
      public  int SaseNo;
      public  int PlakaNo;
      public  string Marka;
      public string Model;
      public void KM_Yap()
      { }

    }

    // Bu OOP prensibi kodun tekrar kullanılabilirliğini arttırmak, kodun düzenlenmesi ve bakımını kolaylaştırmak
    // Daha anlaşılabilir bir yapı sunmak için kullanılır.
    // : operatörü ile sınıflar arası kalıtımsal ilişki kurulmaktadır.

    class Ford:Araba
    {
        bool ElektrikliAyna;
        bool DeriKoltuk;
        bool HavaYastığı;
    }

    class Peugeot:Araba
    {
        bool Klima;
        bool YokusKalkısDestegi;
    }

    // Bir sınıfın sadece tek bir Base Class'ı olabilir. (Base Class = Parent Class)
}


