using System;
using System.Windows.Forms;

namespace WindowsFormsApp3._1
{
    public partial class Form1 : Form
    {
        // Конструктор
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик события для кнопки "Добавить"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text; // Получение полного имени
            string course = textBoxCourse.Text; // Получение введённого курса
            string grade = textBoxGrades.Text; // Получение оценки

            if (!string.IsNullOrWhiteSpace(fullName) && !string.IsNullOrWhiteSpace(course) && !string.IsNullOrWhiteSpace(grade))
            {
                // Добавление студента в список
                listBoxStudents.Items.Add($"{fullName} - {course} - Оценка: {grade}");
                // Очистка полей ввода
                textBoxFullName.Clear();
                textBoxCourse.Clear(); // Очистка TextBox для курса
                textBoxGrades.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события для кнопки "Удалить"
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem != null)
            {
                // Удаление выбранного студента из списка
                listBoxStudents.Items.Remove(listBoxStudents.SelectedItem);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            // Обработчик событий, если нужно что-то делать при изменении текста
        }

        private void textBoxCourse_TextChanged(object sender, EventArgs e)
        {
            // Если вам не нужно ничего делать, можно просто оставить этот метод пустым
        }
    }
}
