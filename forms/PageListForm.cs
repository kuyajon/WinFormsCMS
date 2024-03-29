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

namespace WinFormsCMS
{
    public partial class PageListForm : Form
    {
        private static PageListForm INSTANCE = null;

        private ContentRepository contentRepository = RepositoryFactory.getContentRepository();
        private PageListForm()
        {
            InitializeComponent();
            //dgPages.Dock = DockStyle.Fill;
            dgPages.AutoGenerateColumns = false;
            dgPages.Columns.Add("Title", "The Title");
            dgPages.Columns["Title"].DataPropertyName = "Title";
            Refresh();
        }

        private void Refresh()
        {
            dgPages.DataSource = contentRepository.GetAll();
        }

        public static PageListForm getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new PageListForm();
                INSTANCE.MdiParent = Mainform.INSTANCE;
                INSTANCE.FormBorderStyle = FormBorderStyle.None;
                INSTANCE.TopLevel = false;
                INSTANCE.Dock = DockStyle.Fill;

            }
            return INSTANCE;
        }
    }
}
