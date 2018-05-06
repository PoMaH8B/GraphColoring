using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        public const int MaxN  = 20;
        protected readonly List<Vertex> Vertices;
        /// <summary> 
        /// Матрица смежности
        /// </summary>
        protected bool [,] Matr;

        /// <summary> 
        /// Текущее количество вершин в графе
        /// </summary>
        public int Size
        {
            get
            {
                return Vertices.Count;
            }
        }
        
        public Graph()
        {
            Vertices = new List<Vertex>();
        }

        /// <summary> 
        /// Добавление дуги
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public bool AddArc(ref Point one, ref Point two)
        {
            // поиск вершин дуги
            Point ij = GetVerticesCoords(one, two);
            if (ij.X == -1 && ij.Y == -1)
                return false; 

            Matr[ij.X, ij.Y] = Matr[ij.Y, ij.X] = true;
            return true;
        }

        /// <summary> 
        /// Добавление вершины в граф
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool AddVertex(Point pos)
        {
            if (Vertices.Count == MaxN)
                return false;
            Vertices.Add(new Vertex(pos));

            IncRangMatrix(); 
            return true;
        }

        /// <summary> 
        /// Нахождение индексов вершин по координатам</summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        private Point GetVerticesCoords(Point one, Point two)
        {
            Point res = new Point(0, 0);
            // пытаемся найти две вершины, в радиус которых попадают переданные точки
            for (; res.X < Size && !Vertices[res.X].Crossed(one); ++res.X) { }
            for (; res.Y < Size && !Vertices[res.Y].Crossed(two); ++res.Y) { }
            // если вершины не найдены или совпадают
            if (!(res.Y < Vertices.Count && res.X < Vertices.Count && res.X != res.Y))
                res = new Point(-1, -1);
            return res;
        }

        /// <summary> 
        /// Решение задачи
        /// </summary>
        public void Colorize()
        {
            int countColors = 0;
            do
            {
                ++countColors;
            } while (!ColorizeRec(0, countColors));
        }

        /// <summary>
        /// Рекурсивный алгоритм получения раскраски графа
        /// </summary>
        /// <param name="i"> вершина для окраски </param>
        /// <param name="countColors"></param>
        /// <returns></returns>
        private bool ColorizeRec(int i, int countColors)
        {
            HashSet<int> palitra = new HashSet<int>(); 
            int j = 1;
            for (; j <= countColors; ++j) 
                palitra.Add(j); 

            for (j = 0; j < i; ++j)
                // если у текущей вершины есть связь с предыдущей - удаляем цвет, в который окрашена предыдущая
                if (Matr[i, j])    
                    palitra.Remove(Vertices[j].Color); 
            // если уже не хватает цветов
            if (palitra.Count == 0) 
                return false;

            // попытка раскрасить текущую вершину во все доступные цвета, и переход к следующей
            foreach (var color in palitra)
            {
                Vertices[i].Color = color;
                // если окрашена последняя вершина
                if (i + 1 == Vertices.Count) 
                    return true;
                // если граф успешно окрашен
                if (ColorizeRec(i + 1, countColors))
                    return true; 
                Vertices[i].Color = 0;
            }
            return false;
        }

        /// <summary> 
        /// Установка всем вершинам цвет 0 
        /// </summary>
        protected void SetDefaultColors()
        {
            for (int i = 0; i < Size; ++i)
                Vertices[i].Color = 0;
        }

        /// <summary> 
        /// Добавление новой строки в матрицу смежности
        /// </summary>
        void IncRangMatrix()
        {
            int size = Vertices.Count;
            bool [,] result = new bool[size, size];
            // перезапись старой информации
            for (int i = 0; i < size - 1; ++i)
                for (int j = 0; j < size - 1; ++j)
                    result[i, j] = Matr[i, j];
            // новый ряд и столбец, не связанный ни с одной вершиной 
            for (int i = 0; i < size; ++i)
                result[size - 1, i] = result[i, size - 1] = false;
            Matr = result;
        }

        /// <summary> 
        /// Удаление строки из матрицы смежности
        /// </summary>
        /// <param name="pos"></param>
        void DecRangMatrix(int pos)
        {
            int size = Vertices.Count;
            if (size != 0)
            {
                bool[,] result = new bool[size, size];
                // переписываем всю информацию из старой матрицы до удаленной вершины
                for (int i = 0; i < pos && i < size; ++i)
                    for (int j = 0; j < pos && i < size; ++j)
                        result[i, j] = Matr[i, j];
                // переписываем всю информацию из старой матрицы после удаленной вершины
                for (int i = pos; i < size; ++i)
                    for (int j = pos; j < size; ++j)
                        result[i, j] = Matr[i + 1, j + 1];
                Matr = result;
            }
            else
                Clear();
        }

        /// <summary> 
        /// Очистка графа 
        /// </summary>
        public void Clear()
        {
            Matr = null;
            Vertices.Clear();
        }
    }

}
