using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caffe_Manager_software
{
    class NhanVien
    {
        //thong tin nhan vien
        protected int maNV;
        protected string tenNV;
        protected DateTime ngaySinhNV;
        protected string diaChi;

        //tai khoan nhan vien
        protected string userName;
        protected string passWord;

        //chuc vu cua nhan vien
        enum chucVu
        {
            NHAN_VIEN = 0,
            QUAN_LI = 1,
            ADMIN = 2,
        };
        chucVu viTri = 0;

        //constructor
        public NhanVien()
        {
            maNV = 0;
            tenNV = null;
            ngaySinhNV = Convert.ToDateTime(""); // year-month-day
            diaChi = null;

            userName = null;
            passWord = null;
            viTri = 0;
        }

        ~NhanVien() { }

        //overide

        public void xuatThongTin()
        {
            Console.WriteLine("ID:{0}| {1} NgaySinh:{2}", this.maNV, this.tenNV, this.ngaySinhNV);
            Console.WriteLine("Dia Chi: {0}", this.diaChi);
            Console.WriteLine("USERNAME:{0} | PASS:{1}", this.userName, this.passWord);
            Console.Write("{0}", this.viTri);
        }
    }
}
