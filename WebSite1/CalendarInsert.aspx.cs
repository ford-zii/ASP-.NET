﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class CalendarInsert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SetDayDDL();
            SetMonthDDL();
            SetYearDDL();
            if (Request.QueryString["id"] != null)
            {
                GetData(Convert.ToInt32(Request.QueryString["id"]));
            }
        }

    }

    public void SetDayDDL()
    {
        for(int i=1; i<=31; i++)
        {
            DropDownListDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }
    public void SetMonthDDL()
    {
        for (int i = 1; i <= 12; i++)
        {
            DropDownListMonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }
    public void SetYearDDL()
    {
        int DataY = DateTime.Now.Year;
        int CY = DataY + 543;
        for (int i = CY - 5; i <= CY + 1 ; i++)
        {
            DropDownListYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        lableSuc.Visible = true;
        string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using (SqlConnection ObjConn = new SqlConnection(StrConn))
        {
            ObjConn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.Connection = ObjConn;
                ObjCM.CommandType = CommandType.StoredProcedure;
                ObjCM.CommandText = "spCalendarInsert";
                if(Request.QueryString["id"] != null)
                    ObjCM.Parameters.AddWithValue("@id", Request.QueryString["id"]);
                ObjCM.Parameters.AddWithValue("@Title", TitleInput.Text);
                ObjCM.Parameters.AddWithValue("@Day", DropDownListDay.Text);
                ObjCM.Parameters.AddWithValue("@Month", DropDownListMonth.Text);
                ObjCM.Parameters.AddWithValue("@Year", DropDownListYear.Text);
                if(ObjCM.ExecuteNonQuery() > 0)
                {
                    
                    lableSuc.ForeColor = System.Drawing.Color.Lime;
                    lableSuc.Text = "Success!!!";
                }
                else
                {
                    
                    lableSuc.ForeColor = System.Drawing.Color.Red;
                    lableSuc.Text = "ERROR!.";
                }
            }
            ObjConn.Close();
        }
    }
    private void GetData(int id)
    {
        string StrConn = WebConfigurationManager.ConnectionStrings["UPPart2ConnectionString"].ConnectionString;
        using (SqlConnection ObjConn = new SqlConnection(StrConn))
        {
            ObjConn.Open();
            using (SqlCommand ObjCM = new SqlCommand())
            {
                ObjCM.Connection = ObjConn;
                ObjCM.CommandType = CommandType.StoredProcedure;
                ObjCM.CommandText = "spCalendarByID";
                ObjCM.Parameters.AddWithValue("@ID", id);
                SqlDataReader ObjDR = ObjCM.ExecuteReader();
                ObjDR.Read();
                DropDownListDay.SelectedValue = ObjDR["Day"].ToString();
                DropDownListMonth.SelectedValue = ObjDR["Month"].ToString();
                DropDownListYear.SelectedValue = ObjDR["Year"].ToString();
                TitleInput.Text = ObjDR["Title"].ToString();
                ObjDR.Close();
            }
            ObjConn.Close();  
        }
    }
}
