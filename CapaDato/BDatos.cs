using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Globalization;

namespace CapaDatos
{
    public class BDatos
    {
        private static string Str;
        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;
        //Para todos
        private static DataSet Ds;

        public static void PonerPathBaseAccess(string l)
        {
            Str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + l + @"\Persistencia\baseClub.mdb"; //Se guarda en C:\Users\ftopa\Desktop\TPCD\CapaUsuario\bin\Debug\net5.0-windows\Persistencia\baseClub.mdb
        }

        public static bool GuardarSocio(ArrayList datos)
        {
            bool todoOk = false;
            if (datos != null && datos.Count == 8 || datos.Count == 7)
            {
                try
                {
                    int idSocio = int.Parse(datos[0].ToString());
                    int dni = int.Parse(datos[1].ToString());
                    string nombre = datos[2].ToString();
                    string apellido = datos[3].ToString();
                    string sexo = datos[4].ToString();
                    string status = datos[5].ToString();
                    double cuota = double.Parse(datos[6].ToString());
                    string fechaNac = datos[7].ToString();

                    string strCmd = "INSERT INTO Socio (idSocio,dni,nombre,apellido,fechaNac,sexo,status,cuota) VALUES (" + idSocio + "," + dni + "," + "'" + nombre + "'" + ",'" + apellido + "'" + ",'" + fechaNac + "'," + "'" + sexo + "'" + "," + "'" + status + "'" + "," + cuota + ");";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoOk = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoOk);

        }

        public static bool ModificarSocio(ArrayList datos)
        {
            bool todoOk = false;
            if (datos != null && datos.Count == 8 || datos.Count == 7)
            {
                try
                {
                    int idSocio = int.Parse(datos[0].ToString());
                    int dni = int.Parse(datos[1].ToString());
                    string nombre = datos[2].ToString();
                    string apellido = datos[3].ToString();
                    string sexo = datos[4].ToString();
                    string status = datos[5].ToString();
                    double cuota = double.Parse(datos[6].ToString());
                    string fechaNac = datos[7].ToString();

                    string strCmd = "UPDATE Socio SET dni=" + dni+","+ " nombre= '" + nombre + "'" + ", apellido= '" + apellido + "'" + ", fechaNac= '" + fechaNac + "'," + "sexo= '" + sexo + "'" + "," + "status= '" + status + "'" + ", cuota=" + cuota + " WHERE idSocio = " + idSocio;
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoOk = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoOk);

        }

        public static List<ArrayList> RecuperarSocios()
        {

            ArrayList datosSocio;
            List<ArrayList> contenedorSocios = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Socio ORDER BY idSocio";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosSocio = new ArrayList();

                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //id        
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //dni       
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //nombre
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //apellido
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString()); //sexo
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString()); //status
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[6].ToString()); //cuota
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[7].ToString()); //fechaNac
                    contenedorSocios.Add(datosSocio);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorSocios);
        }

        public static void EliminarSocio(int idSocio)
        {
            string consulta = "DELETE * FROM Socio WHERE idSocio = " + idSocio + ";";

            try
            {
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(consulta, Con);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Con.Close();
                Cmd.Dispose();
            }

        }

        public static bool GuardarProfesor(ArrayList datos)
        {
            bool todoOk = false;
            if (datos != null && datos.Count == 8)
            {
                try
                {
                    int numProfesor = int.Parse(datos[0].ToString());
                    int dni = int.Parse(datos[1].ToString());
                    string nombre = datos[2].ToString();
                    string apellido = datos[3].ToString();
                    string sexo = datos[4].ToString();
                    string alias = datos[5].ToString();
                    string status = datos[6].ToString();
                    string fechaNac = datos[7].ToString();

                    string strCmd = "INSERT INTO Profesor (numProfesor,dni,nombre,apellido,fechaNac,sexo,alias,status) VALUES (" + numProfesor + "," + dni + "," + "'" + nombre + "'" + "," + "'" + apellido + "'" + ",'" + fechaNac + "'," + "'" + sexo + "'" + "," + "'" + alias + "'" + "," + "'" + status + "'" + ")";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoOk = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoOk);

        }

        public static bool ModificarProfesor(ArrayList datos)
        {
            bool todoOk = false;
            if (datos != null && datos.Count == 8)
            {
                try
                {
                    int numProfesor = int.Parse(datos[0].ToString());
                    int dni = int.Parse(datos[1].ToString());
                    string nombre = datos[2].ToString();
                    string apellido = datos[3].ToString();
                    string sexo = datos[4].ToString();
                    string alias = datos[5].ToString();
                    string status = datos[6].ToString();
                    string fechaNac = datos[7].ToString();

                    string strCmd = "UPDATE Profesor SET dni=" + dni + "," + " nombre= '" + nombre + "'" + "," + " apellido= '" + apellido + "'" + ", fechaNac= '" + fechaNac + "'," + "sexo= '" + sexo + "'" + "," + " alias= '" + alias + "'" + "," + " status= '" + status + "'" + "WHERE numProfesor= " + numProfesor;
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoOk = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoOk);

        }

        public static List<ArrayList> RecuperarProfesor()
        {

            ArrayList datosProfesores;
            List<ArrayList> contenedorProfesores = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Profesor ORDER BY numProfesor";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosProfesores = new ArrayList();

                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //idProfesor        
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //dni       
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //nombre
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //apellido
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString()); //sexo
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString()); //alias
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[6].ToString()); //status
                    datosProfesores.Add(Ds.Tables[0].Rows[i].ItemArray[7].ToString()); //fechaNac
                    contenedorProfesores.Add(datosProfesores);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorProfesores);
        }

        public static void EliminarProfesor(int numProfesor)
        {
            string consulta = "DELETE * FROM Profesor WHERE numProfesor = '" + numProfesor + "';";

            try
            {
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(consulta, Con);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Con.Close();
                Cmd.Dispose();
            }

        }

        public static bool GuardarActiv(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 5)
            {
                try
                {
                    int cod = int.Parse(datos[0].ToString());
                    string nomb = datos[1].ToString();
                    string descrip = datos[2].ToString();
                    int cantMaxPart = int.Parse(datos[3].ToString());
                    double costo = double.Parse(datos[4].ToString());

                    string strCmd = "INSERT INTO Actividad (codActividad,nombre,descrip,costo,cantMaxPart) VALUES (" + cod + "," + "'" + nomb + "'" + "," + "'" + descrip + "'" + "," + costo + "," + cantMaxPart + ");";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoBien);

        }

        public static bool ModificarActiv(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 5)
            {
                try
                {
                    int cod = int.Parse(datos[0].ToString());
                    string nomb = datos[1].ToString();
                    string descrip = datos[2].ToString();
                    int cantMaxPart = int.Parse(datos[3].ToString());
                    double costo = double.Parse(datos[4].ToString());

                    string strCmd = "UPDATE Actividad SET nombre= '" + nomb + "'" + "," + " descrip= '" + descrip + "'" + ", costo= " + costo + ", cantMaxPart= " + cantMaxPart + " WHERE codActividad = " + cod;
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoBien);

        }

        public static List<ArrayList> RecuperarActividades()
        {

            ArrayList datosActiv;
            List<ArrayList> contenedorActividades = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Actividad ORDER BY codActividad";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosActiv = new ArrayList();

                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //cod        
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //nomb       
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //descrip
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //cantMax
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString()); //costo       
                    contenedorActividades.Add(datosActiv);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorActividades);
        }

        public static void EliminarActividad(int cod)
        {
            string consulta = "DELETE * FROM Actividad WHERE cod = " + cod + ";";

            try
            {
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(consulta, Con);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Con.Close();
                Cmd.Dispose();
            }

        }


        public static bool GuardarClase(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 5)
            {
                try
                {
                    int idClase = int.Parse(datos[0].ToString());
                    string dia = datos[1].ToString(); ;
                    string horarios = datos[2].ToString();
                    int numProfesor = int.Parse(datos[3].ToString());
                    int codActividad = int.Parse(datos[4].ToString());

                    string strCmd = "INSERT INTO Clase (idClase,dia,horarios,numProfesor,codActividad) VALUES (" + idClase + "," + "'" + dia + "'" + "," + "'" + horarios + "'" + "," + numProfesor + "," + codActividad + ");";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoBien);

        }

        public static bool ModificarClase(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 5)
            {
                try
                {
                    int idClase = int.Parse(datos[0].ToString());
                    string dia = datos[1].ToString(); ;
                    string horarios = datos[2].ToString();
                    int numProfesor = int.Parse(datos[3].ToString());
                    int codActividad = int.Parse(datos[4].ToString());

                    string strCmd = "UPDATE Clase SET dia= '" + dia + "'" + "," + " horarios= '" + horarios + "'" + ", numProfesor= " + numProfesor + ", codActividad= " + codActividad + " WHERE idClase= "+ idClase;
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoBien);

        }

        public static List<ArrayList> RecuperarClase()
        {

            ArrayList datosClases;
            List<ArrayList> contenedorClases = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Clase ORDER BY idClase";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosClases = new ArrayList();

                    datosClases.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //idclase        
                    datosClases.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //dia       
                    datosClases.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //horario
                    datosClases.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //profesor
                    datosClases.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString()); //actividad
                    contenedorClases.Add(datosClases);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorClases);
        }

        public static void EliminarClase(int idClase)
        {
            string consulta = "DELETE * FROM Clase WHERE idClase = '" + idClase + "';";

            try
            {
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(consulta, Con);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Con.Close();
                Cmd.Dispose();
            }

        }

        public static bool GuardarFactura(ArrayList datos)
        {
            bool todoOk = false;
            if (datos != null && datos.Count == 4)
            {
                try
                {
                    int nroFactura = int.Parse(datos[0].ToString());
                    double monto = double.Parse(datos[1].ToString());
                    string fechaPago = datos[2].ToString();
                    int idSocio = int.Parse(datos[3].ToString());

                    string strCmd = "INSERT INTO Factura (nroFactura,monto,fechaPago,idSocio) VALUES (" + nroFactura + "," + monto + ",'" + fechaPago + "'," + idSocio + ");";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoOk = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoOk);

        }

        public static List<ArrayList> RecuperarFactura()
        {

            ArrayList datosFacturas;
            List<ArrayList> contenedorFacturas = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Factura ORDER BY nroFactura";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosFacturas = new ArrayList();

                    datosFacturas.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //nroFactura        
                    datosFacturas.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //monto       
                    datosFacturas.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //fechaPago
                    datosFacturas.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //idSocio
                    contenedorFacturas.Add(datosFacturas);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorFacturas);
        }

        public static void EliminarFactura(int nroFactura)
        {
            string consulta = "DELETE * FROM Factura WHERE nroFactura = '" + nroFactura + "';";

            try
            {
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(consulta, Con);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Con.Close();
                Cmd.Dispose();
            }

        }

        


        
        public static void GuardarInscripcion(ArrayList datos)
        {
            if (datos != null && datos.Count == 2)
            {
                try
                {
                    int idClase = int.Parse(datos[0].ToString());
                    int idSocio = int.Parse(datos[1].ToString());

                    string strCmd = "INSERT INTO ClaseSocio (idClase,idSocio) VALUES (" + idClase + "," + idSocio + ")";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }

        }

        public static List<ArrayList> RecuperarInscripcion()
        {

            ArrayList datosInscrip;
            List<ArrayList> contenedorInscripciones = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM ClaseSocio ORDER BY idClase";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosInscrip = new ArrayList();

                    datosInscrip.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //idclase        
                    datosInscrip.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //idsocio       
                    contenedorInscripciones.Add(datosInscrip);
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorInscripciones);
        }

        //version 1
        public static void AnularInscripcion(ArrayList datos)
        {
            if(datos!= null && datos.Count == 2)
            {
                try
                {
                    int idClase = int.Parse(datos[0].ToString());
                    int idSocio = int.Parse(datos[1].ToString());

                    string strCmd = "DELETE FROM ClaseSocio WHERE idClase = " + idClase + "AND idSocio = " + idSocio;
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
        }


    }

}
