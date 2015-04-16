using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.Models
{
    public class NewRequirement : IFileFormat
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string EyeColor { get; set; }

        public string PositionID { get; set; }

        public string Title { get; set; }

        public string Key { get; set; }

        public string FavoriteIceCream { get; set; }

        public NewRequirement() { }

        public NewRequirement( string input)
        {
            AssignInputToModel(input);
        }

        public List<string> AssignInputToModel(string input)
        {
            //here we'll want to make sure we grab the right info and put it into the right Fields. 
            //including our new favoriteIceCream data point
            throw new NotImplementedException();
        }
    }
}
