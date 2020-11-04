using GDI_Transformation.Model.Interfaces;

namespace GDI_Transformation.Model
{
    class ParallelogrammModel:IFigure
    {
        public byte MaxPeak { get; set; } = 4;
        public int X { get; set; } = 10;
        public int Y { get; set; } = 10;

        /// <summary>
        /// Длина фигуры
        /// </summary>
        public int Length_X { get; set; }
        /// <summary>
        /// Высота фигуры
        /// </summary>
        public int Length_Y { get; set; }

        /// <summary>
        /// Угол наклона параллелограмма
        /// </summary>
        public int Angle;

        public ParallelogrammModel()
        {
            Length_X = 100;
            Length_Y = Length_X / 2;

            Angle = 35;
        }
    }
}
