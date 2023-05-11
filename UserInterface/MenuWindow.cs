using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MenuWindow : Form
    {
        private UserRepo userList;
        private CredentialsManager credentials;

        public MenuWindow(UserRepo newUserList, CredentialsManager newCredentials)
        {
            InitializeComponent();
            userList = newUserList;
            credentials = newCredentials;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            credentials.Logout();
            UsersWindow newWindow = new UsersWindow();
            newWindow.Show();
        }
        
        private void btnFigures_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl figures = new FiguresView();
            mainPanel.Controls.Add(figures);
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl materials = new MaterialsView();
            mainPanel.Controls.Add(materials);
        }

        private void btnModels_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl models = new ModelsView();
            mainPanel.Controls.Add(models);
        }

        private void btnScenes_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl scenes = new ScenesView();
            mainPanel.Controls.Add(scenes);
        }
    }
}
