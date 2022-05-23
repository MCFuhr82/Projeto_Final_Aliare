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
            var frm_aluno = new Frm_Cadastrar();
            frm_aluno.ShowDialog();
        }
    }
}
