﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.IO;
using System.Security.Cryptography;

namespace BUS
{
    public class clsNhanVien_BUS
    {
        public clsNhanVienDangNhap LayThongTinNhanVien(string strTenDN)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.LayThongTinNhanVien(strTenDN);
        }

        public bool KiemTraDangNhap(string strTenDN, string strMK)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.KiemTraDangNhap(strTenDN, strMK);
        }

        // Khi thêm nhân viên thì Mã hóa mật khẩu MD5
        public bool ThemNhanVien(DTO.clsNhanVien_DTO nv)
        {
            clsNhanVien_DAO dao = new clsNhanVien_DAO();
            return dao.ThemNhanVien(nv);
        }

        //Đã viết 1 hàm đếm trong 1 table với tham số truyền vào là TABLE và SQLconnection. Ở Class ThaoTacDuLieu. Để khỏi mất thời gian khi viết câu truy vấn.
        //public int DemNhanVien()
        //{
        //    clsNhanVien_DAO dao = new clsNhanVien_DAO();
        //    int soLuongNhanVien = dao.DemNhanVien();
        //    return soLuongNhanVien;
        //}

        // Lấy danh sách nhân viên theo phòng
        public List<clsNhanVien_DTO> LayDanhSachNhanVien(List<clsPhongBan_DTO> lsPhongBan)
        {
            clsNhanVien_DAO DAO = new clsNhanVien_DAO();
            return DAO.LayDanhSachNhanVien(lsPhongBan);
        }
        
        // Mã hóa mật khẩu
        private string MaHoaMD5(string MatKhau)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(MatKhau);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    MatKhau = Convert.ToBase64String(ms.ToArray());
                }
            }
            return MatKhau;
        }

        // Giải mã khẩu MD5
        private string GiaiMaMD5(string MatKhau)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(MatKhau);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    MatKhau = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return MatKhau;
        }
    }
}
