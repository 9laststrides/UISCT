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
    public partial class AddDoctorDetails : System.Web.UI.Page
    {
        Doctor_BLL objDoctorBLL = new Doctor_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //session is common to all pages..
                //viewstate is for the current page only
                if (Session["userName"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {

                    if (Session["DoctorID"] != null)
                    {
                        ViewState["DoctorID"] = Session["DoctorID"];
                        Session.Remove("DoctorID");
                        BindDetailsByID(Convert.ToInt32(ViewState["DoctorID"]));
                    }
                }
            }
        }

        private void BindDetailsByID(int Id)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = objDoctorBLL.ViewDoctorDetails(Id);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDoctorName.Text = Convert.ToString(ds.Tables[0].Rows[0]["DoctorName"]);
                    txtDoctorDepartment.Text = Convert.ToString(ds.Tables[0].Rows[0]["Department"]);
                }
            }
            catch (Exception ex)
            {

                Console.Write("<script>alert(" + ex.Message + ")</script>");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor objDoctor = new Doctor();
                if (ViewState["DoctorID"] != null)
                {
                    objDoctor.DoctorId = Convert.ToInt32(ViewState["DoctorID"]);
                }
                else
                {
                    objDoctor.DoctorId = 0;
                }
                objDoctor.DoctorName = txtDoctorName.Text;
                objDoctor.DoctorDepartment = txtDoctorDepartment.Text;
                int addResult = objDoctorBLL.AddUpdateDoctorDetails(objDoctor);
                if (addResult > 0)
                {
                    Response.Redirect("ViewDoctorDetails.aspx");
                }
            }
            catch (Exception ex)
            {

                Console.Write("<script>alert(" + ex.Message + ")</script>");
            }

        }
    }
}