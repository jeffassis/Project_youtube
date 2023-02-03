using Project_Youtube.project.dao;
using Project_Youtube.project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Youtube
{
    public partial class FrmUsuario : Form
    {
        string idSelecionado;
        string usuarioAntigo;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {            
            txtNome.Text = txtSenha.Text = txtUsername.Text = string.Empty;
            txtNivel.Value = 0;
            CbStatus.SelectedIndex = 0;
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsername.Enabled = true;
            txtSenha.Enabled = true;
            CbStatus.Enabled = true;
            txtNivel.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            // Botoes
            BtnSalvar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            // Campos
            txtNome.Enabled = false;
            txtUsername.Enabled = false;
            txtSenha.Enabled = false;
            CbStatus.Enabled = false;
            txtNivel.Enabled = false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CbStatus.SelectedIndex = 0;

            // Preenchendo o DataGridView
            UsuarioDAO dao = new UsuarioDAO();
            Grid.DataSource = dao.ListarUsuario();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            tabUsuario.SelectedTab = tabPage2;
            HabilitarCampos();
            LimparCampos();
        }         

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Verfificar se o campo Nome esta vazio
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo NOME!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            // Verfificar se o campo Username esta vazio
            if (txtUsername.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo USERNAME!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            // Verfificar se o campo Senha esta vazio
            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo SENHA!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            Usuario obj = new Usuario
            {
                Nome = txtNome.Text,
                Username = txtUsername.Text,
                Senha = txtSenha.Text,
                Status = CbStatus.Text,
                Nivel = int.Parse(txtNivel.Value.ToString())
            };
            UsuarioDAO dao = new UsuarioDAO();
            // Verificar se o username ja existe
            DataTable dt = dao.VerificarUsername(txtUsername.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username já cadastrado!!", "Erro ao adicionar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtUsername.Focus();
                return;
            }
            // Executa o comando para adicionar
            dao.CadastrarUsuario(obj);
            DesabilitarCampos();
            LimparCampos();
            Grid.DataSource = dao.ListarUsuario();
            tabUsuario.SelectedTab = tabPage1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {            
            tabUsuario.SelectedTab = tabPage1;
            LimparCampos();
            DesabilitarCampos();
        }        

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Verfificar se o campo Nome esta vazio
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo NOME!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            // Verfificar se o campo Username esta vazio
            if (txtUsername.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo USERNAME!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            // Verfificar se o campo Senha esta vazio
            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo SENHA!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            Usuario obj = new Usuario
            {
                Nome = txtNome.Text,
                Username = txtUsername.Text,
                Senha = txtSenha.Text,
                Status = CbStatus.Text,
                Nivel = int.Parse(txtNivel.Value.ToString())
            };
            UsuarioDAO dao = new UsuarioDAO();
            // Verifica  se o username ja existe
            if (txtUsername.Text != usuarioAntigo)
            {
                DataTable dt = dao.VerificarUsername(txtUsername.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username já cadastrado!!", "Erro ao atualizar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtUsername.Focus();
                    return;
                }
            }
            // Executa o comando para atualizar
            dao.EditarUsuario(obj, idSelecionado);
            DesabilitarCampos();
            LimparCampos();
            Grid.DataSource = dao.ListarUsuario();
            tabUsuario.SelectedTab = tabPage1;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UsuarioDAO dao = new UsuarioDAO();
                dao.ExcluirUsuario(idSelecionado);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            DesabilitarCampos();
            LimparCampos();
            tabUsuario.SelectedTab = tabPage1;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            CbStatus.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtNivel.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = Grid.CurrentRow.Cells[5].Value.ToString();

            tabUsuario.SelectedTab = tabPage2;
            HabilitarCampos();
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;

            // Pega o username cadastrado no banco de dados
            usuarioAntigo = Grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + TxtPesquisar.Text + "%";

            UsuarioDAO dao = new UsuarioDAO();
            Grid.DataSource = dao.ListarUsuarioPorNome(nome);
        }
    }
}
