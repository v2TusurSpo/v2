#define Debug
using Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    ///  Класс для добавления информации.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Коллекция элементов с фигурами. 
        /// </summary>
        private readonly List<FigureBase> _figuresBase;

        /// <summary>
        /// Делегат обновления данных в FigureVolumeDataGridView.
        /// </summary>
        private readonly UpdateDataGridInformation _updateMainInformation;

        /// <summary>
        /// Конструктор класса AddForm.
        /// </summary>
        /// <param name="figuresBase">Объект с информацией о фигуре.</param>
        /// <param name="updateMainInformation">Делегат обновления 
        /// информации.</param>
        public AddForm(List<FigureBase> figuresBase,
            UpdateDataGridInformation updateMainInformation)
        {
            InitializeComponent();
            _figuresBase = figuresBase;
            _updateMainInformation = updateMainInformation;
            FigureNameComboBox.SelectedIndex = 0;
#if Release
            this.RandomValueButton.Visible = false;
#elif Debug
            this.RandomValueButton.Visible = true;
#endif
        }

        /// <summary>
        /// Событие выбора информации из выпадающего меню.
        /// </summary>
        private void FigureNameComboBox_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            Temp1TextBox.Text = string.Empty;
            Temp2TextBox.Text = string.Empty;
            Temp3TextBox.Text = string.Empty;

            switch (FigureNameComboBox.SelectedIndex)
            {
                case 0:
                    Temp1Label.Visible = true;
                    Temp2Label.Visible = false;
                    Temp3Label.Visible = false;

                    Temp1Label.Text = "Радиус";

                    Temp1TextBox.Visible = true;
                    Temp2TextBox.Visible = false;
                    Temp3TextBox.Visible = false;

                    break;
                case 1:
                    Temp1Label.Visible = true;
                    Temp2Label.Visible = true;
                    Temp3Label.Visible = true;

                    Temp1Label.Text = "Сторона А";
                    Temp2Label.Text = "Сторона B";
                    Temp3Label.Text = "Сторона C";


                    Temp1TextBox.Visible = true;
                    Temp2TextBox.Visible = true;
                    Temp3TextBox.Visible = true;

                    break;
                case 2:
                    Temp1Label.Visible = true;
                    Temp2Label.Visible = true;
                    Temp3Label.Visible = false;

                    Temp1Label.Text = "Площадь основания";
                    Temp2Label.Text = "Высота";

                    Temp1TextBox.Visible = true;
                    Temp2TextBox.Visible = true;
                    Temp3TextBox.Visible = false;

                    break;
            }
        }

        /// <summary>
        /// Событие при загрузке формы AddForm.
        /// </summary>
        private void AddForm_Load(object sender, EventArgs e)
        {
            FigureNameComboBox_SelectedIndexChanged(sender, e);

            Temp1TextBox.KeyPress += ValidateField.ValidateTextBox;
            Temp2TextBox.KeyPress += ValidateField.ValidateTextBox;
            Temp2TextBox.KeyPress += ValidateField.ValidateTextBox;
        }

        /// <summary>
        /// Событие при нажатии на кнопку ОТМЕНА.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (_figuresBase.Count > 0)
                _updateMainInformation();
        }

        /// <summary>
        /// Событие при нажатии на кнопку OK
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                switch (FigureNameComboBox.SelectedIndex)
                {
                    case 0:
                        if (Temp1TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "радиус шара.\n";
                        }
                        if (message == string.Empty)
                        {
                            BaseFigure ball = new BallFigure(Convert
                                .ToDouble(Temp1TextBox.Text));
                            AddFigure(ball);
                        }
                        break;
                    case 1:
                        if (Temp1TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "сторону А параллелепипеда.\n";
                        }
                        if (Temp2TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "сторону B параллелепипеда.\n";
                        }
                        if (Temp3TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "сторону C параллелепипеда.\n";
                        }
                        if (message == string.Empty)
                        {
                            BaseFigure parallelepiped =
                                new ParallelepipedFigure(Convert
                                .ToDouble(Temp1TextBox.Text),
                                Convert.ToDouble(Temp2TextBox.Text),
                                Convert.ToDouble(Temp3TextBox.Text));
                            AddFigure(parallelepiped);
                        }
                        break;
                    case 2:
                        if (Temp1TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "площадь основания пирамиды.\n";
                        }
                        if (Temp2TextBox.Text == string.Empty)
                        {
                            message += "Необходимо ввести " +
                                "высоту пирамиды.\n";
                        }
                        if (message == string.Empty)
                        {
                            BaseFigure pyramid =
                                new PyramidFigure(Convert
                                .ToDouble(Temp1TextBox.Text),
                                Convert.ToDouble(Temp2TextBox.Text));
                            AddFigure(pyramid);
                        }
                        break;
                }
                if (message != string.Empty)
                {
                    MessageBox.Show(message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод добавления данных.
        /// </summary>
        /// <param name="baseFigure">Объект с добавляемой фигурой.</param>
        private void AddFigure(BaseFigure baseFigure)
        {
            _figuresBase.Add(new FigureBase
            {
                FigureName = FigureNameComboBox.SelectedItem.ToString(),
                FigureVolume = (double?)decimal.Round(Convert
                .ToDecimal(baseFigure.FigureVolume),
                3, MidpointRounding.ToEven)
            });
        }

        /// <summary>
        /// Событие при нажатии на кнопку СЛУЧАЙНОЕ ЗНАЧЕНИЕ.
        /// </summary>
        private void RandomValueButton_Click(object sender, EventArgs e)
        {
            Random randomValue = new Random();
            int numberComboBox = randomValue.Next(0, 3);
            FigureNameComboBox.SelectedIndex = numberComboBox;
            Thread.Sleep(35);
            switch (FigureNameComboBox.SelectedIndex)
            {
                case 0:
                    Temp1TextBox.Text = randomValue.Next(BallFigure
                        .minRadius + 1, BallFigure.maxRadius)
                        .ToString();
                    break;
                case 1:
                    Temp1TextBox.Text = randomValue
                        .Next(ParallelepipedFigure.minSide + 1,
                        ParallelepipedFigure.maxSide)
                        .ToString();
                    Temp2TextBox.Text = randomValue
                        .Next(ParallelepipedFigure.minSide + 1,
                        ParallelepipedFigure.maxSide)
                        .ToString();
                    Temp3TextBox.Text = randomValue
                        .Next(ParallelepipedFigure.minSide + 1,
                        ParallelepipedFigure.maxSide)
                        .ToString();
                    break;
                case 2:
                    Temp1TextBox.Text = randomValue
                        .Next(PyramidFigure.minBaseArea + 1,
                        PyramidFigure.maxBaseArea)
                        .ToString();
                    Temp2TextBox.Text = randomValue
                        .Next(PyramidFigure.minHeigth + 1,
                        PyramidFigure.maxHeigth)
                        .ToString();
                    break;
            }
        }
    }
}