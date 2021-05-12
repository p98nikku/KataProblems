﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogData.Entities
{
    public class Category
    {
        public static int AutoIncreament = 0;
        public int Id { get; }
        public string Name { get; set; }

        public string ShortCode { get; set; }
        public string Description { get; set; }

        public Category()
        {
            AutoIncreament++;
            Id = AutoIncreament;
        }
        public override string ToString()
        {
            return $"ID: {this.Id} Name: {this.Name} ShortCode: {this.ShortCode} Description: {this.Description}\n";
        }
    }
}
