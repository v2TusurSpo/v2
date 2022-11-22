
namespace View
{
    partial class FindForm
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
            this.FigureNameComboBox = new System.Windows.Forms.ComboBox();
            this.ExitFindButton = new System.Windows.Forms.Button();
            this.FindFigureButton = new System.Windows.Forms.Button();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.FigureNameLabel = new System.Windows.Forms.Label();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FigureNameComboBox
            // 
            this.FigureNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureNameComboBox.FormattingEnabled = true;
            this.FigureNameComboBox.Items.AddRange(new object[] {
            "Шар",
            "Параллелепипед",
            "Пирамида"});
            this.FigureNameComboBox.Location = new System.Drawing.Point(124, 10);
            this.FigureNameComboBox.Name = "FigureNameComboBox";
            this.FigureNameComboBox.Size = new System.Drawing.Size(129, 21);
            this.FigureNameComboBox.TabIndex = 21;
            this.FigureNameComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureNameComboBox_SelectedIndexChanged);
            // 
            // ExitFindButton
            // 
            this.ExitFindButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitFindButton.Location = new System.Drawing.Point(178, 63);
            this.ExitFindButton.Name = "ExitFindButton";
            this.ExitFindButton.Size = new System.Drawing.Size(75, 23);
            this.ExitFindButton.TabIndex = 20;
            this.ExitFindButton.Text = "Отмена";
            this.ExitFindButton.UseVisualStyleBackColor = true;
            this.ExitFindButton.Click += new System.EventHandler(this.ExitFindButton_Click);
            // 
            // FindFigureButton
            // 
            this.FindFigureButton.Location = new System.Drawing.Point(12, 63);
            this.FindFigureButton.Name = "FindFigureButton";
            this.FindFigureButton.Size = new System.Drawing.Size(75, 23);
            this.FindFigureButton.TabIndex = 19;
            this.FindFigureButton.Text = "Найти";
            this.FindFigureButton.UseVisualStyleBackColor = true;
            this.FindFigureButton.Click += new System.EventHandler(this.FindFigureButton_Click);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(12, 37);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(83, 13);
            this.VolumeLabel.TabIndex = 16;
            this.VolumeLabel.Text = "Объём фигуры";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FigureNameLabel
            // 
            this.FigureNameLabel.AutoSize = true;
            this.FigureNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FigureNameLabel.Name = "FigureNameLabel";
            this.FigureNameLabel.Size = new System.Drawing.Size(98, 13);
            this.FigureNameLabel.TabIndex = 17;
            this.FigureNameLabel.Text = "Название фигуры";
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(124, 37);
            this.VolumeTextBox.MaxLength = 10;
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(129, 20);
            this.VolumeTextBox.TabIndex = 18;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 97);
            this.Controls.Add(this.FigureNameComboBox);
            this.Controls.Add(this.ExitFindButton);
            this.Controls.Add(this.FindFigureButton);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.FigureNameLabel);
            this.Controls.Add(this.VolumeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(286, 136);
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск информации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureNameComboBox;
        private System.Windows.Forms.Button ExitFindButton;
        private System.Windows.Forms.Button FindFigureButton;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label FigureNameLabel;
        private System.Windows.Forms.TextBox VolumeTextBox;
    }
}