﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "TestCom" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "TestCom2" });
            }

            Console.WriteLine(vendors);

            return vendors;
        }

        public T RetriveValue<T>(string sql, T defaultValue)
        {
            //Call to the database to retrive the value
            //If no value is returned, return the default value

            T value = defaultValue;

            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
