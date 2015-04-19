using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata2.Models;

namespace Kata2
{
    public class DataSet : IMinimalFile
    {

        public string Name { get; set; }

        public string Phone  { get; set; }
        
        public string EyeColor  { get; set; }
    
        public string PositionID  { get; set; }
        
        public string Title  { get; set; }
        
        public string Key  { get; set; }
    }
}
