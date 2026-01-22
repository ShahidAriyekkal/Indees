namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Say Hello, " + txtName.Text + "!";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblMessage.Text = "Welcome, " + txtName.Text + "!";
            }
            else
            {
                lblMessage.Text = txtName.Text;
            }
        }
    }
}
