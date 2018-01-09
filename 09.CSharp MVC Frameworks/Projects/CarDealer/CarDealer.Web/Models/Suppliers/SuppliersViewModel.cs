﻿namespace CarDealer.Web.Models.Suppliers
{
    using CarDealer.Services.Models.Suppliers;
    using System.Collections.Generic;

    public class SuppliersViewModel
    {
        public string Type { get; set; }

        public IEnumerable<SupplierListingServiceModel> Suppliers { get; set; }
    }
}