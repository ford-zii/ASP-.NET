using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class DBTreeView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
            using (SqlConnection ObjConn = new SqlConnection(StrConn))
            {
                ObjConn.Open();
                using (SqlCommand ObjCM = new SqlCommand())
                {
                    ObjCM.Connection = ObjConn;
                    ObjCM.CommandText = "SELECT ID,Name,Parent FROM TreeView WHERE parent IS NULL;";
                    //ObjCM.ExecuteNonQuery();
                    SqlDataReader ObjDR = ObjCM.ExecuteReader();
                    while (ObjDR.Read())
                    {
                        TreeNode node = new TreeNode(ObjDR["Name"].ToString(), ObjDR["ID"].ToString());
                        TreeView1.Nodes.Add(node);
                        TreeViewNodes(ObjDR["ID"].ToString(),node);
                    }
                    ObjDR.Close();
                    
                }
                ObjConn.Close();
            }
        }
    }

    private void TreeViewNodes(string parent,TreeNode parentNode)
    {
        string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using (SqlConnection ObjConn = new SqlConnection(StrConn))
        {
            ObjConn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.Connection = ObjConn;
                ObjCM.CommandText = "SELECT ID,Name,Parent FROM TreeView WHERE parent =" + parent;
                //ObjCM.ExecuteNonQuery();
                SqlDataReader ObjDR = ObjCM.ExecuteReader();
                while (ObjDR.Read())
                {
                    TreeNode node = new TreeNode(ObjDR["Name"].ToString(), ObjDR["ID"].ToString());
                    parentNode.ChildNodes.Add(node);
                }
                ObjDR.Close();

            }
            ObjConn.Close();
        }
    }
}