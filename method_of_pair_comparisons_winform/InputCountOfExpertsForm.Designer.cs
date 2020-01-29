namespace method_of_pair_comparisons_winform
{
    partial class InputCountOfExpertsForm
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
            this.btnSetCountOfExperts = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbCountOfExperts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetCountOfExperts
            // 
            this.btnSetCountOfExperts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetCountOfExperts.Location = new System.Drawing.Point(66, 103);
            this.btnSetCountOfExperts.Name = "btnSetCountOfExperts";
            this.btnSetCountOfExperts.Size = new System.Drawing.Size(80, 30);
            this.btnSetCountOfExperts.TabIndex = 1;
            this.btnSetCountOfExperts.Text = "Ок";
            this.btnSetCountOfExperts.UseVisualStyleBackColor = true;
            this.btnSetCountOfExperts.Click += new System.EventHandler(this.BtnSetCountOfExperts_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCansel.Location = new System.Drawing.Point(173, 103);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(80, 30);
            this.btnCansel.TabIndex = 3;
            this.btnCansel.Text = "Отмена";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.BtnCansel_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(63, 28);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(190, 15);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Введите количество экспертов";
            // 
            // tbCountOfExperts
            // 
            this.tbCountOfExperts.Location = new System.Drawing.Point(66, 62);
            this.tbCountOfExperts.Name = "tbCountOfExperts";
            this.tbCountOfExperts.Size = new System.Drawing.Size(187, 20);
            this.tbCountOfExperts.TabIndex = 0;
            // 
            // InputCountOfExpertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 158);
            this.Controls.Add(this.tbCountOfExperts);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSetCountOfExperts);
            this.Name = "InputCountOfExpertsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод количества экспертов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetCountOfExperts;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox tbCountOfExperts;
    }
}