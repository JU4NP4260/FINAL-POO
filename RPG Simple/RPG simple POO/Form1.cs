namespace RPG_simple_POO
{
    public partial class Form1 : Form
    {
        public string playerNameTxtBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            NameForm nameForm = new NameForm(this);

            nameForm.ShowDialog();
        }
    }
}