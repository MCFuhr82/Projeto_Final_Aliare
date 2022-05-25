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
    public partial class Frm_Matricular : Form
    {
        public Frm_Matricular()
        {
            InitializeComponent();
        }
        
        public Frm_Matricular(String matricula, String nome)
        {
            InitializeComponent();
            Txb_Matricula.Text = matricula;
            Txb_Nome.Text = nome;
            PopularComboBox();
        }

        private void PopularComboBox()
        {

            //toDo
            var cursos = CursoController.lerCursos();

            foreach (var curso in cursos)
            {
                Cbox_SelecionaCurso.Items.Add(curso.Nome);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Update Aluno
        }
    }
}
