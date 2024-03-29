namespace WinFormsCMS
{
    public partial class Mainform : Form
    {
        public static Mainform INSTANCE;
        public Mainform()
        {
            InitializeComponent();
            INSTANCE = this;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageListForm.getInstance().Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
