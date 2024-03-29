namespace WinFormsCMS
{
    partial class PageListForm
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
            ((System.ComponentModel.ISupportInitialize)dgPages).BeginInit();
            SuspendLayout();
            // 
            // dgPages
            // 
            dgPages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPages.Location = new Point(12, 99);
            dgPages.Name = "dgPages";
            dgPages.RowHeadersWidth = 62;
            dgPages.Size = new Size(1416, 477);
            dgPages.TabIndex = 0;
            // 
            // PageListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 1145);
            Controls.Add(dgPages);
            Name = "PageListForm";
            Text = "FrmPageList";
            ((System.ComponentModel.ISupportInitialize)dgPages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPages;
    }
}