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
    }
}
