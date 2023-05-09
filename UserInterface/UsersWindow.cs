using System;
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
        public UsersWindow()
        {
            InitializeComponent();
            panelLogin.Show();
            panelRegister.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            try
            {
                this.Hide();
                MenuWindow newWindow = new MenuWindow();
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
    }
}
