using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

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
            string Ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName); //get ext
            if(Ext.ToUpper() == ".JPG")
            {
                string Newname = Guid.NewGuid().ToString(); //gen name
                string cNewname = string.Format("{0}{1}", Newname, Ext); // create name+ext
                string Path = "Upload/"; //Path Upload
                string cPath = Server.MapPath(string.Format("{0}{1}", Path, cNewname));
                FileUpload1.SaveAs(cPath);
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
}