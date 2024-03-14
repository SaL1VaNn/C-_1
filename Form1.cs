using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1
{
    public partial class Form1 : Form
    {
        private File file;
        

        public Form1()

        {


            InitializeComponent();


         


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDay.Text, out var name))
            {
                MessageBox.Show("invalid name");
                return;
            }
            if (!int.TryParse(textBoxDay.Text, out var day))
            {
                MessageBox.Show("invalid day");
                return;
            }
            if(!int.TryParse(textBoxMonth.Text,out var month))
            {
                MessageBox.Show("invalid month");
                return;
            }
            if (!int.TryParse(textBoxMonth.Text, out var year))
            {
                MessageBox.Show("invalid year");
                return;
            }
            if (!float.TryParse(textBoxMonth.Text, out var capacity))
            {
                MessageBox.Show("invalid capacity");
                return;
            }
            file = new File(textBoxName.Text, day,month,year,capacity );

            textBoxResult.AppendText(file.GetFileInfo());
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    public class File
    {
        private string _name;
        private int _day;
        private int _month;
        private int _year;
        private float _capacity;

        public string Name { get => _name; set => _name = value; }
        public float Capacity
        {
            get { return _capacity; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Файл не може мати від'ємну або нульову ємність", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _capacity = value;
                }
            }
        }

        public int Day
        {
            get { return _day; }
            set
            {
                if (value < 1 || value > 31)
                {
                    MessageBox.Show("День в даті повинен бути в межах від 1 до 31", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _day = value;
                }
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    MessageBox.Show("Місяць в даті повинен бути в межах від 1 до 12", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _month = value;
                }
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Рік не може бути від'ємним", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _year = value;
                }
            }
        }
        //конструктор

        public File(string name, int day, int month, int year, float capacity)
        {
            this.Name = name;
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Capacity = capacity;
        }


        public string GetFileInfo()
        {
            return $"Ім'я: {Name}, Дата створення: {Day}.{Month}.{Year}, Ємність: {Capacity} MB";
        }
    }
}

