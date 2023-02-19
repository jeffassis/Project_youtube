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
            Listar();
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
            // Executa o comando para adicionar
            dao.CadastrarFornecedor(obj);
            DesabilitarCampos();
            LimparCampos();            
            tabFornecedor.SelectedTab = tabPage1;
        }
    }
}
