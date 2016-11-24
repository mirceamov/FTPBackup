namespace Salvator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnCopiazaEvidenta = new System.Windows.Forms.Button();
            this.lblStatusCopiereEvidenta = new System.Windows.Forms.Label();
            this.timerStatusCopiereFTP = new System.Windows.Forms.Timer(this.components);
            this.bgwCopiazaEvidenta = new System.ComponentModel.BackgroundWorker();
            this.btnCopiazaAbsolut = new System.Windows.Forms.Button();
            this.lblStatusCopiereAbsolut = new System.Windows.Forms.Label();
            this.bgwCopiazaAbsolut = new System.ComponentModel.BackgroundWorker();
            this.btnCreeazaDirectoareFTP = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabActiuni = new System.Windows.Forms.TabPage();
            this.btnLogoutActiuni = new System.Windows.Forms.Button();
            this.tabOptiuni = new System.Windows.Forms.TabPage();
            this.btnIpExtern = new System.Windows.Forms.Button();
            this.btnVerificareFTPAbsolut = new System.Windows.Forms.Button();
            this.btnSalvareOptiuni = new System.Windows.Forms.Button();
            this.btnLogoutOptiuni = new System.Windows.Forms.Button();
            this.txtListaFisiereAbsolute = new System.Windows.Forms.TextBox();
            this.lblInfoListaFisiereAbsolute = new System.Windows.Forms.Label();
            this.txtCaleFTPAbsoluta = new System.Windows.Forms.TextBox();
            this.lblInfoCaleFTPAbsoluta = new System.Windows.Forms.Label();
            this.txtCaleLocalaAbsoluta = new System.Windows.Forms.TextBox();
            this.btnCaleLocalaAbsoluta = new System.Windows.Forms.Button();
            this.lblInfoCaleLocalaAbsoluta = new System.Windows.Forms.Label();
            this.txtCaleLocalaRecursiva = new System.Windows.Forms.TextBox();
            this.txtCaleFTPRecursiva = new System.Windows.Forms.TextBox();
            this.lblInfoCaleFTPRecursiva = new System.Windows.Forms.Label();
            this.btnCaleLocalaRecursiva = new System.Windows.Forms.Button();
            this.lblInfoCaleLocalaRecursiva = new System.Windows.Forms.Label();
            this.gbOreCopiere = new System.Windows.Forms.GroupBox();
            this.btnStergeOra = new System.Windows.Forms.Button();
            this.cbOreCopiere = new System.Windows.Forms.ComboBox();
            this.btnAdaugaOra = new System.Windows.Forms.Button();
            this.nudOraCopiere = new System.Windows.Forms.NumericUpDown();
            this.lblUltimaEvidenta = new System.Windows.Forms.Label();
            this.lblUltimeleAbsolute = new System.Windows.Forms.Label();
            this.timerOraCopiere = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtAdreseMailErori = new System.Windows.Forms.TextBox();
            this.lblInfoAdreseMailErori = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabActiuni.SuspendLayout();
            this.tabOptiuni.SuspendLayout();
            this.gbOreCopiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOraCopiere)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopiazaEvidenta
            // 
            this.btnCopiazaEvidenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiazaEvidenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopiazaEvidenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiazaEvidenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiazaEvidenta.ForeColor = System.Drawing.Color.White;
            this.btnCopiazaEvidenta.Location = new System.Drawing.Point(6, 87);
            this.btnCopiazaEvidenta.Name = "btnCopiazaEvidenta";
            this.btnCopiazaEvidenta.Size = new System.Drawing.Size(227, 31);
            this.btnCopiazaEvidenta.TabIndex = 0;
            this.btnCopiazaEvidenta.TabStop = false;
            this.btnCopiazaEvidenta.Text = "Copiaza evidenta";
            this.btnCopiazaEvidenta.UseVisualStyleBackColor = false;
            this.btnCopiazaEvidenta.Click += new System.EventHandler(this.btnCopiazaEvidenta_Click);
            // 
            // lblStatusCopiereEvidenta
            // 
            this.lblStatusCopiereEvidenta.AutoSize = true;
            this.lblStatusCopiereEvidenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCopiereEvidenta.Location = new System.Drawing.Point(239, 105);
            this.lblStatusCopiereEvidenta.Name = "lblStatusCopiereEvidenta";
            this.lblStatusCopiereEvidenta.Size = new System.Drawing.Size(0, 13);
            this.lblStatusCopiereEvidenta.TabIndex = 1;
            // 
            // timerStatusCopiereFTP
            // 
            this.timerStatusCopiereFTP.Interval = 1000;
            this.timerStatusCopiereFTP.Tick += new System.EventHandler(this.timerStatusCopiereFTP_Tick);
            // 
            // bgwCopiazaEvidenta
            // 
            this.bgwCopiazaEvidenta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCopiazaEvidenta_DoWork);
            this.bgwCopiazaEvidenta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCopiazaEvidenta_RunWorkerCompleted);
            // 
            // btnCopiazaAbsolut
            // 
            this.btnCopiazaAbsolut.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiazaAbsolut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopiazaAbsolut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiazaAbsolut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiazaAbsolut.ForeColor = System.Drawing.Color.White;
            this.btnCopiazaAbsolut.Location = new System.Drawing.Point(6, 143);
            this.btnCopiazaAbsolut.Name = "btnCopiazaAbsolut";
            this.btnCopiazaAbsolut.Size = new System.Drawing.Size(227, 31);
            this.btnCopiazaAbsolut.TabIndex = 2;
            this.btnCopiazaAbsolut.TabStop = false;
            this.btnCopiazaAbsolut.Text = "Copiaza fisiere diverse";
            this.btnCopiazaAbsolut.UseVisualStyleBackColor = false;
            this.btnCopiazaAbsolut.Click += new System.EventHandler(this.btnCopiazaAbsolut_Click);
            // 
            // lblStatusCopiereAbsolut
            // 
            this.lblStatusCopiereAbsolut.AutoSize = true;
            this.lblStatusCopiereAbsolut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCopiereAbsolut.Location = new System.Drawing.Point(239, 161);
            this.lblStatusCopiereAbsolut.Name = "lblStatusCopiereAbsolut";
            this.lblStatusCopiereAbsolut.Size = new System.Drawing.Size(0, 13);
            this.lblStatusCopiereAbsolut.TabIndex = 3;
            // 
            // bgwCopiazaAbsolut
            // 
            this.bgwCopiazaAbsolut.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCopiazaAbsolut_DoWork);
            this.bgwCopiazaAbsolut.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCopiazaAbsolut_RunWorkerCompleted);
            // 
            // btnCreeazaDirectoareFTP
            // 
            this.btnCreeazaDirectoareFTP.BackColor = System.Drawing.Color.Transparent;
            this.btnCreeazaDirectoareFTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreeazaDirectoareFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreeazaDirectoareFTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreeazaDirectoareFTP.ForeColor = System.Drawing.Color.White;
            this.btnCreeazaDirectoareFTP.Location = new System.Drawing.Point(6, 31);
            this.btnCreeazaDirectoareFTP.Name = "btnCreeazaDirectoareFTP";
            this.btnCreeazaDirectoareFTP.Size = new System.Drawing.Size(227, 31);
            this.btnCreeazaDirectoareFTP.TabIndex = 4;
            this.btnCreeazaDirectoareFTP.TabStop = false;
            this.btnCreeazaDirectoareFTP.Text = "Creeaza structura directoare FTP";
            this.btnCreeazaDirectoareFTP.UseVisualStyleBackColor = false;
            this.btnCreeazaDirectoareFTP.Click += new System.EventHandler(this.btnCreeazaDirectoareFTP_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtLogin);
            this.gbLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.ForeColor = System.Drawing.Color.White;
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(225, 95);
            this.gbLogin.TabIndex = 6;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Introduceti codul de acces";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(6, 57);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(213, 31);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 26);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '•';
            this.txtLogin.Size = new System.Drawing.Size(213, 25);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "salvator";
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabActiuni);
            this.tabControlMain.Controls.Add(this.tabOptiuni);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(243, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(753, 537);
            this.tabControlMain.TabIndex = 7;
            this.tabControlMain.Visible = false;
            // 
            // tabActiuni
            // 
            this.tabActiuni.BackColor = System.Drawing.Color.Black;
            this.tabActiuni.CausesValidation = false;
            this.tabActiuni.Controls.Add(this.btnLogoutActiuni);
            this.tabActiuni.Controls.Add(this.btnCreeazaDirectoareFTP);
            this.tabActiuni.Controls.Add(this.btnCopiazaEvidenta);
            this.tabActiuni.Controls.Add(this.lblStatusCopiereAbsolut);
            this.tabActiuni.Controls.Add(this.lblStatusCopiereEvidenta);
            this.tabActiuni.Controls.Add(this.btnCopiazaAbsolut);
            this.tabActiuni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabActiuni.ForeColor = System.Drawing.Color.White;
            this.tabActiuni.Location = new System.Drawing.Point(4, 26);
            this.tabActiuni.Name = "tabActiuni";
            this.tabActiuni.Padding = new System.Windows.Forms.Padding(3);
            this.tabActiuni.Size = new System.Drawing.Size(745, 507);
            this.tabActiuni.TabIndex = 0;
            this.tabActiuni.Text = "Actiuni";
            // 
            // btnLogoutActiuni
            // 
            this.btnLogoutActiuni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogoutActiuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutActiuni.Location = new System.Drawing.Point(6, 199);
            this.btnLogoutActiuni.Name = "btnLogoutActiuni";
            this.btnLogoutActiuni.Size = new System.Drawing.Size(227, 31);
            this.btnLogoutActiuni.TabIndex = 8;
            this.btnLogoutActiuni.TabStop = false;
            this.btnLogoutActiuni.Text = "Logout";
            this.btnLogoutActiuni.UseVisualStyleBackColor = true;
            this.btnLogoutActiuni.Click += new System.EventHandler(this.btnLogoutActiuni_Click);
            // 
            // tabOptiuni
            // 
            this.tabOptiuni.BackColor = System.Drawing.Color.Black;
            this.tabOptiuni.CausesValidation = false;
            this.tabOptiuni.Controls.Add(this.txtAdreseMailErori);
            this.tabOptiuni.Controls.Add(this.lblInfoAdreseMailErori);
            this.tabOptiuni.Controls.Add(this.btnIpExtern);
            this.tabOptiuni.Controls.Add(this.btnVerificareFTPAbsolut);
            this.tabOptiuni.Controls.Add(this.btnSalvareOptiuni);
            this.tabOptiuni.Controls.Add(this.btnLogoutOptiuni);
            this.tabOptiuni.Controls.Add(this.txtListaFisiereAbsolute);
            this.tabOptiuni.Controls.Add(this.lblInfoListaFisiereAbsolute);
            this.tabOptiuni.Controls.Add(this.txtCaleFTPAbsoluta);
            this.tabOptiuni.Controls.Add(this.lblInfoCaleFTPAbsoluta);
            this.tabOptiuni.Controls.Add(this.txtCaleLocalaAbsoluta);
            this.tabOptiuni.Controls.Add(this.btnCaleLocalaAbsoluta);
            this.tabOptiuni.Controls.Add(this.lblInfoCaleLocalaAbsoluta);
            this.tabOptiuni.Controls.Add(this.txtCaleLocalaRecursiva);
            this.tabOptiuni.Controls.Add(this.txtCaleFTPRecursiva);
            this.tabOptiuni.Controls.Add(this.lblInfoCaleFTPRecursiva);
            this.tabOptiuni.Controls.Add(this.btnCaleLocalaRecursiva);
            this.tabOptiuni.Controls.Add(this.lblInfoCaleLocalaRecursiva);
            this.tabOptiuni.Controls.Add(this.gbOreCopiere);
            this.tabOptiuni.ForeColor = System.Drawing.Color.White;
            this.tabOptiuni.Location = new System.Drawing.Point(4, 26);
            this.tabOptiuni.Name = "tabOptiuni";
            this.tabOptiuni.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptiuni.Size = new System.Drawing.Size(745, 507);
            this.tabOptiuni.TabIndex = 1;
            this.tabOptiuni.Text = "Optiuni";
            // 
            // btnIpExtern
            // 
            this.btnIpExtern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIpExtern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIpExtern.Location = new System.Drawing.Point(394, 265);
            this.btnIpExtern.Name = "btnIpExtern";
            this.btnIpExtern.Size = new System.Drawing.Size(183, 31);
            this.btnIpExtern.TabIndex = 24;
            this.btnIpExtern.TabStop = false;
            this.btnIpExtern.Text = "IP Extern";
            this.btnIpExtern.UseVisualStyleBackColor = true;
            this.btnIpExtern.Click += new System.EventHandler(this.btnIpExtern_Click);
            // 
            // btnVerificareFTPAbsolut
            // 
            this.btnVerificareFTPAbsolut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerificareFTPAbsolut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificareFTPAbsolut.Location = new System.Drawing.Point(583, 265);
            this.btnVerificareFTPAbsolut.Name = "btnVerificareFTPAbsolut";
            this.btnVerificareFTPAbsolut.Size = new System.Drawing.Size(148, 31);
            this.btnVerificareFTPAbsolut.TabIndex = 23;
            this.btnVerificareFTPAbsolut.TabStop = false;
            this.btnVerificareFTPAbsolut.Text = "Verificare FTP absolut";
            this.btnVerificareFTPAbsolut.UseVisualStyleBackColor = true;
            this.btnVerificareFTPAbsolut.Click += new System.EventHandler(this.btnVerificareFTPAbsolut_Click);
            // 
            // btnSalvareOptiuni
            // 
            this.btnSalvareOptiuni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvareOptiuni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSalvareOptiuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvareOptiuni.Location = new System.Drawing.Point(21, 433);
            this.btnSalvareOptiuni.Name = "btnSalvareOptiuni";
            this.btnSalvareOptiuni.Size = new System.Drawing.Size(227, 31);
            this.btnSalvareOptiuni.TabIndex = 22;
            this.btnSalvareOptiuni.TabStop = false;
            this.btnSalvareOptiuni.Text = "Salvare optiuni";
            this.btnSalvareOptiuni.UseVisualStyleBackColor = true;
            this.btnSalvareOptiuni.Click += new System.EventHandler(this.btnSalvareOptiuni_Click);
            // 
            // btnLogoutOptiuni
            // 
            this.btnLogoutOptiuni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogoutOptiuni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogoutOptiuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutOptiuni.Location = new System.Drawing.Point(21, 470);
            this.btnLogoutOptiuni.Name = "btnLogoutOptiuni";
            this.btnLogoutOptiuni.Size = new System.Drawing.Size(227, 31);
            this.btnLogoutOptiuni.TabIndex = 21;
            this.btnLogoutOptiuni.TabStop = false;
            this.btnLogoutOptiuni.Text = "Logout";
            this.btnLogoutOptiuni.UseVisualStyleBackColor = true;
            this.btnLogoutOptiuni.Click += new System.EventHandler(this.btnLogoutOptiuni_Click);
            // 
            // txtListaFisiereAbsolute
            // 
            this.txtListaFisiereAbsolute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtListaFisiereAbsolute.BackColor = System.Drawing.Color.Black;
            this.txtListaFisiereAbsolute.ForeColor = System.Drawing.Color.Lime;
            this.txtListaFisiereAbsolute.Location = new System.Drawing.Point(394, 359);
            this.txtListaFisiereAbsolute.Multiline = true;
            this.txtListaFisiereAbsolute.Name = "txtListaFisiereAbsolute";
            this.txtListaFisiereAbsolute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaFisiereAbsolute.Size = new System.Drawing.Size(337, 142);
            this.txtListaFisiereAbsolute.TabIndex = 20;
            // 
            // lblInfoListaFisiereAbsolute
            // 
            this.lblInfoListaFisiereAbsolute.AutoSize = true;
            this.lblInfoListaFisiereAbsolute.Location = new System.Drawing.Point(391, 322);
            this.lblInfoListaFisiereAbsolute.Name = "lblInfoListaFisiereAbsolute";
            this.lblInfoListaFisiereAbsolute.Size = new System.Drawing.Size(152, 34);
            this.lblInfoListaFisiereAbsolute.TabIndex = 19;
            this.lblInfoListaFisiereAbsolute.Text = "Lista fisiere absolute\r\n( ex. \\data\\produse.dbf)";
            // 
            // txtCaleFTPAbsoluta
            // 
            this.txtCaleFTPAbsoluta.BackColor = System.Drawing.Color.Black;
            this.txtCaleFTPAbsoluta.ForeColor = System.Drawing.Color.Lime;
            this.txtCaleFTPAbsoluta.Location = new System.Drawing.Point(394, 234);
            this.txtCaleFTPAbsoluta.Name = "txtCaleFTPAbsoluta";
            this.txtCaleFTPAbsoluta.Size = new System.Drawing.Size(337, 25);
            this.txtCaleFTPAbsoluta.TabIndex = 18;
            // 
            // lblInfoCaleFTPAbsoluta
            // 
            this.lblInfoCaleFTPAbsoluta.AutoSize = true;
            this.lblInfoCaleFTPAbsoluta.Location = new System.Drawing.Point(391, 197);
            this.lblInfoCaleFTPAbsoluta.Name = "lblInfoCaleFTPAbsoluta";
            this.lblInfoCaleFTPAbsoluta.Size = new System.Drawing.Size(272, 34);
            this.lblInfoCaleFTPAbsoluta.TabIndex = 17;
            this.lblInfoCaleFTPAbsoluta.Text = "Cale FTP absoluta \r\n( ex. ftp://1.11.11.111/NumeFarmacie/pharma )\r\n";
            // 
            // txtCaleLocalaAbsoluta
            // 
            this.txtCaleLocalaAbsoluta.BackColor = System.Drawing.Color.Black;
            this.txtCaleLocalaAbsoluta.ForeColor = System.Drawing.Color.Lime;
            this.txtCaleLocalaAbsoluta.Location = new System.Drawing.Point(394, 146);
            this.txtCaleLocalaAbsoluta.Name = "txtCaleLocalaAbsoluta";
            this.txtCaleLocalaAbsoluta.Size = new System.Drawing.Size(292, 25);
            this.txtCaleLocalaAbsoluta.TabIndex = 16;
            // 
            // btnCaleLocalaAbsoluta
            // 
            this.btnCaleLocalaAbsoluta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCaleLocalaAbsoluta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaleLocalaAbsoluta.Location = new System.Drawing.Point(692, 146);
            this.btnCaleLocalaAbsoluta.Name = "btnCaleLocalaAbsoluta";
            this.btnCaleLocalaAbsoluta.Size = new System.Drawing.Size(39, 25);
            this.btnCaleLocalaAbsoluta.TabIndex = 15;
            this.btnCaleLocalaAbsoluta.TabStop = false;
            this.btnCaleLocalaAbsoluta.Text = "...";
            this.btnCaleLocalaAbsoluta.UseVisualStyleBackColor = true;
            this.btnCaleLocalaAbsoluta.Click += new System.EventHandler(this.btnCaleLocalaAbsoluta_Click);
            // 
            // lblInfoCaleLocalaAbsoluta
            // 
            this.lblInfoCaleLocalaAbsoluta.AutoSize = true;
            this.lblInfoCaleLocalaAbsoluta.Location = new System.Drawing.Point(391, 111);
            this.lblInfoCaleLocalaAbsoluta.Name = "lblInfoCaleLocalaAbsoluta";
            this.lblInfoCaleLocalaAbsoluta.Size = new System.Drawing.Size(131, 34);
            this.lblInfoCaleLocalaAbsoluta.TabIndex = 14;
            this.lblInfoCaleLocalaAbsoluta.Text = "Cale locala absoluta \r\n( ex. D:\\pharma )\r\n";
            // 
            // txtCaleLocalaRecursiva
            // 
            this.txtCaleLocalaRecursiva.BackColor = System.Drawing.Color.Black;
            this.txtCaleLocalaRecursiva.ForeColor = System.Drawing.Color.Lime;
            this.txtCaleLocalaRecursiva.Location = new System.Drawing.Point(21, 148);
            this.txtCaleLocalaRecursiva.Name = "txtCaleLocalaRecursiva";
            this.txtCaleLocalaRecursiva.Size = new System.Drawing.Size(281, 25);
            this.txtCaleLocalaRecursiva.TabIndex = 13;
            // 
            // txtCaleFTPRecursiva
            // 
            this.txtCaleFTPRecursiva.BackColor = System.Drawing.Color.Black;
            this.txtCaleFTPRecursiva.ForeColor = System.Drawing.Color.Lime;
            this.txtCaleFTPRecursiva.Location = new System.Drawing.Point(21, 234);
            this.txtCaleFTPRecursiva.Name = "txtCaleFTPRecursiva";
            this.txtCaleFTPRecursiva.Size = new System.Drawing.Size(326, 25);
            this.txtCaleFTPRecursiva.TabIndex = 12;
            // 
            // lblInfoCaleFTPRecursiva
            // 
            this.lblInfoCaleFTPRecursiva.AutoSize = true;
            this.lblInfoCaleFTPRecursiva.Location = new System.Drawing.Point(18, 197);
            this.lblInfoCaleFTPRecursiva.Name = "lblInfoCaleFTPRecursiva";
            this.lblInfoCaleFTPRecursiva.Size = new System.Drawing.Size(329, 34);
            this.lblInfoCaleFTPRecursiva.TabIndex = 11;
            this.lblInfoCaleFTPRecursiva.Text = "Cale FTP recursiva \r\n( ex. ftp://1.11.11.111/NumeFarmacie/pharma/evidenta )\r\n";
            // 
            // btnCaleLocalaRecursiva
            // 
            this.btnCaleLocalaRecursiva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCaleLocalaRecursiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaleLocalaRecursiva.Location = new System.Drawing.Point(308, 148);
            this.btnCaleLocalaRecursiva.Name = "btnCaleLocalaRecursiva";
            this.btnCaleLocalaRecursiva.Size = new System.Drawing.Size(39, 25);
            this.btnCaleLocalaRecursiva.TabIndex = 9;
            this.btnCaleLocalaRecursiva.TabStop = false;
            this.btnCaleLocalaRecursiva.Text = "...";
            this.btnCaleLocalaRecursiva.UseVisualStyleBackColor = true;
            this.btnCaleLocalaRecursiva.Click += new System.EventHandler(this.btnCaleLocalaRecursiva_Click);
            // 
            // lblInfoCaleLocalaRecursiva
            // 
            this.lblInfoCaleLocalaRecursiva.AutoSize = true;
            this.lblInfoCaleLocalaRecursiva.Location = new System.Drawing.Point(18, 111);
            this.lblInfoCaleLocalaRecursiva.Name = "lblInfoCaleLocalaRecursiva";
            this.lblInfoCaleLocalaRecursiva.Size = new System.Drawing.Size(166, 34);
            this.lblInfoCaleLocalaRecursiva.TabIndex = 8;
            this.lblInfoCaleLocalaRecursiva.Text = "Cale locala recursiva \r\n( ex. D:\\pharma\\evidenta )\r\n";
            // 
            // gbOreCopiere
            // 
            this.gbOreCopiere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOreCopiere.Controls.Add(this.btnStergeOra);
            this.gbOreCopiere.Controls.Add(this.cbOreCopiere);
            this.gbOreCopiere.Controls.Add(this.btnAdaugaOra);
            this.gbOreCopiere.Controls.Add(this.nudOraCopiere);
            this.gbOreCopiere.ForeColor = System.Drawing.Color.White;
            this.gbOreCopiere.Location = new System.Drawing.Point(21, 19);
            this.gbOreCopiere.Name = "gbOreCopiere";
            this.gbOreCopiere.Size = new System.Drawing.Size(707, 72);
            this.gbOreCopiere.TabIndex = 7;
            this.gbOreCopiere.TabStop = false;
            this.gbOreCopiere.Text = "Ore copiere";
            // 
            // btnStergeOra
            // 
            this.btnStergeOra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStergeOra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStergeOra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergeOra.Location = new System.Drawing.Point(605, 26);
            this.btnStergeOra.Name = "btnStergeOra";
            this.btnStergeOra.Size = new System.Drawing.Size(96, 27);
            this.btnStergeOra.TabIndex = 12;
            this.btnStergeOra.TabStop = false;
            this.btnStergeOra.Text = "Sterge ora";
            this.btnStergeOra.UseVisualStyleBackColor = true;
            this.btnStergeOra.Click += new System.EventHandler(this.btnStergeOra_Click);
            // 
            // cbOreCopiere
            // 
            this.cbOreCopiere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOreCopiere.FormattingEnabled = true;
            this.cbOreCopiere.Location = new System.Drawing.Point(449, 26);
            this.cbOreCopiere.Name = "cbOreCopiere";
            this.cbOreCopiere.Size = new System.Drawing.Size(150, 25);
            this.cbOreCopiere.TabIndex = 11;
            // 
            // btnAdaugaOra
            // 
            this.btnAdaugaOra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdaugaOra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaOra.Location = new System.Drawing.Point(162, 26);
            this.btnAdaugaOra.Name = "btnAdaugaOra";
            this.btnAdaugaOra.Size = new System.Drawing.Size(96, 27);
            this.btnAdaugaOra.TabIndex = 10;
            this.btnAdaugaOra.TabStop = false;
            this.btnAdaugaOra.Text = "Adauga ora";
            this.btnAdaugaOra.UseVisualStyleBackColor = true;
            this.btnAdaugaOra.Click += new System.EventHandler(this.btnAdaugaOra_Click);
            // 
            // nudOraCopiere
            // 
            this.nudOraCopiere.Location = new System.Drawing.Point(6, 26);
            this.nudOraCopiere.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudOraCopiere.Name = "nudOraCopiere";
            this.nudOraCopiere.Size = new System.Drawing.Size(150, 25);
            this.nudOraCopiere.TabIndex = 0;
            // 
            // lblUltimaEvidenta
            // 
            this.lblUltimaEvidenta.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimaEvidenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUltimaEvidenta.ForeColor = System.Drawing.Color.White;
            this.lblUltimaEvidenta.Location = new System.Drawing.Point(12, 129);
            this.lblUltimaEvidenta.Name = "lblUltimaEvidenta";
            this.lblUltimaEvidenta.Size = new System.Drawing.Size(225, 56);
            this.lblUltimaEvidenta.TabIndex = 2;
            this.lblUltimaEvidenta.Text = "Ultima actualizarea a evidentei:";
            this.lblUltimaEvidenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUltimeleAbsolute
            // 
            this.lblUltimeleAbsolute.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimeleAbsolute.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUltimeleAbsolute.ForeColor = System.Drawing.Color.White;
            this.lblUltimeleAbsolute.Location = new System.Drawing.Point(12, 217);
            this.lblUltimeleAbsolute.Name = "lblUltimeleAbsolute";
            this.lblUltimeleAbsolute.Size = new System.Drawing.Size(225, 52);
            this.lblUltimeleAbsolute.TabIndex = 8;
            this.lblUltimeleAbsolute.Text = "Ultima salvare fisiere diverse:";
            this.lblUltimeleAbsolute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerOraCopiere
            // 
            this.timerOraCopiere.Interval = 3600000;
            this.timerOraCopiere.Tick += new System.EventHandler(this.timerOraCopiere_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Salvator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // txtAdreseMailErori
            // 
            this.txtAdreseMailErori.BackColor = System.Drawing.Color.Black;
            this.txtAdreseMailErori.ForeColor = System.Drawing.Color.Lime;
            this.txtAdreseMailErori.Location = new System.Drawing.Point(21, 320);
            this.txtAdreseMailErori.Name = "txtAdreseMailErori";
            this.txtAdreseMailErori.Size = new System.Drawing.Size(326, 25);
            this.txtAdreseMailErori.TabIndex = 26;
            // 
            // lblInfoAdreseMailErori
            // 
            this.lblInfoAdreseMailErori.AutoSize = true;
            this.lblInfoAdreseMailErori.Location = new System.Drawing.Point(18, 283);
            this.lblInfoAdreseMailErori.Name = "lblInfoAdreseMailErori";
            this.lblInfoAdreseMailErori.Size = new System.Drawing.Size(285, 34);
            this.lblInfoAdreseMailErori.TabIndex = 25;
            this.lblInfoAdreseMailErori.Text = "Adrese mail erori\r\n(ex. adresa1@gmail.com,adresa2@yahoo.com)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salvator.Properties.Resources.s_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.lblUltimeleAbsolute);
            this.Controls.Add(this.lblUltimaEvidenta);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "Salvator";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabActiuni.ResumeLayout(false);
            this.tabActiuni.PerformLayout();
            this.tabOptiuni.ResumeLayout(false);
            this.tabOptiuni.PerformLayout();
            this.gbOreCopiere.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOraCopiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopiazaEvidenta;
        private System.Windows.Forms.Label lblStatusCopiereEvidenta;
        private System.Windows.Forms.Timer timerStatusCopiereFTP;
        private System.ComponentModel.BackgroundWorker bgwCopiazaEvidenta;
        private System.Windows.Forms.Button btnCopiazaAbsolut;
        private System.Windows.Forms.Label lblStatusCopiereAbsolut;
        private System.ComponentModel.BackgroundWorker bgwCopiazaAbsolut;
        private System.Windows.Forms.Button btnCreeazaDirectoareFTP;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabActiuni;
        private System.Windows.Forms.TabPage tabOptiuni;
        private System.Windows.Forms.Button btnLogoutActiuni;
        private System.Windows.Forms.Label lblUltimaEvidenta;
        private System.Windows.Forms.Label lblUltimeleAbsolute;
        private System.Windows.Forms.GroupBox gbOreCopiere;
        private System.Windows.Forms.NumericUpDown nudOraCopiere;
        private System.Windows.Forms.Label lblInfoCaleLocalaRecursiva;
        private System.Windows.Forms.Button btnCaleLocalaRecursiva;
        private System.Windows.Forms.Label lblInfoCaleFTPRecursiva;
        private System.Windows.Forms.TextBox txtCaleLocalaRecursiva;
        private System.Windows.Forms.TextBox txtCaleFTPRecursiva;
        private System.Windows.Forms.TextBox txtCaleLocalaAbsoluta;
        private System.Windows.Forms.Button btnCaleLocalaAbsoluta;
        private System.Windows.Forms.Label lblInfoCaleLocalaAbsoluta;
        private System.Windows.Forms.TextBox txtCaleFTPAbsoluta;
        private System.Windows.Forms.Label lblInfoCaleFTPAbsoluta;
        private System.Windows.Forms.TextBox txtListaFisiereAbsolute;
        private System.Windows.Forms.Label lblInfoListaFisiereAbsolute;
        private System.Windows.Forms.Button btnSalvareOptiuni;
        private System.Windows.Forms.Button btnLogoutOptiuni;
        private System.Windows.Forms.Button btnStergeOra;
        private System.Windows.Forms.ComboBox cbOreCopiere;
        private System.Windows.Forms.Button btnAdaugaOra;
        private System.Windows.Forms.Button btnVerificareFTPAbsolut;
        private System.Windows.Forms.Button btnIpExtern;
        private System.Windows.Forms.Timer timerOraCopiere;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtAdreseMailErori;
        private System.Windows.Forms.Label lblInfoAdreseMailErori;
    }
}

