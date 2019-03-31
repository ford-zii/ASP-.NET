using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calendar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        Literal ObjL = new Literal();
        if (e.Day.Date.Day == 1 && e.Day.Date.Month == 1)
        {
            //Literal ObjL = new Literal();
            ObjL.Text = "Happy new year";
            e.Cell.Controls.AddAt(1, ObjL);
            e.Cell.BackColor = System.Drawing.Color.DarkViolet;
        }
        else if ((e.Day.Date.Day >= 13 && e.Day.Date.Day <= 15) && e.Day.Date.Month == 4)
        {
            ObjL.Text = "Songkan Day";
            e.Cell.Controls.AddAt(1, ObjL);
            e.Cell.BackColor = System.Drawing.Color.Red;
            e.Cell.ForeColor = System.Drawing.Color.White;
        }
        else if ((e.Day.Date.Day == 20 ) && e.Day.Date.Month == 4)
        {
            ObjL.Text = "family day";
            e.Cell.Controls.AddAt(1, ObjL);
            e.Cell.BackColor = System.Drawing.Color.Lime;
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
       // LabelOnClicked.Text = Calendar1.SelectedDate.ToString();
        string[] AttData = Calendar1.SelectedDate.ToString().Split(' ');
        string[] AttDate = AttData[0].Split('/');
        Response.Redirect(string.Format("CalendarDetail.aspx?d={0}&m={1}&y={2}",AttDate[0],AttDate[1],AttDate[2]));
    }
}