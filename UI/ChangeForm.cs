using UI.Http_Client;
using UI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Http_Client;


namespace UI
{
    public partial class ChangeForm : Form
    {
        public int index = 0;
        bool Drag;
        Point startpoint = new Point();
        Service _service;
        Action Refresh;
        public ChangeForm(Service service, Action action)
        {
            _service = service;
            InitializeComponent();
            Refresh = action;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startpoint.X, p.Y - startpoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Priority));
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Label_Click(object sender, EventArgs e)
        {

        }


        private async void Edit_Button_Click(object sender, EventArgs e)
        {
            var task = new TaskDto()
            {
                Title = Title_TextBox.Text,
                Description = Description_TextBox.Text,
                Priority = (Priority)comboBox1.SelectedItem,
                LastUpdateTime = DateTime.Now,
                DeadLine = dateTimePicker1.Value.Date
            };

            await _service.UpdateTaskAsync(index, task);
            Refresh();
            this.Hide();


        }
    }
}
