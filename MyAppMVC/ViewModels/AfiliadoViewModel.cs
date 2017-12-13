using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAppMVC.ViewModels
{
    public class AfiliadoViewModel
    {
        public int ClienteId { get; set; }


        public int TipoDocumentoId { get; set; }

        public string CodigoTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public int TipoClienteId { get; set; }

        public string CodigoTipoCliente { get; set; }
        public string NombreTipoCliente { get; set; }


    }
}