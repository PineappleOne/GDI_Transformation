using System;
using GDI_Transformation.Model;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GDI_Transformation.View
{
    public partial class MainWindow : Form
    {

        //Создаем новую модель фигуры
        ParallelogrammModel Figure = new ParallelogrammModel();



        public MainWindow()
        {
            InitializeComponent();
            txtAngle.Text = Figure.Angle.ToString();
            txtLenghtX.Text = Figure.Length_X.ToString();
            txtLenghtY.Text = Figure.Length_Y.ToString();
        }

        //Функция отрисовки фигуры
        private void PaintFigure(ParallelogrammModel figure)
        {
            if (figure.Length_X == 0.0 && figure.Length_Y == 0.0)
                MessageBox.Show("Не корректные длина и высоты фигуры");

            Graphics graphics = CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);
        
            using (SolidBrush brush = new SolidBrush(Color.DarkSalmon))
            {
                graphics.FillPolygon(brush, new[]
                {
                    new Point(figure.X,figure.Y),
                    new Point(figure.X + figure.Angle,figure.Y + figure.Length_Y),
                    new Point(figure.X + figure.Angle + figure.Length_X,figure.Y+ figure.Length_Y),
                    new Point(figure.X + figure.Length_X,figure.Y),
                });
            }
          
        }



        private void btnPaint_Click(object sender, System.EventArgs e)
        {
            Figure.Length_X = Convert.ToInt32(txtLenghtX.Text);
            Figure.Length_Y = Convert.ToInt32(txtLenghtY.Text);
            Figure.Angle = Convert.ToInt32(txtAngle.Text);

            PaintFigure(Figure);
        }


        /// <summary>
        /// Движение вправо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveRight_Click(object sender, System.EventArgs e)
        {
            Figure.X += Convert.ToInt32(txtStep.Text);
            PaintFigure(Figure);
        }

        /// <summary>
        /// Движение вверх
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveUp_Click(object sender, System.EventArgs e)
        {
            Figure.Y -= Convert.ToInt32(txtStep.Text);
            PaintFigure(Figure);
        }

        /// <summary>
        /// Движение вниз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveDown_Click(object sender, System.EventArgs e)
        {
            Figure.Y += Convert.ToInt32(txtStep.Text);
            PaintFigure(Figure);
        }

        /// <summary>
        /// Движение влево
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveLeft_Click(object sender, System.EventArgs e)
        {
            Figure.X -= Convert.ToInt32(txtStep.Text);
            PaintFigure(Figure);
        }

        /// <summary>
        /// Сброс позиции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, System.EventArgs e)
        {
            Figure.X = 10;
            Figure.Y = 10;
            PaintFigure(Figure);
        }
    }
}
