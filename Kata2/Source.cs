using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kata2
{
    public class Source
    {
        private string path;
        public List<SourceModel> sourceSet;

        public Source() : this("../../input/input.txt") { }

        public Source(string path)
        {
            this.path = path;
        }

        public void CreateSourceList()
        {
            sourceSet = new List<SourceModel>();
            using (StreamReader s = new StreamReader(path))
            {
                while (!s.EndOfStream)
                {
                    var currentLine = s.ReadLine();
                    sourceSet.Add(new SourceModel(currentLine));
                }
            }
        }

        public void LoadSource()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Load the File");
            }
            else throw new IOException("input file");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SourceModel s in sourceSet)
            {
                sb.Append(s.Name + ", " + s.Phone + ", " + s.EyeColor + ", " + s.PositionID + ", " + s.Title + s.Key + "\n");
            }
            return sb.ToString();
        }

        public static string Output(List<SourceModel> sourceSet)
        {
            StringBuilder sb = new StringBuilder();
            foreach(SourceModel s in sourceSet)
            {
                sb.Append("stub");
            }
            return sb.ToString();
        }

    }
}
