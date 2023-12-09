using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Product
    {
        //Property - özellik
        // Bir şeyin sonunda manager, service, dal, date access, controller gibi ifadeler bir opersyon tutuyor demek
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Explanation { get; set; }
        public int StockQuantity { get; set; }


    }
}
