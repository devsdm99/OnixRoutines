using System;
using System.Collections.Generic;
using System.Text;

namespace OnixModels.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {

        }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
