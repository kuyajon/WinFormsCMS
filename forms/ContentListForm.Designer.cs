namespace WinFormsCMS
{
    partial class ContentListForm
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
            dgPages = new DataGridView();
            labelTitle = new Label();
            rbDraft = new RadioButton();
            rbPublished = new RadioButton();
            rbTrash = new RadioButton();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPages).BeginInit();
            SuspendLayout();
            // 
            // dgPages
            // 
            dgPages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPages.Location = new Point(12, 89);
            dgPages.Name = "dgPages";
            dgPages.RowHeadersWidth = 62;
            dgPages.Size = new Size(1585, 670);
            dgPages.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(91, 38);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "label1";
            // 
            // rbDraft
            // 
            rbDraft.AutoSize = true;
            rbDraft.Checked = true;
            rbDraft.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDraft.Location = new Point(203, 18);
            rbDraft.Name = "rbDraft";
            rbDraft.Size = new Size(104, 42);
            rbDraft.TabIndex = 2;
            rbDraft.TabStop = true;
            rbDraft.Text = "Draft";
            rbDraft.UseVisualStyleBackColor = true;
            rbDraft.CheckedChanged += rbDraft_CheckedChanged;
            // 
            // rbPublished
            // 
            rbPublished.AutoSize = true;
            rbPublished.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPublished.Location = new Point(338, 18);
            rbPublished.Name = "rbPublished";
            rbPublished.Size = new Size(163, 42);
            rbPublished.TabIndex = 3;
            rbPublished.Text = "Published";
            rbPublished.UseVisualStyleBackColor = true;
            rbPublished.CheckedChanged += rbDraft_CheckedChanged;
            // 
            // rbTrash
            // 
            rbTrash.AutoSize = true;
            rbTrash.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTrash.Location = new Point(529, 19);
            rbTrash.Name = "rbTrash";
            rbTrash.Size = new Size(107, 42);
            rbTrash.TabIndex = 4;
            rbTrash.Text = "Trash";
            rbTrash.UseVisualStyleBackColor = true;
            rbTrash.CheckedChanged += rbDraft_CheckedChanged;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(738, 14);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 50);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // ContentListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 1145);
            Controls.Add(btnNew);
            Controls.Add(rbTrash);
            Controls.Add(rbPublished);
            Controls.Add(rbDraft);
            Controls.Add(labelTitle);
            Controls.Add(dgPages);
            Name = "ContentListForm";
            Text = "FrmPageList";
            Load += ContentListForm_Load;
            Resize += ContentListForm_Resize;
            ((System.ComponentModel.ISupportInitialize)dgPages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPages;
        private Label labelTitle;
        private RadioButton rbDraft;
        private RadioButton rbPublished;
        private RadioButton rbTrash;
        private Button btnNew;
    }
}