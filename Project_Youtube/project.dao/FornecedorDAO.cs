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

        #region CadastrarFornecedor
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
        #endregion

        #region EditarFornecedor
        public void EditarFornecedor(Fornecedor obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedor SET nome=@nome, telefone=@telefone, endereco=@endereco WHERE id_fornecedor=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizar com sucesso!!", "Dados atualizados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex);
            }
        }
        #endregion

        #region ExcluirFornecedor
        public void ExcluirFornecedor(string id)
        {
            try
            {
                string sql = @"DELETE FROM tb_fornecedor WHERE id_fornecedor=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);                
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso!!", "Remover dados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex);
            }
        }
        #endregion

        #region LitarFornecedor
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
        #endregion


        public DataTable ListarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT id_fornecedor, nome, endereco, telefone FROM tb_fornecedor WHERE nome LIKE @nome";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", nome);
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
                MessageBox.Show("Erro ao executar a pesquisa: " + ex);
                return null;
            }
        }

        public DataTable VerificarFornecedor(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT nome FROM tb_fornecedor WHERE nome=@nome";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", nome);
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
                MessageBox.Show("Erro ao verificar: " + ex);
                return null;
            }
        }

    }
}
