using System.Data;
using System.Data.SqlClient;

namespace POOII_CL1_QUISPE_EDSON.Models
{
    public class BDProducto
    {
        // Cambiar la cadena de conexion segun tu configuración
        string cadenaConexion = "Data Source=MINAMI-EED;" +
                    "Initial Catalog=POOCL1;" +
                    "Integrated Security=True;";

        public List<Producto> ObtenerTodos()
        {
            List<Producto> listaProducto = new List<Producto>();
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.Id = dr.GetInt32(0);
                producto.Descripcion = dr.GetString(1);
                producto.Tipo = dr.GetString(2);
                producto.Precio = dr.GetDecimal(3);

                listaProducto.Add(producto);
            }
            return listaProducto;
        }
        public List<Producto> ProductosPorDescripcion(string descripcion)
        {
            List<Producto> listaProducto = new List<Producto>();
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("usp_productos_por_descripcion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            string paramDescripcion = "%" + descripcion + "%";
            cmd.Parameters.AddWithValue("@descripcion", paramDescripcion);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.Id = dr.GetInt32(0);
                producto.Descripcion = dr.GetString(1);
                producto.Tipo = dr.GetString(2);
                producto.Precio = dr.GetDecimal(3);
                listaProducto.Add(producto);
            }
            return listaProducto;
        }

        public List<Producto> ProductosPorPrecio(decimal precioMin, decimal precioMax)
        {
            List<Producto> listaProducto = new List<Producto>();
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("usp_productos_por_precio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@precioMin", precioMin);
            cmd.Parameters.AddWithValue("@precioMax", precioMax);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.Id = dr.GetInt32(0);
                producto.Descripcion = dr.GetString(1);
                producto.Tipo = dr.GetString(2);
                producto.Precio = dr.GetDecimal(3);
                listaProducto.Add(producto);
            }
            return listaProducto;
        }

        public List<Producto> ProductosPorTipoYPrecio(string tipo, decimal precio)
        {
            List<Producto> listaProducto = new List<Producto>();
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("usp_productos_por_tipo_y_precio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            string paramTipo = "%" + tipo + "%";
            cmd.Parameters.AddWithValue("@tipo", paramTipo);
            cmd.Parameters.AddWithValue("@precio", precio);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.Id = dr.GetInt32(0);
                producto.Descripcion = dr.GetString(1);
                producto.Tipo = dr.GetString(2);
                producto.Precio = dr.GetDecimal(3);
                listaProducto.Add(producto);
            }
            return listaProducto;
        }
    }
}
