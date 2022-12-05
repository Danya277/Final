using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<UserAds> UserAds { get; set; }
        public List<Ad> Ads { get; set; }
        public User()
        {
            public virtual List<StudentsSkills> StudentsSkills { get; set; }
    }
    }
}
