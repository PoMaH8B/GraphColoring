using Graph.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class FrmMain : Form
    {
        private Point[] _clickPoints = new Point[2];
        private GraphGui _graph;

        public FrmMain()
        {
            InitializeComponent();
            _graph = new GraphGui(pnlGraph);
        }

        /// <summary> 
        /// Запоминает координату начала "протягивания" дуги
        /// </summary>
        private void pnlGraph_MouseDown(object sender, MouseEventArgs e)
        {
            if (addArc.Checked)
                _clickPoints[0] = new Point(e.X, e.Y);
        }

        /// <summary> 
        /// Запоминает финальную точку "протягивания" дуги и вызывает функцию добавления  дуги
        /// </summary>
        private void pnlGraph_MouseUp(object sender, MouseEventArgs e)
        {
            _clickPoints[1] = new Point(e.X, e.Y);
            if (_clickPoints[0] == _clickPoints[1])
                return;
            if (addArc.Checked)
                _graph.AddArc(_clickPoints[0], _clickPoints[1]);
        }

        /// <summary> 
        /// Добавить вершину в граф
        /// </summary>        
        private void pnlGraph_MouseClick(object sender, MouseEventArgs e)
        {
            if (addVertex.Checked)
                _graph.AddVertex(new Point(e.X, e.Y));
        }
        
        /// <summary>
        /// Раскраска графа
        /// </summary>
        private void btnColorize_Click(object sender, EventArgs e)
        {
            _graph.Colorize();
        }

        /// <summary>
        /// Очистка графа
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            _graph.Clear();
        }
    } 
}
