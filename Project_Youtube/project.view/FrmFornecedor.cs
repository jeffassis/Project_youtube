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

namespace Project_Youtube.project.view
{
    public partial class FrmFornecedor : Form
    {
        string idSelecionado;
        string fornecedorAntigo;
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "ENDEREÇO";
            Grid.Columns[3].HeaderText = "TELEFONE";

            // Define se a coluna e visivel
            Grid.Columns[0].Visible = false;

            // Tamanho da Letra do Header antes devemos colocar VisualStyles como "FALSE"
            Grid.EnableHeadersVisualStyles = false;
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkViolet;
            Grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.AliceBlue;

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Define tamanho da coluna
            Grid.Columns[3].Width = 130;
        }

        private void Listar()
        {
            // Preenchendo o DataGridView
            FornecedorDAO dao = new FornecedorDAO();
            Grid.DataSource = dao.ListarFornecedor();

            FormatarDG();
        }

        private void LimparCampos()
        {
            txtNome.Text = txtTelefone.Text = txtEndereco.Text = string.Empty;

            // Codigo para limpar o DataGridView
            if (Grid.DataSource is DataTable dt)
            {
                dt.Rows.Clear();
            }
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            // Botoes
            BtnSalvar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            // Campos
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtEndereco.Enabled = false;            
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            tabFornecedor.SelectedTab = tabPage2;
            LimparCampos();
            HabilitarCampos();
        }       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            tabFornecedor.SelectedTab = tabPage1;
            LimparCampos();
            DesabilitarCampos();
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
            Fornecedor obj = new Fornecedor 
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text
            };
            FornecedorDAO dao = new FornecedorDAO();
            // Verificar se o nome ja existe
            DataTable dt = dao.VerificarFornecedor(txtNome.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Fornecedor já cadastrado!!", "Erro ao adicionar...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            // Executa o comando para adicionar
            dao.CadastrarFornecedor(obj);
            DesabilitarCampos();
            LimparCampos();            
            tabFornecedor.SelectedTab = tabPage1;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FornecedorDAO dao = new FornecedorDAO();
                dao.ExcluirFornecedor(idSelecionado);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            DesabilitarCampos();
            LimparCampos();
            tabFornecedor.SelectedTab = tabPage1;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = Grid.CurrentRow.Cells[3].Value.ToString();

            tabFornecedor.SelectedTab = tabPage2;
            HabilitarCampos();
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;

            // Pega o fornecedor cadastrado no banco de dados
            fornecedorAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
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
            Fornecedor obj = new Fornecedor
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text
            };
            FornecedorDAO dao = new FornecedorDAO();
            // Verifica  se o fornecedor ja existe
            if (txtNome.Text != fornecedorAntigo)
            {
                DataTable dt = dao.VerificarFornecedor(txtNome.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Fornecedor já cadastrado!!", "Erro ao atualizar...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Text = "";
                    txtNome.Focus();
                    return;
                }
            }
            // Executa o comando para atualizar
            dao.EditarFornecedor(obj, idSelecionado);
            DesabilitarCampos();
            LimparCampos();
            tabFornecedor.SelectedTab = tabPage1;
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + TxtPesquisar.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            Grid.DataSource = dao.ListarFornecedorPorNome(nome);

            FormatarDG();
        }
    }
}
