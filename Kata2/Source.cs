using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Kata2.Models;

namespace Kata2
{
    public class Source : IInput
    {
        private string path;
        public List<Original> sourceSet;
        

        public Source() : this("../../input/input.txt") { }

        public Source(string path)
        {
            this.path = path;
            CreateSourceList();
            CleanHeaderRow();
            SortList();
        }

        public void CreateSourceList()
        {
            sourceSet = new List<Original>();
            using (StreamReader s = new StreamReader(path))
            {
                while (!s.EndOfStream)
                {
                    var currentLine = s.ReadLine();
                    sourceSet.Add(new Original(currentLine));
                }
            }
        }

        public void SortList()
        {
            var sortedList = sourceSet.OrderBy(s => s.Key).ToList();
            sourceSet = sortedList;
        }

        public void CleanHeaderRow()
        {
            var cleanedSource = new List<Original>();
            foreach (Original s in sourceSet.Where(s => s.Name != "SKIP_THIS_ROW"))
                cleanedSource.Add(s);

            sourceSet = cleanedSource;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Original s in sourceSet)
            {
                sb.Append(s.Name + ", " + s.Phone + ", " + s.EyeColor + ", " + s.PositionID + ", " + s.Title + "\n");
            }
            return sb.ToString();
        }

        public string OutputFile()
        {
            var previousKey = "empty_key_value";
            int counter = 1;
            StringBuilder sb = new StringBuilder("Name, Phone, EyeColor, PositionId, Title, PositionCount\n");
            for(int i = 0; i < sourceSet.Count(); i ++)
            {
                if (previousKey == sourceSet[i].Key)
                {
                    sb.AppendLine(", , , " + sourceSet[i].PositionID + ", " + sourceSet[i].Title + ", " + ++counter);
                    previousKey = sourceSet[i].Key;
                }
                else if (previousKey != sourceSet[i].Key)
                {
                    sb.AppendLine(sourceSet[i].Name + ", " + sourceSet[i].Phone + ", " + sourceSet[i].EyeColor + ", " + sourceSet[i].PositionID
                        + ", " + sourceSet[i].Title + ", 1");
                    counter=1;
                    previousKey = sourceSet[i].Key;
                }
            }
              
            return sb.ToString();
        }

        public void Load(string location)
        {
            sourceSet = new List<Original>();
            using (StreamReader s = new StreamReader(path))
            {
                while (!s.EndOfStream)
                {
                    var currentLine = s.ReadLine();
                    sourceSet.Add(new Original(currentLine));
                }
            }
        }
    }
}
/*
 Name       Phone       EyeColor        PositionID      Title               PositionCount
 Franklin   1212        Blue            123             General Manager     1
                                        67              Salesman            2
 Pierce     1313        Blue            234             Digger              1
                                        456             Porter              2
 Hoolihan   1414        Green           123             General Manager     1
 Bob        1515        Blue            86              Maid                1
                                        90              Electrician         2

*/