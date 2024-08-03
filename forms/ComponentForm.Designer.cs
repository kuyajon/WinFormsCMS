namespace WinFormsCMS.forms
{
    partial class ComponentForm
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
            dgComponents = new DataGridView();
            tbName = new TextBox();
            btnAdd = new Button();
            rtbContent = new RichTextBox();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgComponents).BeginInit();
            SuspendLayout();
            // 
            // dgComponents
            // 
            dgComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgComponents.Location = new Point(32, 55);
            dgComponents.MultiSelect = false;
            dgComponents.Name = "dgComponents";
            dgComponents.RowHeadersWidth = 62;
            dgComponents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgComponents.Size = new Size(1261, 324);
            dgComponents.TabIndex = 1;
            dgComponents.SelectionChanged += dgComponents_SelectionChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(32, 18);
            tbName.Name = "tbName";
            tbName.Size = new Size(379, 31);
            tbName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(437, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rtbContent
            // 
            rtbContent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbContent.Location = new Point(32, 398);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(2055, 908);
            rtbContent.TabIndex = 17;
            rtbContent.Text = "";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(572, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1975, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ComponentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2132, 1318);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(rtbContent);
            Controls.Add(btnAdd);
            Controls.Add(tbName);
            Controls.Add(dgComponents);
            Name = "ComponentForm";
            Text = "ComponentForm";
            ((System.ComponentModel.ISupportInitialize)dgComponents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgComponents;
        private TextBox tbName;
        private Button btnAdd;
        private RichTextBox rtbContent;
        private Button btnDelete;
        private Button btnSave;
    }
}