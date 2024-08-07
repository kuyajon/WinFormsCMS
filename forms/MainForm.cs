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
            ToolStripMenuItem sectionMenu = new ToolStripMenuItem($"Sections");
            menuStrip1.Items.Add(sectionMenu);
            sectionMenu.Click += SectionItem_Click;

            ToolStripMenuItem componentMenu = new ToolStripMenuItem($"Components");
            menuStrip1.Items.Add(componentMenu);
            componentMenu.Click += ComponentItem_Click;

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
            CategoryForm childForm = CategoryForm.getInstance();
            childForm.Show();
            childForm.BringToFront();
        }
        private void SectionItem_Click(object sender, EventArgs e)
        {
            SectionForm childForm = SectionForm.getInstance();
            childForm.Show();
            childForm.BringToFront();
        }
        private void ComponentItem_Click(object sender, EventArgs e)
        {
            ComponentForm childForm = ComponentForm.getInstance();
            childForm.Show();
            childForm.BringToFront();
        }
        
        private void Mainform_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
