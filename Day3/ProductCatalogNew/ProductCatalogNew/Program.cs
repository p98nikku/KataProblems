using System;
using ProductCatalogData.Entities;
using ProductCatalogData.Processors;

namespace ProductCatalogNew
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var command = args[0];
            //if(command=="--file")
            //{
            //    var filePath = args[1];
            //    Console.WriteLine($"Single File {filePath} selected");
            //    ProcessProductFile(filePath);
            //}
            //else if(command=="--dir")
            //{
            //    var directorypath = args[1];
            //    var fileType = args[2];
            //    Console.WriteLine($"Directory {directorypath} selected for {fileType} files");
            //    ProcessCategoryFile(directorypath, fileType);
            //}
            //    else
            //    {
            //        Console.WriteLine("Invalid command line operations");
            //    }
            //    Console.WriteLine("Press enter to exit");
            //    Console.ReadLine();
            //}
            //public static void ProcessProductFile(string filePath)
            //{
            //    var productProcessor = new ProductProcessor(filePath);
            //    productProcessor.Process();
            Catalog catalog = new Catalog();
            catalog.DisplayCatalog();
        }
    }
}
