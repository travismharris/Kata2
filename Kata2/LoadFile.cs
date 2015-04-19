using FileHelpers;
using Kata2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kata2
{
    public class LoadFile : ILoad
    {
        public List<DataSet> dataFromSource;

        public LoadFile() : this("../../input/input.txt") { }

        public LoadFile(string path)
        {
            Load(path);
        }
        
        public void Load(string fileLocation)
        {
            if(!File.Exists(fileLocation))
                throw new FileNotFoundException("sourceFile");

            using (StreamReader reader = new StreamReader(fileLocation))
            {
                ConfirmHeaders(reader.ReadLine());
            }

            //if the file doesn't exist in an accepted format the above throws an exeption
            FileHelperEngine<DataSet> engine = new FileHelperEngine<DataSet>();
            dataFromSource = engine.ReadFile(fileLocation).ToList();
            
        }

        public void ConfirmHeaders(string headerRow)
        {
            int fieldCount = 1;
            for (int i = 0; i < headerRow.Length; i++)
            {
                if (headerRow[i] == ',')
                    fieldCount++;
            }
            var values = headerRow.Split(new string[] { "," }, fieldCount, StringSplitOptions.None).ToList();
            for (int i = 0; i < values.Count(); i++ )
            {
                values[i] = values[i].Trim();
            }

            if (!(values[0] == "Name" && values[1] == "Phone" & values[2] == "EyeColor"))
                throw new InvalidDataException("sourceFile");
        }

    }
}
