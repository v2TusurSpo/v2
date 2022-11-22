using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс поиска фигуры. 
    /// </summary>
    public partial class FindForm : Form
    {
        /// <summary>
        /// Делегат передачи информации на форму.
        /// </summary>
        private readonly FindDelegate _findDelegate = null;

        /// <summary>
        /// Конструктор класса FindForm.
        /// </summary>
        /// <param name="findDelegate">Делегат поиска.</param>
        public FindForm(FindDelegate findDelegate)
        {
            InitializeComponent();
            _findDelegate = findDelegate;
            VolumeTextBox.KeyPress += ValidateField.ValidateTextBox;
            FigureNameComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие поиска информации.
        /// </summary>
        private void FindFigureButton_Click(object sender, EventArgs e)
        {
            Hide();
            FigureBase figure = new FigureBase
            {
                FigureName = FigureNameComboBox.Text.ToString()
            };
            if (!string.IsNullOrEmpty(VolumeTextBox.Text))
                figure.FigureVolume = Convert
                        .ToDouble(VolumeTextBox.Text);
            else
                figure.FigureVolume = null;
            _findDelegate(figure);
        }

        /// <summary>
        /// Событие выбора названия фигуры из выпадающего списка.
        /// </summary>
        private void FigureNameComboBox_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            VolumeTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Событие при нажатии на кнопку ОТМЕНА.
        /// </summary>
        private void ExitFindButton_Click(object sender, EventArgs e)
        {
            Hide();
            FigureBase figure = new FigureBase
            {
                FigureName = "",
                FigureVolume = null
            };
            _findDelegate(figure);
        }
    }
}