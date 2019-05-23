﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// Summary description for EncryptDecrypt
/// </summary>
namespace CRM_Repository.DataServices
{
    public class EncryptDecrypt
    {
        public EncryptDecrypt()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //Define the tripple Des Provider
        public TripleDESCryptoServiceProvider m_des = new TripleDESCryptoServiceProvider();
        //Define the string Handler
        public UTF8Encoding m_utf8 = new UTF8Encoding();
        //Define the local Propertirs Array
        public byte[] m_key = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 13, 15, 16, 17, 18, 19, 20, 21, 22, 24, 23 };
        public byte[] m_iv = { 8, 7, 6, 5, 4, 3, 2, 1 };

        public byte[] Encypt(byte[] input)
        {
            return Transform(input, m_des.CreateEncryptor(m_key, m_iv));
        }
        public byte[] Decrypt(byte[] input)
        {
            return Transform(input, m_des.CreateDecryptor(m_key, m_iv));
        }
        public string Encypt(string text)
        {
            byte[] input = m_utf8.GetBytes(text);
            byte[] output = Transform(input, m_des.CreateEncryptor(m_key, m_iv));
            return Convert.ToBase64String(output);
        }
        public string Decrypt(string text)
        {
            byte[] input = Convert.FromBase64String(text);
            byte[] output = Transform(input, m_des.CreateDecryptor(m_key, m_iv));
            return m_utf8.GetString(output);
        }

        private byte[] Transform(byte[] input, ICryptoTransform cryptoTransform)
        {
            //Create the Neccessary streams
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, cryptoTransform, CryptoStreamMode.Write);
            //transform the bytes as requested
            cryptoStream.Write(input, 0, input.Length);
            cryptoStream.FlushFinalBlock();
            //Reasd the memory stream and convert it to byte array
            memStream.Position = 0;
            byte[] result = new byte[Convert.ToInt32(memStream.Length - 1) + 1];
            memStream.Read(result, 0, Convert.ToInt32(result.Length));
            memStream.Close();
            cryptoStream.Close();
            return result;
        }
    }
}