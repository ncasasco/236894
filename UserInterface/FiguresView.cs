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
    public partial class FiguresView : UserControl
    {
        private UserRepo userList;
        private CredentialsManager credentials;
        private FigureRepo figureList;

        public FiguresView(UserRepo newUserList, CredentialsManager newCredentials)
        {
            InitializeComponent();
            userList = newUserList;
            credentials = newCredentials;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure newFigure = new Figure();

            try
            {
                newFigure.Owner = credentials.UserLogged.Username;
                newFigure.Name = txtFigureName.Text;
                newFigure.Radius = Convert.ToDouble(txtRadiusFigure.Text);

                figureList.Add(newFigure);
                ListViewItem item = new ListViewItem(txtFigureName.Text);
                item.SubItems.Add(txtRadiusFigure.Text);
                lstFigures.Items.Add(item);

                txtFigureName.Clear();
                txtRadiusFigure.Clear();

                MessageBox.Show("Figure created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnDeleteFigure_Click(object sender, EventArgs e)
        {
            if (lstFigures.Items.Count > 0 && lstFigures.SelectedItems != null)
            {
                string auxName = lstFigures.SelectedItems[0].Text;
                figureList.Remove(auxName);
                lstFigures.Items.Remove(lstFigures.SelectedItems[0]);
                MessageBox.Show("Figure removed", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
