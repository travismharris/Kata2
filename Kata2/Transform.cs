using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2
{
    public class Transform
    {
        public List<DataSet> loadedFile;
        public List<TransformedDataSet> transformedFile;

        public Transform(List<DataSet> loadedFile)
        {
            transformedFile = new List<TransformedDataSet>();
            foreach(DataSet a in loadedFile)
            {
                transformedFile.Add(new TransformedDataSet()
                {
                    Name = a.Name,
                    EyeColor = a.EyeColor,
                    Phone = a.Phone,
                    PositionID = a.PositionID,
                    Title = a.Title,
                    Key = a.Name + a.Phone + a.EyeColor
                });
            }
            transformedFile.OrderBy(s => s.Key);
        }

        public void Format()
        {
            var previousKey = "empty_key_value";
            int counter = 1;
            StringBuilder sb = new StringBuilder("Name, Phone, EyeColor, PositionId, Title, PositionCount\n");
            for (int i = 0; i < transformedFile.Count(); i++)
            {
                if (previousKey == transformedFile[i].Key)
                {
                    sb.AppendLine(", , , " + transformedFile[i].PositionID + ", " + transformedFile[i].Title + ", " + ++counter);
                    previousKey = transformedFile[i].Key;
                }
                else if (previousKey != transformedFile[i].Key)
                {
                    sb.AppendLine(transformedFile[i].Name + ", " + transformedFile[i].Phone + ", " + transformedFile[i].EyeColor + ", " + transformedFile[i].PositionID
                        + ", " + transformedFile[i].Title + ", 1");
                    counter = 1;
                    previousKey = transformedFile[i].Key;
                }
            }

            //return sb.ToString();
        }
    }
}
