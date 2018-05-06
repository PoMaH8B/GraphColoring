namespace Graph
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора 
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.addVertex = new System.Windows.Forms.RadioButton();
            this.addArc = new System.Windows.Forms.RadioButton();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.gbGraphAction = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColorize = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.gbGraphAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnColorize);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.addArc);
            this.pnlMain.Controls.Add(this.addVertex);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(728, 398);
            this.pnlMain.TabIndex = 0;
            // 
            // addVertex
            // 
            this.addVertex.AutoSize = true;
            this.addVertex.Location = new System.Drawing.Point(12, 12);
            this.addVertex.Name = "addVertex";
            this.addVertex.Size = new System.Drawing.Size(76, 17);
            this.addVertex.TabIndex = 0;
            this.addVertex.TabStop = true;
            this.addVertex.Text = "Add vertex";
            this.addVertex.UseVisualStyleBackColor = true;
            // 
            // addArc
            // 
            this.addArc.AutoSize = true;
            this.addArc.Location = new System.Drawing.Point(12, 35);
            this.addArc.Name = "addArc";
            this.addArc.Size = new System.Drawing.Size(62, 17);
            this.addArc.TabIndex = 2;
            this.addArc.TabStop = true;
            this.addArc.Text = "Add arc";
            this.addArc.UseVisualStyleBackColor = true;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.Coral;
            this.pnlGraph.Location = new System.Drawing.Point(0, 0);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(571, 398);
            this.pnlGraph.TabIndex = 0;
            this.pnlGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseClick);
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseDown);
            this.pnlGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseUp);
            // 
            // gbGraphAction
            // 
            this.gbGraphAction.Controls.Add(this.pnlGraph);
            this.gbGraphAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbGraphAction.Location = new System.Drawing.Point(157, 0);
            this.gbGraphAction.Name = "gbGraphAction";
            this.gbGraphAction.Size = new System.Drawing.Size(571, 398);
            this.gbGraphAction.TabIndex = 1;
            this.gbGraphAction.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(94, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColorize
            // 
            this.btnColorize.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColorize.Location = new System.Drawing.Point(12, 89);
            this.btnColorize.Name = "btnColorize";
            this.btnColorize.Size = new System.Drawing.Size(139, 37);
            this.btnColorize.TabIndex = 4;
            this.btnColorize.Text = "Colorize!";
            this.btnColorize.UseVisualStyleBackColor = true;
            this.btnColorize.Click += new System.EventHandler(this.btnColorize_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 398);
            this.Controls.Add(this.gbGraphAction);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmMain";
            this.Text = "Graph";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbGraphAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.RadioButton addVertex;
        private System.Windows.Forms.RadioButton addArc;
        private System.Windows.Forms.Button btnColorize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.GroupBox gbGraphAction;
    }
}

