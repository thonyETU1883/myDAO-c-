using System;
using System.Reflection;
using Npgsql;

namespace dao.Models;

public class Intermediary{
    public FieldInfo[] getallattribute() {
        Type personnelType = this.GetType();
        FieldInfo[] fields = personnelType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        return fields;
    }


    public String getnameofclass(){
        Type myType = this.GetType();
        string name = myType.Name;
        return name;
    }

    public List<object[]> getannotationcolumn(){
        FieldInfo[] fields = this.getallattribute();
        List<object[]> columnlist = new List<object[]>();
        foreach (var field in fields)
        {
            object[] attributs = field.GetCustomAttributes(false);
            columnlist.Add(attributs);
        }
        return columnlist;
    }

    /*
        utiliser pour avoir tous les noms des colonnes sous formes de  : (colonne1,colonne2,colonne3,...)
    */
    public String namescolumnstring(){
        String first = "(";
        List<object[]> columns = this.getannotationcolumn();
        for(int i=0;i<columns.Count;i++){
            for(int j=0;j<columns[i].Length;j++){ 
                if(){
                    if(i<(columns.Count-1)){
                        first = first+columns[i].Name+",";
                    }else{
                        first = first+columns[i].Name+")";
                    }
                }
            }
        }
        return first;
    }

    /*
    public void save(NpgsqlConnection connection){
        String sql = $"INSERT INTO {this.getnameofclass()} ()";
    }   */
}       