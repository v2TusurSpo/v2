
namespace View
{
    partial class AddForm
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
            this.Temp3Label = new System.Windows.Forms.Label();
            this.Temp3TextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RandomValueButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Temp2TextBox = new System.Windows.Forms.TextBox();
            this.Temp1TextBox = new System.Windows.Forms.TextBox();
            this.FigureNameComboBox = new System.Windows.Forms.ComboBox();
            this.Temp2Label = new System.Windows.Forms.Label();
            this.FigureNameLabel = new System.Windows.Forms.Label();
            this.Temp1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parametr3Label
            // 
            this.Temp3Label.AutoSize = true;
            this.Temp3Label.Location = new System.Drawing.Point(12, 106);
            this.Temp3Label.Name = "Parametr3Label";
            this.Temp3Label.Size = new System.Drawing.Size(66, 13);
            this.Temp3Label.TabIndex = 28;
            this.Temp3Label.Text = "Temp3Label";
            // 
            // Temp3TextBox
            // 
            this.Temp3TextBox.Location = new System.Drawing.Point(129, 103);
            this.Temp3TextBox.MaxLength = 10;
            this.Temp3TextBox.Name = "Temp3TextBox";
            this.Temp3TextBox.Size = new System.Drawing.Size(171, 20);
            this.Temp3TextBox.TabIndex = 27;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(225, 133);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomValueButton
            // 
            this.RandomValueButton.Location = new System.Drawing.Point(93, 133);
            this.RandomValueButton.Name = "RandomValueButton";
            this.RandomValueButton.Size = new System.Drawing.Size(126, 37);
            this.RandomValueButton.TabIndex = 25;
            this.RandomValueButton.Text = "Случайное значение";
            this.RandomValueButton.UseVisualStyleBackColor = true;
            this.RandomValueButton.Click += new System.EventHandler(this.RandomValueButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 133);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 37);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Ok";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Temp2TextBox
            // 
            this.Temp2TextBox.Location = new System.Drawing.Point(129, 77);
            this.Temp2TextBox.MaxLength = 10;
            this.Temp2TextBox.Name = "Temp2TextBox";
            this.Temp2TextBox.Size = new System.Drawing.Size(171, 20);
            this.Temp2TextBox.TabIndex = 23;
            // 
            // Temp1TextBox
            // 
            this.Temp1TextBox.Location = new System.Drawing.Point(129, 50);
            this.Temp1TextBox.MaxLength = 10;
            this.Temp1TextBox.Name = "Temp1TextBox";
            this.Temp1TextBox.Size = new System.Drawing.Size(171, 20);
            this.Temp1TextBox.TabIndex = 22;
            // 
            // FigureNameComboBox
            // 
            this.FigureNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureNameComboBox.FormattingEnabled = true;
            this.FigureNameComboBox.Items.AddRange(new object[] {
            "Шар",
            "Параллелепипед",
            "Пирамида"});
            this.FigureNameComboBox.Location = new System.Drawing.Point(129, 20);
            this.FigureNameComboBox.Name = "FigureNameComboBox";
            this.FigureNameComboBox.Size = new System.Drawing.Size(171, 21);
            this.FigureNameComboBox.TabIndex = 21;
            this.FigureNameComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureNameComboBox_SelectedIndexChanged);
            // 
            // Parametr2Label
            // 
            this.Temp2Label.AutoSize = true;
            this.Temp2Label.Location = new System.Drawing.Point(12, 77);
            this.Temp2Label.Name = "Parametr2Label";
            this.Temp2Label.Size = new System.Drawing.Size(66, 13);
            this.Temp2Label.TabIndex = 18;
            this.Temp2Label.Text = "Temp2Label";
            // 
            // FigureNameLabel
            // 
            this.FigureNameLabel.AutoSize = true;
            this.FigureNameLabel.Location = new System.Drawing.Point(12, 23);
            this.FigureNameLabel.Name = "FigureNameLabel";
            this.FigureNameLabel.Size = new System.Drawing.Size(98, 13);
            this.FigureNameLabel.TabIndex = 19;
            this.FigureNameLabel.Text = "Название фигуры";
            // 
            // Parametr1Label
            // 
            this.Temp1Label.AutoSize = true;
            this.Temp1Label.Location = new System.Drawing.Point(12, 50);
            this.Temp1Label.Name = "Parametr1Label";
            this.Temp1Label.Size = new System.Drawing.Size(66, 13);
            this.Temp1Label.TabIndex = 20;
            this.Temp1Label.Text = "Temp1Label";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 174);
            this.Controls.Add(this.Temp3Label);
            this.Controls.Add(this.Temp3TextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RandomValueButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Temp2TextBox);
            this.Controls.Add(this.Temp1TextBox);
            this.Controls.Add(this.FigureNameComboBox);
            this.Controls.Add(this.Temp2Label);
            this.Controls.Add(this.FigureNameLabel);
            this.Controls.Add(this.Temp1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 213);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(328, 213);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление информации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temp3Label;
        private System.Windows.Forms.TextBox Temp3TextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RandomValueButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Temp2TextBox;
        private System.Windows.Forms.TextBox Temp1TextBox;
        private System.Windows.Forms.ComboBox FigureNameComboBox;
        private System.Windows.Forms.Label Temp2Label;
        private System.Windows.Forms.Label FigureNameLabel;
        private System.Windows.Forms.Label Temp1Label;
    }
}