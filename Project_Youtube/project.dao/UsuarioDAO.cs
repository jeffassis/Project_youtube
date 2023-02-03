﻿using MySql.Data.MySqlClient;
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
    public class UsuarioDAO
    {
        // Variavel de conexao
        private readonly MySqlConnection vcon;

        // Construtor
        public UsuarioDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        #region CadastrarUsuário
        public void CadastrarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_user(nome, username, senha, status, nivel) 
                                VALUES(@nome, @username, @senha, @status, @nivel)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@nivel", obj.Nivel);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso", "Sucesso ao cadastrar",MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex);
                
            }
        }
        #endregion

        #region EditarUsuário
        public void EditarUsuario(Usuario obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_user SET nome=@nome, username=@username, senha=@senha, status=@status, 
                                nivel=@nivel WHERE id_user=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@nivel", obj.Nivel);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário atualizado com sucesso", "Sucesso ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar usuário: " + ex);
            }
        }
        #endregion

        #region ExcluirUsuário
        public void ExcluirUsuario(string id)
        {
            try
            {
                string sql = "DELETE FROM tb_user WHERE id_user=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluido com sucesso", "Sucesso ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir usuário: " + ex);
            }
        }
        #endregion

        #region ListarUsuario
        public DataTable ListarUsuario()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT id_user, nome, username, status, nivel, senha FROM tb_user";
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
                MessageBox.Show("Erro ao executar a lista: " + ex);
                return null;
            }
        }
        #endregion
    

        public DataTable ListarUsuarioPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_user WHERE nome LIKE @nome";
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

        public DataTable VerificarUsername(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT username FROM tb_user WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@username", username);
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
                MessageBox.Show("Erro ao verificar Username: " + ex);
                return null;
            }
        }

        public DataTable EfetuarLogin(string username, string senha)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_user WHERE username=@username AND senha=@senha";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@senha", senha);
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
                MessageBox.Show("Erro ao efetuar login: " + ex);
                return null;
            }
        }
    }
}
