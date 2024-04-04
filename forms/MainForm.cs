using WinFormsCMS.forms;

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
            ToolStripMenuItem catMenu = new ToolStripMenuItem($"Categories");
            menuStrip1.Items.Add(catMenu);
            catMenu.Click += CategoryItem_Click;
        }

        private void ContentListItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContentType contentType = (ContentType)menuItem.Tag;
            ContentListForm childForm = ContentListForm.getInstance(contentType);
            childForm.Show();
            childForm.BringToFront();
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            CategoryForm childForm = new CategoryForm();
            childForm.Show();
            childForm.BringToFront();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
