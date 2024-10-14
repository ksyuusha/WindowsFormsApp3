namespace WindowsFormsApp3._1
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBoxGrades;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove; // Новая кнопка

        private void InitializeComponent()
        {
            this.textBoxGrades = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxGrades
            // 
            this.textBoxGrades.Location = new System.Drawing.Point(305, 44);
            this.textBoxGrades.Name = "textBoxGrades";
            this.textBoxGrades.Size = new System.Drawing.Size(100, 22);
            this.textBoxGrades.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(24, 44);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(108, 22);
            this.textBoxFullName.TabIndex = 2;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(24, 164);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(363, 148);
            this.listBoxStudents.TabIndex = 3;
            this.listBoxStudents.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(152, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(317, 164);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 30);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Оценка";
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(173, 44);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourse.TabIndex = 9;
            this.textBoxCourse.TextChanged += new System.EventHandler(this.textBoxCourse_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(472, 384);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGrades);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCourse;
    }
}
