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
    public partial class ModelsView : UserControl
    {
        private UserRepo userList;
        private CredentialsManager credentials;
        public ModelsView(UserRepo newUserList, CredentialsManager newCredentials)
        {
            InitializeComponent();
        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {

        }
    }
}
