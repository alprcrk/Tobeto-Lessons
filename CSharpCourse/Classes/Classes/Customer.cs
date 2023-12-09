using System;

namespace Classes
{
	class Customer()
	{   // şu anlama geliyor bir müşterinin özelliklerini tutmak için kullandığımız nesnedir genellikle veritabanlarında kolonların karşılıklarını biz burada bir class için tutabiliriz 
        // Müşterinin özelliklerini tutmak içinde property ve class dan yararlanabiliyoruz. 

        //Property 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        // --------* Encapsulation Teknikleri *--------
        // Bir kural getiriyoruz eğer ki kullanıcı FirstName set ederse yani ona bir değer verirse FirstName in başına başka bir karakter getirelim.
        //Field 
        private string _firstName;   
        public string FirstName 
        { 
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

    }
}
