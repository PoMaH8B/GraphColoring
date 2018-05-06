using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graph
{
    class Vertex
    {
        /// <summary>
        /// радиус точки на панели
        /// </summary>
        public const int Radius = 8;

        public int Color { get; set; }
        public Point Coord { get; }
        
        public Vertex(Point point, int c = 0)
        {
            Coord = point;
            Color = c;
        }

        /// <summary> 
        /// Проверка на попадание точки в радиус текущей вершины
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Crossed(Point p)
        {
            return Radius >= Math.Sqrt(Math.Pow(p.X - Coord.X, 2) + Math.Pow(p.Y - Coord.Y, 2));
        }

    }
}
