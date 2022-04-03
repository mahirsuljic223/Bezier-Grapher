
namespace Bezier_Grapher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.num_P0X = new System.Windows.Forms.NumericUpDown();
            this.num_P0Y = new System.Windows.Forms.NumericUpDown();
            this.num_P1Y = new System.Windows.Forms.NumericUpDown();
            this.num_P1X = new System.Windows.Forms.NumericUpDown();
            this.num_P2Y = new System.Windows.Forms.NumericUpDown();
            this.num_P2X = new System.Windows.Forms.NumericUpDown();
            this.num_P3Y = new System.Windows.Forms.NumericUpDown();
            this.num_P3X = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_dY = new System.Windows.Forms.NumericUpDown();
            this.num_dX = new System.Windows.Forms.NumericUpDown();
            this.tbar_range = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_range = new System.Windows.Forms.Label();
            this.num_dL = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.num_k = new System.Windows.Forms.NumericUpDown();
            this.btn_dup = new System.Windows.Forms.Button();
            this.num_scaleX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.num_scaleY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P0X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P0Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P1X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P3Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P3X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_scaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_scaleY)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_main
            // 
            this.pb_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_main.Location = new System.Drawing.Point(0, 77);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(800, 484);
            this.pb_main.TabIndex = 0;
            this.pb_main.TabStop = false;
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(688, 9);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(100, 30);
            this.btn_graph.TabIndex = 15;
            this.btn_graph.Text = "Graph";
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(738, 41);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(50, 30);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // num_P0X
            // 
            this.num_P0X.DecimalPlaces = 2;
            this.num_P0X.Location = new System.Drawing.Point(12, 25);
            this.num_P0X.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P0X.Name = "num_P0X";
            this.num_P0X.Size = new System.Drawing.Size(44, 20);
            this.num_P0X.TabIndex = 0;
            // 
            // num_P0Y
            // 
            this.num_P0Y.DecimalPlaces = 2;
            this.num_P0Y.Location = new System.Drawing.Point(12, 51);
            this.num_P0Y.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P0Y.Name = "num_P0Y";
            this.num_P0Y.Size = new System.Drawing.Size(44, 20);
            this.num_P0Y.TabIndex = 1;
            // 
            // num_P1Y
            // 
            this.num_P1Y.DecimalPlaces = 2;
            this.num_P1Y.Location = new System.Drawing.Point(73, 51);
            this.num_P1Y.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P1Y.Name = "num_P1Y";
            this.num_P1Y.Size = new System.Drawing.Size(44, 20);
            this.num_P1Y.TabIndex = 3;
            // 
            // num_P1X
            // 
            this.num_P1X.DecimalPlaces = 2;
            this.num_P1X.Location = new System.Drawing.Point(73, 25);
            this.num_P1X.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P1X.Name = "num_P1X";
            this.num_P1X.Size = new System.Drawing.Size(44, 20);
            this.num_P1X.TabIndex = 2;
            // 
            // num_P2Y
            // 
            this.num_P2Y.DecimalPlaces = 2;
            this.num_P2Y.Location = new System.Drawing.Point(134, 51);
            this.num_P2Y.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P2Y.Name = "num_P2Y";
            this.num_P2Y.Size = new System.Drawing.Size(44, 20);
            this.num_P2Y.TabIndex = 5;
            // 
            // num_P2X
            // 
            this.num_P2X.DecimalPlaces = 2;
            this.num_P2X.Location = new System.Drawing.Point(134, 25);
            this.num_P2X.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P2X.Name = "num_P2X";
            this.num_P2X.Size = new System.Drawing.Size(44, 20);
            this.num_P2X.TabIndex = 4;
            // 
            // num_P3Y
            // 
            this.num_P3Y.DecimalPlaces = 2;
            this.num_P3Y.Location = new System.Drawing.Point(195, 51);
            this.num_P3Y.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P3Y.Name = "num_P3Y";
            this.num_P3Y.Size = new System.Drawing.Size(44, 20);
            this.num_P3Y.TabIndex = 7;
            // 
            // num_P3X
            // 
            this.num_P3X.DecimalPlaces = 2;
            this.num_P3X.Location = new System.Drawing.Point(195, 25);
            this.num_P3X.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_P3X.Name = "num_P3X";
            this.num_P3X.Size = new System.Drawing.Size(44, 20);
            this.num_P3X.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "P0 (x, y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "P1 (x, y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "P2 (x, y)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "P3 (x, y)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "dX, dY";
            // 
            // num_dY
            // 
            this.num_dY.DecimalPlaces = 2;
            this.num_dY.Location = new System.Drawing.Point(253, 51);
            this.num_dY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_dY.Name = "num_dY";
            this.num_dY.Size = new System.Drawing.Size(44, 20);
            this.num_dY.TabIndex = 9;
            // 
            // num_dX
            // 
            this.num_dX.DecimalPlaces = 2;
            this.num_dX.Location = new System.Drawing.Point(253, 25);
            this.num_dX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_dX.Name = "num_dX";
            this.num_dX.Size = new System.Drawing.Size(44, 20);
            this.num_dX.TabIndex = 8;
            // 
            // tbar_range
            // 
            this.tbar_range.LargeChange = 10;
            this.tbar_range.Location = new System.Drawing.Point(442, 30);
            this.tbar_range.Maximum = 100;
            this.tbar_range.Name = "tbar_range";
            this.tbar_range.Size = new System.Drawing.Size(240, 45);
            this.tbar_range.TabIndex = 14;
            this.tbar_range.Value = 100;
            this.tbar_range.Scroll += new System.EventHandler(this.tbar_range_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "1";
            // 
            // lb_range
            // 
            this.lb_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_range.Location = new System.Drawing.Point(442, 9);
            this.lb_range.Name = "lb_range";
            this.lb_range.Size = new System.Drawing.Size(240, 20);
            this.lb_range.TabIndex = 20;
            this.lb_range.Text = "1";
            this.lb_range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_dL
            // 
            this.num_dL.DecimalPlaces = 3;
            this.num_dL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num_dL.Location = new System.Drawing.Point(312, 25);
            this.num_dL.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_dL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.num_dL.Name = "num_dL";
            this.num_dL.Size = new System.Drawing.Size(51, 20);
            this.num_dL.TabIndex = 10;
            this.num_dL.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "dL, k";
            // 
            // num_k
            // 
            this.num_k.DecimalPlaces = 1;
            this.num_k.Location = new System.Drawing.Point(312, 51);
            this.num_k.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_k.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_k.Name = "num_k";
            this.num_k.Size = new System.Drawing.Size(51, 20);
            this.num_k.TabIndex = 11;
            this.num_k.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_dup
            // 
            this.btn_dup.Location = new System.Drawing.Point(688, 41);
            this.btn_dup.Name = "btn_dup";
            this.btn_dup.Size = new System.Drawing.Size(50, 30);
            this.btn_dup.TabIndex = 16;
            this.btn_dup.Text = "Dup";
            this.btn_dup.UseVisualStyleBackColor = true;
            this.btn_dup.Click += new System.EventHandler(this.btn_dup_Click);
            // 
            // num_scaleX
            // 
            this.num_scaleX.DecimalPlaces = 1;
            this.num_scaleX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.num_scaleX.Location = new System.Drawing.Point(377, 25);
            this.num_scaleX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_scaleX.Name = "num_scaleX";
            this.num_scaleX.Size = new System.Drawing.Size(52, 20);
            this.num_scaleX.TabIndex = 12;
            this.num_scaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "scale x,y";
            // 
            // num_scaleY
            // 
            this.num_scaleY.DecimalPlaces = 1;
            this.num_scaleY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.num_scaleY.Location = new System.Drawing.Point(377, 51);
            this.num_scaleY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_scaleY.Name = "num_scaleY";
            this.num_scaleY.Size = new System.Drawing.Size(52, 20);
            this.num_scaleY.TabIndex = 13;
            this.num_scaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.num_scaleY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_scaleX);
            this.Controls.Add(this.btn_dup);
            this.Controls.Add(this.num_k);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_dL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbar_range);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_dY);
            this.Controls.Add(this.num_dX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_P3Y);
            this.Controls.Add(this.num_P3X);
            this.Controls.Add(this.num_P2Y);
            this.Controls.Add(this.num_P2X);
            this.Controls.Add(this.num_P1Y);
            this.Controls.Add(this.num_P1X);
            this.Controls.Add(this.num_P0Y);
            this.Controls.Add(this.num_P0X);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.pb_main);
            this.Controls.Add(this.lb_range);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bezier Curve Grapher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P0X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P0Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P1X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P3Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_P3X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_scaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_scaleY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.NumericUpDown num_P0X;
        private System.Windows.Forms.NumericUpDown num_P0Y;
        private System.Windows.Forms.NumericUpDown num_P1Y;
        private System.Windows.Forms.NumericUpDown num_P1X;
        private System.Windows.Forms.NumericUpDown num_P2Y;
        private System.Windows.Forms.NumericUpDown num_P2X;
        private System.Windows.Forms.NumericUpDown num_P3Y;
        private System.Windows.Forms.NumericUpDown num_P3X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_dY;
        private System.Windows.Forms.NumericUpDown num_dX;
        private System.Windows.Forms.TrackBar tbar_range;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_range;
        private System.Windows.Forms.NumericUpDown num_dL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_k;
        private System.Windows.Forms.Button btn_dup;
        private System.Windows.Forms.NumericUpDown num_scaleX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_scaleY;
    }
}

