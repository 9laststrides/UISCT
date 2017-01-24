using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcs.construct.BO;
using tcs.construct.BLL;
using System.Data;

namespace tcs.construct.UI
{
    public partial class Login : System.Web.UI.Page
    {
        Doctor_BLL objDoctorBLL = new Doctor_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User objUser = new User();
            objUser.UserName = txtUserName.Text;
            objUser.Password = txtPassword.Text;
            DataSet ds = objDoctorBLL.getUserDetails(objUser);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["userName"]=ds.Tables[0].Rows[0]["UserName"];
                Response.Redirect("AddDoctorDetails.aspx");
            }
        }
    }
}