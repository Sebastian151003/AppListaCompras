using AppListaCompras.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using static SQLite.SQLite3;
//using System.Data.SQLite;

namespace AppListaCompras
{
    public class UsuarioRepository
    {
        string _dbPath;
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;
        public UsuarioRepository(string dbPath) { _dbPath = dbPath; }

        private void Init()
        {
            if (conn is not null)
                return;
            conn = new(_dbPath);
            conn.CreateTable<ModeloUsuarios>();
            conn.CreateTable<ModeloListaCompras>();
        }
        private bool ValidarUsuario(string nombre)
        {
            Init();

            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = string.Format("Select * from tbusuarios where Nombre ='{0}'", nombre);

            List<ModeloUsuarios> rowUsuarios = command.ExecuteQuery<ModeloUsuarios>();

            if (rowUsuarios.Count() > 0)
                return false;

            return true;
        }

        public bool AddNewUsuario(ModeloUsuarios datosUsuario)
        {
            bool status = true;
            try
            {
                if (ValidarUsuario(datosUsuario.Nombre))
                {
                    Init();

                    if (string.IsNullOrEmpty(datosUsuario.Nombre))
                    {
                        StatusMessage = string.Format("Se requiere {0} valido.", "Nombre");
                        status = false;
                        return status;
                    }
                    if (string.IsNullOrEmpty(datosUsuario.Contraseña))
                    {
                        StatusMessage = string.Format("Se requiere {0} valido.", "Contraseña");
                        status = false;
                        return status;
                    }
                    if (string.IsNullOrEmpty(datosUsuario.Correo))
                    {
                        StatusMessage = string.Format("Se requiere {0} valido.", "Correo");
                    }
                    if (string.IsNullOrEmpty(datosUsuario.Telefono))
                    {
                        StatusMessage = string.Format("Se requiere {0} valido.", "Telefono");
                        status = false;
                        return status;
                    }

                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = string.Format("INSERT INTO tbUsuarios (Nombre, Correo, Contraseña, FechaCreacion) " +
                                            "VALUES ('{0}', '{1}','{2}','" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "')",
                                            datosUsuario.Nombre, datosUsuario.Correo, datosUsuario.Contraseña);

                    int rowsAffected = command.ExecuteNonQuery();
                    StatusMessage = string.Format("El usuario {0}, se registro con exito.", datosUsuario.Nombre);
                }
                else
                {
                    StatusMessage = string.Format("Ya existe un usuario con nombre de usuario {0}", datosUsuario.Nombre);
                    status = false;
                }
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Error al cargar el usuario {0}. Error:{1}", datosUsuario.Nombre, ex.Message);
                status = false;
            }
            return status;
        }
        public List<ModeloUsuarios> GetUsuarios()
        {
            try
            {
                Init();
                return conn.Table<ModeloUsuarios>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrive data. {0}", ex.Message);

            }
            return new List<ModeloUsuarios>();
        }
        public void DeleteUsuariosall()
        {
            Init();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = "Delete from tbUsuarios";
            int rowsAffected = command.ExecuteNonQuery();

            List<ModeloUsuarios> _listusuarios = GetUsuarios();
        }

        public bool ValidarLogin(ModeloUsuarios datosLogeo)
        {
            Init();

            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = string.Format("Select * from tbusuarios where Nombre ='{0}' and Contraseña='{1}'",
                                                datosLogeo.Nombre, datosLogeo.Contraseña);

            List<ModeloUsuarios> rowUsuarios = command.ExecuteQuery<ModeloUsuarios>();

            if (rowUsuarios.Count() == 0)
            {
                StatusMessage = string.Format("El usuario y/o la contraseña son incorrectos");
                return false;
            }

            return true;
        }
    }
}
