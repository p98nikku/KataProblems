using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductCatalogData.OperationOnCsv
{
    public class CategoryOperationCsv
    {
        public static List<string> ReadCategory()
        {
            string InputFilePath = @"C:\Users\S S INFOTECH\source\repos\ProductCatalogNew\ProductCatalogData\categorydata.csv";
            using (StreamReader inputStreamReader = new StreamReader(InputFilePath))
            {
                List<string> categoryvalue = new List<string>();
                inputStreamReader.ReadLine();
                while (!inputStreamReader.EndOfStream)
                {
                    categoryvalue.Add(inputStreamReader.ReadLine());
                }
                return categoryvalue;
            }
        }
    }
}
