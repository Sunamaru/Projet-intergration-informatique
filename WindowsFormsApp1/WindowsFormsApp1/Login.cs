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
            gogo();
        }

        private void gogo()
        {
            switch (textBoxLogin.Text)
            {
                case "Admin":
                    if (textBoxMdp.Text == "mdpa")
                    {
                        goLogin("Admin");
                    }
                    else
                    {
                        error.Visible = true;
                        textBoxMdp.Text = "";
                    }
                    break;
                case "Tech1":
                    if (textBoxMdp.Text == "mdpt1")
                    {
                        goLogin("Tech1");
                    }
                    else
                    {
                        error.Visible = true;
                        textBoxMdp.Text = "";
                    }
                    break;
                case "Tech2":
                    if (textBoxMdp.Text == "mdpt2")
                    {
                        goLogin("Tech2");
                    }
                    else
                    {
                        error.Visible = true;
                        textBoxMdp.Text = "";
                    }
                    break;
                case "User1":
                    if (textBoxMdp.Text == "mdpu1")
                    {
                        goLogin("User1");
                    }
                    else
                    {
                        error.Visible = true;
                        textBoxMdp.Text = "";
                    }
                    break;
                case "User2":
                    if (textBoxMdp.Text == "mdpu2")
                    {
                        goLogin("User2");
                    }
                    else
                    {
                        error.Visible = true;
                        textBoxMdp.Text = "";
                    }
                    break;
                case "User3":
                    if (textBoxMdp.Text == "mdpu3")
                    {
                        goLogin("User3");
                    }
                    else
                    {
                        error.Visible = true;
                        textBoxMdp.Text = "";
                    }
                    break;
                default:
                    error.Visible = true;
                    textBoxMdp.Text = "";                  
                    break;
            }
        }

        private void goLogin(string user)
        {
            Program.Data.utilisateur = user;
            Program.Data.loginOk = true;
            this.Close();
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) gogo();
        }

        private void textBoxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) gogo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
