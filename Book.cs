using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace deneme12
{
    public class Book
    {
        [Key]
        public int Kitapid {  get; set; }
        public string KitapAd {  get; set; }
        public string Yazar {  get; set; }
        public string Tur {  get; set; }
        public int Sayfa {  get; set; }
    }
}
