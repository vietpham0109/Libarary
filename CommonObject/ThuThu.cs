﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class ThuThu
    {
        private string maTT;

        public string MaTT
        {
            get { return maTT; }
            set { maTT = value; }
        }
        private string tenTT;

        public string TenTT
        {
            get { return tenTT; }
            set { tenTT = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string SDT;

        public string SDT1
        {
            get { return SDT; }
            set { SDT = value; }
        }
        private string capBac;

        public string CapBac
        {
            get { return capBac; }
            set { capBac = value; }
        }
    }
}
