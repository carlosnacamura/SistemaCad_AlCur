using CadAlunCurs.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAlunCurs
{
    public partial class formLogin : Form
    {
        private const string nameLogin = "user";
        private const string passwordLogin = "112233";
        public formLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string name = txtNomeUser.Text;
            string password = txtSenha.Text;
            if (name == nameLogin && password == passwordLogin)
            {
                frmMain m = new frmMain();
                m.ShowDialog();
            }

        }
    }
}
