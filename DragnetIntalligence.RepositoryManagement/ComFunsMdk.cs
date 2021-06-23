using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Net;
using Dragnet.DataObjects;

/// <summary>
/// Summary description for ComFuns
/// </summary>
public class ComFunsMdk
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionStringTec"));
    DataTable dt = new DataTable();
    public ComFunsMdk()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataSet GetDataSet(String Query)
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        da.SelectCommand = new SqlCommand(Query, con);
        da.SelectCommand.CommandTimeout = 2 * 60;
        da.Fill(ds, "Data");
        return ds;
    }

    public int RunQueryWOCheck(string Query)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        con.Open();
        cmd.CommandText = Query;
        int i = cmd.ExecuteNonQuery();
        con.Close();
        return i;
    }

  

    public DataTable GetDataTable(String Query)
    {
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = new SqlCommand(Query, con);
        da.SelectCommand.CommandTimeout = 2 * 60;
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

}