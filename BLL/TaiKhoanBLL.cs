using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogic(TaiKhoan taiKhoan)
        {
            // kiem tra nghiep vu
            if (taiKhoan.sTaiKhoan == "")
            {
                return "requeid_taikhoan";
            }
            if (taiKhoan.sMatKhau == "")
            {
                return "requeid_matkhau";
            }
            if (taiKhoan.sEmail == "")
            {
                return "requeid_email";
            }
            string info = tkAccess.CheckLogic(taiKhoan);
            return info;
        }



        public string checkRegisterExist(TaiKhoan taiKhoan)
        {
            if (taiKhoan.sTaiKhoan == "")
            {
                return "requeid_taikhoan";
            }
            if (taiKhoan.sMatKhau == "")
            {
                return "requeid_matkhau";
            }
            if (taiKhoan.sEmail == "")
            {
                return "requeid_email";
            }
            if (tkAccess.CheckRegisterExist(taiKhoan))
            {
                return "email_exist";
            }
            return "email_not_exist";
        }
        public bool checkRegister(TaiKhoan taiKhoan)
        {
            if (tkAccess.CheckRegister(taiKhoan))
            {
                return true;
            }
            return false;
        }

        public bool CheckAddStaff(TaiKhoan taiKhoan)
        {
            if (tkAccess.CheckAddStaff(taiKhoan))
            {
                return true;
            }
            return false;
        }

        public bool CheckUpdateStaff(TaiKhoan taiKhoan)
        {
            if (tkAccess.CheckUpdateStaff(taiKhoan))
            {
                return true;
            }
            return false;
        }

        public bool CheckDeleteStaff(TaiKhoan taiKhoan)
        {
            if (tkAccess.CheckDeleteStaff(taiKhoan))
            {
                return true;
            }
            return false;
        }

    }
}
