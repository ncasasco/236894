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
    public partial class EventCreateView : UserControl
    {
        private EventRepo eventList;
        public EventCreateView()
        {
            InitializeComponent();
            eventList = new EventRepo();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = openFileDialog1.FileName;
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

            try
            {
                
                MessageBox.Show("Schedule added", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Event evt = new Event();

            try
            {
                evt.Name = txtName.Text;
                evt.Description = txtDescription.Text;
                evt.Adress = txtAdress.Text;
                evt.isOnline = checkAdress.Checked;
                evt.PicturePath = txtURL.Text;
                evt.category = cmbCategory.Text;
                evt.schedule.Add(new Tuple<DateTime, DateTime>(dateTimePicker1.Value, dateTimePicker2.Value));
                Ticket tick = new Ticket();
                tick.name = txtTicketName.Text;
                tick.price = int.Parse(txtPrice.Text);
                tick.quantity = int.Parse(txtQuantity.Text);
                evt.tickets.Add(tick);
                eventList.Add(evt);
                MessageBox.Show("Évent Created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
