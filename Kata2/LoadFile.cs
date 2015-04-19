using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2
{
    public class LoadFile : ILoad
    {
        public List<DataSet> dataFromSource;

        public LoadFile() : this("../../input/input.txt") { }

        public LoadFile(string path)
        {
            //CreateSourceList();
            //CleanHeaderRow();
            //SortList();
        }
        
        public void Load(string fileLocation)
        {
            throw new NotImplementedException();
        }
    }
}
