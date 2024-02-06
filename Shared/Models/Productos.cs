using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioProductos.Shared.Models
{
    public class Productos
    {
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime fecha { get; set; }

		public int Cantidad { get; set; }

		public int Precio { get; set; }

		public int TipoProducto { get; set; }

		public int IdSucursal { get; set; }
	}
}