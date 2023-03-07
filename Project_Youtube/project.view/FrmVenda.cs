using Project_Youtube.project.dao;
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
    public partial class FrmVenda : Form
    {
        // Variaveis
        int qtd, estoque, codigoProd;
        decimal preco;
        decimal subtotal, total;

        // Carrinho
        DataTable carrinho = new DataTable();
        public FrmVenda()
        {
            InitializeComponent();
            lblData.Visible = false;

            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preco", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            Grid_Carrinho.DataSource = carrinho;
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

        private void Limpar()
        {
            // Limpa os Label e os TextBox 
            lblProduto.Text = lblEstoque.Text = lblPreco.Text = string.Empty;
            txtQuantidade.Text = TxtPesquisar.Text = string.Empty;
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {

        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            tabVenda.SelectedTab = tabPage2;
            Listar();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            lblProduto.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            lblEstoque.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            lblPreco.Text = Grid.CurrentRow.Cells[5].Value.ToString();

            tabVenda.SelectedTab = tabPage1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtQuantidade.Text);
            preco = decimal.Parse(lblPreco.Text);

            subtotal = qtd * preco;

            total += subtotal;

            estoque = int.Parse(lblEstoque.Text);
            codigoProd = int.Parse(lblCodigo.Text);

            if (estoque >= qtd)
            {
                // Adicionar o produto no carrinho
                carrinho.Rows.Add(codigoProd, lblProduto.Text, qtd, preco, subtotal);

                // Valor Total
                lblTotalVenda.Text = total.ToString();
                Limpar();
            }
            else
            {
                MessageBox.Show("Estoque está menor que a venda", "Erro ao adicionar ao carrinho...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            tabVenda.SelectedTab = tabPage1;
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
