using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method injection yani bu metotun kullanacağı ICreditManager creditManager yani hangi türü olacağını ve hangi ILoggerService loggerService (loglayıcı) olacağını enjecte ediyoruz
        public void Apply(ICreditManager creditManager, ILoggerService loggerService) //Başvuru yap
        {
            // Başvuran bilgilerini değerlendirme
            // 
            creditManager.Calculate();
            loggerService.Log();
        }

        // aynı veri türünde 1 tane 0 tane 1000 tane de olabilecek veriyi taşıyabilecek bir yapı (List)
        // bana bir liste ver ama bu listenin türü ICreditManager olsun
        // *interfacleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        // Loglama nedir? bir nevi o sistemde olan hareketleri döktüğümüz bir dökümdür.
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {

            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}
