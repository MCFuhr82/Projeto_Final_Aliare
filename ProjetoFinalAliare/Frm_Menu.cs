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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Aluno_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarAluno();
            form.ShowDialog();
        }

        private void Btn_Curso_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarCurso();
            form.ShowDialog();
        }

        private void Icon_Aluno_MouseEnter(object sender, EventArgs e)
        {
            Icon_Aluno.BackColor = Color.Black;
        }

        private void Icon_Aluno_MouseLeave(object sender, EventArgs e)
        {
            Icon_Aluno.BackColor = Color.Gainsboro;
        }

        private void Icon_Curso_MouseEnter(object sender, EventArgs e)
        {
            Icon_Curso.BackColor = Color.Black;
        }

        private void Icon_Curso_MouseLeave(object sender, EventArgs e)
        {
            Icon_Curso.BackColor = Color.Gainsboro;
        }

        private void Icon_Ajuda_MouseEnter(object sender, EventArgs e)
        {
            Icon_Ajuda.BackColor = Color.Black;
        }

        private void Icon_Ajuda_MouseLeave(object sender, EventArgs e)
        {
            Icon_Ajuda.BackColor = Color.Gainsboro;
        }

        private void Icon_Sobre_MouseEnter(object sender, EventArgs e)
        {
            Icon_Sobre.BackColor = Color.Black;
        }

        private void Icon_Sobre_MouseLeave(object sender, EventArgs e)
        {
            Icon_Sobre.BackColor = Color.Gainsboro;
        }

        private void Icon_Sobre_Click(object sender, EventArgs e)
        {
            var form = new Frm_Sobre();
            form.ShowDialog();
        }

        private void Icon_Ajuda_Click(object sender, EventArgs e)
        {
            var form = new Frm_Contato();
            form.ShowDialog();
        }

        private void Icon_Aluno_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarAluno();
            form.ShowDialog();
        }

        private void Icon_Curso_Click(object sender, EventArgs e)
        {
            var form = new Frm_ConsultarCurso();
            form.ShowDialog();
        }
    }
}
