using ProjetoFinalAliare.Models;
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
            var curso = UpdateCurso(int.Parse(Txb_IdCurso.Text));
            CursoController.UpdateCurso(curso);       
            MessageBox.Show("Dados inseridos com sucesso!");
            this.Close();
        }

        private Curso UpdateCurso(int idCurso)
        {
            try
            {
                var nome = Txb_Nome.Text;
                var cargaHoraria = int.Parse(Txb_CargaHoraria.Text);
                    
                var curso = CursoController.SelectCursoPorId(idCurso);
                curso.SetNome(nome);
                curso.SetCargaHoraria(cargaHoraria);

                return curso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
