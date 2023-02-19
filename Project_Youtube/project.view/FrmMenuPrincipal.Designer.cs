
namespace Project_Youtube.project.view
{
    partial class FrmMenuPrincipal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNivelAcesso = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuLogin = new System.Windows.Forms.Panel();
            this.BtnLogOff = new System.Windows.Forms.Button();
            this.BtnLogOn = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.Btn02 = new System.Windows.Forms.Button();
            this.panelSubMenuCadastros = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCadastros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.BtnFecharChildForm = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuLogin.SuspendLayout();
            this.panelSubMenuCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblData,
            this.toolStripStatusLabel2,
            this.lblHora,
            this.toolStripStatusLabel3,
            this.lblNivelAcesso,
            this.toolStripStatusLabel4,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(960, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 18);
            this.toolStripStatusLabel1.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.Control;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(82, 18);
            this.lblData.Text = "00-00-0000";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 18);
            this.toolStripStatusLabel2.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 18);
            this.lblHora.Text = "00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 18);
            this.toolStripStatusLabel3.Text = "Nivel.:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.BackColor = System.Drawing.SystemColors.Control;
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(16, 18);
            this.lblNivelAcesso.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(71, 18);
            this.toolStripStatusLabel4.Text = "Usuário.:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(28, 18);
            this.lblUsuario.Text = "----";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.panelSubMenuLogin);
            this.panelMenu.Controls.Add(this.BtnLogin);
            this.panelMenu.Controls.Add(this.BtnUsuario);
            this.panelMenu.Controls.Add(this.Btn02);
            this.panelMenu.Controls.Add(this.panelSubMenuCadastros);
            this.panelMenu.Controls.Add(this.BtnCadastros);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 577);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSubMenuLogin
            // 
            this.panelSubMenuLogin.Controls.Add(this.BtnLogOff);
            this.panelSubMenuLogin.Controls.Add(this.BtnLogOn);
            this.panelSubMenuLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuLogin.Location = new System.Drawing.Point(0, 360);
            this.panelSubMenuLogin.Name = "panelSubMenuLogin";
            this.panelSubMenuLogin.Size = new System.Drawing.Size(150, 75);
            this.panelSubMenuLogin.TabIndex = 2;
            // 
            // BtnLogOff
            // 
            this.BtnLogOff.FlatAppearance.BorderSize = 0;
            this.BtnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOff.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOff.Image = global::Project_Youtube.Properties.Resources.logoff_24;
            this.BtnLogOff.Location = new System.Drawing.Point(0, 35);
            this.BtnLogOff.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogOff.Name = "BtnLogOff";
            this.BtnLogOff.Size = new System.Drawing.Size(150, 35);
            this.BtnLogOff.TabIndex = 3;
            this.BtnLogOff.Text = "   LogOff";
            this.BtnLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogOff.UseVisualStyleBackColor = true;
            this.BtnLogOff.Click += new System.EventHandler(this.BtnLogOff_Click);
            // 
            // BtnLogOn
            // 
            this.BtnLogOn.FlatAppearance.BorderSize = 0;
            this.BtnLogOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOn.Image = global::Project_Youtube.Properties.Resources.logon_24;
            this.BtnLogOn.Location = new System.Drawing.Point(0, 0);
            this.BtnLogOn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogOn.Name = "BtnLogOn";
            this.BtnLogOn.Size = new System.Drawing.Size(150, 35);
            this.BtnLogOn.TabIndex = 2;
            this.BtnLogOn.Text = "   LogOn";
            this.BtnLogOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogOn.UseVisualStyleBackColor = true;
            this.BtnLogOn.Click += new System.EventHandler(this.BtnLogOn_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Image = global::Project_Youtube.Properties.Resources.menuLogin_32;
            this.BtnLogin.Location = new System.Drawing.Point(0, 305);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(150, 55);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "   Login";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.Image = global::Project_Youtube.Properties.Resources.menuUsuario_32;
            this.BtnUsuario.Location = new System.Drawing.Point(0, 250);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(150, 55);
            this.BtnUsuario.TabIndex = 4;
            this.BtnUsuario.Text = "   Usuário";
            this.BtnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuario.UseVisualStyleBackColor = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // Btn02
            // 
            this.Btn02.BackColor = System.Drawing.SystemColors.Control;
            this.Btn02.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn02.FlatAppearance.BorderSize = 0;
            this.Btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn02.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn02.Location = new System.Drawing.Point(0, 195);
            this.Btn02.Margin = new System.Windows.Forms.Padding(2);
            this.Btn02.Name = "Btn02";
            this.Btn02.Size = new System.Drawing.Size(150, 55);
            this.Btn02.TabIndex = 3;
            this.Btn02.Text = "Menu2";
            this.Btn02.UseVisualStyleBackColor = false;
            // 
            // panelSubMenuCadastros
            // 
            this.panelSubMenuCadastros.Controls.Add(this.button1);
            this.panelSubMenuCadastros.Controls.Add(this.button2);
            this.panelSubMenuCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCadastros.Location = new System.Drawing.Point(0, 120);
            this.panelSubMenuCadastros.Name = "panelSubMenuCadastros";
            this.panelSubMenuCadastros.Size = new System.Drawing.Size(150, 75);
            this.panelSubMenuCadastros.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Project_Youtube.Properties.Resources.produto_24;
            this.button1.Location = new System.Drawing.Point(0, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "   Produto     ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Project_Youtube.Properties.Resources.fornecedor_24;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "   Fornecedor";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCadastros
            // 
            this.BtnCadastros.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastros.FlatAppearance.BorderSize = 0;
            this.BtnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastros.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastros.Image = global::Project_Youtube.Properties.Resources.menuCadastro_32;
            this.BtnCadastros.Location = new System.Drawing.Point(0, 65);
            this.BtnCadastros.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCadastros.Name = "BtnCadastros";
            this.BtnCadastros.Size = new System.Drawing.Size(150, 55);
            this.BtnCadastros.TabIndex = 1;
            this.BtnCadastros.Text = "   Cadastros";
            this.BtnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastros.UseVisualStyleBackColor = false;
            this.BtnCadastros.Click += new System.EventHandler(this.BtnCadastros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.DarkViolet;
            this.PanelTitle.Controls.Add(this.BtnFecharChildForm);
            this.PanelTitle.Controls.Add(this.BtnFechar);
            this.PanelTitle.Controls.Add(this.lblTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(150, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(810, 65);
            this.PanelTitle.TabIndex = 2;
            this.PanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // BtnFecharChildForm
            // 
            this.BtnFecharChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFecharChildForm.FlatAppearance.BorderSize = 0;
            this.BtnFecharChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharChildForm.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFecharChildForm.ForeColor = System.Drawing.Color.White;
            this.BtnFecharChildForm.Image = global::Project_Youtube.Properties.Resources.btn_home_32;
            this.BtnFecharChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFecharChildForm.Location = new System.Drawing.Point(0, 0);
            this.BtnFecharChildForm.Name = "BtnFecharChildForm";
            this.BtnFecharChildForm.Size = new System.Drawing.Size(121, 65);
            this.BtnFecharChildForm.TabIndex = 3;
            this.BtnFecharChildForm.Text = "   HOME";
            this.BtnFecharChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFecharChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFecharChildForm.UseVisualStyleBackColor = true;
            this.BtnFecharChildForm.Click += new System.EventHandler(this.BtnFecharChildForm_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Image = global::Project_Youtube.Properties.Resources.btn_cancelar_24;
            this.BtnFechar.Location = new System.Drawing.Point(782, 2);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 25);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(282, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(150, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(810, 577);
            this.panelDesktop.TabIndex = 3;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuLogin.ResumeLayout(false);
            this.panelSubMenuCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button BtnCadastros;
        private System.Windows.Forms.Button Btn02;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.ToolStripStatusLabel lblNivelAcesso;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSubMenuLogin;
        private System.Windows.Forms.Button BtnLogOn;
        private System.Windows.Forms.Button BtnLogOff;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnFecharChildForm;
        private System.Windows.Forms.Panel panelSubMenuCadastros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}