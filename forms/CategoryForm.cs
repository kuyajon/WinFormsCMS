using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCMS.forms
{
    public partial class CategoryForm : Form
    {
        private CategoryRepository categoryRepository = RepositoryFactory.getCategoryRepository();
        private ContentType selectedContentType;
        public CategoryForm()
        {
            InitializeComponent();
            MdiParent = Mainform.INSTANCE;
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            Dock = DockStyle.Fill;
            foreach (var contentType in Enum.GetValues(typeof(ContentType)))
            {
                cbContentType.Items.Add(contentType);
            }
            cbContentType.SelectedIndex = 0;
        }

        private void RefreshGrid()
        {
            if (selectedContentType != null)
            {
                dgCategories.DataSource = categoryRepository.GetCategoriesByContentType(selectedContentType);

            }
        }

        private void cbContentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContentType.SelectedItem != null)
            {
                selectedContentType = (ContentType)cbContentType.SelectedItem;
                RefreshGrid();
                ClearForm();
            }
        }

        private void ClearForm()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbSlug.Text = "";
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0 && tbSlug.Text.Length == 0)
            {
                tbSlug.Text = StringUtil.ConvertToPermalink(tbName.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedContentType != null)
            {
                Category cat = new Category();
                if (tbID.Text.Length > 0)
                {
                    cat.Id = Convert.ToInt64(tbID.Text);
                }
                cat.Name = tbName.Text;
                cat.Slug = tbSlug.Text;
                cat.ContentType = selectedContentType;

                if (cat.Id == 0)
                {
                    tbID.Text = categoryRepository.Insert(cat).Id.ToString();
                }
                else
                {
                    categoryRepository.Update(cat);
                }
                RefreshGrid();
            }
        }

        private void dgCategories_Click(object sender, EventArgs e)
        {
            if (dgCategories.CurrentRow != null)
            {
                Category cat = dgCategories.CurrentRow.DataBoundItem as Category;
                if (cat != null)
                {
                    tbID.Text = cat.Id.ToString();
                    tbName.Text = cat.Name;
                    tbSlug.Text = cat.Slug;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0)
            {
                long Id = Convert.ToInt64(tbID.Text);
                categoryRepository.DeleteById(Id);
                ClearForm();
                RefreshGrid();
            }
        }
    }
}
