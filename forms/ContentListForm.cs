using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCMS.forms;

namespace WinFormsCMS
{
    public partial class ContentListForm : Form
    {
        private static Dictionary<ContentType, ContentListForm> INSTANCE_MAP = new Dictionary<ContentType, ContentListForm>();

        private ContentRepository contentRepository = RepositoryFactory.getContentRepository();

        private ContentType contentType;

        private ContentListForm()
        {
            InitializeComponent();
            dgPages.AutoGenerateColumns = false;
            dgPages.Columns.Add("ContentType", "ContentType");
            dgPages.Columns.Add("Title", "Title");
            dgPages.Columns.Add("Permalink", "Permalink");
            dgPages.Columns.Add("CreatedDate", "Created Date");
            dgPages.Columns["ContentType"].DataPropertyName = "ContentType";
            dgPages.Columns["Title"].DataPropertyName = "Title";
            dgPages.Columns["Permalink"].DataPropertyName = "Permalink";
            dgPages.Columns["CreatedDate"].DataPropertyName = "CreatedDate";
            dgPages.Columns["Title"].Width = 800;
        }

        private void Refresh()
        {
            dgPages.DataSource = contentRepository.Search(contentType, getSelectedStatus());
        }

        private ContentStatus getSelectedStatus()
        {
            if (rbDraft.Checked)
            {
                return ContentStatus.Draft;
            }
            if (rbPublished.Checked)
            {
                return ContentStatus.Published;
            }
            return ContentStatus.Trash;
        }

        public static ContentListForm getInstance(ContentType contentType)
        {
            INSTANCE_MAP.TryGetValue(contentType, out ContentListForm form);
            if (form == null)
            {
                form = new ContentListForm();
                form.MdiParent = Mainform.INSTANCE;
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.contentType = contentType;
                form.labelTitle.Text = $"{contentType}";
                INSTANCE_MAP[contentType] = form;
            }
            return form;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new AddEditContentForm(contentType).Show();
        }

        private void ContentListForm_Resize(object sender, EventArgs e)
        {
            int newWidth = this.ClientSize.Width - 40;
            int newHeight = this.ClientSize.Height - 100;

            // Set the new size for the DataGridView
            dgPages.Size = new System.Drawing.Size(newWidth, newHeight);
        }

        private void rbDraft_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ContentListForm_Load(object sender, EventArgs e)
        {
            rbDraft.Checked = true;
            Refresh();
        }
    }
}
