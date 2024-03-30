namespace WinFormsCMS
{
    public partial class Mainform : Form
    {
        public static Mainform INSTANCE;
        public Mainform()
        {
            InitializeComponent();
            INSTANCE = this;

            foreach (ContentType contentType in Enum.GetValues(typeof(ContentType)))
            {
                ToolStripMenuItem contentTypeMenu = new ToolStripMenuItem($"{contentType}");
                menuStrip1.Items.Add(contentTypeMenu);
                contentTypeMenu.Tag = contentType;
                contentTypeMenu.Click += ContentListItem_Click;
            }
        }

        private void ContentListItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContentType contentType = (ContentType)menuItem.Tag;
            ContentListForm childForm = ContentListForm.getInstance(contentType);
            childForm.Show();
            childForm.BringToFront();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
