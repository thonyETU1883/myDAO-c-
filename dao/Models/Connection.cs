namespace dao.Models;
using System;
using System.Xml;
using Npgsql;
using MySql.Data.MySqlClient;

public class Connection{
    
    public Connection(){}

    public NpgsqlConnection? createconnectionpostgresql(){
      Database database = this.getinformationdatabase();
      string connectionString =$"Host=localhost;Port={database.getport()};Username={database.getusername()};Password={database.getpassword()};Database={database.getdatabase()};";
      try{
          NpgsqlConnection connection = new NpgsqlConnection(connectionString);
          connection.Open();
          return connection;
      }catch(Exception ex){
          Console.WriteLine($"Erreur lors de la connexion à PostgreSQL : {ex.Message}");
      }
      return null;
    }


    //non tester
    public MySqlConnection? createconnectionmysql(){
      Database database = this.getinformationdatabase();
      string connectionString = $"Server={database.getserver()};Database={database.getdatabase()};User ID={database.getusername()};Password={database.getpassword()};";
      try
      {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        return connection;
      }
      catch (Exception ex)
      {
          Console.WriteLine("Erreur de connexion : " + ex.Message);
      }
      return null;
    }

    public Database getinformationdatabase(){
        Database database =  new Database();
        try{
          XmlReader reader = XmlReader.Create(@"config.xml");
          while (reader.Read()) {
            if (reader.IsStartElement()) {
              switch (reader.Name.ToString()) {
                case "server":
                  database.setserver(reader.ReadString());
                  break;
                case "databasename":
                  database.setdatabase(reader.ReadString());
                  break;
                case "port":
                  database.setport(reader.ReadString());
                break;
                case "username":
                  database.setusername(reader.ReadString());
                break;
                case "password":
                  database.setpassword(reader.ReadString());
                break;
              }
            }
          }
        }catch(Exception e){
          Console.WriteLine("fichier non trouver \n"+e.Message);
        }
        return database;
    }
    
}