namespace ComputerGraphicsAlgorithms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblY0;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;

        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;

        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnMidpointLine;
        private System.Windows.Forms.Button btnBresenhamLine;
        private System.Windows.Forms.Button btnMidpointCircle;
        private System.Windows.Forms.Button btnBresenhamCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Panel pnlCanvas;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblX0 =
                new System.Windows.Forms.Label();

            this.lblY0 =
                new System.Windows.Forms.Label();

            this.lblX1 =
                new System.Windows.Forms.Label();

            this.lblY1 =
                new System.Windows.Forms.Label();

            this.lblRadius =
                new System.Windows.Forms.Label();

            this.lblA =
                new System.Windows.Forms.Label();

            this.lblB =
                new System.Windows.Forms.Label();

            this.txtX0 =
                new System.Windows.Forms.TextBox();

            this.txtY0 =
                new System.Windows.Forms.TextBox();

            this.txtX1 =
                new System.Windows.Forms.TextBox();

            this.txtY1 =
                new System.Windows.Forms.TextBox();

            this.txtRadius =
                new System.Windows.Forms.TextBox();

            this.txtA =
                new System.Windows.Forms.TextBox();

            this.txtB =
                new System.Windows.Forms.TextBox();

            this.btnPoint =
                new System.Windows.Forms.Button();

            this.btnDDA =
                new System.Windows.Forms.Button();

            this.btnMidpointLine =
                new System.Windows.Forms.Button();

            this.btnBresenhamLine =
                new System.Windows.Forms.Button();

            this.btnMidpointCircle =
                new System.Windows.Forms.Button();

            this.btnBresenhamCircle =
                new System.Windows.Forms.Button();

            this.btnEllipse =
                new System.Windows.Forms.Button();

            this.btnClear =
                new System.Windows.Forms.Button();

            this.pnlCanvas =
                new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // =====================================================
            // 窗体
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1200, 720);

            this.Name =
                "MainForm";

            this.Text =
                "计算机图形学基本算法演示系统";

            // =====================================================
            // 标题
            // =====================================================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Microsoft YaHei",
                    16F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(30, 20);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(360, 30);

            this.lblTitle.Text =
                "计算机图形学基本算法演示系统";

            // =====================================================
            // X0
            // =====================================================

            this.lblX0.AutoSize = true;

            this.lblX0.Location =
                new System.Drawing.Point(30, 75);

            this.lblX0.Text =
                "起点 X：";

            this.txtX0.Location =
                new System.Drawing.Point(110, 72);

            this.txtX0.Name =
                "txtX0";

            this.txtX0.Size =
                new System.Drawing.Size(100, 25);

            this.txtX0.Text =
                "100";

            // =====================================================
            // Y0
            // =====================================================

            this.lblY0.AutoSize = true;

            this.lblY0.Location =
                new System.Drawing.Point(30, 110);

            this.lblY0.Text =
                "起点 Y：";

            this.txtY0.Location =
                new System.Drawing.Point(110, 107);

            this.txtY0.Name =
                "txtY0";

            this.txtY0.Size =
                new System.Drawing.Size(100, 25);

            this.txtY0.Text =
                "100";

            // =====================================================
            // X1
            // =====================================================

            this.lblX1.AutoSize = true;

            this.lblX1.Location =
                new System.Drawing.Point(30, 145);

            this.lblX1.Text =
                "终点 X：";

            this.txtX1.Location =
                new System.Drawing.Point(110, 142);

            this.txtX1.Name =
                "txtX1";

            this.txtX1.Size =
                new System.Drawing.Size(100, 25);

            this.txtX1.Text =
                "500";

            // =====================================================
            // Y1
            // =====================================================

            this.lblY1.AutoSize = true;

            this.lblY1.Location =
                new System.Drawing.Point(30, 180);

            this.lblY1.Text =
                "终点 Y：";

            this.txtY1.Location =
                new System.Drawing.Point(110, 177);

            this.txtY1.Name =
                "txtY1";

            this.txtY1.Size =
                new System.Drawing.Size(100, 25);

            this.txtY1.Text =
                "300";

            // =====================================================
            // Radius
            // =====================================================

            this.lblRadius.AutoSize = true;

            this.lblRadius.Location =
                new System.Drawing.Point(30, 215);

            this.lblRadius.Text =
                "半径：";

            this.txtRadius.Location =
                new System.Drawing.Point(110, 212);

            this.txtRadius.Name =
                "txtRadius";

            this.txtRadius.Size =
                new System.Drawing.Size(100, 25);

            this.txtRadius.Text =
                "100";

            // =====================================================
            // A
            // =====================================================

            this.lblA.AutoSize = true;

            this.lblA.Location =
                new System.Drawing.Point(30, 250);

            this.lblA.Text =
                "长半轴 a：";

            this.txtA.Location =
                new System.Drawing.Point(110, 247);

            this.txtA.Name =
                "txtA";

            this.txtA.Size =
                new System.Drawing.Size(100, 25);

            this.txtA.Text =
                "200";

            // =====================================================
            // B
            // =====================================================

            this.lblB.AutoSize = true;

            this.lblB.Location =
                new System.Drawing.Point(30, 285);

            this.lblB.Text =
                "短半轴 b：";

            this.txtB.Location =
                new System.Drawing.Point(110, 282);

            this.txtB.Name =
                "txtB";

            this.txtB.Size =
                new System.Drawing.Size(100, 25);

            this.txtB.Text =
                "120";

            // =====================================================
            // 按钮
            // =====================================================

            CreateButton(
                this.btnPoint,
                "生成点",
                30,
                330);

            CreateButton(
                this.btnDDA,
                "DDA直线",
                30,
                370);

            CreateButton(
                this.btnMidpointLine,
                "中点画线",
                30,
                410);

            CreateButton(
                this.btnBresenhamLine,
                "Bresenham直线",
                30,
                450);

            CreateButton(
                this.btnMidpointCircle,
                "中点画圆",
                30,
                490);

            CreateButton(
                this.btnBresenhamCircle,
                "Bresenham画圆",
                30,
                530);

            CreateButton(
                this.btnEllipse,
                "中点椭圆",
                30,
                570);

            CreateButton(
                this.btnClear,
                "清空",
                30,
                620);

            // =====================================================
            // 绘图区
            // =====================================================

            this.pnlCanvas.BackColor =
                System.Drawing.Color.White;

            this.pnlCanvas.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlCanvas.Location =
                new System.Drawing.Point(250, 70);

            this.pnlCanvas.Name =
                "pnlCanvas";

            this.pnlCanvas.Size =
                new System.Drawing.Size(900, 600);

            this.pnlCanvas.Paint +=
                new System.Windows.Forms.PaintEventHandler(
                    this.pnlCanvas_Paint);

            // =====================================================
            // Controls
            // =====================================================

            this.Controls.Add(
                this.lblTitle);

            this.Controls.Add(
                this.lblX0);

            this.Controls.Add(
                this.lblY0);

            this.Controls.Add(
                this.lblX1);

            this.Controls.Add(
                this.lblY1);

            this.Controls.Add(
                this.lblRadius);

            this.Controls.Add(
                this.lblA);

            this.Controls.Add(
                this.lblB);

            this.Controls.Add(
                this.txtX0);

            this.Controls.Add(
                this.txtY0);

            this.Controls.Add(
                this.txtX1);

            this.Controls.Add(
                this.txtY1);

            this.Controls.Add(
                this.txtRadius);

            this.Controls.Add(
                this.txtA);

            this.Controls.Add(
                this.txtB);

            this.Controls.Add(
                this.btnPoint);

            this.Controls.Add(
                this.btnDDA);

            this.Controls.Add(
                this.btnMidpointLine);

            this.Controls.Add(
                this.btnBresenhamLine);

            this.Controls.Add(
                this.btnMidpointCircle);

            this.Controls.Add(
                this.btnBresenhamCircle);

            this.Controls.Add(
                this.btnEllipse);

            this.Controls.Add(
                this.btnClear);

            this.Controls.Add(
                this.pnlCanvas);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        // =========================================================
        // 创建按钮
        // =========================================================

        private void CreateButton(
            System.Windows.Forms.Button button,
            string text,
            int x,
            int y)
        {
            button.Location =
                new System.Drawing.Point(x, y);

            button.Size =
                new System.Drawing.Size(180, 35);

            button.Text =
                text;

            button.UseVisualStyleBackColor =
                true;

            this.Controls.Add(button);
        }
    }
}

