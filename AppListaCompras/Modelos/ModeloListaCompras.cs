using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaCompras.Modelos
{
    [Table("tbListaCompras")]
    public class ModeloListaCompras
    {
        [PrimaryKey, AutoIncrement]
        public int IdListaCompras { get; set; }
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public string FechaCreacion { get; set; }
    }
}
