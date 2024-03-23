using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanAccess : DatabaseAccess
    {
        public string CheckLogic(TaiKhoan taiKhoan)
        {
            string info = CheckLogicDTO(taiKhoan);
            Console.WriteLine(info);
            return info;
        }
        public bool CheckRegisterExist(TaiKhoan taiKhoan)
        {
            bool info = CheckRegisterExistDTO(taiKhoan);
            return info;
        }
        public bool CheckRegister(TaiKhoan taiKhoan)
        {
            bool info = CheckRegisterDTO(taiKhoan);
            return info;
        }

        public bool CheckAddStaff(TaiKhoan taiKhoan)
        {
            bool info = AddStaffDTO(taiKhoan);
            return info;
        }

        public bool CheckUpdateStaff(TaiKhoan taiKhoan)
        {
            bool info = UpdateStaffDTO(taiKhoan);
            return info;
        }

        public bool CheckDeleteStaff(TaiKhoan taiKhoan)
        {
            bool info = DeleteStaffDTO(taiKhoan);
            return info;
        }
        /*public bool CheckAddStaff(TaiKhoan taiKhoan)
        {
            bool info = CheckAddStaffDTO(taiKhoan);
            return info;
        }*/
    }
}
