using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using tcs.construct.BO;
using tcs.construct.DAL;

namespace tcs.construct.BLL
{
  public  class Doctor_BLL
    {
        DocorBLL objDoctorDAL = new DocorBLL();




        public DataSet getUserDetails(User objuser)
        {
            try
            {
                return objDoctorDAL.getUserDetails(objuser);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataSet ViewDoctorDetails(int Id)
        {
            try
            {
                return objDoctorDAL.ViewDoctorDetails(Id);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public int AddUpdateDoctorDetails(Doctor objDoctor)
        {
            try
            {
                return objDoctorDAL.AddUpdateDoctorDetails(objDoctor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int DeleteDoctorDetails(int id)
        {
            try
            {
                return objDoctorDAL.DeleteDoctorDetails(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
