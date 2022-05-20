using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoFinalAliare
{
    public partial class Frm_Login : Form
    {
        
        public Frm_Login()
        {
            InitializeComponent();

        }

        private void Btn_Conectar_Click(object sender, EventArgs e)
        {
            if (Txb_Login.Text == "Admin" && Txb_Password.Text == "1234")
            {
                MessageBox.Show("Bem vindo ao sistema!");
                this.Close();
                var nt = new Thread(novoFormulario);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
        }

        private void novoFormulario()
        {
            Application.Run(new Frm_Menu());
        }
    }
}
