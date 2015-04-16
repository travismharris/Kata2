using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.Models

{
    public class Original : IFileFormat
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string EyeColor { get; set; }

        public string PositionID { get; set; }

        public string Title { get; set; }

        public string Key { get; set; }

        public Original() { }

        public Original(string input)
        {
            var dataPoints = AssignInputToModel(input);
            if (dataPoints[0] == "Name" && dataPoints[1] == "Phone" & dataPoints[2] == "EyeColor")
            {
                Name = "SKIP_THIS_ROW";
            }
            else
            {
                Name = dataPoints[0];
                Phone = dataPoints[1];
                EyeColor = dataPoints[2];
                PositionID = dataPoints[3];
                Title = dataPoints[4];
                Key = Name + Phone + EyeColor;
            }
        }

        public List<string> AssignInputToModel(string input)
        {
            return input.Split(new string[]{", "}, 5, StringSplitOptions.None).ToList();
        }

        
    }
}
