using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVeReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 30;
            //sayi1 = sayi2;
            //sayi2 = 65;
            //sayi1 ?? 30
            //                          { 999, 200, 300 }
            int[] sayilar1 = new int[] { 10, 20, 30 }; //101
            int[] sayilar2 = new int[] { 100, 200, 300 }; //102
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999

            // sayısal veri tipleri (int, decimal, floot, double, bool) bunlar = değer tip diyoruz.
            // ama bir (array, class, interface) = bunlar ise karşımıza referans tip olarak çıkıyor.

            // Bir değişken tanımladığımızda Örn: (int sayi1) gibi değer tip olanlar tamamen stack'de gerçekleşiyor.
            // okunuş: sayi1'in değeri eşittir sayı2'nin değeri yani sadece değeri aktarırız.
            // sayi2 ile olan irtibat direkt kopar yani sayi2'nin değeri sayi1'e aktarılır.
            // sayi2 = 65 dediğimizde değeri 65 olur sayi1 ile hiç bir alakası yoktur tamamen bağlantı kopar olay sadece değeri atamaktır.
            // (Değer tip olanlar) 
            //  ---* stack *---           
            // sayi1 = /10/ 30 *Yeni değeri
            // sayi2 = 30

            //(Referans tip olanlar)
            // ---* heap *---
            // int[] sayilar1 tanımlama yaptığımızda ( --* stack * --) da sayilar1 tanımlanır.
            // new dediğimiz an sayilar1 için (--* heap *--)'de yeni bir alan oluştur ve değerleri oraya yaz demek. 
            // bağlantıları 
            // (--* heap *--) in bir adresi var. Bir adres değeri tutuyor. Örn: 101 gibi 
            // sayılar1'in karşılığı (101) numaralı adreste 
            // (new) demek (--* heap *--)'de yeni bir adres oluştur demek bu şekilde düşünebilirsin
            // array int bile olsa arrayler daima referans tiptir.
            // Değer tiplerde değeri atıyoruz referans tiplerde adresi atıyoruz
            // (Değer tip)          (Referans tip)
            // ---* stack *---  &   ---* heap *---
            // 101^/sayilar1 ----> 101^/[10,20,30] * Yeni değeri: 102^/[100,200,300]
            // 102^/sayilar2 ----> 102^/[100,200,300]
            // sayilar1 = sayilar2; Okunuşu: sayilar1'in referans numarası sayilar2'nin referans numarasına eşittir.
            // sayilar2[0] = 999; Not: sayılar2 nin yani 102'nin referans numarasının 0'ıncı elemanı [-->999<--,200,300]
            // sayilar1[0] 999 sayilar1 artık 102'yi tuttuğu için değeri 999 oluyor 

        }
    }
}
