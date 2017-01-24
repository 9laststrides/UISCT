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
    public partial class ViewDoctorDetails : System.Web.UI.Page
    {
        Doctor_BLL objDoctorBLL = new Doctor_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    bindDoctorDetails();
                }
            }
        }

        private void bindDoctorDetails()
        {
            try
            {
                grvDoctorDetails.DataSource = objDoctorBLL.ViewDoctorDetails(0);
                grvDoctorDetails.DataBind();
                

            }
            catch (Exception ex)
            {
                
                 Console.Write("<script>alert("+ ex.Message + ")</script>");
            }
        }

        protected void grvDoctorDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdEdit")
            {
                Session["doctorID"] = e.CommandArgument;
                Response.Redirect("AddDoctorDetails.aspx");
            }
            if (e.CommandName == "cmdDelete")
            {
                try
                {
                    int delResult = objDoctorBLL.DeleteDoctorDetails(Convert.ToInt32(e.CommandArgument));
                    if (delResult > 0) 
                    {
                        bindDoctorDetails();
                    }
                }
                catch (Exception ex)
                {
                    
                Console.Write("<script>alert("+ ex.Message + ")</script>");
                }
            }
        }

        protected void grvDoctorDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

    }
}