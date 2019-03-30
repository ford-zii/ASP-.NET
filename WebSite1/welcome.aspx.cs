using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //เข้าทุกครั้งทำทุกครั้ง
        //Class1 ObjC = new Class1();
        //ObjC.name = "FORD";
        //SUMresult.Text = ObjC.sum(1, 2).ToString();
    }

    protected void SUM_Click(object sender, EventArgs e)
    {
        Class1 ObjC = new Class1();
        ObjC.name = "ผลบวก ";
        int N1 = Convert.ToInt32(Input1.Text);
        int N2 = Convert.ToInt32(Input2.Text);
        int N3 = Convert.ToInt32(Input3.Text);
        int N4 = Convert.ToInt32(Input4.Text);
        int N5 = Convert.ToInt32(Input5.Text);
       
        SUMresult.Text = ObjC.sum(N1,N2).ToString();
        SUMresult1.Text = ObjC.sum(N3, N4, N5).ToString();
    }
    protected void SUM_Click2(object sender, EventArgs e)
    {
        Class1 ObjC = new Class1();
        ObjC.name = "ผลบวก ";
       
        int N1 = Convert.ToInt32(Input3.Text);
        int N2  = Convert.ToInt32(Input4.Text);
        int N3 = Convert.ToInt32(Input5.Text);

        SUMresult1.Text = ObjC.sum(N1, N2, N3).ToString();
    }
}