using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegionApp
{
    public partial class RoomForm : Form
    {
        void EraseField() //функция очищает основное поле
        {
            Graphics g = PBoxMap.CreateGraphics();
            g.Clear(DefaultBackColor);
        }   
        void DrawLines() //функция рисует линии сетки на основном поле
        {
            Graphics g = PBoxMap.CreateGraphics();
            EraseField();
            for (int i = 0; i <= 800; i += (int)(dist * scale))
            {
                g.DrawLine(Pens.LightGray, 0 + i, 0, 0 + i, 400);
            }
            for (int i = 0; i <= 400; i += (int)(dist * scale))
            {
                g.DrawLine(Pens.LightGray, 0, 0 + i, 800, 0 + i);
            }
        }   
        void DrawHanger(PictureBox P,int x, int y) //функция рисует подвеску на выбранном элементе по координатам
        {
            Graphics g = P.CreateGraphics();
            int size = 50;
            g.FillEllipse(Brushes.LightBlue, x, y, size+x, size + y);
            g.DrawEllipse(Pens.Black, x, y, size + x, size + y);
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 20);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            int SizeToFortX = 5;
            int SizeToFortY = 10;
            g.DrawString("42", drawFont, Brushes.Black, SizeToFortX + x, SizeToFortY + y, drawFormat);
        }    
        void DrawWall(PictureBox P, int x1, int y1, int x2, int y2)  //функция рисует стену на выбранном элементе по двум точкам  
        {

        }   
        void DrawAll()  //функция рисует все элементы, существующие в пределах матрицы
        {

        }           
        public RoomForm()
        {
            InitializeComponent();
            scale = 1; //расстояние между элементами по умолчанию = 25 пикселей
            DrawLines();
        }

        private void PBoxHanger_Click(object sender, EventArgs e)
        {
            
        }

        private void ScaleUpBut_Click(object sender, EventArgs e)
        {
            scale *= 1.1;
            DrawLines();
        }

        private void ScaleDowBut_Click(object sender, EventArgs e)
        {
            scale *= 0.9;
            DrawLines();
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            DrawLines();
            Graphics g = PBoxHanger.CreateGraphics();
            DrawHanger(PBoxHanger,0, 0);
        }
    }
}
