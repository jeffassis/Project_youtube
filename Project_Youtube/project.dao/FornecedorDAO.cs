using MySql.Data.MySqlClient;
using Project_Youtube.project.connect;
using Project_Youtube.project.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Youtube.project.dao
{
    public class FornecedorDAO
    {
        private readonly MySqlConnection vcon;

        public FornecedorDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_fornecedor(nome, telefone, endereco) VALUES (@nome, @telefone, @endereco)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Adicionado com sucesso!!", "Dados inseridos...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex);                
            }
        }

        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT id_fornecedor, nome, endereco, telefone FROM tb_fornecedor";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex);
                return null;
            }
        }
    }
}
