using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogData.Processors
{
    public class ProductProcessor
    {
        public string InputFilePath { get; }
        public ProductProcessor(string filePath)
        {
            InputFilePath = filePath;
        }
        public void Process()
        {
            Console.WriteLine($"{InputFilePath}");
        }
    }
}
