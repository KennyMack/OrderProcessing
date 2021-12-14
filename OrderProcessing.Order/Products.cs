using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Order
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public List<Products> GetDummy()
        {
            var Persons = new List<Products>();
            var Names = new string[]
            {
                "Carro",
                "Barco",
                "Furadeira",
                "Martelo",
                "Serra",
                "Tico-Tico",
                "Chave de fenda"
            };

            var random = new Random();

            var items = random.Next(5, 20);

            for (int i = 0; i < items; i++)
            {
                var ProductName = Names[random.Next(0, 6)];

                Persons.Add(new Products
                {
                    Name = ProductName,
                    Quantity = Math.Round((random.NextDouble() * 100) + 1, 2),
                    Price = Math.Round((random.NextDouble() * 100) + 1, 2),
                    Id = Guid.NewGuid()
                });
            }

            return Persons;
        }
    }
}
