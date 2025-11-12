using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_TIENDA_VIRTUALwpfPROGRAMII
{
    class Producto
    {
        //PROPIEDADES 
        public int IdProd { get; set; }
        public string NombreProd { get; set; }
        public double PrecioProd { get; set; }
        //CONSTRUCTORES
        public Producto()
        {
            IdProd = 0;
            NombreProd = "No definido";
            PrecioProd = 0;
        }
        public Producto(int idProd, string NombrePro, double Precio)
        {
            IdProd = idProd;
            NombreProd = NombrePro;
            PrecioProd = Precio;
        }
    }
}
