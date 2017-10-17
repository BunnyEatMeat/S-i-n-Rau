using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caffe_Manager_software
{
    class KhachHang
    {
        protected int maKH;
        protected string tenKH;
        protected string sdtKH;
        protected int soLyDaUong;

        public KhachHang()
        {
            maKH = 0;
            tenKH = null;
            sdtKH = null;
            soLyDaUong = 0;
        }

        public KhachHang(int maKhachHang, string tenKhachHang, string soDienThoai, int soLy)
        {
            this.maKH = maKhachHang;
            this.tenKH = tenKhachHang;
            this.sdtKH = soDienThoai;
            this.soLyDaUong = soLy;
        }

        ~KhachHang() { }
    }
}
