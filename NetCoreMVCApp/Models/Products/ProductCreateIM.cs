using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.Models.Products
{
    // Bussiness bir durum yoksa DataAnnotations
    // Fluent Api Validation daha karmaşık validasyon kontrolü için var.
    public class ProductCreateIM
    {

        [Required(ErrorMessage ="İsim Boş geçilemez")]
        public string Name { get; set; }

        [Min(10,ErrorMessage ="Min fiyat 10 TL altında olamaz")]
        [Required(ErrorMessage = "fiyat değeri boş geçilemez")]
        public decimal Price { get; set; }

        [Max(100, ErrorMessage = "Max stock 100 adet olabilir")]
        [Required(ErrorMessage = "stock değeri boş geçilemez")]
        public short Stock { get; set; }



    }
}
