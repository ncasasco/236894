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
    public partial class MaterialsView : UserControl
    {
        private UserRepo userList;
        private CredentialsManager credentials;
        public MaterialsView(UserRepo newUserList, CredentialsManager newCredentials)
        {
            InitializeComponent();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateMaterial_Click(object sender, EventArgs e)
        {

        }
    }
}
