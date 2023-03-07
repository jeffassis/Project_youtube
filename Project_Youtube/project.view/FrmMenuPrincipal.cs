using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Youtube.project.view
{
    public partial class FrmMenuPrincipal : Form
    {
        // Variavel de ativacao do formulario
        private Form activeForm;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            FrmLogin login = new FrmLogin(this);
            login.ShowDialog();
            CustomDesing();
            BtnFecharChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        // Metodo para abrir os formularios com paramestros de nivel de acesso
        private void AbreForm(int nivel, Form f, object sender)
        {
            if (Program.logado)
            {
                if (Program.nivel >= nivel)
                {
                    OpenChildForm(f, sender);                                 
                }
                else
                {
                    MessageBox.Show("Acesso não permitido", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado", "Acesso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo para esconder os subMenu
        private void CustomDesing()
        {
            panelSubMenuLogin.Visible = false;
            panelSubMenuCadastros.Visible = false;
            panelSubMenuMovimentacao.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuLogin.Visible == true)
                panelSubMenuLogin.Visible = false;
            if (panelSubMenuCadastros.Visible == true)
                panelSubMenuCadastros.Visible = false;
            if (panelSubMenuMovimentacao.Visible == true)
                panelSubMenuMovimentacao.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuLogin);
        }

        private void BtnCadastros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuCadastros);
        }

        private void BtnMovimentacao_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuMovimentacao);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do Sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            AbreForm(1, form, sender);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnFecharChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            lblTitle.Text = "HOME";
            BtnFecharChildForm.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                BtnFecharChildForm.Visible = true;
            }
        }

        private void BtnLogOff_Click(object sender, EventArgs e)
        {
            lblNivelAcesso.Text = "0";
            lblUsuario.Text = "----";

            Program.nivel = 0;
            Program.logado = false;
        }

        private void BtnLogOn_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin(this);
            login.ShowDialog();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor form = new FrmFornecedor();
            AbreForm(1, form, sender);
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmProduto form = new FrmProduto();
            AbreForm(1, form, sender);
        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            FrmCompra form = new FrmCompra();
            AbreForm(1, form, sender);
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            FrmVenda form = new FrmVenda();
            AbreForm(1, form, sender);
        }
    }
}
