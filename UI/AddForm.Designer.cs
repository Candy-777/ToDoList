namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            panel1 = new Panel();
            Exit_Button = new Button();
            AddForm_Label = new Label();
            Title_TextBox = new TextBox();
            Description_TextBox = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Create_Button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(Exit_Button);
            panel1.Controls.Add(AddForm_Label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 41);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Exit_Button
            // 
            Exit_Button.Dock = DockStyle.Right;
            Exit_Button.FlatAppearance.BorderSize = 0;
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit_Button.Location = new Point(289, 0);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(35, 41);
            Exit_Button.TabIndex = 1;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // AddForm_Label
            // 
            AddForm_Label.AutoSize = true;
            AddForm_Label.Dock = DockStyle.Left;
            AddForm_Label.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddForm_Label.Location = new Point(0, 0);
            AddForm_Label.Name = "AddForm_Label";
            AddForm_Label.Size = new Size(155, 40);
            AddForm_Label.TabIndex = 1;
            AddForm_Label.Text = "New  Task";
            AddForm_Label.Click += AddForm_Label_Click;
            AddForm_Label.MouseDown += panel1_MouseDown;
            AddForm_Label.MouseMove += panel1_MouseMove;
            AddForm_Label.MouseUp += panel1_MouseUp;
            // 
            // Title_TextBox
            // 
            Title_TextBox.Location = new Point(51, 67);
            Title_TextBox.Name = "Title_TextBox";
            Title_TextBox.Size = new Size(215, 23);
            Title_TextBox.TabIndex = 1;
            // 
            // Description_TextBox
            // 
            Description_TextBox.Location = new Point(51, 120);
            Description_TextBox.Name = "Description_TextBox";
            Description_TextBox.Size = new Size(215, 23);
            Description_TextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(51, 219);
            dateTimePicker1.MinDate = new DateTime(2024, 11, 30, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2024, 11, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(131, 43);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 5;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(109, 93);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(109, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 7;
            label3.Text = "Priority";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(103, 195);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 8;
            label4.Text = "Dead Line";
            // 
            // Create_Button
            // 
            Create_Button.BackColor = Color.Transparent;
            Create_Button.BackgroundImage = (Image)resources.GetObject("Create_Button.BackgroundImage");
            Create_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Create_Button.FlatAppearance.BorderSize = 0;
            Create_Button.FlatAppearance.MouseDownBackColor = Color.Indigo;
            Create_Button.FlatStyle = FlatStyle.Flat;
            Create_Button.Location = new Point(231, 222);
            Create_Button.Name = "Create_Button";
            Create_Button.Size = new Size(70, 64);
            Create_Button.TabIndex = 9;
            Create_Button.UseVisualStyleBackColor = false;
            Create_Button.Click += Create_Button_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(324, 298);
            Controls.Add(Create_Button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(Description_TextBox);
            Controls.Add(Title_TextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "AddForm";
            Load += AddForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label AddForm_Label;
        private Button Exit_Button;
        private TextBox Title_TextBox;
        private TextBox Description_TextBox;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Create_Button;
    }
}