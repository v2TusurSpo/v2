using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Делегат обновления информации в FigureVolumeDataGridView.
    /// </summary>
    public delegate void UpdateDataGridInformation();

    /// <summary>
    /// Делегат поиска фигуры.
    /// </summary>
    /// <param name="figureBase">Информация об искомой фигуре.</param>
    public delegate void FindDelegate(FigureBase figureBase);

    /// <summary>
    /// Класс для описания действий на главной форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _updateMainInformation = UpdateFigureVolumeDataGridView;
        }

        /// <summary>
        /// Коллекция элементов с фигурами.
        /// </summary>
        private readonly List<FigureBase> _figureBases =
            new List<FigureBase>();

        /// <summary>
        /// Делегат для обновления информации 
        /// в FigureVolumeDataGridView.
        /// </summary>
        private readonly UpdateDataGridInformation
            _updateMainInformation = null;

        /// <summary>
        /// Удаляемый объект. 
        /// </summary>
        private readonly FigureBase _delFigure = new FigureBase();

        /// <summary>
        /// Поле с путем к файлу сохранения/загрузки. 
        /// </summary>
        private string _path;

        /// <summary>
        /// Метод обновления информации в FigureVolumeDataGridView.
        /// </summary>
        internal void UpdateFigureVolumeDataGridView()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.SuspendBinding();
            bindingSource.DataSource = _figureBases;
            bindingSource.ResumeBinding();

            FigureVolumeDataGridView.DataSource = bindingSource;

            FigureVolumeDataGridView.ClearSelection();
        }

        /// <summary>
        /// Метод поиска фигуры.
        /// </summary>
        /// <param name="figureBase">Объект с информацией о фигуре.</param>
        private void FindFigure(FigureBase figureBase)
        {
            FigureVolumeDataGridView.ClearSelection();

            for (int i = 0; i < FigureVolumeDataGridView.RowCount; i++)
            {
                FigureVolumeDataGridView.Rows[i].DefaultCellStyle
                    .BackColor = System.Drawing.Color.White;
            }

            if (figureBase.FigureVolume != null)
            {
                for (int i = 0; i < FigureVolumeDataGridView.RowCount; i++)
                {
                    if ((FigureVolumeDataGridView.Rows[i].Cells[0]
                        .Value.ToString()) == figureBase.FigureName
                        .ToString() && (
                        (double)FigureVolumeDataGridView
                        .Rows[i].Cells[1].Value <= (figureBase
                        .FigureVolume + figureBase
                        .FigureVolume * 0.07)
                        &&
                        (double)FigureVolumeDataGridView
                        .Rows[i].Cells[1].Value >= (figureBase
                        .FigureVolume - figureBase
                        .FigureVolume * 0.075)
                        ))
                    {
                        FigureVolumeDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        FigureVolumeDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.White;
                    }
                }
            }
            else
            {
                for (int i = 0; i < FigureVolumeDataGridView.RowCount; i++)
                {

                    if ((FigureVolumeDataGridView.Rows[i].Cells[0]
                        .Value.ToString()) == figureBase.FigureName
                        .ToString())
                    {
                        FigureVolumeDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        FigureVolumeDataGridView.Rows[i].DefaultCellStyle
                            .BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку СОХРАНИТЬ.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            if (_path != null)
            {
                saveDialog.InitialDirectory = _path;
            }
            else
            {
                saveDialog.InitialDirectory = Application.StartupPath;
            }
            saveDialog.Filter = "3DFigure *.3df|*.3df";
            saveDialog.FilterIndex = 1;

            List<FigureBase> saveList = new List<FigureBase>();
            foreach (var figure in _figureBases)
            {
                saveList.Add(figure);
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _path = saveDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(
                    saveDialog.FileName, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, saveList);
                }
            }
            saveDialog.Dispose();
        }

        /// <summary>
        ///Событие при нажатии на кнопку ЗАГРУЗИТЬ.
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (_path != null)
            {
                openDialog.InitialDirectory = _path;
            }
            else
            {
                openDialog.InitialDirectory = Application.StartupPath;
            }
            openDialog.Filter = "3DFigure *.3df|*.3df";
            openDialog.FilterIndex = 1;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _path = openDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(
                    openDialog.FileName, FileMode.OpenOrCreate))
                {
                    try
                    {
                        List<FigureBase> openlList =
                            (List<FigureBase>)binaryFormatter
                            .Deserialize(fileStream);
                        if (_figureBases.Count > 0)
                        {
                            _figureBases.Clear();
                        }
                        foreach (var figure in openlList)
                        {
                            _figureBases.Add(figure);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка. Не удалось загрузить" +
                            " файл.\n" + exception.Message);
                    }
                }
                UpdateFigureVolumeDataGridView();
            }
            openDialog.Dispose();
        }

        /// <summary>
        /// Событие открытия формы добавления информации.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(_figureBases,
                _updateMainInformation);
            addForm.ShowDialog();
            UpdateFigureVolumeDataGridView();
            addForm.Dispose();
        }

        /// <summary>
        ///Событие при нажатии на кнопку УДАЛИТЬ.
        /// </summary>
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (FigureVolumeDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow figure in
                             this.FigureVolumeDataGridView.SelectedRows)
                {
                    _delFigure.FigureName =
                        FigureVolumeDataGridView[0, figure.Index]
                        .Value.ToString();
                    _delFigure.FigureVolume = Convert.ToDouble
                        (FigureVolumeDataGridView[1, figure.Index].Value);
                }

                foreach (var figure in _figureBases)
                {
                    if ((figure.FigureName == _delFigure.FigureName)
                        && (figure.FigureVolume == _delFigure
                        .FigureVolume))
                    {
                        _figureBases.Remove(figure);
                        break;
                    }
                }
                UpdateFigureVolumeDataGridView();
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку НАЙТИ.
        /// </summary>
        private void FindButton_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm(new FindDelegate(FindFigure));
            findForm.ShowDialog();
            findForm.Dispose();
        }

        /// <summary>
        /// Событие при нажатии на кнопку ВЫХОД.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}