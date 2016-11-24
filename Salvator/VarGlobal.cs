using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvator
{
    public class VarGlobal
    {
        [Serializable]
        public class ScanareLocala
        {
            public string CaleFisier { get; set; }
            public DateTime UltimaModificare { get; set; }
        }

        public static List<int> listaOreCopiere = new List<int>() { 8 };
        public static string fisierLogRecursiv = "salvator_LogRecursiv.txt";
        public static string fisierLogAbsolut = "salvator_LogAbsolut.txt";
        public static string fisierLogGeneral = "salvator_LogGeneral.txt";
        public static string fisierConfig = "salvator_Config.txt";
        public static string fisierUltimaCopieRecursiva = "salvator_UltimaCopieRecursiva.bin"; //ultima copie fisiere recursive
        public static string fisierUltimaCopieAbsoluta = "salvator_UltimaCopieAbsoluta.bin"; //ultima copie fisiere absolute
        public static string caleLocalaRecursiva = @"D:\pharma\evidenta"; //cale locala director evidenta
        public static string caleFTPRecursiva = @"ftp://5.13.14.193/Marbo/pharma/evidenta"; //cale FTP director evidenta
        public static string userFTP = "administrator"; //utilizator FTP
        public static string passFTP = "britney10121983"; //parola FTP

        public static string caleLocalaAbsoluta = @"D:\pharma";
        public static string caleFTPAbsoluta = @"ftp://5.13.14.193/Marbo/pharma";
        
        public static List<string> listaFisiereAbsolute = new List<string>() {
            @"\data\produse.dbf",
            @"\data\produse.cdx",
            @"\data\facturi.cdx",
            @"\data\facturi.dbf",
            @"\data\facturi.fpt",
            @"\data\furnizori.cdx",
            @"\data\furnizori.dbf",
            @"\data\angajati.cdx",
            @"\data\angajati.dbf",
            @"\retete\dbf\reteta.cdx",
            @"\retete\dbf\reteta.dbf",
            @"\retete\dbf\retetap.cdx",
            @"\retete\dbf\retetap.dbf",
            @"\retete\dbf\retetape.cdx",
            @"\retete\dbf\retetape.dbf"
        };

        public static List<string> listaDirectoareAbsoluteFTP = new List<string>() {
            @"/data",
            @"/retete",
            @"/retete/dbf",
            @"/evidenta",
            @"/evidenta/baza",
            @"/evidenta/doc",
            @"/evidenta/doc2009",
            @"/evidenta/ev",
            @"/evidenta/facturi",
            @"/evidenta/in"
        };

        public static string adreseMailErori = "mirceamov@gmail.com";

    }
}
