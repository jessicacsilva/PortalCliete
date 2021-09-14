using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCadastroCliente.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public static List<ClienteModel> RetornaListaCliente()
        {
            List<ClienteModel> clienteModels = new List<ClienteModel>();

            clienteModels.Add(new ClienteModel()
            {
                Id=1,
                Name = "Jessica Cruz",
                Email = "jessica.silva@iteris.com.br",
                Adress = "Rua Abc, 455, Jardim Luciana - São Paulo -SP"
            });

            clienteModels.Add(new ClienteModel()
            {
                Id = 2,
                Name = "José da Silva",
                Email = "jose.silva@gmail.com.br",
                Adress = "Rua Abc, 600, Jardim Luciana - São Paulo -SP"
            });

            clienteModels.Add(new ClienteModel()
            {
                Id = 3,
                Name = "Maria Pereira",
                Email = "maria.pereira@yahoo.com",
                Adress = "Rua Abc, 500, Jardim Luciana - São Paulo -SP"
            });

            clienteModels.Add(new ClienteModel()
            {
                Id = 4,
                Name = " Paulo Cardoso",
                Email = "paulo.cardoso@bol.com.br",
                Adress = "Rua Abc, 700, Jardim Luciana - São Paulo -SP"
            });

            return clienteModels;

        }

       
    }
}
