﻿using System.Collections.Generic;

namespace TCGshopTestEnvironment.ViewModels
{
    public class ProductsDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Grade { get; set; }

        public int Stock { get; set; }

        public string ImageUrl { get; set; }

        public List<string> CardCatagoryList { get; set; }

        public string returnUrl { get; set; }

        public int Views { get; set; }
    }
}