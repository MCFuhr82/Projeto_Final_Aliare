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
    public partial class Frm_ConsultarTurma : Form
    {
        public Frm_ConsultarTurma()
        {
            InitializeComponent();
            PopularComboBoxCurso();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopularComboBoxCurso()
        {
            var cursos = CursoController.SelecionarCursos();

            foreach (var curso in cursos)
            {
                Cbox_SelecionarCurso.Items.Add(curso.Nome);
            }
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var form = new Frm_CadastrarTurma();
            form.ShowDialog();
        }
    }
}
