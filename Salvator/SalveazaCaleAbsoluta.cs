using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Salvator
{
    public class SalveazaCaleAbsoluta
    {
        public static int countCopiate = 0;
        public static int countDeCopiat = 0;
        public static int countNecopiate = 0;
        public static List<string> copiate = new List<string>();
        public static List<string> necopiate = new List<string>();

        /// <summary>
        /// Scrie in fisierul 'fisierUltimaCopieAbsoluta' informatiile despre fisierele de copiat pe FTP
        /// </summary>
        /// <param name="_copiatePeFTP"></param>
        private static void ScrieBin(List<string> _copiatePeFTP)
        {
            using (Stream s = File.Open(VarGlobal.fisierUltimaCopieAbsoluta, FileMode.Create))
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bin.Serialize(s, _copiatePeFTP);
            }
        }

        public static void SalveazaPeFTP()
        {
            StringBuilder sbCaleFTP = new StringBuilder();
            StringBuilder sbCaleLocala = new StringBuilder();

            copiate.Clear();
            necopiate.Clear();

            countDeCopiat = VarGlobal.listaFisiereAbsolute.Count;
            string denumireDirFTPNou = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            foreach (var fisierCA in VarGlobal.listaFisiereAbsolute)
            {
                sbCaleFTP.Clear();
                sbCaleLocala.Clear();
                sbCaleLocala.Append(VarGlobal.caleLocalaAbsoluta + fisierCA);
                sbCaleFTP.Append(VarGlobal.caleFTPAbsoluta);
                sbCaleFTP.Append(fisierCA.Remove(fisierCA.LastIndexOf('\\')).Replace("\\", "/"));
                sbCaleFTP.Append("/" + denumireDirFTPNou);
                functiiUtile.CreeazaDirectorFTP(sbCaleFTP.ToString());
                sbCaleFTP.Append("/" + Path.GetFileName(sbCaleLocala.ToString()));
                                
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(sbCaleFTP.ToString());
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(VarGlobal.userFTP, VarGlobal.passFTP);
                    
                    Stream s = File.Open(sbCaleLocala.ToString(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    byte[] fileContents;
                    using (BinaryReader br = new BinaryReader(s))
                    {
                        fileContents = br.ReadBytes((int)s.Length);
                    }
                    s.Close();
                    request.ContentLength = fileContents.Length;

                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(fileContents, 0, fileContents.Length);
                    requestStream.Close();

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    //Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);
                    response.Close();
                    copiate.Add(fisierCA);
                    countCopiate = copiate.Count;

                    //using (WebClient client = new WebClient())
                    //{
                    //    client.Credentials = new NetworkCredential(VarGlobal.userFTP, VarGlobal.passFTP);
                    //    client.UploadFile(sbCaleFTP.ToString(), "STOR", sbCaleLocala.ToString());
                    //    copiate.Add(fisierCA);
                    //    countCopiate = copiate.Count;
                    //}
                }
                catch (Exception ex)
                {
                    necopiate.Add(fisierCA);
                    countNecopiate = necopiate.Count;
                }
            }    
            var listaFisiereAbsoluteFTP = VarGlobal.listaFisiereAbsolute.Except<string>(necopiate).ToList();
            ScrieBin(listaFisiereAbsoluteFTP);       
        }

    }
}
