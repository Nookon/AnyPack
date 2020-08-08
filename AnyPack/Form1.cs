using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyPack
{
    public partial class StratWindow : Form
    {
        private static object exitApp;

        public StratWindow()
        {
            InitializeComponent();
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StratWindow startform = new StratWindow();
            //startform.Hide();

            this.Hide();

            Form3 Signup = new Form3();
            Signup.Show();

           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)

                label2.Text = "Чтобы начять загрузку вам нужно согласиться с правилами условий...";

            if (progressBar1.Value == 10)

                label2.Text = "Подключение к серверу...";
            
                

            if (progressBar1.Value == 20)

                label2.Text = "Подключение к серверу успешно...";
                

            if (progressBar1.Value == 30)

                label2.Text = "Получение данных с сервера...";

            if (progressBar1.Value == 40)

                label2.Text = "Проверка полученых данных...";

            if (progressBar1.Value == 50)

                label2.Text = "Проверка на необходимость обновления...";

            if (progressBar1.Value == 60)

                label2.Text = "Загрузка изображений...";

            if (progressBar1.Value == 70)

                label2.Text = "Подготовительные работы...";

            if (progressBar1.Value == 80)

                label2.Text = "Создание интерфейса...";

            if (progressBar1.Value == 90)

                label2.Text = "Всё готово...";



            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                button1.Enabled = true;
                button2.Enabled = true;

            }

            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StratWindow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все данные исползивание в данной програме принадлежат компании Any Pack");
        }
    }
}
