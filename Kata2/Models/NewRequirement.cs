using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.Models
{
    public class NewRequirement : IMinimalFile
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string EyeColor { get; set; }

        public string PositionID { get; set; }

        public string Title { get; set; }

        public string FavoriteIceCream { get; set; }
    }
}
