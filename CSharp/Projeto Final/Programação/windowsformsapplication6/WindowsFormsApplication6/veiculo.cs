//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class veiculo
    {
        public int idVeiculo { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string ano { get; set; }
        public int idCliente { get; set; }
        public int idTipoEstacionamento { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual tipo_estacionamento tipo_estacionamento { get; set; }
    }
}
