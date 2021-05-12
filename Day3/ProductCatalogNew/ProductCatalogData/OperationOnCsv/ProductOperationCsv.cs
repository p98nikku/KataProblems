using System.Collections.Generic;
using System.IO;

namespace ProductCatalogData.OperationOnCsv
{
    public class ProductOperationCsv
    {
        public static List<string> ReadProduct()
        {
            string InputFilePath = @"C:\Users\S S INFOTECH\source\repos\ProductCatalogNew\ProductCatalogData\productdata.csv";
            using (StreamReader inputStreamReader = new StreamReader(InputFilePath))
            {
                List<string> productvalue = new List<string>();
                inputStreamReader.ReadLine();
                while(!inputStreamReader.EndOfStream)
                {
                    productvalue.Add(inputStreamReader.ReadLine());
                }
                return productvalue;
            }
        }
    }
}
