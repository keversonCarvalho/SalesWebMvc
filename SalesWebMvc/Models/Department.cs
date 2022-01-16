using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; } = new List<Saller>();

        public Department()
        {
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSaller(Saller saller)
        {
            Sallers.Add(saller);
        }

        public double TotalDepartmentSales(DateTime initial, DateTime final)
        {
            return Sallers.Sum(saller => saller.TotaSallerlSales(initial, final));
        }
    }
}
