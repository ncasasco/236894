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
        
        public MenuWindow()
        {
            InitializeComponent();
            eventsView1.Hide();
            eventCreateView1.Hide();
            if(ProducersWindow.credentialsHandler == null)
                    btnCreateEvt.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
                this.Hide();
                ProducersWindow newWindow = new ProducersWindow();
                newWindow.Show();
        }

        private void eventsView1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventsView1.Show();
            eventCreateView1.Hide();
        }

        private void eventCreatorView_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEvt_Click(object sender, EventArgs e)
        {
            eventsView1.Hide();
            eventCreateView1.Show();
        }
    }
}
