using SQLite;
using System.Globalization;

namespace AppListaCompras.Modelos;

[Table("tbUsuarios")]
public class ModeloUsuarios
{
    [PrimaryKey, AutoIncrement]
    public int IdUsuario { get; set; }

    [MaxLength(50)]
    public string Nombre { get; set; }

    public string Correo { get; set; }

    public string Contraseña { get; set; }
    public string Telefono { get; set; }

    public string FechaCreacion { get; set; }
}

