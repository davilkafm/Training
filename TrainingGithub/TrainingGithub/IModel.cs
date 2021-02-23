using System;
namespace TrainingGithub
{
    /// <summary>
    /// Протокол для разработки подсчета периметра прямоугольника
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Метод, возвращающий периметр прямоугольникапо двум сторонам
        /// </summary>
        /// <returns>Возвращает периметр прямоугольника</returns>
        /// <param name="a">Ширина прямоугольника</param>
        /// <param name="b">Высота прямоугольника</param>
        int GetP(int a, int b);
    }
}
