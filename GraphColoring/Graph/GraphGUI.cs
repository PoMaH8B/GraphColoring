using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    class GraphGui : Graph
    {
        /// <summary> 
        /// Панель, на которой происходит отрисовка графики
        /// </summary>
        private Panel _panel;

        public GraphGui(Panel panel)
        {
            _panel = panel;
        }

        /// <summary> 
        /// Добавление вершины в граф
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public new bool AddVertex(Point pos)
        {
            if (!base.AddVertex(pos))
                return false;
            Draw();
            return true;
        }

        /// <summary> 
        /// Действие с дугой
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public bool AddArc(Point one, Point two)
        {
            if (!base.AddArc(ref one, ref two))
                return false;
            Draw();
            return true;
        }

        /// <summary> 
        /// Очистка
        /// </summary>
        public new void Clear()
        {
            ClearPanel();
            base.Clear();
        }

        /// <summary>
        /// Перерисовка панели цветом фона 
        /// </summary>
        private void ClearPanel()
        {
            _panel.CreateGraphics().FillRectangle(new SolidBrush(_panel.BackColor), 0, 0, _panel.Width, _panel.Height);
        }

        /// <summary> 
        /// Отображение на панели всех вершин и дуг графа
        /// </summary>
        private void Draw()
        {
            ClearPanel();
            for (int i = 0; i < Size; ++i)
                for (int j = 0; j < Size; ++j)
                    if (Matr[i, j]) 
                        // отображение дуг
                        DrawArc(IntToColor(), Vertices[i].Coord, Vertices[j].Coord);
            foreach (var v in Vertices) 
                // отображение вершин            
                DrawVertex(IntToColor(v.Color), v.Coord);
        }

        /// <summary> 
        /// Вызов рекурсивного алгоритма и отображение на панели
        /// </summary>
        public new bool Colorize()
        {
            if (Vertices.Count == 0)
                return false;
            base.Colorize();
            Draw();
            SetDefaultColors();
            return true;
        }

        /// <summary> 
        /// Изображение вершины на панели
        /// </summary>
        /// <param name="c"></param>
        /// <param name="coord"></param>
        private void DrawVertex(Color c, Point coord)
        {
            _panel.CreateGraphics().FillEllipse(new SolidBrush(c), coord.X - Vertex.Radius, coord.Y - Vertex.Radius, Vertex.Radius * 2, Vertex.Radius * 2);
        }

        /// <summary> 
        /// Изображение дуги на панели
        /// </summary>
        /// <param name="c"></param>
        /// <param name="one"></param>
        /// <param name="two"></param>
        private void DrawArc(Color c, Point one, Point two)
        {
            _panel.CreateGraphics().DrawLine(new Pen(c, 2), one, two);
        }

        /// <summary> 
        /// Отображение целого числа в множество цветов
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static Color IntToColor(int num = 0)
        {
            switch (num)
            {
                case 1:
                    return Color.Aquamarine;
                case 2:
                    return Color.Gold;
                case 3:
                    return Color.Lime;
                case 4:
                    return Color.Black;
                case 5:
                    return Color.Red;
                case 6:
                    return Color.NavajoWhite;
                case 7:
                    return Color.Green;
                case 8:
                    return Color.Yellow;
                case 9:
                    return Color.Gray;
                case 10:
                    return Color.Orchid;
                case 11:
                    return Color.Brown;
                case 12:
                    return Color.DarkCyan;
                case 13:
                    return Color.Tan;
                case 14:
                    return Color.DarkTurquoise;
                case 15:
                    return Color.Lime;
                case 16:
                    return Color.SeaGreen;
                case 17:
                    return Color.SandyBrown;
                case 18:
                    return Color.Pink;
                case 19:
                    return Color.Peru;
                case 20:
                    return Color.Plum;

                default:
                    return Color.Blue;
            }
        }

    }
}
