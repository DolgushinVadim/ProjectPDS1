
namespace Program
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.pictureBoxVarp = new System.Windows.Forms.PictureBox();
            this.pictureBoxVarr = new System.Windows.Forms.PictureBox();
            this.pictureBoxVarRk = new System.Windows.Forms.PictureBox();
            this.pictureBoxVarPz = new System.Windows.Forms.PictureBox();
            this.pictureBoxVarPp = new System.Windows.Forms.PictureBox();
            this.pictureBoxVaru = new System.Windows.Forms.PictureBox();
            this.pictureBoxVarh = new System.Windows.Forms.PictureBox();
            this.pictureBoxVark = new System.Windows.Forms.PictureBox();
            this.textBoxVarp = new System.Windows.Forms.TextBox();
            this.textBoxVark = new System.Windows.Forms.TextBox();
            this.textBoxVarPp = new System.Windows.Forms.TextBox();
            this.textBoxVarRk = new System.Windows.Forms.TextBox();
            this.textBoxVarr = new System.Windows.Forms.TextBox();
            this.textBoxVaru = new System.Windows.Forms.TextBox();
            this.textBoxVarPz = new System.Windows.Forms.TextBox();
            this.textBoxVarh = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarRk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarPz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarPp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVark)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(23, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(735, 153);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Информация:";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = global::Program.Properties.Resources.FormulaD;
            this.pictureBoxFormula.Location = new System.Drawing.Point(365, 21);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(361, 126);
            this.pictureBoxFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(353, 126);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.label2);
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Controls.Add(this.textBoxResult2);
            this.groupBoxOutput.Controls.Add(this.chartGraph);
            this.groupBoxOutput.Controls.Add(this.pictureBoxResult);
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(764, 33);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(577, 437);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "м^3/ч";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(206, 67);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(43, 17);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "м^3/с";
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(302, 62);
            this.textBoxResult2.Multiline = true;
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.ReadOnly = true;
            this.textBoxResult2.Size = new System.Drawing.Size(191, 22);
            this.textBoxResult2.TabIndex = 6;
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(6, 90);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(430, 321);
            this.chartGraph.TabIndex = 5;
            this.chartGraph.Text = "chart1";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Image = global::Program.Properties.Resources.Result;
            this.pictureBoxResult.Location = new System.Drawing.Point(6, 31);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(194, 25);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 4;
            this.pictureBoxResult.TabStop = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 62);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(194, 22);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.pictureBoxVarp);
            this.groupBoxInput.Controls.Add(this.pictureBoxVarr);
            this.groupBoxInput.Controls.Add(this.pictureBoxVarRk);
            this.groupBoxInput.Controls.Add(this.pictureBoxVarPz);
            this.groupBoxInput.Controls.Add(this.pictureBoxVarPp);
            this.groupBoxInput.Controls.Add(this.pictureBoxVaru);
            this.groupBoxInput.Controls.Add(this.pictureBoxVarh);
            this.groupBoxInput.Controls.Add(this.pictureBoxVark);
            this.groupBoxInput.Controls.Add(this.textBoxVarp);
            this.groupBoxInput.Controls.Add(this.textBoxVark);
            this.groupBoxInput.Controls.Add(this.textBoxVarPp);
            this.groupBoxInput.Controls.Add(this.textBoxVarRk);
            this.groupBoxInput.Controls.Add(this.textBoxVarr);
            this.groupBoxInput.Controls.Add(this.textBoxVaru);
            this.groupBoxInput.Controls.Add(this.textBoxVarPz);
            this.groupBoxInput.Controls.Add(this.textBoxVarh);
            this.groupBoxInput.Location = new System.Drawing.Point(23, 197);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(735, 340);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных:";
            // 
            // pictureBoxVarp
            // 
            this.pictureBoxVarp.Image = global::Program.Properties.Resources.Varp;
            this.pictureBoxVarp.Location = new System.Drawing.Point(398, 255);
            this.pictureBoxVarp.Name = "pictureBoxVarp";
            this.pictureBoxVarp.Size = new System.Drawing.Size(246, 37);
            this.pictureBoxVarp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVarp.TabIndex = 17;
            this.pictureBoxVarp.TabStop = false;
            // 
            // pictureBoxVarr
            // 
            this.pictureBoxVarr.Image = global::Program.Properties.Resources.Varrc;
            this.pictureBoxVarr.Location = new System.Drawing.Point(398, 175);
            this.pictureBoxVarr.Name = "pictureBoxVarr";
            this.pictureBoxVarr.Size = new System.Drawing.Size(190, 31);
            this.pictureBoxVarr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVarr.TabIndex = 16;
            this.pictureBoxVarr.TabStop = false;
            // 
            // pictureBoxVarRk
            // 
            this.pictureBoxVarRk.Image = global::Program.Properties.Resources.VarRk;
            this.pictureBoxVarRk.Location = new System.Drawing.Point(398, 93);
            this.pictureBoxVarRk.Name = "pictureBoxVarRk";
            this.pictureBoxVarRk.Size = new System.Drawing.Size(309, 33);
            this.pictureBoxVarRk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVarRk.TabIndex = 15;
            this.pictureBoxVarRk.TabStop = false;
            // 
            // pictureBoxVarPz
            // 
            this.pictureBoxVarPz.Image = global::Program.Properties.Resources.VarPz;
            this.pictureBoxVarPz.Location = new System.Drawing.Point(398, 17);
            this.pictureBoxVarPz.Name = "pictureBoxVarPz";
            this.pictureBoxVarPz.Size = new System.Drawing.Size(269, 29);
            this.pictureBoxVarPz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVarPz.TabIndex = 14;
            this.pictureBoxVarPz.TabStop = false;
            // 
            // pictureBoxVarPp
            // 
            this.pictureBoxVarPp.Image = global::Program.Properties.Resources.VarPp;
            this.pictureBoxVarPp.Location = new System.Drawing.Point(6, 259);
            this.pictureBoxVarPp.Name = "pictureBoxVarPp";
            this.pictureBoxVarPp.Size = new System.Drawing.Size(212, 33);
            this.pictureBoxVarPp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVarPp.TabIndex = 13;
            this.pictureBoxVarPp.TabStop = false;
            // 
            // pictureBoxVaru
            // 
            this.pictureBoxVaru.Image = global::Program.Properties.Resources.Varu;
            this.pictureBoxVaru.Location = new System.Drawing.Point(6, 175);
            this.pictureBoxVaru.Name = "pictureBoxVaru";
            this.pictureBoxVaru.Size = new System.Drawing.Size(341, 31);
            this.pictureBoxVaru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVaru.TabIndex = 12;
            this.pictureBoxVaru.TabStop = false;
            // 
            // pictureBoxVarh
            // 
            this.pictureBoxVarh.Image = global::Program.Properties.Resources.Varh;
            this.pictureBoxVarh.Location = new System.Drawing.Point(6, 95);
            this.pictureBoxVarh.Name = "pictureBoxVarh";
            this.pictureBoxVarh.Size = new System.Drawing.Size(179, 31);
            this.pictureBoxVarh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVarh.TabIndex = 4;
            this.pictureBoxVarh.TabStop = false;
            // 
            // pictureBoxVark
            // 
            this.pictureBoxVark.Image = global::Program.Properties.Resources.Vark;
            this.pictureBoxVark.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxVark.Name = "pictureBoxVark";
            this.pictureBoxVark.Size = new System.Drawing.Size(272, 29);
            this.pictureBoxVark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVark.TabIndex = 4;
            this.pictureBoxVark.TabStop = false;
            // 
            // textBoxVarp
            // 
            this.textBoxVarp.Location = new System.Drawing.Point(398, 298);
            this.textBoxVarp.Name = "textBoxVarp";
            this.textBoxVarp.Size = new System.Drawing.Size(269, 22);
            this.textBoxVarp.TabIndex = 11;
            // 
            // textBoxVark
            // 
            this.textBoxVark.Location = new System.Drawing.Point(6, 56);
            this.textBoxVark.Name = "textBoxVark";
            this.textBoxVark.Size = new System.Drawing.Size(272, 22);
            this.textBoxVark.TabIndex = 10;
            // 
            // textBoxVarPp
            // 
            this.textBoxVarPp.Location = new System.Drawing.Point(6, 298);
            this.textBoxVarPp.Name = "textBoxVarPp";
            this.textBoxVarPp.Size = new System.Drawing.Size(272, 22);
            this.textBoxVarPp.TabIndex = 5;
            // 
            // textBoxVarRk
            // 
            this.textBoxVarRk.Location = new System.Drawing.Point(398, 132);
            this.textBoxVarRk.Name = "textBoxVarRk";
            this.textBoxVarRk.Size = new System.Drawing.Size(269, 22);
            this.textBoxVarRk.TabIndex = 6;
            // 
            // textBoxVarr
            // 
            this.textBoxVarr.Location = new System.Drawing.Point(398, 212);
            this.textBoxVarr.Name = "textBoxVarr";
            this.textBoxVarr.Size = new System.Drawing.Size(269, 22);
            this.textBoxVarr.TabIndex = 4;
            // 
            // textBoxVaru
            // 
            this.textBoxVaru.Location = new System.Drawing.Point(6, 212);
            this.textBoxVaru.Name = "textBoxVaru";
            this.textBoxVaru.Size = new System.Drawing.Size(272, 22);
            this.textBoxVaru.TabIndex = 9;
            // 
            // textBoxVarPz
            // 
            this.textBoxVarPz.Location = new System.Drawing.Point(398, 52);
            this.textBoxVarPz.Name = "textBoxVarPz";
            this.textBoxVarPz.Size = new System.Drawing.Size(269, 22);
            this.textBoxVarPz.TabIndex = 8;
            // 
            // textBoxVarh
            // 
            this.textBoxVarh.Location = new System.Drawing.Point(6, 132);
            this.textBoxVarh.Name = "textBoxVarh";
            this.textBoxVarh.Size = new System.Drawing.Size(272, 22);
            this.textBoxVarh.TabIndex = 7;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Location = new System.Drawing.Point(1195, 476);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(146, 61);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp.Location = new System.Drawing.Point(1061, 476);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(105, 61);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 549);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxTask);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование притока к вертикальным газовым скважинам";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarRk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarPz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarPp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVarh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxVarp;
        private System.Windows.Forms.TextBox textBoxVark;
        private System.Windows.Forms.TextBox textBoxVarPp;
        private System.Windows.Forms.TextBox textBoxVarRk;
        private System.Windows.Forms.TextBox textBoxVarr;
        private System.Windows.Forms.TextBox textBoxVaru;
        private System.Windows.Forms.TextBox textBoxVarPz;
        private System.Windows.Forms.TextBox textBoxVarh;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxVark;
        private System.Windows.Forms.PictureBox pictureBoxVarh;
        private System.Windows.Forms.PictureBox pictureBoxVaru;
        private System.Windows.Forms.PictureBox pictureBoxVarPp;
        private System.Windows.Forms.PictureBox pictureBoxVarPz;
        private System.Windows.Forms.PictureBox pictureBoxVarRk;
        private System.Windows.Forms.PictureBox pictureBoxVarr;
        private System.Windows.Forms.PictureBox pictureBoxVarp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult2;
    }
}

