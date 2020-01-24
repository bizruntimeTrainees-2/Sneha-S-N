using System;  
using System.Collections.Generic;  
using System.Drawing;  
using System.Linq;  
using System.Web;  
using System.Web.UI;  
using System.Web.UI.WebControls;  
  
public partial class _Default : System.Web.UI.Page  
{  
    EmployeeDataContext db = new EmployeeDataContext();  
    protected void Page_Load(object sender, EventArgs e)  
    {  
        if (!Page.IsPostBack)  
  
        {  
  
            BindGridview();  
  
        }  
    }  
    protected void BindGridview()  
  
    {  
  
        var result = from ed in db.EmployeeDetails  
  
                     select new  
  
                     {  
  
                         Id = ed.Id,  
  
                         Name = ed.Name,  
  
                         Location = ed.Location,  
  
                         Gender = ed.Gender  
  
                     };  
  
        gvDetails.DataSource = result;  
  
        gvDetails.DataBind();  
  
    }  
    protected void gvDetails_RowCommand(object sender, GridViewCommandEventArgs e)  
  
    {  
  
        if (e.CommandName.Equals("AddNew"))  
  
        {  
  
            TextBox txtname = (TextBox)gvDetails.FooterRow.FindControl("txtfName");  
  
            TextBox txtlocation = (TextBox)gvDetails.FooterRow.FindControl("txtfLocation");  
  
            TextBox txtgender = (TextBox)gvDetails.FooterRow.FindControl("txtfGender");  
  
            EmployeeDetail emp = new EmployeeDetail();  
  
            emp.Name = txtname.Text;  
  
            emp.Location = txtlocation.Text;  
  
            emp.Gender = txtgender.Text;  
  
            db.EmployeeDetails.InsertOnSubmit(emp);  
  
            db.SubmitChanges();  
  
            lblresult.ForeColor = Color.Green;  
  
            lblresult.Text = txtname.Text + " details inserted successfully";  
  
            BindGridview();  
  
        }  
  
    }  
    protected void gvDetails_RowEditing(object sender, GridViewEditEventArgs e)  
  
    {  
  
        gvDetails.EditIndex = e.NewEditIndex;  
  
        BindGridview();  
  
    }  
  
    protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)  
  
    {  
  
        gvDetails.EditIndex = -1;  
  
        BindGridview();  
  
    }  
  
    protected void gvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)  
  
    {  
  
        gvDetails.PageIndex = e.NewPageIndex;  
  
        BindGridview();  
  
  
    }  
    protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)  
  
    {  
  
        int empid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["Id"].ToString());  
  
        TextBox txtname = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtName");  
  
        TextBox txtlocation = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtLocation");  
  
        TextBox txtgender = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtGender");  
  
        EmployeeDetail emp = new EmployeeDetail();  
  
        emp = db.EmployeeDetails.Single(x => x.Id == empid);  
  
        emp.Name = txtname.Text;  
  
        emp.Location = txtlocation.Text;  
  
        emp.Gender = txtgender.Text;  
  
        db.SubmitChanges();  
  
  
  
        gvDetails.EditIndex = -1;  
  
        BindGridview();  
  
        lblresult.ForeColor = Color.Green;  
  
        lblresult.Text = txtname.Text + " details updated successfully";  
    }  
    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)  
  
    {  
  
        int empid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["Id"].ToString());  
  
        string empname = gvDetails.DataKeys[e.RowIndex].Values["Name"].ToString();  
  
        EmployeeDetail emp = new EmployeeDetail();  
  
        emp = db.EmployeeDetails.Single(x => x.Id == empid);  
  
        db.EmployeeDetails.DeleteOnSubmit(emp);  
  
        db.SubmitChanges();  
  
        BindGridview();  
  
        lblresult.ForeColor = Color.Green;  
  
        lblresult.Text = empname + " details deleted successfully";  
  
    }  
}