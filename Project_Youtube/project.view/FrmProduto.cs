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
    public partial class FrmProduto : Form
    {
        string idSelecionado;
        string produtoAntigo;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "DESCRIÇÂO";
            Grid.Columns[3].HeaderText = "FORNECEDOR";
            Grid.Columns[4].HeaderText = "ESTOQUE";
            Grid.Columns[5].HeaderText = "VENDA";
            Grid.Columns[6].HeaderText = "COMPRA";
            Grid.Columns[7].HeaderText = "DATA";
            Grid.Columns[8].HeaderText = "ID_FORNECEDOR";

            // Define se a coluna e visivel
            Grid.Columns[0].Visible = false;
            Grid.Columns[7].Visible = false;
            Grid.Columns[8].Visible = false;

            // Tamanho da Letra do Header antes devemos colocar VisualStyles como "FALSE"
            Grid.EnableHeadersVisualStyles = false;
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkViolet;
            Grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.AliceBlue;

            // O Header so fica centralizado se desabilitar a propriedade de ordenacao
            Grid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Colocar valores centralizados na celula
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formatar coluna para moeda
            Grid.Columns[5].DefaultCellStyle.Format = "C2";
            Grid.Columns[6].DefaultCellStyle.Format = "C2";

            // Define tamanho da coluna
            Grid.Columns[3].Width = 140;
            Grid.Columns[4].Width = 70;
            Grid.Columns[5].Width = 80;
            Grid.Columns[6].Width = 80;
        }

        private void Listar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProduto();
            
            FormatarDG();
        }

        private void ComboFornecedor()
        {
            FornecedorDAO dao = new FornecedorDAO();
            CbFornecedor.DataSource = dao.ListarFornecedor();
            CbFornecedor.DisplayMember = "nome";
            CbFornecedor.ValueMember = "id_fornecedor";
        }

        private void LimparCampos()
        {
            txtNome.Text = txtDescricao.Text = txtEstoque.Text = txtVenda.Text = string.Empty;
            CbFornecedor.SelectedIndex = 0;

            // Codigo para limpar o DataGridView
            if (Grid.DataSource is DataTable dt)
            {
                dt.Rows.Clear();
            }
        }

        private void Habilitar()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtVenda.Enabled = true;
            CbFornecedor.Enabled = true;
            txtNome.Focus();
        }

        private void Desabilitar()
        {
            // Botoes
            BtnSalvar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            // Campos
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtVenda.Enabled = false;
            CbFornecedor.Enabled = false;            
        }


        private void FrmProduto_Load(object sender, EventArgs e)
        {
            ComboFornecedor();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
            LimparCampos();
            Habilitar();
            tabProduto.SelectedTab = tabPage2;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Desabilitar();
            tabProduto.SelectedTab = tabPage1;
            TxtPesquisar.Focus();
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
            // Verfificar se o campo Venda esta vazia
            if (txtVenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo NOME!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenda.Focus();
                return;
            }
            // Adiciona o Produto
            Produto obj = new Produto
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                FornecedorId = int.Parse(CbFornecedor.SelectedValue.ToString()),
                ValorVenda = decimal.Parse(txtVenda.Text)
            };
            ProdutoDAO dao = new ProdutoDAO();
            // Verificar se o nome ja existe
            DataTable dt = dao.VerificarProduto(txtNome.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Produto já cadastrado!!", "Erro ao adicionar...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            dao.CadastrarProduto(obj);
            Desabilitar();
            LimparCampos();
            tabProduto.SelectedTab = tabPage1;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            CbFornecedor.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtEstoque.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            txtVenda.Text = Grid.CurrentRow.Cells[5].Value.ToString();

            tabProduto.SelectedTab = tabPage2;
            Habilitar();
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ProdutoDAO dao = new ProdutoDAO();
                dao.ExcluirProduto(idSelecionado);
                Grid.Rows.Remove(Grid.CurrentRow);
            }
            Desabilitar();
            LimparCampos();
            tabProduto.SelectedTab = tabPage1;
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
            // Verfificar se o campo Venda esta vazia
            if (txtVenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo NOME!", "Campo nome está vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVenda.Focus();
                return;
            }
            // Atualiza o Produto
            Produto obj = new Produto
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                FornecedorId = int.Parse(CbFornecedor.SelectedValue.ToString()),
                ValorVenda = decimal.Parse(txtVenda.Text)
            };
            ProdutoDAO dao = new ProdutoDAO();
            // Verifica  se o produto ja existe
            if (txtNome.Text != produtoAntigo)
            {
                DataTable dt = dao.VerificarProduto(txtNome.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Produto já cadastrado!!", "Erro ao atualizar...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Text = "";
                    txtNome.Focus();
                    return;
                }
            }
            dao.EditarProduto(obj, idSelecionado);
            Desabilitar();
            LimparCampos();
            tabProduto.SelectedTab = tabPage1;
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + TxtPesquisar.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProdutoPorNome(nome);

            FormatarDG();
        }
    }
}
