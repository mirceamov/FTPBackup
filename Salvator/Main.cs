using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salvator
{
    public partial class Main : Form
    {
        #region functii

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedura seteaza statusul ultimelor copieri
        /// </summary>
        private void UpdateUltimaCopiere()
        {
            FileInfo fiRecursiv = new FileInfo(VarGlobal.fisierUltimaCopieRecursiva);
            if (!fiRecursiv.Exists) lblUltimaEvidenta.Text = "Ultima actualizarea a evidentei:" + Environment.NewLine + "N/A";
            else lblUltimaEvidenta.Text = "Ultima actualizarea a evidentei:" + Environment.NewLine + fiRecursiv.LastWriteTime.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine + lblStatusCopiereEvidenta.Text;

            FileInfo fiAbsolut = new FileInfo(VarGlobal.fisierUltimaCopieAbsoluta);
            if (!fiAbsolut.Exists) lblUltimeleAbsolute.Text = "Ultima salvare fisiere diverse:" + Environment.NewLine + "N/A";
            else lblUltimeleAbsolute.Text = "Ultima salvare fisiere diverse:" + Environment.NewLine + fiAbsolut.LastWriteTime.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine + lblStatusCopiereAbsolut.Text;
        }

        /// <summary>
        /// Functia returneaza TRUE daca se poate realiza conexiunea catre calea FTP din parametru
        /// </summary>
        /// <param name="_caleFTP"></param>
        /// <returns></returns>
        private bool VerificaFTP(string _caleFTP)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_caleFTP);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Timeout = 5000;
                request.Credentials = new NetworkCredential(VarGlobal.userFTP, VarGlobal.passFTP);
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Directorul '" + txtCaleFTPAbsoluta.Text + "' accesibil.");
                    return true;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        MessageBox.Show("Directorul '"+txtCaleFTPAbsoluta.Text+"' este invalid.");
                        return false;
                    }
                }
                MessageBox.Show("Eroare conectare FTP: " + ex.Message);
                return false;
            } 
        }

        /// <summary>
        /// Procedura returneaza TRUE daca datele introduse in optiuni sunt valide
        /// </summary>
        /// <returns></returns>
        private bool ValideazaOptiuni()
        {
            if(cbOreCopiere.Items.Count == 0)
            {
                MessageBox.Show("Nu este setata nici o ora pentru copierea datelor.");
                nudOraCopiere.Focus();
                return false;
            }

            if(txtCaleLocalaRecursiva.Text.Trim() == "" || !(new DirectoryInfo(txtCaleLocalaRecursiva.Text).Exists))
            {
                MessageBox.Show("Calea locala recursiva este necompletata sau nu este un director valid.");
                txtCaleLocalaRecursiva.Focus();
                return false;
            }

            if(txtCaleFTPRecursiva.Text.Trim() == "")
            {
                MessageBox.Show("Calea FTP recursiva este necompletata.");
                txtCaleFTPRecursiva.Focus();
                return false;
            }
           
            if(txtCaleLocalaAbsoluta.Text.Trim() == "" || !(new DirectoryInfo(txtCaleLocalaAbsoluta.Text).Exists))
            {
                MessageBox.Show("Calea locala absoluta este necompletata sau nu este un director valid.");
                txtCaleLocalaAbsoluta.Focus();
                return false;
            }

            if(txtCaleFTPAbsoluta.Text.Trim() == "")
            {
                MessageBox.Show("Calea FTP absoluta este necompletata.");
                txtCaleFTPAbsoluta.Focus();
                return false;
            }

            if(txtListaFisiereAbsolute.Text.Trim() == "")
            {
                MessageBox.Show("Caile catre fisierele absolute sunt necompletate.");
                txtListaFisiereAbsolute.Focus();
            }

            foreach(var fisierAbsolut in txtListaFisiereAbsolute.Text.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                string caleFA = txtCaleLocalaAbsoluta.Text + fisierAbsolut;
                if(!(new FileInfo(caleFA).Exists))
                {
                    MessageBox.Show("Fisierul local absolut "+caleFA+" nu este valid.");
                    txtCaleLocalaAbsoluta.Focus();
                    return false;
                }
            }

            if (txtAdreseMailErori.Text.Trim() == "")
            {
                MessageBox.Show("Adrese mail erori necompletate.");
                txtListaFisiereAbsolute.Focus();
            }

            return true;
        }

        /// <summary>
        /// Procedura incarca valorile din fisierul de configurari (daca exista) in variabilele globale
        /// </summary>
        private void CitesteOptiuniDinFisier()
        {
            if(File.Exists(VarGlobal.fisierConfig)) //citeste din fisier
            {
                VarGlobal.listaFisiereAbsolute.Clear();
                VarGlobal.listaOreCopiere.Clear();
                foreach (var rand in File.ReadAllLines(VarGlobal.fisierConfig))
                {
                    switch (rand.Substring(0, rand.IndexOf('>')))
                    {
                        case "oreCopiere": VarGlobal.listaOreCopiere.AddRange(rand.Substring(rand.IndexOf('>') + 1).Split(',').Select(s=>int.Parse(s)));
                            break;                        
                        case "caleLocalaRecursiva": VarGlobal.caleLocalaRecursiva = rand.Substring(rand.IndexOf('>') + 1);
                            break;
                        case "caleFTPRecursiva": VarGlobal.caleFTPRecursiva = rand.Substring(rand.IndexOf('>') + 1);
                            break;
                        case "caleLocalaAbsoluta": VarGlobal.caleLocalaAbsoluta = rand.Substring(rand.IndexOf('>') + 1);
                            break;
                        case "caleFTPAbsoluta": VarGlobal.caleFTPAbsoluta = rand.Substring(rand.IndexOf('>') + 1);
                            break;
                        case "listaFisiereAbsolute": VarGlobal.listaFisiereAbsolute.Add(rand.Substring(rand.IndexOf('>') + 1));
                            break;
                        case "adreseMailErori": VarGlobal.adreseMailErori = rand.Substring(rand.IndexOf('>') + 1);
                            break;
                        default:
                            break;
                    }
                }
            }            
        }

        /// <summary>
        /// Procedura populeaza controalele din optiuni cu valorile existente in variabilele globale
        /// </summary>
        private void PopuleazaOptiuni()
        {
            cbOreCopiere.Items.Clear();
            foreach (var ora in VarGlobal.listaOreCopiere)
            {
                cbOreCopiere.Items.Add(ora);
            }
            txtCaleLocalaRecursiva.Text = VarGlobal.caleLocalaRecursiva;
            txtCaleFTPRecursiva.Text = VarGlobal.caleFTPRecursiva;
            txtCaleLocalaAbsoluta.Text = VarGlobal.caleLocalaAbsoluta;
            txtCaleFTPAbsoluta.Text = VarGlobal.caleFTPAbsoluta;
            txtListaFisiereAbsolute.Text = String.Join(Environment.NewLine, VarGlobal.listaFisiereAbsolute);
            txtAdreseMailErori.Text = VarGlobal.adreseMailErori;
        }

        /// <summary>
        /// Procedura salveaza in fisierul de configurare informatiile din controale
        /// </summary>
        /// <returns></returns>
        private bool SalveazaOptiuniInFisier()
        {
            try
            {
                if (ValideazaOptiuni())
                {
                    StringBuilder sbOptiuni = new StringBuilder();
                    sbOptiuni.Append("oreCopiere>");
                    foreach (var item in cbOreCopiere.Items)
                    {
                        sbOptiuni.Append(item.ToString() + ",");
                    }
                    sbOptiuni.Remove(sbOptiuni.Length - 1, 1);
                    sbOptiuni.AppendLine("");
                    sbOptiuni.AppendLine("caleLocalaRecursiva>" + txtCaleLocalaRecursiva.Text.Trim());
                    sbOptiuni.AppendLine("caleFTPRecursiva>" + txtCaleFTPRecursiva.Text.Trim());
                    sbOptiuni.AppendLine("caleLocalaAbsoluta>" + txtCaleLocalaAbsoluta.Text.Trim());
                    sbOptiuni.AppendLine("caleFTPAbsoluta>" + txtCaleFTPAbsoluta.Text.Trim());
                    foreach (var rand in txtListaFisiereAbsolute.Text.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        sbOptiuni.AppendLine("listaFisiereAbsolute>" + rand.Trim());
                    }
                    sbOptiuni.AppendLine("adreseMailErori>" + txtAdreseMailErori.Text.Trim());
                    
                    File.WriteAllText(VarGlobal.fisierConfig, sbOptiuni.ToString());
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void StartCopiereLaOra()
        {
            int oraCurenta = DateTime.Now.Hour;
            if (VarGlobal.listaOreCopiere.Where(ora => ora == oraCurenta).Any())
            {
                btnCopiazaAbsolut_Click(null, null);
                btnCopiazaEvidenta_Click(null, null);
            }
        }

        #endregion

        #region actiuni

        private void Main_Shown(object sender, EventArgs e)
        {
            UpdateUltimaCopiere();
            CitesteOptiuniDinFisier();
            StartCopiereLaOra();
            timerOraCopiere.Enabled = true;            
        }

        private void btnCopiazaEvidenta_Click(object sender, EventArgs e)
        {
            ((Control)this.tabOptiuni).Enabled = false;
            timerStatusCopiereFTP.Enabled = true;
            SalveazaEvidenta.InitializareListaScanareLocala();
            btnCopiazaEvidenta.Enabled = false;
            SalveazaEvidenta.countCopiate = 0;
            SalveazaEvidenta.countDeCopiat = 0;
            SalveazaEvidenta.countNecopiate = 0;
            bgwCopiazaEvidenta.RunWorkerAsync();
        }

        private void btnCopiazaAbsolut_Click(object sender, EventArgs e)
        {
            ((Control)this.tabOptiuni).Enabled = false;
            timerStatusCopiereFTP.Enabled = true;            
            btnCopiazaAbsolut.Enabled = false;
            SalveazaCaleAbsoluta.countCopiate = 0;
            SalveazaCaleAbsoluta.countDeCopiat = 0;
            SalveazaCaleAbsoluta.countNecopiate = 0;
            bgwCopiazaAbsolut.RunWorkerAsync();
        }

        private void bgwCopiazaEvidenta_DoWork(object sender, DoWorkEventArgs e)
        {
            SalveazaEvidenta.SalveazaDiferentePeFTP();
        }

        private void bgwCopiazaAbsolut_DoWork(object sender, DoWorkEventArgs e)
        {
            SalveazaCaleAbsoluta.SalveazaPeFTP();
        }

        private void bgwCopiazaEvidenta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerStatusCopiereFTP_Tick(null, null);            
            btnCopiazaEvidenta.Enabled = true;
            UpdateUltimaCopiere();      
            functiiUtile.ScrieLog(DateTime.Now.ToString() + " - " + lblStatusCopiereEvidenta.Text, VarGlobal.fisierLogRecursiv);
            if (SalveazaEvidenta.countNecopiate > 0)
            {
                string subiect = "Salvator - " + VarGlobal.caleFTPRecursiva;
                StringBuilder sbBody = new StringBuilder();
                sbBody.AppendLine("Eroare la copiere evidenta:");
                sbBody.AppendLine("Fisiere necopiate:" + SalveazaEvidenta.countNecopiate);
                foreach(var fisierNecopiat in SalveazaEvidenta.necopiate)
                {
                    sbBody.AppendLine(fisierNecopiat.CaleFisier);
                }                
                functiiUtile.TrimiteEmail(subiect, sbBody.ToString());
            }
            notifyIcon.BalloonTipText = "Actualizarea fisierelor de evidenta a fost finalizata.";
            notifyIcon.ShowBalloonTip(2000);
            
            if(!bgwCopiazaAbsolut.IsBusy && !bgwCopiazaEvidenta.IsBusy)
            {
                timerStatusCopiereFTP.Enabled = false;
                ((Control)this.tabOptiuni).Enabled = true;            
            }      
        }

        private void bgwCopiazaAbsolut_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerStatusCopiereFTP_Tick(null, null);                
            btnCopiazaAbsolut.Enabled = true;
            UpdateUltimaCopiere(); 
            functiiUtile.ScrieLog(DateTime.Now.ToString() + " - " + lblStatusCopiereAbsolut.Text, VarGlobal.fisierLogAbsolut);
            if (SalveazaCaleAbsoluta.countNecopiate > 0)
            {
                string subiect = "Salvator - " + VarGlobal.caleFTPAbsoluta;
                StringBuilder sbBody = new StringBuilder();
                sbBody.AppendLine("Eroare la copiere fisiere diverse (produse, retete, etc.):");
                sbBody.AppendLine("Fisiere necopiate:" + SalveazaCaleAbsoluta.countNecopiate);
                foreach (var fisierNecopiat in SalveazaCaleAbsoluta.necopiate)
                {
                    sbBody.AppendLine(fisierNecopiat);
                }
                functiiUtile.TrimiteEmail(subiect, sbBody.ToString());
            }
            notifyIcon.BalloonTipText = "Salvarea fisierelor diverse (produse, facturi, retete, etc) a fost finalizata.";
            notifyIcon.ShowBalloonTip(2000);

            if (!bgwCopiazaAbsolut.IsBusy && !bgwCopiazaEvidenta.IsBusy)
            {
                timerStatusCopiereFTP.Enabled = false;
                ((Control)this.tabOptiuni).Enabled = true;            
            }                       
        }

        private void timerStatusCopiereFTP_Tick(object sender, EventArgs e)
        {
            lblStatusCopiereEvidenta.Text = SalveazaEvidenta.countCopiate + " din " + SalveazaEvidenta.countDeCopiat + " (necopiate = " + SalveazaEvidenta.countNecopiate + ")";
            lblStatusCopiereAbsolut.Text = SalveazaCaleAbsoluta.countCopiate + " din " + SalveazaCaleAbsoluta.countDeCopiat + " (necopiate = " + SalveazaCaleAbsoluta.countNecopiate + ")";

            if(bgwCopiazaAbsolut.IsBusy)
                lblUltimeleAbsolute.Text = "Copiere fisiere in progres..." + Environment.NewLine + SalveazaCaleAbsoluta.countCopiate + " din " + SalveazaCaleAbsoluta.countDeCopiat + " (necopiate = " + SalveazaCaleAbsoluta.countNecopiate + ")";
            if(bgwCopiazaEvidenta.IsBusy) 
                lblUltimaEvidenta.Text = "Copiere EVIDENTA in progres..." + Environment.NewLine + SalveazaEvidenta.countCopiate + " din " + SalveazaEvidenta.countDeCopiat + " (necopiate = " + SalveazaEvidenta.countNecopiate + ")";
        }

        private void btnCreeazaDirectoareFTP_Click(object sender, EventArgs e)
        {
            foreach(var dirFTP in VarGlobal.listaDirectoareAbsoluteFTP)
            {
                functiiUtile.CreeazaDirectorFTP(VarGlobal.caleFTPAbsoluta + dirFTP);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "salvator")
            {
                txtLogin.Text = "";
                gbLogin.Visible = false;
                tabControlMain.Visible = true;
                PopuleazaOptiuni();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            gbLogin.Visible = true;
            tabControlMain.Visible = false;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnCaleLocalaRecursiva_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (txtCaleLocalaRecursiva.Text != "" && new DirectoryInfo(txtCaleLocalaRecursiva.Text).Exists)
            {
                fbd.SelectedPath = txtCaleLocalaRecursiva.Text;
            }

            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCaleLocalaRecursiva.Text = fbd.SelectedPath;
            }
        }

        private void btnCaleLocalaAbsoluta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (txtCaleLocalaAbsoluta.Text != "" && new DirectoryInfo(txtCaleLocalaAbsoluta.Text).Exists)
            {
                fbd.SelectedPath = txtCaleLocalaAbsoluta.Text;
            }

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCaleLocalaAbsoluta.Text = fbd.SelectedPath;
            }
        }

        private void btnLogoutActiuni_Click(object sender, EventArgs e)
        {
            gbLogin.Visible = true;
            tabControlMain.Visible = false;
        }

        private void btnLogoutOptiuni_Click(object sender, EventArgs e)
        {
            gbLogin.Visible = true;
            tabControlMain.Visible = false;
        }

        private void btnAdaugaOra_Click(object sender, EventArgs e)
        {
            int oraNoua = int.Parse(nudOraCopiere.Value.ToString());
            if(cbOreCopiere.Items.Contains(oraNoua)) return;

            cbOreCopiere.Items.Add(oraNoua);
        }

        private void btnStergeOra_Click(object sender, EventArgs e)
        {
            if (cbOreCopiere.SelectedItem != null) cbOreCopiere.Items.Remove(cbOreCopiere.SelectedItem);
            if (cbOreCopiere.Items.Count == 0) cbOreCopiere.Text = "";
        }

        private void btnSalvareOptiuni_Click(object sender, EventArgs e)
        {
            if (SalveazaOptiuniInFisier())
            {
                MessageBox.Show("Salvare optiuni cu succes.");
                CitesteOptiuniDinFisier();
            }
        }
        
        private void btnIpExtern_Click(object sender, EventArgs e)
        {
            WebRequest req = HttpWebRequest.Create(@"https://www.google.ro/search?hl=en&safe=off&q=what+is+my+ip&ei=ZSaDVvmTKKPmyQP3qqX4CA");
            WebResponse res = req.GetResponse();
            StreamReader sr = new StreamReader(res.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            var match = Regex.Match(response, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            btnIpExtern.Text = "IP Extern = " + match.Value;
        }

        private void btnVerificareFTPAbsolut_Click(object sender, EventArgs e)
        {
            VerificaFTP(txtCaleFTPAbsoluta.Text);
        }

        private void timerOraCopiere_Tick(object sender, EventArgs e)
        {
            StartCopiereLaOra();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.BalloonTipText = "Aplicatia ruleaza pe fundal...";
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        #endregion



    } 
}
