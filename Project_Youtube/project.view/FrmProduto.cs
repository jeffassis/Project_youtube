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
    public partial class FrmProduto : Form
    {
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

            // Colocar valores centralizados na celula
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formatar coluna para moeda
            Grid.Columns[5].DefaultCellStyle.Format = "C2";
            Grid.Columns[6].DefaultCellStyle.Format = "C2";

            // Define tamanho da coluna
            Grid.Columns[3].Width = 130;
        }

        private void Listar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProduto();
            
            FormatarDG();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
