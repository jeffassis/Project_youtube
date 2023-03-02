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
    public class ProdutoDAO
    {
        private readonly MySqlConnection vcon;

        public ProdutoDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_produto(nome, descricao, valor_venda, data, fornecedor_id) 
                                              VALUES (@nome, @descricao, @valor_venda, curDate(), @fornecedor_id)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);                
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);                
                cmd.Parameters.AddWithValue("@valor_venda", obj.ValorVenda);                
                cmd.Parameters.AddWithValue("@fornecedor_id", obj.FornecedorId);                
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

        public void EditarProduto(Produto obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_produto SET nome=@nome, descricao=@descricao, 
                                                      fornecedor_id=@fornecedor_id, valor_venda=@valor_venda WHERE id_produto=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@fornecedor_id", obj.FornecedorId);
                cmd.Parameters.AddWithValue("@valor_venda", obj.ValorVenda);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!!", "Dados atualizados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex);
            }
        }

        public DataTable ListarProduto()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT tbp.id_produto, tbp.nome, tbp.descricao, tbf.nome, tbp.estoque, 
                                        tbp.valor_venda, tbp.valor_compra, tbp.data, tbp.fornecedor_id
                                FROM tb_produto AS tbp
                                INNER JOIN tb_fornecedor AS tbf ON tbf.id_fornecedor = tbp.fornecedor_id
                                ORDER BY tbp.nome";
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

        public void ExcluirProduto(string id)
        {
            try
            {
                string sql = @"DELETE FROM tb_produto WHERE id_produto=@id";
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

        public DataTable VerificarProduto(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT nome FROM tb_produto WHERE nome=@nome";
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

        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT tbp.id_produto, tbp.nome, tbp.descricao, tbf.nome, tbp.estoque, 
                                        tbp.valor_venda, tbp.valor_compra, tbp.data, tbp.fornecedor_id
                                FROM tb_produto AS tbp
                                INNER JOIN tb_fornecedor AS tbf ON tbf.id_fornecedor = tbp.fornecedor_id
                                WHERE tbp.nome like @nome
                                ORDER BY tbp.nome";
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
                MessageBox.Show("Erro ao listar dados: " + ex);
                return null;
            }
        }
    }
}
