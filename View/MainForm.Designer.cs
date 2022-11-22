
namespace View
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FigureVolumeDataGridView = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FigureVolumeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FigureVolumeDataGridView
            // 
            this.FigureVolumeDataGridView.AllowUserToAddRows = false;
            this.FigureVolumeDataGridView.AllowUserToDeleteRows = false;
            this.FigureVolumeDataGridView.AllowUserToResizeColumns = false;
            this.FigureVolumeDataGridView.AllowUserToResizeRows = false;
            this.FigureVolumeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FigureVolumeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FigureVolumeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FigureVolumeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FigureVolumeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1});
            this.FigureVolumeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.FigureVolumeDataGridView.MultiSelect = false;
            this.FigureVolumeDataGridView.Name = "FigureVolumeDataGridView";
            this.FigureVolumeDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FigureVolumeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FigureVolumeDataGridView.RowHeadersVisible = false;
            this.FigureVolumeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FigureVolumeDataGridView.Size = new System.Drawing.Size(600, 269);
            this.FigureVolumeDataGridView.TabIndex = 3;
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column0.DataPropertyName = "FigureName";
            this.Column0.HeaderText = "Фигура";
            this.Column0.MaxInputLength = 25;
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "FigureVolume";
            this.Column1.HeaderText = "Объём";
            this.Column1.MaxInputLength = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 287);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 41);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(114, 287);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(96, 41);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(216, 287);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 41);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(318, 287);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(96, 41);
            this.DelButton.TabIndex = 7;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(420, 287);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(96, 41);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(520, 287);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 41);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 337);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FigureVolumeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 376);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 376);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вариант 2";
            ((System.ComponentModel.ISupportInitialize)(this.FigureVolumeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FigureVolumeDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

