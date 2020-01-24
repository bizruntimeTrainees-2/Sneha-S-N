using System;  
using System.Collections.Generic;  
using System. Linq;  
using System. Web;  
using System.Web.UI;  
using System.Web.UI.WebControls;  
  
public partial class _Default : System.Web.UI.Page  
{  
    protected void Page_Load(object sender, EventArgs e)  
    {  
        EmployeeDBDataContext db1 = new EmployeeDBDataContext();  
  
        var result = from ed in db.EmployeeDetails  
  
  
  
                     select new  
  
                     {  
  
                         EmployeeName = ed.EmpName,  
  
                         Location = ed.Location,  
  
                         Gender = ed.Gender  
  
                     };  
  
        gvDetails.DataSource = result;  
  
        gvDetails.DataBind();  
  
    }  
}  