using System;

namespace GDI_Transformation.Model.Interfaces
{
    /// <summary>
    /// Описание фигуры
    /// </summary>
    interface IFigure
    {
        /// <summary>
        /// Максимальное кол-во углов(вершин)
        /// </summary>
        byte MaxPeak { get; set; }


        /// <summary>
        /// Начало отрисовки фигуры
        /// </summary>
        int X { get; set; }
        int Y { get; set; }


    }
}
