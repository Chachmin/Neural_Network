using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NeuralNetwork_project
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Graphics g;
        Bitmap image;

        Bitmap b2;
        Graphics g2;

        public List<Neuron> neurons = new List<Neuron>();
        List<int> pixels;

        public Form1()
        {
            InitializeComponent();
            b  = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            b2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            g  = Graphics.FromImage(b);

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;           // вид границы рабочей области
            pictureBox1.BackColor   = Color.White;                       // белый фон рабочей области

            pictureBox2.BorderStyle = BorderStyle.FixedSingle;           // вид границы рабочей области
            pictureBox2.BackColor   = Color.White;                       // белый фон рабочей области

            initialize_neurons();
            //pictureBox1.Image = Image.FromFile("c:\")
        }

        public bool mouseButtonPressed = false;      // чернила (вкл/выкл)
        public List<Point> list = new List<Point>(); // координаты точек рисунка пользователя

        // инициализация нейронов (веса и смещение)
        public void initialize_neurons()
        {
            for (int i = 0; i < Constant.digits; i++)
                neurons.Add(new Neuron());
        }

        // I.1 Рисование - клавиша нажата
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Start.Enabled = true;              // активация кнопки "Пуск" после начала рисования
            mouseButtonPressed = true;
            pictureBox1_MouseMove(sender, e);  // делает возможным рисование кликом без движения
        }
        // I.2 Рисование - клавиша отпущена
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseButtonPressed = false;
        }
        // I.3 Рисование
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseButtonPressed == true)
            {
                // клавиша нажата - идёт рисование
                Point p = new Point(e.X, e.Y);  // только что нарисованная точка
                list.Add(p);                    // её добавление в список

                pictureBox1.Invalidate();
                g.FillEllipse(Brushes.Black, p.X - Constant.brush_size/2, p.Y - Constant.brush_size/2, Constant.brush_size, Constant.brush_size);
                pictureBox1.Image = b;
            }  
        }

        // II.1 - Приведение изображения к заданному разрешению (пикселизация) и его отображение
        public void scanImage()
        {
            image = new Bitmap(b, new Size(Constant.side, Constant.side));
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = image;
            // image.Save("DSC_0002_thumb.jpg");
        }
        // II.2 - Обработка изображения - представление изображения в виде списка нулей (белый пиксель) и единиц (чёрный пиксель)
        public List<int> read_pixels()
        {
            List<int> pixels = new List<int>();

            for (int i = 0; i < Constant.side; i++)
            {
                for (int j = 0; j < Constant.side; j++)
                {
                    if (image.GetPixel(j, i) == Color.FromArgb(255, 0, 0, 0))
                        pixels.Add(1);  // чёрный пиксель
                    else
                        pixels.Add(0);  // белый пиксель
                }
            }

            return pixels;
        }

        // III.1 - Распознавание - пуск
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;        // кнопка "Пуск" становится неактивной
            pictureBox1.Enabled = false;  // область рисования блокируется

            grey_matter();
        }
        // III.2 - Распознавание - серое вещество
        public void grey_matter()
        {
            scanImage();                                               // приведение изображения к заданному разрешению
            pixels = read_pixels();                                    // получение списка чисел (0/1), соответствующих цветам пикселей
            total_calc();                                              // подсчёт значений нейронов
            double max_score = neurons.Max(n => n.score);              // поиск максимального значения нейрона
            int guess = neurons.FindIndex(n => n.score == max_score);  // номер нейрона с максимальным значением

            Guess.Text = Convert.ToString(guess);  // отображение результата

            Right.Enabled = true;                  // блокировка кнопки "Угадано верно"
            Wrong.Enabled = true;                  // блокировка кнопки "Не угадано"
        }
        // III.2.a - Распознавание - вычисление значений нейронов
        public void total_calc()
        {
            for (int i = 0; i < Constant.digits; i++)
                neurons[i].score = one_neuron_calc(neurons[i]);
        }
        // III.2.b - Распознавание - вычисление значения одного нейрона
        public double one_neuron_calc(Neuron neuron)
        {
            double x = 0;
            int pixels_size = pixels.Count;

            for (int i = 0; i < pixels_size; i++)
                x += pixels[i] * neuron.Weights[i];

            x += neuron.bias;

            return x;
        }
        // III.2.c - Распознавание - сигмоид (0...1)
        public double sigmoid(double x)
        {
            double s = 1 / (1 + Math.Exp(-x));
            return s;
        }

        // IV.1.a - Обучение - угадано
        private void Right_Click(object sender, EventArgs e)
        {
            learning(Convert.ToInt32(Guess.Text), true);
            pictureBox1.Enabled = true;
        }
        // IV.1.b - Обучение - не угадано
        private void Wrong_Click(object sender, EventArgs e)
        {
            learning(Convert.ToInt32(Guess.Text), false);
            pictureBox1.Enabled = true;
        }
        // IV.2 Обучение - корректировка весов в зависимости от корректности догадки
        public void learning(int guess, bool guessed_correctly)
        {
            Right.Enabled = false;  // блокировка кнопки "Угадано верно"
            Wrong.Enabled = false;  // блокировка кнопки "Не угадано"
            Guess.Text = "";        // поле ответа пока пусто

            int pixels_size = pixels.Count;

            if (guessed_correctly)
            {
                for (int i = 0; i < pixels_size; i++)
                {
                    if (pixels[i] == 1)
                        neurons[guess].Weights[i] += 1;
                    else
                        neurons[guess].Weights[i] -= 0.5;
                }
            }
            else
            {
                for (int i = 0; i < pixels_size; i++)
                {
                    if (pixels[i] == 1)
                        neurons[guess].Weights[i] -= 1;
                }
            }

            drawGuess(guess, pictureBox3);  // отобразить иллюстрацию весов для активированного нейрона
            drawGuessAll();                 // отобразить иллюстрацию весов для всех нейронов

            g.Clear(pictureBox1.BackColor);
        }

        // V.1 - Визуализация весов -  все нейроны
        public void drawGuessAll()
        {
            drawGuess(0, visual_0);
            drawGuess(1, visual_1);
            drawGuess(2, visual_2);
            drawGuess(3, visual_3);
            drawGuess(4, visual_4);
            drawGuess(5, visual_5);
            drawGuess(6, visual_6);
            drawGuess(7, visual_7);
            drawGuess(8, visual_8);
            drawGuess(9, visual_9);
        }
        // V.2 - Визуализация весов -  один нейрон
        public void drawGuess(int guess, PictureBox sender)
        {
            Bitmap visualization = new Bitmap(Constant.side, Constant.side);

            int shade;
            for (int i = 0; i < Constant.side; i++)
            {
                for (int j = 0; j < Constant.side; j++)
                {
                    shade = 255 - (int) (sigmoid(neurons[guess].Weights[i*Constant.side + j]) * 255);
                    visualization.SetPixel(j, i, Color.FromArgb(255, shade, shade, shade));
                }
            }

            visualization = new Bitmap(visualization, new Size(Constant.side, Constant.side));

            sender.SizeMode = PictureBoxSizeMode.StretchImage;
            sender.Image = visualization;           
        }

        // VI.1 - Работа с файлами - открытие
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "..\\";  // current directory
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            Stream sourceFileName = ofd.OpenFile();
            StreamReader sr = new StreamReader(sourceFileName);

            for(int i = 0; i < Constant.digits; i++)
                for (int j = 0; j < Constant.side * Constant.side; j++)
                    neurons[i].Weights[j] = Convert.ToDouble(sr.ReadLine());

            drawGuessAll();
        }
        // VI.2 - Работа с файлами - сохранение
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "..\\";
            sfd.Filter = "txt files (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;

            Stream outputFileName = sfd.OpenFile();
            StreamWriter sw = new StreamWriter(outputFileName);

            for (int i = 0; i < Constant.digits; i++)
                for (int j = 0; j < Constant.side * Constant.side; j++)
                    sw.WriteLine(string.Format("{0}", neurons[i].Weights[j]));

            sw.Close();
        }
    }
}

static class Constant
{
    public const int side = 10;              // сторона анализируемого изображения (в пикселях)
    public const int brush_size = 3 * side;  // толщина кисти, используемой для рисования
    public const int digits = 10;            // количество нейронов
}

public class Neuron
{
    public List<double> Weights = new List<double>();  // список весов нейрона
    public double bias;                                // смещение нейрона
    public double score;                               // значение нейрона

    public Neuron()
    {
        // веса и смещение инициализируются нулём
        Random random_init = new Random();
        for (int i = 0; i < Constant.side * Constant.side; i++)
            Weights.Add(0);
        bias = 0;
    }
}