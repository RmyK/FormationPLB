using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Parallel
{
    class DoParallel
    {
        public List<Client> MesClients{ get; set; }

        public void DoFacturation()
        {
            ConcurrentBag<string> mesFactures = new ConcurrentBag<string>();
            Parallel.ForEach(MesClients, (client) => {
                mesFactures.Add(CreateFacture(client));
            });
        }

        public string CreateFacture(Client client)
        {
            return $"Voici la facture du client {client.Nom}";
        }
    }
}
