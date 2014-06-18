using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using InterviewTest1.Models;

namespace InterviewTest1
{
    public class Repo
    {
        public IEnumerable<Invoice> All()
        {
            var invoices = new List<Invoice>();
            var rnd = new Random();
            var idx = 0;

            while (idx++ < 2)
            {
                var reqDate = DateTime.UtcNow.AddDays(-rnd.Next(10,
                                                                15));
                invoices.Add(new Invoice
                             {
                                 InvoiceNo = string.Format("B2{0}", idx.ToString(CultureInfo.InvariantCulture).PadRight(6, '0')),
                                 BillingCity = _cities[rnd.Next(_cities.Length)],
                                 BillingContact = _contactNames[rnd.Next(_contactNames.Length)],
                                 BillingState = _states[rnd.Next(_states.Length)],
                                 BillingStreet = _streets[rnd.Next(_streets.Length)],
                                 BillingZip = string.Format("{0}-{1}",
                                                            rnd.Next(10000,
                                                                     99999),
                                                            rnd.Next(1000,
                                                                     9999)),
                                 CompanyName = _companyNames[rnd.Next(_companyNames.Length)],
                                 LineItems = GetItems(rnd.Next(1,
                                                               10)),
                                 PostedDate = DateTime.UtcNow,
                                 RequisitionDate = reqDate,
                                 Shipping = (decimal) Math.Round(rnd.NextDouble()*35, 2),
                                 ShippingDate = reqDate.AddDays(rnd.Next(3, 5)),
                                 TaxRate = (decimal) Math.Round(rnd.NextDouble(), 2)
                             });
            }

            return invoices;
        }

        private IEnumerable<InvoiceItem> GetItems(int itemCount)
        {
            var items = new List<InvoiceItem>();
            var rnd = new Random();
            var i = 0;

            while (i++ < itemCount)
            {
                items.Add(new InvoiceItem
                          {
                              Discount = (byte) Math.Floor(rnd.NextDouble()*30),
                              LineText = _products[rnd.Next(_products.Count())],
                              Quantity = rnd.Next(1,99),
                              UnitPrice = (decimal) Math.Round(rnd.NextDouble()*600,2),
                              Taxable = Math.Round(rnd.NextDouble(), MidpointRounding.ToEven) > 0
                          });
            }

            return items;
        }

        #region Data Generation Elements

        private readonly string[] _contactNames = new[]
                                                  {
                                                      "John Smith",
                                                      "Jane Smith",
                                                      "Curious George",
                                                      "Tony Stark",
                                                      "Mickey Mouse",
                                                      "Bruce Wayne",
                                                      "Clark Kent",
                                                      "Tow Mater"
                                                  };

        private readonly string[] _companyNames = new[]
                                                  {
                                                      "Start Industries",
                                                      "Daily Planet",
                                                      "Mater Towing",
                                                      "Wayne Industries",
                                                      "San Francisco Zoo",
                                                      "Buena Vista",
                                                      "ACME Company"
                                                  };

        private readonly string[] _streets = new[]
                                             {
                                                 "1234 Mater Lane",
                                                 "3428 Zoo Ave",
                                                 "8293 10th St",
                                                 "239 Main St",
                                                 "9283 Secret Hideout Dr"
                                             };

        private readonly string[] _cities = new[]
                                            {
                                                "San Francisco",
                                                "New York City",
                                                "Lake Buena Vista"
                                            };

        private readonly string[] _states = new[]
                                            {
                                                "Florida",
                                                "New York",
                                                "California"
                                            };

        private readonly string[] _products = new[]
                                              {
                                                  "Action Figure",
                                                  "Golf Clubs",
                                                  "Video Game",
                                                  "RC Car",
                                                  "Universal Remote",
                                                  "Coffee Cup",
                                                  "Smart Phone"
                                              };

        #endregion
    }
}