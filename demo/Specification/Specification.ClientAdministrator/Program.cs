using Specification.ClientAdministrator.Models;
using Specification.ClientAdministrator.Models.Specifications;
using Specification.ClientAdministrator.Repository;
using System;

namespace Specification.ClientAdministrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientRepository = new ClientRepository();

            #region Get Clients By Name
            Console.WriteLine("==============================================");
            Console.WriteLine("Clients By Name\n");

            GetClientsByName(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            #region Get Clients By Min Age
            Console.WriteLine("==============================================");
            Console.WriteLine("Clients By Min Age \n");
            GetClientsByMinAge(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            #region Get Clients for Discount
            Console.WriteLine("==============================================");
            Console.WriteLine("Clients For Discount \n");
            GetClientsForDiscount(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            Console.ReadLine();
        }

        private static void GetClientsByName(ClientRepository clientRepository)
        {
            var clients = clientRepository.GetClientBy(new ClientNameSpecification("a"));

            foreach (var client in clients)
            {
                Console.WriteLine($"Client with Id {client.ClientId}, Name {client.Name} {client.LastName} and Join Date {client.JoinDate.ToShortDateString()}");
            }
        }

        private static void GetClientsByMinAge(ClientRepository clientRepository)
        {
            var clients = clientRepository.GetClientBy(new ClientMinAgeSpecification());

            foreach (var client in clients)
            {
                Console.WriteLine($"Client with Id {client.ClientId}, Name {client.Name} {client.LastName} and Age {client.Age}");
            }
        }

        private static void GetClientsForDiscount(ClientRepository clientRepository)
        {
            var clients = clientRepository.GetClientBy(new ClientForDiscountSpecification());

            foreach (var client in clients)
            {
                Console.WriteLine($"Client with Id {client.ClientId}, Name {client.Name} {client.LastName}, Join Date {client.JoinDate} and Age {client.Age}");
            }
        }
    }
}
