using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_EditarCurso : Form
    {
        public Frm_EditarCurso()
        {
            InitializeComponent();
        }

        public Frm_EditarCurso(string idCurso)
        {
            InitializeComponent();
            Txb_IdCurso.Text = idCurso;
            PopulateTextBoxes(int.Parse(idCurso));
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            UpdateCurso(int.Parse(Txb_IdCurso.Text));
            this.Close();
        }

        private void UpdateCurso(int idCurso)
        {
            try
            {

                using (var context = new Context())
                {
                    var curso = context.Curso.Where(x => x.Id == idCurso).FirstOrDefault();

                    var nome = Txb_Nome.Text;
                    var cargaHoraria = int.Parse(Txb_CargaHoraria.Text);
                    
                    curso.SetNome(nome);
                    curso.SetCargaHoraria(cargaHoraria);
                    
                    context.Entry(curso).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateTextBoxes(int idCurso)
        {
            using (var context = new Context())
            {
                var curso = context.Curso.Where(x => x.Id == idCurso).FirstOrDefault();

                var nome = curso.Nome;
                var cargaHoraria = curso.CargaHoraria;

                Txb_Nome.Text = nome;
                Txb_CargaHoraria.Text = cargaHoraria.ToString();
            }
        }
    }
}
