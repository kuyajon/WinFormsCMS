namespace WinFormsCMS.forms
{
    partial class SectionForm
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
            cbSection = new ComboBox();
            label5 = new Label();
            rtbContent = new RichTextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(184, 21);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(428, 46);
            cbSection.TabIndex = 15;
            cbSection.SelectedIndexChanged += cbSection_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 24);
            label5.Name = "label5";
            label5.Size = new Size(108, 38);
            label5.TabIndex = 14;
            label5.Text = "Section";
            // 
            // rtbContent
            // 
            rtbContent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbContent.Location = new Point(26, 95);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(2055, 1125);
            rtbContent.TabIndex = 16;
            rtbContent.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1957, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 45);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2110, 1259);
            Controls.Add(btnSave);
            Controls.Add(rtbContent);
            Controls.Add(cbSection);
            Controls.Add(label5);
            Name = "SectionForm";
            Text = "SectionForm";
            Load += SectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSection;
        private Label label5;
        private RichTextBox rtbContent;
        private Button btnSave;
    }
}