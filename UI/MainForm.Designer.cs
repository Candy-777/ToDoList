namespace UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Hide_Button = new Button();
            Exit_Button = new Button();
            MainLabel = new Label();
            Create_Button = new Button();
            Del_Button = new Button();
            DataGrid = new DataGridView();
            toDoItemBindingSource = new BindingSource(components);
            Edit_Button = new Button();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            DeadLine = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toDoItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(Hide_Button);
            panel1.Controls.Add(Exit_Button);
            panel1.Controls.Add(MainLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 45);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Hide_Button
            // 
            Hide_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Hide_Button.FlatAppearance.BorderSize = 0;
            Hide_Button.FlatStyle = FlatStyle.Flat;
            Hide_Button.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Hide_Button.ForeColor = SystemColors.ButtonFace;
            Hide_Button.Location = new Point(648, -4);
            Hide_Button.Name = "Hide_Button";
            Hide_Button.Size = new Size(40, 46);
            Hide_Button.TabIndex = 1;
            Hide_Button.Text = "-";
            Hide_Button.TextAlign = ContentAlignment.TopCenter;
            Hide_Button.UseMnemonic = false;
            Hide_Button.UseVisualStyleBackColor = true;
            Hide_Button.Click += Hide_Button_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.AutoSize = true;
            Exit_Button.Dock = DockStyle.Right;
            Exit_Button.FlatAppearance.BorderSize = 0;
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit_Button.ForeColor = Color.Transparent;
            Exit_Button.Location = new Point(694, 0);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(39, 45);
            Exit_Button.TabIndex = 1;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainLabel.Location = new Point(260, 0);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(159, 47);
            MainLabel.TabIndex = 1;
            MainLabel.Text = "Task List";
            MainLabel.MouseDown += panel1_MouseDown;
            MainLabel.MouseMove += panel1_MouseMove;
            MainLabel.MouseUp += panel1_MouseUp;
            // 
            // Create_Button
            // 
            Create_Button.BackColor = Color.Transparent;
            Create_Button.BackgroundImage = (Image)resources.GetObject("Create_Button.BackgroundImage");
            Create_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Create_Button.FlatAppearance.BorderSize = 0;
            Create_Button.FlatAppearance.MouseDownBackColor = Color.Indigo;
            Create_Button.FlatStyle = FlatStyle.Flat;
            Create_Button.Location = new Point(209, 449);
            Create_Button.Name = "Create_Button";
            Create_Button.Size = new Size(68, 64);
            Create_Button.TabIndex = 1;
            Create_Button.UseVisualStyleBackColor = false;
            Create_Button.Click += Create_Button_Click;
            // 
            // Del_Button
            // 
            Del_Button.BackColor = Color.Transparent;
            Del_Button.BackgroundImage = (Image)resources.GetObject("Del_Button.BackgroundImage");
            Del_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Del_Button.FlatAppearance.BorderSize = 0;
            Del_Button.FlatAppearance.MouseDownBackColor = Color.Indigo;
            Del_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            Del_Button.FlatStyle = FlatStyle.Flat;
            Del_Button.Location = new Point(419, 439);
            Del_Button.Name = "Del_Button";
            Del_Button.Size = new Size(71, 74);
            Del_Button.TabIndex = 2;
            Del_Button.UseVisualStyleBackColor = false;
            Del_Button.Click += Del_Button_Click;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = false;
            DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.BackgroundColor = Color.White;
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Description, Priority, CreationDate, DeadLine });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.Dock = DockStyle.Top;
            DataGrid.GridColor = Color.Indigo;
            DataGrid.ImeMode = ImeMode.NoControl;
            DataGrid.Location = new Point(0, 45);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowTemplate.DividerHeight = 1;
            DataGrid.RowTemplate.ReadOnly = true;
            DataGrid.Size = new Size(733, 393);
            DataGrid.TabIndex = 3;
            DataGrid.CellContentClick += DataGrid_CellContentClick;
            // 
            // Edit_Button
            // 
            Edit_Button.BackColor = Color.Transparent;
            Edit_Button.BackgroundImage = (Image)resources.GetObject("Edit_Button.BackgroundImage");
            Edit_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Edit_Button.FlatAppearance.BorderSize = 0;
            Edit_Button.FlatAppearance.MouseDownBackColor = Color.Indigo;
            Edit_Button.FlatStyle = FlatStyle.Flat;
            Edit_Button.Location = new Point(311, 441);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(84, 80);
            Edit_Button.TabIndex = 4;
            Edit_Button.UseVisualStyleBackColor = false;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Priority
            // 
            Priority.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Priority.HeaderText = "Priority";
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            // 
            // CreationDate
            // 
            CreationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreationDate.HeaderText = "Last Update";
            CreationDate.Name = "CreationDate";
            CreationDate.ReadOnly = true;
            // 
            // DeadLine
            // 
            DeadLine.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeadLine.HeaderText = "Dead Line";
            DeadLine.Name = "DeadLine";
            DeadLine.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(733, 517);
            Controls.Add(Edit_Button);
            Controls.Add(DataGrid);
            Controls.Add(Del_Button);
            Controls.Add(Create_Button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)toDoItemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MainLabel;
        private Button Exit_Button;
        private Button Hide_Button;
        private Button Create_Button;
        private Button Del_Button;
        private DataGridView DataGrid;
        private Button Edit_Button;
        private BindingSource toDoItemBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn DeadLine;
    }
}
