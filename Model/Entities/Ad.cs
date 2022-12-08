using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Ad : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<UserAds> UserAds { get; set; }
        public int Price { get; set; }  
        public string Specification { get; set; }
    }
}
