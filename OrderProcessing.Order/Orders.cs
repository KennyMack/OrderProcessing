using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Order
{
    public class Orders
    {
        public Orders()
        {
            Items = new List<Products>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Products> Items { get; set; }

        public List<Orders> GetDummy()
        {
            var Orders = new List<Orders>();
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

            var Persons = new string[]
            {
                "Paulo",
                "Marcos",
                "Silvio",
                "Marcelo",
                "Matos",
                "Julio",
                "João",
                "Paula",
                "Márcia",
                "Fabiana",
                "Juliana",
                "Ricardo",
                "Moura",
                "Silva",
                "Regina",
                "Fabiano",
                "Augusto",
                "Reinaldo"
            };

            var Products = new Products().GetDummy();

            var random = new Random();

            var NumOrders = random.Next(5, 20);

            for (int i = 0; i < NumOrders; i++)
            {
                var nameA = Persons[random.Next(0, 17)];
                var nameB = Persons[random.Next(0, 17)];

                var name = string.Join(' ', nameA, nameB);
                var Order = new Orders
                {
                    Email = $"{name}@mail.com",
                    Name = name,
                    Id = Guid.NewGuid()
                };
                var NumItems = random.Next(2, 15);
                for (int p = 0; p < NumItems; p++)
                {
                    var ItemIndex = random.Next(0, Products.Count - 1);

                    Order.Items.Add(Products[ItemIndex]);
                }

                Orders.Add(Order);
            }

            return Orders;
        }
    }
}
