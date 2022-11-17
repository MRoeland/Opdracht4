using System.Globalization;
using TeDoen;

namespace Opdracht4
{
    public partial class Form1 : Form
    {

        FouteRij<TEDoen> Taken = new FouteRij<TEDoen>();
        bool bMeedelenText = true;
        bool bMeedelenMsgBox = false;
        bool bGeluid = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void cbTijd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTijd.Checked)
            {
                dtPickerTijd.Visible = true;
                // Setting the minimum date of the DateTimePicker
                dtPickerTijd.MinDate = DateTime.Now.AddMinutes(5); //.new DateTime(1753, 1, 1);
                dtPickerTijd.Value = DateTime.Now.AddMinutes(5);
            }
            else
            {
                dtPickerTijd.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTijd.Checked = true;
            // Setting the minimum date of the DateTimePicker
            dtPickerTijd.Format = DateTimePickerFormat.Time;
            dtPickerTijd.ShowUpDown = true;
            dtPickerTijd.MinDate = DateTime.Now.AddMinutes(5); //.new DateTime(1753, 1, 1);
            btnMeedelenText.BackColor = Color.Green;
            btnMeedelenBox.BackColor = Color.Red;
            btnGeluid.BackColor = Color.Red;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DateTime? tijd = null;

            string[] informatie = new string[1];
            //Array.Resize(ref informatie, informatie.Length + 1);
            informatie[informatie.Length - 1] = tbInfo.Text;

            if (cbTijd.Checked)
                tijd = dtPickerTijd.Value;

            TEDoen nieuweObject = new TEDoen(tijd, tbTitel.Text, informatie);
            Taken.Toevoegen(nieuweObject);

            ListViewItem newItem = new ListViewItem();
            newItem.Tag = nieuweObject;
            newItem.Text = nieuweObject.ToString();
            lvTaken.Items.Add(newItem);

            tbTitel.Text = "";
            tbInfo.Text = "";
            dtPickerTijd.MinDate = DateTime.Now.AddMinutes(5);
        }

        private void tbMededelingen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaskFinished_Click(object sender, EventArgs e)
        {
            /*if (lvTaken.SelectedItems.Count > 0)
            {
                TEDoen selTaak = (TEDoen)lvTaken.SelectedItems[0].Tag;

                lvTaken.SelectedItems[0].Remove();

                for (int i = lvTaken.Items.Count - 1; i >= 0; i--)
                {
                    TEDoen itemTaak = (TEDoen)lvTaken.Items[i].Tag;
                    if (itemTaak != null && itemTaak == selTaak)
                    {
                        lvTaken.Items[i].Remove();
                        break;
                    }
                }
                Taken.Verwijderen();
            }*/

            TEDoen? taak = Taken.HuidigElement();
            if (taak != null)
            {
                for (int i = lvTaken.Items.Count - 1; i >= 0; i--)
                {
                    TEDoen itemTaak = (TEDoen)lvTaken.Items[i].Tag;
                    if (itemTaak != null && itemTaak == taak)
                    {
                        lvTaken.Items[i].Remove();
                        break;
                    }
                }
                Taken.Verwijderen();
            }
        }

        private void btnNextTask_Click(object sender, EventArgs e)
        {
            Taken.Volgende();
        }

        private void btnPutTaskBehind_Click(object sender, EventArgs e)
        {
            Taken.ZetAchteraan();
        }

        private void btnMeedelenText_Click(object sender, EventArgs e)
        {
            bMeedelenText = !bMeedelenText;
            if (!bMeedelenText && !bMeedelenMsgBox)
                btnMeedelenBox_Click(sender, e);
            if (bMeedelenText)
                btnMeedelenText.BackColor = Color.Green;
            else
                btnMeedelenText.BackColor = Color.Red;
        }

        private void btnMeedelenBox_Click(object sender, EventArgs e)
        {
            bMeedelenMsgBox = !bMeedelenMsgBox;
            if (!bMeedelenMsgBox && !bMeedelenText)
                btnMeedelenText_Click(sender, e);

            if (bMeedelenMsgBox)
                btnMeedelenBox.BackColor = Color.Green;
            else
                btnMeedelenBox.BackColor = Color.Red;
        }

        private void btnGeluid_Click(object sender, EventArgs e)
        {
            bGeluid = !bGeluid;

            if (bGeluid)
                btnGeluid.BackColor = Color.Green;
            else
                btnGeluid.BackColor = Color.Red;
        }
    }
}