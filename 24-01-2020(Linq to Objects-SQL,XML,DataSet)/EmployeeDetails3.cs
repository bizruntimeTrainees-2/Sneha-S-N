using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
using System.Web.UI;  
using System.Web.UI.WebControls;  
  
public partial class _Default : System.Web.UI.Page  
{  
    protected void Page_Load(object sender, EventArgs e)  
  
    {  
  
        EmployeeDBDataContext db = new EmployeeDBDataContext();  
  
        if (!Page.IsPostBack)  
  
        {  
  
            var result = from ed in db.EmployeeDetails  
  
                         join d in db.Departments on ed.DeptId equals d.DeptId into edept  
  
                         from dpem in edept  
  
                         select new  
  
                         {  
  
                             Name = ed.EmpName,  
  
                             Location = ed.Location,  
  
                             Gender = ed.Gender,  
  
                             Department = dpem.DeptName  
  
                         };  
  
            gvDetails.DataSource = result;  
  
            gvDetails.DataBind();  
  
        }  
  
    }  
}  