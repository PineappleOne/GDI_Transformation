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

         


        }


        private void PaintFigure(ParallelogrammModel figure)
        {
            if (figure.Length_X == 0.0 && figure.Length_Y == 0.0)
                MessageBox.Show("Не корректные длина и высоты фигуры");



            Graphics graphics = CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

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
            PaintFigure(Figure);
        }
    }
}
