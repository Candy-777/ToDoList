using UI.Enums;
using System.Threading;
using System.Windows.Forms;
using UI.Http_Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class MainForm : Form
    {

        private bool Drag = false;
        private Point StartPoint = new Point(0, 0);
        private Service _service;
        private AddForm _addForm;
        private ChangeForm _changeForm;
        public MainForm()
        {
            InitializeComponent();
            _service = new Service();
            RefreshGrid();
            _addForm = new AddForm(_service, RefreshGrid);
            _changeForm = new ChangeForm(_service, RefreshGrid);


        }
        private async void RefreshGrid()
        {
            var list = await _service.GetAllTasks();            
            DataGrid.Rows.Clear();
            if (list.Count() == 0) return;
            foreach (var item in list)
            {
                DataGrid.Rows.Add(item.Id, item.Title, item.Description, item.Priority, item.LastUpdateTime, item.DeadLine);
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void Hide_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DataGrid_CellContentClick(object sender, EventArgs e)
        {

        }


        private async void Del_Button_Click(object sender, EventArgs e)
        {
            if (_changeForm.Visible) return;
            if (DataGrid.CurrentRow != null) // Проверяем, есть ли выделенная строка
            {
                
                await _service.DeleteTask(Convert.ToInt32(DataGrid.CurrentRow.Cells[0].Value));
                RefreshGrid();

            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            if (_addForm.Visible) return;
            _addForm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private async void Edit_Button_Click(object sender, EventArgs e)
        {
            if (_changeForm.Visible) return;
            if (DataGrid.CurrentRow == null) // Проверяем, есть ли выделенная строка
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }
            int rowIndex = DataGrid.CurrentRow.Index;
            TaskItem task = await _service.GetTask(Convert.ToInt32(DataGrid.CurrentRow.Cells[0].Value));
            _changeForm.index = rowIndex + 1;
            _changeForm.Title_TextBox.Text = task.Title;
            _changeForm.Description_TextBox.Text = task.Description;
            _changeForm.comboBox1.SelectedItem = task.Priority;
            _changeForm.dateTimePicker1.Value = task.DeadLine.Date;

            _changeForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
