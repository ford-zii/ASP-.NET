using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class UploadFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        lableSuc.Visible = true;
        if (FileUpload1.HasFile)
        {
            string OldFileName = FileUpload1.FileName;
            string Ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName); //get ext

            if(Ext.ToUpper() == ".JPG") //Check format
            {
                string Newname = Guid.NewGuid().ToString(); //gen name
                string cNewname = string.Format("{0}{1}", Newname, Ext); // create name+ext
                string Path = string.Format("Upload/{0}",cNewname); //Path Upload
                string cPath = Server.MapPath(Path);
                
                FileUpload1.SaveAs(cPath); 
                InsertFiletoDB(OldFileName,Path);

                lableSuc.ForeColor = System.Drawing.Color.Lime;
                lableSuc.Text = "Success!!!";
            }
            else
            {

                lableSuc.ForeColor = System.Drawing.Color.Red;
                lableSuc.Text = "File not support!!.";
            }
            
        }
        else
        {
         
            lableSuc.ForeColor = System.Drawing.Color.Red;
            lableSuc.Text = "Miss file";
        }
        
    }

    private void InsertFiletoDB(string oldFileName,string cPath)
    {
        string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using (SqlConnection ObjConn = new SqlConnection(StrConn))
        {
            ObjConn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.Connection = ObjConn;
                ObjCM.CommandType = CommandType.StoredProcedure;
                ObjCM.CommandText = "apTreeViewInsertedFile";
                ObjCM.Parameters.AddWithValue("@Name",oldFileName);
                ObjCM.Parameters.AddWithValue("@PicturePath",cPath);
                ObjCM.ExecuteNonQuery();
            }
            ObjConn.Close();
        }
    }
}
