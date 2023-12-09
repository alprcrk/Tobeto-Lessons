using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList <T>
    {
       T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        {

            //newlediğim an referans numarası alır yeni referans numarası demek önceki elemanların uçması demek.
            //Uçmasın diye o referans numarasını başkasına tutturuyoruz sonra kendime başka bir referans alıyorum.

            T[] tempArray = items;
            items = new T[items.Length+1];
            //tempArrayın bütün elemanlarını items a geri atama yapıyoruz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; 
        }
    }
}
