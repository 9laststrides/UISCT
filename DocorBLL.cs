using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using tcs.construct.BO;
namespace tcs.construct.DAL
{
    public class DocorBLL
    {
        string cnnString;
        SqlConnection cnn = null;
        SqlCommand cmd = null;

        void Connection()
        {
            try
            {
                cnnString = ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString;
                cnn = new SqlConnection(cnnString);
                cmd = new SqlCommand();
                cmd.Connection = cnn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public DataSet getUserDetails(User objuser)
        {
            try
            {
                Connection();
                cmd.CommandText = "usp_Select_UserDetails_1193280";
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds=new DataSet();
                cmd.Parameters.AddWithValue("@UserName", objuser.UserName);
                cmd.Parameters.AddWithValue("@Password", objuser.Password);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                cnn.Close();
                return ds;

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
                Connection();
                cmd.CommandText = "usp_SearchSelect_DoctorDetails_1193280";
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                cmd.Parameters.AddWithValue("@DoctorId",Id);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                cnn.Close();
                return ds;

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
                Connection();
                cmd.CommandText = "usp_InsertUpdate_DoctorDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_DoctorId", objDoctor.DoctorId);
                cmd.Parameters.AddWithValue("@DoctorName", objDoctor.DoctorName);
                cmd.Parameters.AddWithValue("@Department", objDoctor.DoctorDepartment);

              
                SqlParameter doctId = new SqlParameter("@DoctorId", SqlDbType.Int);
                doctId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(doctId);
                cnn.Open();
                int AddResult = cmd.ExecuteNonQuery();
                cnn.Close();
                if (AddResult > 0)
                {
                    return Convert.ToInt32( doctId.Value);
                }
                else
                {
                    return -1;
                }


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
                Connection();
                cmd.CommandText = "usp_delete_DoctorDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PK_DoctorId", id);
                
                cnn.Open();
                int deleteResult = cmd.ExecuteNonQuery();
                cnn.Close();
                if (deleteResult > 0)
                {
                    return deleteResult;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
