
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System;
using System.IO;
//using System.Data;
using System.Text;
//using Mono.Data.Sqlite;

public class ConexionConsultas : MonoBehaviour {
    public string connection;
    public IDbConnection dbcon;
    public IDbCommand dbcmd;
    public IDataReader reader;
    public StringBuilder builder;

    public void Start()
    {

    }

    public void OpenDB(string p)
    {
        //connection = "URI =file:" + Application.dataPath + "/StreamingAssets/" + "Oficina.db; Version=3; Password=cualquierpass";
        connection = "URI =file:" + Application.dataPath + "/StreamingAssets/" + "Oficina.db;Version=3;Password=cualquierpass.";

        Debug.Log("Stablishing connection to: " + connection);
        dbcon = new SqliteConnection(connection);
        dbcon.Open();

    }

    public void CloseDB()
    {
        //reader.Close();
        //reader = null;
        //dbcmd.Dispose();
        //dbcmd = null;
        //dbcon.Close();
        //dbcon = null;
    }

    public string retornarMinimoPorId(int id)
    {


        string consulta, min = "";
        consulta = "SELECT * FROM infoApartamentos WHERE id = " + id + "";
        dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = consulta;
        reader = dbcmd.ExecuteReader();

        while (reader.Read())
        {
            min = reader.GetString(6);
        }
        return min;
    }

    //public string retornarMaximoPorId(int id){

    //    //connection = "URI =file:" + Application.dataPath + "/StreamingAssets/" + "Oficina.db;Version=3;Password=Bancolombia2019.";
    //    //Debug.Log("Stablishing connection to: " + connection);
    //    //IDbConnection dbcon = new SqliteConnection(connection);
    //    //dbcon.Open();

    //    string consulta,max="";
    //    consulta = "SELECT * FROM infoApartamentos WHERE id = " + id + "";
    //    dbcmd = dbcon.CreateCommand();
    //    dbcmd.CommandText = consulta;
    //    reader = dbcmd.ExecuteReader();

    //    while (reader.Read())
    //    {
    //        max = reader.GetString(8);
    //    }
    //    return max;
    //}




    //Se guardan los datos de inicio que son CC, fecha de ingreso y hora de ingreso
    public void SaveLogin(string id_cedula, string fecha_ingreso, string hora_ingreso, string tipo_sueno)
    {

        IDbCommand cmnd = dbcon.CreateCommand();
        cmnd.CommandText = "INSERT INTO Cedula(Cedula, Fecha_ingreso, Hora_ingreso, Tipo_sueno) values('" + id_cedula + "', '" + fecha_ingreso + "', '" + hora_ingreso + "', '" + tipo_sueno + "')";
        cmnd.ExecuteNonQuery();

        //IDbCommand cmnd_read = dbcon.CreateCommand();
        //IDataReader lector;
        //string query = "SELECT * FROM Cedula";
        //cmnd_read.CommandText = query;
        //lector = cmnd_read.ExecuteReader();
        //while (lector.Read())
        //{
        //    Debug.Log("ID: " + lector[0].ToString());
        //    Debug.Log("Cedula: " + lector[1].ToString());
        //    Debug.Log("Fecha_ingreso: " + lector[2].ToString());
        //    Debug.Log("Hora_ingreso: " + lector[3].ToString());
        //    Debug.Log("Hora_salida: " + lector[4].ToString());
        //    Debug.Log("Duracion_total: " + lector[5].ToString());
        //    Debug.Log("Preaprobado: " + lector[6].ToString());
        //    Debug.Log("Millones: " + lector[7].ToString());
        //    Debug.Log("Anos: " + lector[8].ToString());
        //    Debug.Log("Tipo_sueno: " + lector[9].ToString());
        //    Debug.Log("Ver_plano: " + lector[10].ToString());
        //    Debug.Log("Ver_mas_proyectos: " + lector[11].ToString());
        //}
        dbcon.Close();

    }

    public void UpdateSaveLogOut(string id_cedula, string hora_ingreso, string hora_salida, string duracion_total)
    {

        string consulta = "";
        consulta = "UPDATE Cedula SET Hora_salida = '" + hora_salida + "', Duracion_total = '" + duracion_total + "' WHERE Cedula = '" + id_cedula + "' AND Hora_ingreso = '" + hora_ingreso + "'";
        dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = consulta;
        reader = dbcmd.ExecuteReader();
    }

    public void UpdatesavePreaprobado360(string id_cedula, string hora_ingreso, int cant_millones, int cant_anos, string preaprobado, string ver_plano, string ver_mas_proyectos)
    {
        string consulta = "";
        consulta = "UPDATE Cedula SET Millones = '" + cant_millones + "', Anos = '" + cant_anos + "', Preaprobado = '" + preaprobado + "', Ver_plano = '" + ver_plano + "', Ver_mas_proyectos = '" + ver_mas_proyectos + "' WHERE Cedula = '" + id_cedula + "' AND Hora_ingreso = '" + hora_ingreso + "'";
        dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = consulta;
        reader = dbcmd.ExecuteReader();
    }

    public void SaveProyectos(string Cedula, string Fecha_ingreso, string Departamento, string Municipio, string Obra)
    {
        //ESTO SE DEBE EJECUTAR PRIMERO ANTES DE CARGAR LA ESCENA

        string consulta = "";
        consulta = "INSERT INTO Proyecto(Cedula, Fecha_ingreso, Departamento, Municipio, Obra) values('" + Cedula + "', '" + Fecha_ingreso + "', '" + Departamento + "','" + Municipio + "','" + Obra + "' )";
        dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = consulta;
        reader = dbcmd.ExecuteReader();
    }
}
*/