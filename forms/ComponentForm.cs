using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCMS.forms
{
    public partial class ComponentForm : Form
    {
        private static ComponentForm INSTANCE = null;

        private ComponentRepository componentRepository = RepositoryFactory.getComponentRepository();

        private ComponentForm()
        {
            InitializeComponent();
            MdiParent = Mainform.INSTANCE;
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            Dock = DockStyle.Fill;
            InitGrid();
            RefreshGrid();
        }

        private void InitGrid()
        {
            dgComponents.AutoGenerateColumns = false;
            dgComponents.Columns.Add("ComponentKey", "ComponentKey");
            dgComponents.Columns["ComponentKey"].DataPropertyName = "ComponentKey";
            dgComponents.Columns["ComponentKey"].Width = 800;
        }

        private void RefreshGrid()
        {
            IEnumerable<Component> components = componentRepository.GetAll();
            dgComponents.DataSource = components;
        }

        public static ComponentForm getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new ComponentForm();
            }
            return INSTANCE;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            if (name.Length > 0)
            {
                Component co = new Component();
                co.ComponentKey = name;
                co.ComponentBody = "";
                componentRepository.Insert(co);
                tbName.Clear();
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgComponents.SelectedRows.Count>0)
            {
                String key = dgComponents.SelectedRows[0].Cells[0].Value.ToString();
                Component co = componentRepository.GetComponentByComponentKey(key);
                if (co != null && MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    componentRepository.Delete(co);
                    RefreshGrid();
                }
            }
        }
    }
}
