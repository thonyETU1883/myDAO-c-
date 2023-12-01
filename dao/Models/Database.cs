namespace dao.Models;
using Npgsql; 

public class Database{
    String? server;
    String? database;
    String? port;
    String? username;
    String? password;


    public Database(){}
    public Database(String server,String database,String port,String username,String password){
        this.server=server;
        this.database=database;
        this.port=port;
        this.username=username;
        this.password=password;
    }

    public String? getserver(){
        return this.server;
    }

    public String? getdatabase(){
        return this.database;
    }

    public String? getport(){
        return this.port;
    }

    public String? getusername(){
        return this.username;
    }

    public String? getpassword(){
        return this.password;
    }

    public void setserver(String server){
        this.server = server;
    }

    public void setdatabase(String database){
        this.database = database;
    }

    public void setport(String port){
        this.port = port;
    }

    public void setusername(String username){
        this.username = username;
    }

    public void setpassword(String password){
        this.password = password;
    }
}
