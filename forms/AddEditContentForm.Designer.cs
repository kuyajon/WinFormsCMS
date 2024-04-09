namespace WinFormsCMS.forms
{
    partial class AddEditContentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbID = new TextBox();
            tbTitle = new TextBox();
            label2 = new Label();
            tbPermalink = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rtbBody = new RichTextBox();
            rtbPreview = new DG.MiniHTMLTextBox.MiniHTMLTextBox();
            btnSave = new Button();
            label5 = new Label();
            cbStatus = new ComboBox();
            lbCategories = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 38);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tbID
            // 
            tbID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbID.Location = new Point(206, 21);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(372, 45);
            tbID.TabIndex = 1;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(206, 72);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(1245, 45);
            tbTitle.TabIndex = 3;
            tbTitle.Leave += tbTitle_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(70, 38);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // tbPermalink
            // 
            tbPermalink.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPermalink.Location = new Point(206, 123);
            tbPermalink.Name = "tbPermalink";
            tbPermalink.Size = new Size(1245, 45);
            tbPermalink.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 130);
            label3.Name = "label3";
            label3.Size = new Size(139, 38);
            label3.TabIndex = 4;
            label3.Text = "Permalink";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 194);
            label4.Name = "label4";
            label4.Size = new Size(79, 38);
            label4.TabIndex = 6;
            label4.Text = "Body";
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(495, 194);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(956, 958);
            rtbBody.TabIndex = 7;
            rtbBody.Text = "";
            rtbBody.TextChanged += rtbBody_TextChanged;
            // 
            // rtbPreview
            // 
            rtbPreview.IllegalPatterns = new string[]
    {
    "<script.*?>",
    "<\\w+\\s+.*?(j|java|vb|ecma)script:.*?>",
    "<\\w+(\\s+|\\s+.*?\\s+)on\\w+\\s*=.+?>",
    "</?input.*?>"
    };
            rtbPreview.Location = new Point(1499, 194);
            rtbPreview.Margin = new Padding(5, 6, 5, 6);
            rtbPreview.Name = "rtbPreview";
            rtbPreview.Padding = new Padding(2, 2, 2, 2);
            rtbPreview.Size = new Size(1300, 939);
            rtbPreview.TabIndex = 8;
            rtbPreview.Text = null;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1339, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 45);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(767, 24);
            label5.Name = "label5";
            label5.Size = new Size(91, 38);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(876, 12);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(428, 46);
            cbStatus.TabIndex = 11;
            // 
            // lbCategories
            // 
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 25;
            lbCategories.Location = new Point(28, 258);
            lbCategories.Name = "lbCategories";
            lbCategories.SelectionMode = SelectionMode.MultiSimple;
            lbCategories.Size = new Size(440, 1004);
            lbCategories.TabIndex = 12;
            // 
            // AddEditContentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2839, 1303);
            Controls.Add(lbCategories);
            Controls.Add(cbStatus);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(rtbPreview);
            Controls.Add(rtbBody);
            Controls.Add(label4);
            Controls.Add(tbPermalink);
            Controls.Add(label3);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(label1);
            Name = "AddEditContentForm";
            Text = "AddEditContentForm";
            FormClosing += AddEditContentForm_FormClosing;
            Load += AddEditContentForm_Load;
            Resize += AddEditContentForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbID;
        private TextBox tbTitle;
        private Label label2;
        private TextBox tbPermalink;
        private Label label3;
        private Label label4;
        private RichTextBox rtbBody;
        private DG.MiniHTMLTextBox.MiniHTMLTextBox rtbPreview;
        private Button btnSave;
        private Label label5;
        private ComboBox cbStatus;
        private ListBox lbCategories;
    }
}