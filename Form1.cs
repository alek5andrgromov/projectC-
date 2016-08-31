using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace ORBK
{
    public partial class Form1 : Form
    {
        /* Переменные, которые будут хранить на протяжение работы программы логин и пароль. */
        public string login = string.Empty;
        public string password = string.Empty;
        private Users user = new Users(); // Экземпляр класса пользователей.

        public Form1()
        {
            InitializeComponent();
            LoadUsers();

        }
        private void LoadUsers()
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                user = (Users)formatter.Deserialize(fs);

                fs.Close();
            }
            catch { return; }
        }

      

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            for (int i = 0; i < user.Logins.Count; i++) // Ищем пользователя и проверяем правильность пароля.
            {
                if (user.Logins[i] == textBox1.Text && user.Passwords[i] == textBox2.Text)
                {
                    login = user.Logins[i];
                    password = user.Passwords[i];

                    MessageBox.Show("Авторизация прошла успешно!");
                    
                    Form2 fm = new Form2();
                    fm.ShowDialog();
                    this.Close();
                  
                }
                else if (user.Logins[i] == textBox1.Text && textBox2.Text != user.Passwords[i])
                {
                    login = user.Logins[i];

                    MessageBox.Show("Неверный пароль!");
                }
            }

            if (login == "") { MessageBox.Show("Пользователь " + textBox1.Text + " не найден!"); }
            
        }

       
        private void button2_Click_2(object sender, EventArgs e) // Регистрируем нового пользователя.
        {
            if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("Не введен логин или пароль!"); return; }

            user.Logins.Add(textBox1.Text);
            user.Passwords.Add(textBox2.Text);

            FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, user); // Сериализуем класс.

            fs.Close();

            login = textBox1.Text;
            MessageBox.Show("Регистрация прошла успешно для " + textBox1.Text);
        }
    }
}
