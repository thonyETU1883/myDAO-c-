namespace dao.Models;

using System;
using System.Xml;


public class Connection{
    
    public Connection(){}

    public Database getinformationdatabase(String pathfichier){
        try
        {
            using (XmlTextReader reader = new XmlTextReader(pathfichier))
            {
                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load(reader);

                XmlNode configurationNode = xmlDoc.SelectSingleNode("/Database/configuration");

                if (configurationNode != null)
                {
                    string server = configurationNode.SelectSingleNode("server").InnerText;
                    string databasename = configurationNode.SelectSingleNode("databasename").InnerText;
                    string port = configurationNode.SelectSingleNode("port").InnerText;
                    string username = configurationNode.SelectSingleNode("username").InnerText;
                    string password = configurationNode.SelectSingleNode("password").InnerText;

                    // Affichez les valeurs
                    Console.WriteLine("Server: " + server);
                    Console.WriteLine("Database Name: " + databasename);
                    Console.WriteLine("Port: " + port);
                    Console.WriteLine("Username: " + username);
                    Console.WriteLine("Password: " + password);
                }
                else
                {
                    Console.WriteLine("L'élément <configuration> n'a pas été trouvé.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Une erreur s'est produite : " + ex.Message);
        }
        return new Database();
    }
    
}