using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
/// <summary>
/// Descripción breve de Data_Pasajero
/// </summary>
public class DataInfo
{

    private SqlConnection con;
    private SqlCommand cmd;
    private SqlDataAdapter DA;
    private DataTable DT;
    public String sqlResult;

    public string SP_Pasajero(int _type, Pasajero _pasajero) {
        sqlResult = "";
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLCONECCION"].ToString());
        cmd = new SqlCommand("SP_Pasajero", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Type", SqlDbType.Int).Value = _type;
        cmd.Parameters.Add("@Id_Pasajero",SqlDbType.Int).Value = _pasajero.Id_Pasajero;
        cmd.Parameters.Add("@Tipo_Ident",SqlDbType.VarChar).Value = _pasajero.Tipo_Ident;
        cmd.Parameters.Add("@Numero_Ident",SqlDbType.VarChar).Value =_pasajero.Numero_Ident ;
        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = _pasajero.Nombre;
        cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = _pasajero.Apellidos;
        cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = _pasajero.Telefono;
        cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = _pasajero.Email;
        con.Open();
        if (_type == 1 || _type == 2 || _type == 3)
        {
            sqlResult = JsonConvert.SerializeObject( cmd.ExecuteNonQuery(),Formatting.Indented);
        }
        else 
        { 
            DT = new DataTable();
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            sqlResult = JsonConvert.SerializeObject(DT, Formatting.Indented);
        }
        con.Close();
        return sqlResult;
    }
    public string SP_Viaje(int _type, Viaje _viaje)
    {
        sqlResult = "";
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLCONECCION"].ToString());
        cmd = new SqlCommand("SP_Viaje", con);
        cmd.CommandType = CommandType.StoredProcedure;
        //Parametros
        cmd.Parameters.Add("@Type", SqlDbType.Int).Value = _type;
        cmd.Parameters.Add("@Id_Viaje", SqlDbType.Int).Value = _viaje.Id_Viaje;
        cmd.Parameters.Add("@Pais_Origen", SqlDbType.VarChar).Value = _viaje.Pais_Origen;
        cmd.Parameters.Add("@Ciudad_origen", SqlDbType.VarChar).Value = _viaje.Ciudad_origen;
        cmd.Parameters.Add("@País_destino", SqlDbType.VarChar).Value = _viaje.País_destino;
        cmd.Parameters.Add("@Ciudad_destino", SqlDbType.VarChar).Value = _viaje.Ciudad_destino;
        cmd.Parameters.Add("@Fecha_viaje", SqlDbType.DateTime).Value = _viaje.Fecha_viaje;
        cmd.Parameters.Add("@Id_Pasajero", SqlDbType.Int).Value = _viaje.Id_Pasajero;
        con.Open();
        if (_type == 1 || _type == 2 || _type == 3)
        {
            sqlResult = JsonConvert.SerializeObject(cmd.ExecuteNonQuery(), Formatting.Indented);
        }
        else
        {
            DT = new DataTable();
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            sqlResult = JsonConvert.SerializeObject(DT, Formatting.Indented);
        }
        con.Close();
        return sqlResult;
    }

    public string SP_Servicio_Adicional(int _type, Servicio_Adicional _servicio)
    {
        sqlResult = "";
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLCONECCION"].ToString());
        cmd = new SqlCommand("SP_Servicio_Adicional", con);
        cmd.CommandType = CommandType.StoredProcedure;
        //Parametros
        cmd.Parameters.Add("@Type", SqlDbType.Int).Value = _type;
        cmd.Parameters.Add("@Id_Servicio", SqlDbType.Int).Value = _servicio.Id_Servicio;
        cmd.Parameters.Add("@Tipo_servicio", SqlDbType.VarChar).Value = _servicio.Tipo_servicio;
        cmd.Parameters.Add("@Id_Viaje", SqlDbType.Int).Value = _servicio.Id_Viaje;
        con.Open();
        if (_type == 1 || _type == 2 || _type == 3)
        {
            sqlResult = JsonConvert.SerializeObject(cmd.ExecuteNonQuery(), Formatting.Indented);
        }
        else
        {
            DT = new DataTable();
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            sqlResult = JsonConvert.SerializeObject(DT, Formatting.Indented);
        }
        con.Close();
        return sqlResult;
    }
    public string SP_Maleta(int _type, Maleta _maleta)
    {
        sqlResult = "";
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLCONECCION"].ToString());
        cmd = new SqlCommand("SP_Maleta", con);
        cmd.CommandType = CommandType.StoredProcedure;
        //Parametros
        cmd.Parameters.Add("@Type", SqlDbType.Int).Value = _type;
        cmd.Parameters.Add("@Id_Maleta", SqlDbType.Int).Value = _maleta.Id_Maleta;
        cmd.Parameters.Add("@Alto", SqlDbType.Decimal).Value = _maleta.Alto;
        cmd.Parameters.Add("@Largo", SqlDbType.Decimal).Value = _maleta.Largo;
        cmd.Parameters.Add("@Ancho", SqlDbType.Decimal).Value = _maleta.Ancho;
        cmd.Parameters.Add("@Peso", SqlDbType.Decimal).Value = _maleta.Peso;
        cmd.Parameters.Add("@Id_Servicio", SqlDbType.Int).Value = _type;
        con.Open();
        if (_type == 1 || _type == 2 || _type == 3)
        {
            sqlResult = JsonConvert.SerializeObject(cmd.ExecuteNonQuery(), Formatting.Indented);
        }
        else
        {
            DT = new DataTable();
            DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            sqlResult = JsonConvert.SerializeObject(DT, Formatting.Indented);
        }
        con.Close();
        return sqlResult;
    }


}