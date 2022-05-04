using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_simple_POO
{
    public partial class NameForm : Form
    {
        private Form1 caller;

        public NameForm(Form1 callerForm)
        {
            InitializeComponent();
            caller = callerForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            lblErrorText.Visible = false;
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                caller.playerNameTxtBox = txtName.Text.Trim();
                Player player1 = new Player(caller.playerNameTxtBox);
                this.Close();
            }
            else
            {
                lblErrorText.Visible = true;
                lblErrorText.Text = "No se ha dado un nombre, intenta de nuevo";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lstPlayerRace.Items
        }
    }
}
