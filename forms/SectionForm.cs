using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCMS.forms
{
    public partial class SectionForm : Form
    {
        private static SectionForm INSTANCE = null;

        private SectionRepository sectionRepository = RepositoryFactory.getSectionRepository();
        private SectionForm()
        {
            InitializeComponent();
            MdiParent = Mainform.INSTANCE;
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            Dock = DockStyle.Fill;

        }
        public static SectionForm getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new SectionForm();
            }
            return INSTANCE;
        }
        private void SectionForm_Load(object sender, EventArgs e)
        {
            string fileContent = File.ReadAllText(Config.ThemeFile);
            string pattern = @"\[(.*?)\]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(fileContent);
            //string[] extractedTexts = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                cbSection.Items.Add(matches[i].Groups[1].Value);
                //extractedTexts[i] = matches[i].Groups[1].Value;
            }

            //return extractedTexts;
        }

        private void cbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbContent.Text = "";
            Section section = sectionRepository.GetSectionByContentKey(cbSection.Text);
            if (section != null)
            {
                rtbContent.Text = section.ContentBody;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Section section = sectionRepository.GetSectionByContentKey(cbSection.Text);
            if (section == null)
            {
                section = new Section();
                section.ContentKey = cbSection.Text;
                section.ContentBody = rtbContent.Text;
                sectionRepository.Insert(section);
            }
            else
            {
                sectionRepository.Update(section);
            }
            MessageBox.Show("Saved");
        }
    }
}
