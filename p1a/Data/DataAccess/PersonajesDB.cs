using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1a.Data.DataAccess
{
    internal class PersonajesDB 
    {

        private string connectionString = "Server=localhost; Database=db_universidad; Uid=root; Pwd=123456";
                                          

        public bool ProbarConexion()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try {
                    connection.Open();
                    return true;
                }

                catch(Exception){
                    return false;
                }
            }
        }


        //Metodo para leer todos los personajes
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }








        // Método para crear un nuevo personaje
        public int CrearPersonaje(string nombre, string raza, int nivelPoder)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder) VALUES (@nombre, @raza, @nivelPoder)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);

                    return command.ExecuteNonQuery();
                }
            }
        }



        //Busca un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }

        //Buscar nombre¿
        //NombreBuscar se llama ahora NombreABuscar
        public DataTable NombreABuscar(string nombre)
        {
            DataTable Nuevopersonaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE nombre = @nombre";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(Nuevopersonaje);
                    }
                }
            }
            return Nuevopersonaje;
        }
































    }
}
