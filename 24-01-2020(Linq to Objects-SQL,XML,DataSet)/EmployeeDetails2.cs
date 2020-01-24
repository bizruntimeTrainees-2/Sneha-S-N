using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
using System.Web.UI;  
using System.Web.UI.WebControls;  
  
public partial class _Default : System.Web.UI.Page  
{  
    private object db;  
  
    protected void Page_Load(object sender, EventArgs e)  
    {  
        var result = from ed in db.Employeedetail  
  
                     join d in db.Department on ed.DeptId equals d.DeptId  
  
                     where d.DeptName.Equals("software")  
  
                     select new  
  
                     {  
  
                         Name = ed.EmpName,  
  
                         Location = ed.Location,  
  
                         Gender = ed.Gender,  
  
                         Department = d.DeptName  
  
                     };  
  
        gvDetails.DataSource = result;  
  
        gvDetails.DataBind();  
  
    }  
}  