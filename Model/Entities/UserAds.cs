using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserAds
    {
        public int UserId { get; set; }
        public int AdId { get; set; }
        public virtual User User { get; set; }
        public virtual Ad Ad { get; set; }
    }
}
