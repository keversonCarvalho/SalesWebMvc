using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public string Something { get; set; }

        public Department()
        {
        }
        public Department(int id, string name, string something)
        {
            Id = id;
            Name = name;
            Something = something;
        }
        public void AddSaller(Seller saller)
        {
            Sellers.Add(saller);
        }

        public double TotalDepartmentSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(saller => saller.TotaSallerlSales(initial, final));
        }
    }
}
