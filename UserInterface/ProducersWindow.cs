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
using DataAccess;

namespace UserInterface
{
    public partial class ProducersWindow : Form
    {
        public static ProducerRepo producerList;
        public static Credentials credentialsAux;
        public static CredentialsManager credentialsHandler;

        public ProducersWindow()
        {
            InitializeComponent();
            panelLogin.Show();
            if (producerList == null)
                producerList = new ProducerRepo();
            if(credentialsAux == null)
                credentialsAux = new Credentials();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producer newProducer = new Producer();

            try
            {
                newProducer.Mail = textBoxMail.Text;
                newProducer.Password = textBoxPassword.Text;
                newProducer.FirstName = textBoxName.Text;
                newProducer.LastName = textBoxLastName.Text;
                credentialsHandler = new CredentialsManager(producerList, newProducer);
                MessageBox.Show("Producer created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (Context db = new Context())
                {
                    var producer = new Producer
                    {
                        Mail = newProducer.Mail,
                        Password = newProducer.Password,
                        FirstName = newProducer.FirstName,
                        LastName = newProducer.LastName,
                    };

                    db.Producers.Add(producer);
                    db.SaveChanges();
                }

                panelLogin.Show();
                panelRegister.Hide();
                ClearTextBoxes();
                btnBack.Enabled = true;
            }
            catch(BusinessLogicException exc1)
            {
                MessageBox.Show(exc1.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentNullException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                credentialsAux.Password = textBoxPasswordLogin.Text;
                credentialsAux.Mail = textBoxProducerLogin.Text;

                credentialsHandler.Login(credentialsAux);

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            panelRegister.Hide();
            panelLogin.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            panelLogin.Hide();
            panelRegister.Show();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuWindow newWindow = new MenuWindow();
            newWindow.Show();
        }
    }
}
