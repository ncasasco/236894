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
        private MaterialRepo materialList;
        public MaterialsView(UserRepo newUserList, CredentialsManager newCredentials)
        {
            InitializeComponent();
            userList = newUserList;
            credentials = newCredentials;
            materialList = new MaterialRepo();
        }

        private void btnCreateMaterial_Click(object sender, EventArgs e)
        {
            Material newMaterial = new Material();

            try
            {
                newMaterial.Owner = credentials.UserLogged.Username;
                newMaterial.Name = txtMaterialName.Text;
                newMaterial.RedMaterial = Convert.ToInt32(txtRedMaterial.Text);
                newMaterial.GreenMaterial = Convert.ToInt32(txtGreenMaterial.Text);
                newMaterial.BlueMaterial = Convert.ToInt32(txtBlueMaterial.Text);

                materialList.Add(newMaterial);
                ListViewItem item = new ListViewItem(txtMaterialName.Text);
                lstMaterials.Items.Add(item);

                txtMaterialName.Clear();
                txtRedMaterial.Clear();
                txtGreenMaterial.Clear();
                txtBlueMaterial.Clear();

                MessageBox.Show("Material created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentNullException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BusinessLogicException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (lstMaterials.Items.Count > 0 && lstMaterials.SelectedItems != null)
            {
                string auxName = lstMaterials.SelectedItems[0].Text;
                materialList.Remove(auxName);
                lstMaterials.Items.Remove(lstMaterials.SelectedItems[0]);
                MessageBox.Show("Material removed", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
