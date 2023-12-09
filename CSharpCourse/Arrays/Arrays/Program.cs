internal class Program
{
    private static void Main(string[] args)
    {
        // --------* Diziler (Array) *--------
        //Aynı tipte ki değerleri değişkenleri tek bir noktada yönetip tek bir değişkenle yönetme şeklinde ve ona hızlıca ulaşma onu bir döngüyle gezme ihtiyacında biz arraylerden dizilerden yararlanıyoruz    

        string[] students = new string[3]{ "Engin", "Derin", "Salih" };
        //string[] students = new string[3]; 
        //students[0] = "Engin";
        //students[1] = "Derin";    //Diğer kullanımı
        //students[2] = "Salih";
        //string[] students2 = new[] {"Engin","Derin","Salih"}; //Diğer Kullanımı

        string[] students2 = { "Engin", "Derin", "Salih" }; //Diğer Kullanımı

        //students[3] = "Ahmet"; // hata


        foreach (var student in students2)  //forech döngüsü bir arrayi gezmek için kullanılır gezerken her bir elemana takma isim veriyoruz 
        {
            Console.WriteLine(student);
        }

        //--------* Çok Boyutlu Diziler * --------
        string[,] regions = new string[5, 3]
        {
            {"İstanbul","İzmit","Balıkesir" },
            {"Ankara","Konya","Kırıkkale" },
            {"Antalya","Adana","Mersin" },
            {"Rize","Trabzon","Samsun" },
            {"İzmir","Muğla","Uşak" },
        };
        //3 3 3 Bir sonuç Almış olduk
        for (int i = 0; i < regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine("**************");
        }
        //GetUpperBound satırlar [0] dimension sütünlar [1] dimension



        Console.WriteLine();
        Console.ReadLine();
    }
}