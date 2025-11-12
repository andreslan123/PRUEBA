using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_TIENDA_VIRTUALwpfPROGRAMII
{
    class Cliente
    {
        //PROPIEDADES 
        public int IdCli { get; set; }
        public string Nombre { get; set; }
        public List<Producto> lstProdVta { get; set; }

        //CONSTRUCTORES
        public Cliente()
        {
            IdCli = 0;
            Nombre = "no definido";
        }
        public Cliente(int idcli,string nomcli)
        {
            IdCli = idcli;
            Nombre = nomcli;
        }
    }
}
