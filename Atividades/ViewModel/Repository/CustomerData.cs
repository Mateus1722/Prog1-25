

using System.Collections.Generic;
using Modelo; 
using System.Linq; 

namespace Repository 
{
    public static class CustomerData
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>
        {
            new Customer { Id = 1, Name = "Romeu Antunes", HomeAddress = "Rua Torres, 655", WorkAddress = "Av. Fortnite, 200" },
            new Customer { Id = 2, Name = "Julieta Andrade", HomeAddress = "Rua Valentine, 122", WorkAddress = "Av. Red Dead, 176" }
        };

        public static List<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = 1, Name = "PC Gamer", Description = "Maquina para jogos", CurrentPrice = 7500.00M },
            new Product { Id = 2, Name = "Smartphone XX", Description = "Top de Linha", CurrentPrice = 4800.00M },
            new Product { Id = 3, Name = "Teclado Mecânico", Description = "Switches Red", CurrentPrice = 375.00M }
        };

        public static List<Order> Orders { get; set; } = new List<Order>();
    }
}