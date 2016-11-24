using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Salvator
{
    public static class SalveazaEvidenta
    {
        public static int countCopiate = 0;
        public static int countDeCopiat = 0;
        public static int countNecopiate = 0;
        public static List<VarGlobal.ScanareLocala> copiate = new List<VarGlobal.ScanareLocala>();
        public static List<VarGlobal.ScanareLocala> necopiate = new List<VarGlobal.ScanareLocala>();

        public static List<VarGlobal.ScanareLocala> listaScanareLocala = new List<VarGlobal.ScanareLocala>();

        /// <summary>
        /// Populeaza variabila 'listaScanareLocala' cu informatiile despre fisiere gasite in directorul din variabila 'caleScanareLocala'
        /// </summary>
        /// <param name="_caleScanareLocala"></param>
        private static void PopuleazaListaScanareLocala(string _caleScanareLocala)
        {
            DirectoryInfo diLocal = new DirectoryInfo(_caleScanareLocala);
            if (diLocal != null)
            {
                //citesc fisiere din director
                var fisiereLocale = diLocal.GetFiles();
                if (fisiereLocale.Count() > 0)
                {
                    foreach (var fisierLocal in fisiereLocale)
                    {
                        listaScanareLocala.Add(new VarGlobal.ScanareLocala() { CaleFisier = fisierLocal.FullName, UltimaModificare = fisierLocal.LastWriteTime });
                    }
                }

                //citesc subdirectoare
                var subdirectoareLocale = diLocal.GetDirectories();
                if (subdirectoareLocale.Count() > 0)
                {
                    foreach (var subdirectorLocal in subdirectoareLocale)
                    {
                        PopuleazaListaScanareLocala(subdirectorLocal.FullName);
                    }
                }
            }
        }

        /// <summary>
        /// Scrie in fisierul 'fisierUltimaCopieRecursiva' informatiile despre fisierele de copiat pe FTP
        /// </summary>
        /// <param name="_copiatePeFTP"></param>
        private static void ScrieBin(List<VarGlobal.ScanareLocala> _copiatePeFTP)
        {
            using (Stream s = File.Open(VarGlobal.fisierUltimaCopieRecursiva, FileMode.Create))
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bin.Serialize(s, _copiatePeFTP);
            }
        }

        /// <summary>
        /// Citeste din fisierul de la calea 'caleSalvareScanare' lista cu informatiile despre fisiere copiate
        /// </summary>
        /// <returns></returns>
        private static List<VarGlobal.ScanareLocala> CitesteBin()
        {
            List<VarGlobal.ScanareLocala> rezultatListaBin = new List<VarGlobal.ScanareLocala>();
            try
            {
                using (Stream s = File.Open(VarGlobal.fisierUltimaCopieRecursiva, FileMode.Open))
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bin = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    rezultatListaBin = (List<VarGlobal.ScanareLocala>)bin.Deserialize(s);
                }
            }
            catch (FileNotFoundException ex)
            {
            }
            return rezultatListaBin;
        }

        /// <summary>
        /// Returneaza fisierele diferite dintre ce a fost salvat in fisierul bin(copiat pe FTP) si lista fisierelor locale curente, rezultand lista ce trebuie copiata pe FTP.
        /// </summary>
        /// <param name="_listaBin"></param>
        /// <param name="_listaDir"></param>
        /// <returns></returns>
        private static List<VarGlobal.ScanareLocala> DiferenteBinDir(List<VarGlobal.ScanareLocala> _listaBin, List<VarGlobal.ScanareLocala> _listaDir)
        {
            List<VarGlobal.ScanareLocala> rezultatFisiereDeCopiat = new List<VarGlobal.ScanareLocala>();
            foreach (var infoFisierDir in _listaDir)
            {
                var dinBin = _listaBin.Where(f => f.CaleFisier == infoFisierDir.CaleFisier).FirstOrDefault();
                if (dinBin != null)
                {
                    if (infoFisierDir.UltimaModificare != dinBin.UltimaModificare)
                    {
                        rezultatFisiereDeCopiat.Add(infoFisierDir);
                    }
                }
                else
                {
                    rezultatFisiereDeCopiat.Add(infoFisierDir);
                }
            }
            return rezultatFisiereDeCopiat;
        }

        public static void InitializareListaScanareLocala()
        {
            listaScanareLocala.Clear();
            PopuleazaListaScanareLocala(VarGlobal.caleLocalaRecursiva);
        }

        public static void SalveazaDiferentePeFTP()
        {
            copiate.Clear();
            necopiate.Clear();

            var listaBin = CitesteBin();
            var listaDiferente = DiferenteBinDir(listaBin, listaScanareLocala);
            countDeCopiat = listaDiferente.Count;
            foreach (var fisierDiferit in listaDiferente)
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Credentials = new NetworkCredential(VarGlobal.userFTP, VarGlobal.passFTP);
                        string fisierLocal = fisierDiferit.CaleFisier.Remove(0, VarGlobal.caleLocalaRecursiva.Count()).Replace("\\", "/");
                        string caleCopiereFTP = VarGlobal.caleFTPRecursiva + fisierLocal;
                        client.UploadFile(caleCopiereFTP, "STOR", fisierDiferit.CaleFisier);
                        copiate.Add(fisierDiferit);
                        countCopiate = copiate.Count;
                    }
                }
                catch (Exception ex)
                {
                    necopiate.Add(fisierDiferit);
                    countNecopiate = necopiate.Count;
                }
            }
            var listaFisiereFTP = listaScanareLocala.Except<VarGlobal.ScanareLocala>(necopiate).ToList();
            ScrieBin(listaFisiereFTP);
        }
    }
}
