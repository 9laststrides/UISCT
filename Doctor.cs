using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcs.construct.BO
{
   public class Doctor
    {
        int doctorId;
        string doctorName;
        string doctorDepartment;

        public string DoctorDepartment
        {
            get { return doctorDepartment; }
            set { doctorDepartment = value; }
        }

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }
        public int DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }
    }
}
