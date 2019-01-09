using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIntegrationInformatique
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(textBoxLogin.Text)
            {
                case "Admin" :
                    if (textBoxMdp.Text == "mdpa")
                    {
                        goLogin("Admin");
                    }
                    else error.Visible = true;
                    break;
                case "Tech1":
                    if (textBoxMdp.Text == "mdpt1")
                    {
                        goLogin("Tech1");
                    }
                    else error.Visible = true;
                    break;
                case "Tech2":
                    if (textBoxMdp.Text == "mdpt2")
                    {
                        goLogin("Tech2");
                    }
                    else error.Visible = true;
                    break;
                case "User1":
                    if (textBoxMdp.Text == "mdpu1")
                    {
                        goLogin("User1");
                    }
                    else error.Visible = true;
                    break;
                case "User2":
                    if (textBoxMdp.Text == "mdpu2")
                    {
                        goLogin("User2");
                    }
                    else error.Visible = true;
                    break;
                case "User3":
                    if (textBoxMdp.Text == "mdpu3")
                    {
                        goLogin("User3");
                    }
                    else error.Visible = true;
                    break;
                default:
                    error.Visible = true;
                    break;
            }
        }
        private void goLogin(string user)
        {
            Program.utilisateur = user;
            Program.loginOk = true;
            this.Close();
        }
    }
}
