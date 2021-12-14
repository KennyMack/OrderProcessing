using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Customer
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Customer> GetDummy()
        {
            var Persons = new List<Customer>();
            var Names = new string[]
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

            var random = new Random();

            var items = random.Next(5, 20);

            for (int i = 0; i < items; i++)
            {
                var nameA = Names[random.Next(0, 17)];
                var nameB = Names[random.Next(0, 17)];

                var name = string.Join(' ', nameA, nameB);

                Persons.Add(new Customer
                {
                    Email = $"{name }@mail.com",
                    Name = name,
                    Id = Guid.NewGuid()
                });
            }

            return Persons;
        }

    }
}
