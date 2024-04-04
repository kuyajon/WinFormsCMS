namespace WinFormsCMS.forms
{
    partial class CategoryForm
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
            cbContentType = new ComboBox();
            label5 = new Label();
            dgCategories = new DataGridView();
            tbSlug = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbID = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            SuspendLayout();
            // 
            // cbContentType
            // 
            cbContentType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbContentType.FormattingEnabled = true;
            cbContentType.Location = new Point(191, 12);
            cbContentType.Name = "cbContentType";
            cbContentType.Size = new Size(428, 46);
            cbContentType.TabIndex = 13;
            cbContentType.SelectedIndexChanged += cbContentType_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 24);
            label5.Name = "label5";
            label5.Size = new Size(75, 38);
            label5.TabIndex = 12;
            label5.Text = "Type";
            // 
            // dgCategories
            // 
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Location = new Point(16, 90);
            dgCategories.Name = "dgCategories";
            dgCategories.RowHeadersWidth = 62;
            dgCategories.Size = new Size(972, 1134);
            dgCategories.TabIndex = 14;
            dgCategories.Click += dgCategories_Click;
            // 
            // tbSlug
            // 
            tbSlug.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSlug.Location = new Point(1197, 182);
            tbSlug.Name = "tbSlug";
            tbSlug.Size = new Size(814, 45);
            tbSlug.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1019, 189);
            label3.Name = "label3";
            label3.Size = new Size(71, 38);
            label3.TabIndex = 19;
            label3.Text = "Slug";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(1197, 131);
            tbName.Name = "tbName";
            tbName.Size = new Size(814, 45);
            tbName.TabIndex = 18;
            tbName.Leave += tbName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1019, 138);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // tbID
            // 
            tbID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbID.Location = new Point(1197, 80);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(814, 45);
            tbID.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1019, 87);
            label1.Name = "label1";
            label1.Size = new Size(44, 38);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1899, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 45);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1019, 242);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 45);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1197, 242);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 45);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2071, 1257);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(tbSlug);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(label1);
            Controls.Add(dgCategories);
            Controls.Add(cbContentType);
            Controls.Add(label5);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbContentType;
        private Label label5;
        private DataGridView dgCategories;
        private TextBox tbSlug;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private TextBox tbID;
        private Label label1;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
    }
}