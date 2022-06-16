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
        Event evt = new Event();
        public EventCreateView()
        {
            InitializeComponent();
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
                
                evt.schedule.Add(new Tuple<DateTime, DateTime>(dateTimePicker1.Value, dateTimePicker2.Value));
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
    }
}
