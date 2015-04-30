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
            var temp = new List<TransformedDataSet>();
            var previousKey = "empty_key_value";
            int counter = 1;
            temp.Add(new TransformedDataSet()
                {
                    Name = "Name",
                    Phone = "Phone",
                    EyeColor = "EyeColor",
                    PositionID = "PositionID",
                    Title = "Title",
                    PositionCount = "PositionCount"
                });
            
            for (int i = 1; i < transformedFile.Count(); i++)
            {
                if (previousKey == transformedFile[i].Key)
                {
                    temp.Add(new TransformedDataSet()
                        {
                            Name = "",
                            Phone = "",
                            EyeColor = "",
                            PositionID = transformedFile[i].PositionID,
                            Title = transformedFile[i].Title,
                            PositionCount = (++counter).ToString()
                        });
                    previousKey = transformedFile[i].Key;
                }
                else if (previousKey != transformedFile[i].Key)
                {
                    temp.Add(new TransformedDataSet()
                    {
                        Name = transformedFile[i].Name,
                        Phone = transformedFile[i].Phone,
                        EyeColor = transformedFile[i].EyeColor,
                        PositionID = transformedFile[i].PositionID,
                        Title = transformedFile[i].Title,
                        PositionCount = "1"
                    });
                    counter = 1;
                    previousKey = transformedFile[i].Key;
                }
            }
            transformedFile = temp;
        }
    }
}
