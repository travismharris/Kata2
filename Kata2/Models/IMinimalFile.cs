using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.Models
{
    public interface IMinimalFile
    {
        string Name { get; set; }

        string Phone { get; set; }

        string EyeColor { get; set; }

        string PositionID { get; set; }

        string Title { get; set; }

        string Key { get; set; }
    }
}
