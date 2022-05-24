using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_CadastrarCurso : Form
    {
        public Frm_CadastrarCurso()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            InserirCurso();
        }

        public void InserirCurso()
        {
            try
            {
                var nome = Txb_Nome.Text;
                var cargaHoraria = int.Parse(Txb_CargaHoraria.Text);
                
                using (var context = new Context())
                {
                    var curso = new Curso(nome, cargaHoraria);
                    context.Curso.Add(curso);
                    context.SaveChanges();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //método para aceitar apenas números
        private void Txb_CargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
