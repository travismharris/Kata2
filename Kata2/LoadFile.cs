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

            try
            {
                using (StreamReader reader = new StreamReader(fileLocation))
                {
                    ConfirmHeaders(reader.ReadLine());
                }
            }catch (InvalidDataException e)
            {
                Console.WriteLine("Exception: " + e.Message + e.ToString());
                throw new Exception("See Inner Exception for Detail", e);
            }
            
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

            bool one = values.Contains("EyeColor");
            bool two = values.Contains("Title");
            bool three = values.Contains("PositionID");
            bool four = values.Contains("Name");
            bool five = values.Contains("Phone");

            
            if (fieldCount > this.PropertiesCount(new DataSet()) || (!(values.Contains("EyeColor") && values.Contains("Name") && values.Contains("Phone") &&
                values.Contains("PositionID") && values.Contains("Title"))))
                throw new InvalidDataException("Provided input file doesn't contain all required headers.");
        }

        public int PropertiesCount(object getPropertyCount)
        {
            var propCount = getPropertyCount.GetType().GetProperties().Count();
            return propCount;
        }
    }
}
