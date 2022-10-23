using System.Globalization;
using TeDoen;

namespace Opdracht4
{
    public partial class Form1 : Form
    {

        FouteRij<TEDoen> fouteRij = new FouteRij<TEDoen>();

        public Form1()
        {
            InitializeComponent();
        }

        private void cbTijd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTijd.Checked)
            {
                tbTijd.Visible = true;
                lblTijd.Visible = true;
            }
            else
            {
                tbTijd.Visible = false;
                lblTijd.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTijd.Checked = true;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DateTime? tijd;

            if(tbTijd.Text == "")
            {
                TEDoen fouteRijObject = new TEDoen(null, tbTitel.Text, tbInfo.Text);
                fouteRij.Toevoegen(fouteRijObject);
            }
            else
            {
                tijd = DateTime.ParseExact(tbTitel.Text, "dd / MM / yyyy", new CultureInfo("en-US"));
            }


            TEDoen nieuweObject = new TEDoen(tijd, tbTitel.Text, tbInfo.Text);
        }
    }
}