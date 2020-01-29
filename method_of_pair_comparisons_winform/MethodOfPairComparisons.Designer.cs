namespace method_of_pair_comparisons_winform
{
    partial class MethodOfPairComparisons
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvComparisonMatrix = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnEndExpertsPoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartExpertsPoll = new System.Windows.Forms.Button();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.condition = new System.Windows.Forms.GroupBox();
            this.tbTextCondition = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.inputGroup.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonMatrix)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.outputGroup.SuspendLayout();
            this.condition.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(739, 27);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.cleanToolStripMenuItem.Text = "Очистить";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.CleanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.panelGrid);
            this.inputGroup.Controls.Add(this.panelButtons);
            this.inputGroup.Location = new System.Drawing.Point(12, 30);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(715, 255);
            this.inputGroup.TabIndex = 1;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Ввод данных";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.dgvComparisonMatrix);
            this.panelGrid.Location = new System.Drawing.Point(205, 19);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(504, 230);
            this.panelGrid.TabIndex = 1;
            // 
            // dgvComparisonMatrix
            // 
            this.dgvComparisonMatrix.AllowUserToAddRows = false;
            this.dgvComparisonMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComparisonMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparisonMatrix.ColumnHeadersVisible = false;
            this.dgvComparisonMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComparisonMatrix.Enabled = false;
            this.dgvComparisonMatrix.Location = new System.Drawing.Point(0, 0);
            this.dgvComparisonMatrix.Name = "dgvComparisonMatrix";
            this.dgvComparisonMatrix.Size = new System.Drawing.Size(504, 230);
            this.dgvComparisonMatrix.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnEndExpertsPoll);
            this.panelButtons.Controls.Add(this.btnReset);
            this.panelButtons.Controls.Add(this.btnStartExpertsPoll);
            this.panelButtons.Location = new System.Drawing.Point(6, 19);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(193, 230);
            this.panelButtons.TabIndex = 0;
            // 
            // btnEndExpertsPoll
            // 
            this.btnEndExpertsPoll.Enabled = false;
            this.btnEndExpertsPoll.Location = new System.Drawing.Point(5, 177);
            this.btnEndExpertsPoll.Name = "btnEndExpertsPoll";
            this.btnEndExpertsPoll.Size = new System.Drawing.Size(185, 50);
            this.btnEndExpertsPoll.TabIndex = 2;
            this.btnEndExpertsPoll.Text = "Окончить опрос";
            this.btnEndExpertsPoll.UseVisualStyleBackColor = true;
            this.btnEndExpertsPoll.Click += new System.EventHandler(this.BtnEndExpertsPoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(5, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(185, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Начать сначала";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnStartExpertsPoll
            // 
            this.btnStartExpertsPoll.Location = new System.Drawing.Point(5, 65);
            this.btnStartExpertsPoll.Name = "btnStartExpertsPoll";
            this.btnStartExpertsPoll.Size = new System.Drawing.Size(185, 50);
            this.btnStartExpertsPoll.TabIndex = 0;
            this.btnStartExpertsPoll.Text = "Начать опрос";
            this.btnStartExpertsPoll.UseVisualStyleBackColor = true;
            this.btnStartExpertsPoll.Click += new System.EventHandler(this.BtnStartExpertsPoll_Click);
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.tbOutput);
            this.outputGroup.Location = new System.Drawing.Point(12, 291);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(441, 208);
            this.outputGroup.TabIndex = 2;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Вывод данных";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(6, 19);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(429, 183);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.WordWrap = false;
            // 
            // condition
            // 
            this.condition.Controls.Add(this.tbTextCondition);
            this.condition.Location = new System.Drawing.Point(459, 291);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(268, 208);
            this.condition.TabIndex = 2;
            this.condition.TabStop = false;
            this.condition.Text = "Условие";
            // 
            // tbTextCondition
            // 
            this.tbTextCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTextCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTextCondition.Location = new System.Drawing.Point(3, 16);
            this.tbTextCondition.Multiline = true;
            this.tbTextCondition.Name = "tbTextCondition";
            this.tbTextCondition.ReadOnly = true;
            this.tbTextCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextCondition.Size = new System.Drawing.Size(262, 189);
            this.tbTextCondition.TabIndex = 5;
            // 
            // MethodOfPairComparisons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 511);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MethodOfPairComparisons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод парных сравнений";
            this.Load += new System.EventHandler(this.MethodOfPairComparisons_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.inputGroup.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonMatrix)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.outputGroup.ResumeLayout(false);
            this.outputGroup.PerformLayout();
            this.condition.ResumeLayout(false);
            this.condition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.GroupBox condition;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnEndExpertsPoll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStartExpertsPoll;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.DataGridView dgvComparisonMatrix;
        private System.Windows.Forms.TextBox tbTextCondition;
    }
}

