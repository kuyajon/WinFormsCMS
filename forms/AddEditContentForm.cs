using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsCMS.forms
{
    public partial class AddEditContentForm : Form
    {
        private ContentListForm parent;
        private ContentRepository contentRepository = RepositoryFactory.getContentRepository();
        private CategoryRepository categoryRepository = RepositoryFactory.getCategoryRepository();
        private ContentType contentType;
        private Content content;
        public AddEditContentForm(ContentListForm parent, ContentType contentType, Content content)
        {
            InitializeComponent();
            wvPreview.EnsureCoreWebView2Async(null);

            cbStatus.DataSource = Enum.GetValues(typeof(ContentStatus));
            this.contentType = contentType;
            this.parent = parent;
            InitializeContent(content);
            lbCategories.DataSource = categoryRepository.GetCategoriesByContentType(contentType).Select(it => it.Name).ToList();
            lbCategories.SelectedItems.Clear();

            if (content != null)
            {
                List<string> selectedCategories = categoryRepository.GetCategoriesByContentId(content.Id).Select(it => it.Name).ToList();
                foreach(string item in selectedCategories)
                {
                    int index = lbCategories.Items.IndexOf(item);
                    if (index >= 0)
                    {
                        lbCategories.SetSelected(index, true);
                    }
                }
                tbCreateDate.Text = content.CreatedDate.ToString();
                tbUpdateDate.Text = content.UpdatedDate.ToString();
                if (content.PublishDate != null)
                {
                    tbPublishDate.Text = content.PublishDate.ToString();
                }
            }

            
        }
        public AddEditContentForm(ContentListForm parent, ContentType contentType) : this(parent, contentType, null)
        {
        }

        private void InitializeContent(Content content)
        {
            this.content = content;
            this.Text = $"{(content == null ? "Add" : "Edit")} {contentType}";
            if (content != null)
            {
                if (content.Id > 0)
                {
                    tbID.Text = content.Id.ToString();
                }
                cbStatus.Text = content.Status.ToString();
                tbTitle.Text = content.Title;
                tbPermalink.Text = content.Permalink;
                rtbBody.Text = content.Body;

                Thread thread = new Thread(new ThreadStart(CallRefreshPreviewAfterDelay));
                thread.Start();
            }
            else
            {
                this.content = new Content();
            }
        }

        private void CallRefreshPreviewAfterDelay()
        {
            Thread.Sleep(2000); // Wait for 2 seconds
            this.Invoke(new Action(RefreshPreview)); // Ensure it runs on the UI thread
        }

        private void AddEditContentForm_Resize(object sender, EventArgs e)
        {
            int newWidth1 = (this.ClientSize.Width / 2) - rtbBody.Location.X - 20 + 100;
            int newHeight1 = this.ClientSize.Height - 220;
            rtbBody.Size = new System.Drawing.Size(newWidth1, newHeight1);

            wvPreview.Location = new System.Drawing.Point(this.ClientSize.Width / 2 + 20 + 100, wvPreview.Location.Y);
            int newWidth2 = (this.ClientSize.Width / 2) - 40 - 100;
            int newHeight2 = this.ClientSize.Height - 220;
            wvPreview.Size = new System.Drawing.Size(newWidth2, newHeight2);
        }

        private void AddEditContentForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void rtbBody_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void RefreshPreview()
        {
            var markdown = rtbBody.Text;
            var html = MarkdownToHtml(markdown);
            wvPreview.NavigateToString(html);
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text.Length > 0 && tbPermalink.Text.Length == 0)
            {
                tbPermalink.Text = StringUtil.ConvertToPermalink(tbTitle.Text);
            }
        }

        private static string MarkdownToHtml(string markdown)
        {
            string htmlString = Markdown.ToHtml(markdown);

            string youtubePattern = @"(https:\/\/www\.youtube\.com\/watch\?v=([a-zA-Z0-9_-]+))";

            string result = Regex.Replace(htmlString, youtubePattern, m =>
            {
                string url = m.Groups[1].Value;
                string videoId = m.Groups[2].Value;
                string iframe = $"<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/{videoId}\" frameborder=\"0\" allowfullscreen style=\"display:block; margin:auto;\"></iframe>";
                return iframe;
            });
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> selectedCategories = lbCategories.SelectedItems.Cast<string>().ToList();

            content.Title = tbTitle.Text;
            content.Permalink = tbPermalink.Text;
            content.Body = rtbBody.Text;
            content.Rendered = MarkdownToHtml(rtbBody.Text);
            content.ContentType = contentType;
            content.Status = (ContentStatus)cbStatus.SelectedItem;

            if (content.Id == 0)
            {
                content = contentRepository.Insert(content, selectedCategories);
            }
            else
            {
                contentRepository.Update(content, selectedCategories);
            }
            InitializeContent(content);
        }

        private void AddEditContentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.RefreshGrid();
        }
    }
}
