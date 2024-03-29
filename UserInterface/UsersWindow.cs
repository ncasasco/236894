﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class UsersWindow : Form
    {
        public static UserRepo userList;
        public static Credentials credentialsAux;
        public static CredentialsManager credentialsHandler;
        public UsersWindow()
        {
            InitializeComponent();
            panelLogin.Show();
            panelRegister.Hide();

            if (userList == null)
                userList = new UserRepo();
            if (credentialsAux == null)
            {
                credentialsAux = new Credentials();
                User admin = new User();
                admin.Username = "nico";
                admin.Password = "Contra9";
                credentialsHandler = new CredentialsManager(userList, admin);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            try
            {
                newUser.Username = textBoxUsername.Text;
                newUser.Password = textBoxPassword.Text;
                newUser.RegistrationDate = DateTime.Now;
                if (textBoxPassword.Text == textBoxConfirm.Text)
                {
                    credentialsHandler = new CredentialsManager(userList, newUser);
                    MessageBox.Show("User created", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    panelLogin.Show();
                    panelRegister.Hide();
                    ClearTextBoxes();
                    label1.Hide();
                    label7.Hide();
                }
                else
                {
                    label7.Show();
                }
            }
            catch (BusinessLogicException exc1)
            {
                MessageBox.Show(exc1.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            label9.Hide();
            label10.Hide();
            try
            {
                if (textBoxUserLogin.Text == "")
                {
                    label9.Show();
                }
                if (textBoxPasswordLogin.Text == "")
                {
                    label10.Show();
                }
                credentialsAux.Username = textBoxUserLogin.Text;
                credentialsAux.Password = textBoxPasswordLogin.Text;
                credentialsHandler.Login(credentialsAux);

                this.Hide();
                MenuWindow newWindow = new MenuWindow(userList, credentialsHandler);
                newWindow.Show();

            }
            catch (BusinessLogicException exc)
            {
                ClearTextBoxes();
                MessageBox.Show(exc.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            panelLogin.Hide();
            panelRegister.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearTextBoxes();
            panelRegister.Hide();
            panelLogin.Show();
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            label1.Hide();
            if (!textBoxPassword.Text.Any(Char.IsDigit) || !textBoxPassword.Text.Any(Char.IsUpper))
            {
                label1.Show();
            }
        }
    }
}
