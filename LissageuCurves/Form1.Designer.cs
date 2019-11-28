namespace LissageuCurves
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.figure1RadioButton = new System.Windows.Forms.RadioButton();
            this.figure2RadioButton = new System.Windows.Forms.RadioButton();
            this.figure3RadioButton = new System.Windows.Forms.RadioButton();
            this.figure4RadioButton = new System.Windows.Forms.RadioButton();
            this.figure5RadioButton = new System.Windows.Forms.RadioButton();
            this.figure6RadioButton = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startManualButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amplitudeNumeric = new System.Windows.Forms.NumericUpDown();
            this.frequencyXNumeric = new System.Windows.Forms.NumericUpDown();
            this.frequencyYNumeric = new System.Windows.Forms.NumericUpDown();
            this.phaseNumeric = new System.Windows.Forms.NumericUpDown();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.frequencyXLabel = new System.Windows.Forms.Label();
            this.frequencyYLabel = new System.Windows.Forms.Label();
            this.PhaseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyXNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyYNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Line";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(413, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // figure1RadioButton
            // 
            this.figure1RadioButton.AutoSize = true;
            this.figure1RadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.figure1RadioButton.Location = new System.Drawing.Point(9, 20);
            this.figure1RadioButton.Name = "figure1RadioButton";
            this.figure1RadioButton.Size = new System.Drawing.Size(108, 19);
            this.figure1RadioButton.TabIndex = 1;
            this.figure1RadioButton.TabStop = true;
            this.figure1RadioButton.Text = "Figure 1(1:2)";
            this.figure1RadioButton.UseVisualStyleBackColor = true;
            this.figure1RadioButton.Click += new System.EventHandler(this.RadioButton1_Click);
            // 
            // figure2RadioButton
            // 
            this.figure2RadioButton.AutoSize = true;
            this.figure2RadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.figure2RadioButton.Location = new System.Drawing.Point(9, 43);
            this.figure2RadioButton.Name = "figure2RadioButton";
            this.figure2RadioButton.Size = new System.Drawing.Size(108, 19);
            this.figure2RadioButton.TabIndex = 2;
            this.figure2RadioButton.TabStop = true;
            this.figure2RadioButton.Text = "Figure 2(3:2)";
            this.figure2RadioButton.UseVisualStyleBackColor = true;
            this.figure2RadioButton.Click += new System.EventHandler(this.RadioButton2_Click);
            // 
            // figure3RadioButton
            // 
            this.figure3RadioButton.AutoSize = true;
            this.figure3RadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.figure3RadioButton.Location = new System.Drawing.Point(9, 66);
            this.figure3RadioButton.Name = "figure3RadioButton";
            this.figure3RadioButton.Size = new System.Drawing.Size(108, 19);
            this.figure3RadioButton.TabIndex = 3;
            this.figure3RadioButton.TabStop = true;
            this.figure3RadioButton.Text = "Figure 3(3:4)";
            this.figure3RadioButton.UseVisualStyleBackColor = true;
            this.figure3RadioButton.Click += new System.EventHandler(this.RadioButton3_Click);
            // 
            // figure4RadioButton
            // 
            this.figure4RadioButton.AutoSize = true;
            this.figure4RadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.figure4RadioButton.Location = new System.Drawing.Point(9, 89);
            this.figure4RadioButton.Name = "figure4RadioButton";
            this.figure4RadioButton.Size = new System.Drawing.Size(108, 19);
            this.figure4RadioButton.TabIndex = 4;
            this.figure4RadioButton.TabStop = true;
            this.figure4RadioButton.Text = "Figure 4(5:4)";
            this.figure4RadioButton.UseVisualStyleBackColor = true;
            this.figure4RadioButton.Click += new System.EventHandler(this.RadioButton4_Click);
            // 
            // figure5RadioButton
            // 
            this.figure5RadioButton.AutoSize = true;
            this.figure5RadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.figure5RadioButton.Location = new System.Drawing.Point(9, 112);
            this.figure5RadioButton.Name = "figure5RadioButton";
            this.figure5RadioButton.Size = new System.Drawing.Size(108, 19);
            this.figure5RadioButton.TabIndex = 5;
            this.figure5RadioButton.TabStop = true;
            this.figure5RadioButton.Text = "Figure 5(5:6)";
            this.figure5RadioButton.UseVisualStyleBackColor = true;
            this.figure5RadioButton.Click += new System.EventHandler(this.RadioButton5_Click);
            // 
            // figure6RadioButton
            // 
            this.figure6RadioButton.AutoSize = true;
            this.figure6RadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.figure6RadioButton.Location = new System.Drawing.Point(9, 135);
            this.figure6RadioButton.Name = "figure6RadioButton";
            this.figure6RadioButton.Size = new System.Drawing.Size(108, 19);
            this.figure6RadioButton.TabIndex = 6;
            this.figure6RadioButton.TabStop = true;
            this.figure6RadioButton.Text = "Figure 6(9:8)";
            this.figure6RadioButton.UseVisualStyleBackColor = true;
            this.figure6RadioButton.Click += new System.EventHandler(this.RadioButton6_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.buttonStart.Location = new System.Drawing.Point(440, 209);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 49);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.Button_Start_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.clearButton.Location = new System.Drawing.Point(440, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 49);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // startManualButton
            // 
            this.startManualButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startManualButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.startManualButton.Location = new System.Drawing.Point(647, 209);
            this.startManualButton.Name = "startManualButton";
            this.startManualButton.Size = new System.Drawing.Size(103, 49);
            this.startManualButton.TabIndex = 12;
            this.startManualButton.Text = "StartR";
            this.startManualButton.UseVisualStyleBackColor = false;
            this.startManualButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.figure6RadioButton);
            this.panel1.Controls.Add(this.figure5RadioButton);
            this.panel1.Controls.Add(this.figure4RadioButton);
            this.panel1.Controls.Add(this.figure3RadioButton);
            this.panel1.Controls.Add(this.figure2RadioButton);
            this.panel1.Controls.Add(this.figure1RadioButton);
            this.panel1.Location = new System.Drawing.Point(431, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 163);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manually";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label2.Location = new System.Drawing.Point(454, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Auto";
            // 
            // amplitudeNumeric
            // 
            this.amplitudeNumeric.Location = new System.Drawing.Point(687, 72);
            this.amplitudeNumeric.Name = "amplitudeNumeric";
            this.amplitudeNumeric.Size = new System.Drawing.Size(104, 20);
            this.amplitudeNumeric.TabIndex = 16;
            this.amplitudeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // frequencyXNumeric
            // 
            this.frequencyXNumeric.Location = new System.Drawing.Point(687, 98);
            this.frequencyXNumeric.Name = "frequencyXNumeric";
            this.frequencyXNumeric.Size = new System.Drawing.Size(104, 20);
            this.frequencyXNumeric.TabIndex = 16;
            this.frequencyXNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frequencyYNumeric
            // 
            this.frequencyYNumeric.Location = new System.Drawing.Point(687, 124);
            this.frequencyYNumeric.Name = "frequencyYNumeric";
            this.frequencyYNumeric.Size = new System.Drawing.Size(104, 20);
            this.frequencyYNumeric.TabIndex = 17;
            this.frequencyYNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // phaseNumeric
            // 
            this.phaseNumeric.Location = new System.Drawing.Point(688, 150);
            this.phaseNumeric.Name = "phaseNumeric";
            this.phaseNumeric.Size = new System.Drawing.Size(103, 20);
            this.phaseNumeric.TabIndex = 18;
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitudeLabel.Location = new System.Drawing.Point(584, 73);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(73, 15);
            this.amplitudeLabel.TabIndex = 19;
            this.amplitudeLabel.Text = "Amplitude";
            // 
            // frequencyXLabel
            // 
            this.frequencyXLabel.AutoSize = true;
            this.frequencyXLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyXLabel.Location = new System.Drawing.Point(584, 99);
            this.frequencyXLabel.Name = "frequencyXLabel";
            this.frequencyXLabel.Size = new System.Drawing.Size(97, 15);
            this.frequencyXLabel.TabIndex = 20;
            this.frequencyXLabel.Text = "Frequency (X)";
            // 
            // frequencyYLabel
            // 
            this.frequencyYLabel.AutoSize = true;
            this.frequencyYLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyYLabel.Location = new System.Drawing.Point(584, 128);
            this.frequencyYLabel.Name = "frequencyYLabel";
            this.frequencyYLabel.Size = new System.Drawing.Size(97, 15);
            this.frequencyYLabel.TabIndex = 21;
            this.frequencyYLabel.Text = "Frequency (Y)";
            // 
            // PhaseLabel
            // 
            this.PhaseLabel.AutoSize = true;
            this.PhaseLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhaseLabel.Location = new System.Drawing.Point(584, 156);
            this.PhaseLabel.Name = "PhaseLabel";
            this.PhaseLabel.Size = new System.Drawing.Size(47, 15);
            this.PhaseLabel.TabIndex = 22;
            this.PhaseLabel.Text = "Phase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PhaseLabel);
            this.Controls.Add(this.frequencyYLabel);
            this.Controls.Add(this.frequencyXLabel);
            this.Controls.Add(this.amplitudeLabel);
            this.Controls.Add(this.phaseNumeric);
            this.Controls.Add(this.frequencyYNumeric);
            this.Controls.Add(this.frequencyXNumeric);
            this.Controls.Add(this.amplitudeNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startManualButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyXNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyYNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton figure1RadioButton;
        private System.Windows.Forms.RadioButton figure2RadioButton;
        private System.Windows.Forms.RadioButton figure3RadioButton;
        private System.Windows.Forms.RadioButton figure4RadioButton;
        private System.Windows.Forms.RadioButton figure5RadioButton;
        private System.Windows.Forms.RadioButton figure6RadioButton;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button startManualButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amplitudeNumeric;
        private System.Windows.Forms.NumericUpDown frequencyXNumeric;
        private System.Windows.Forms.NumericUpDown frequencyYNumeric;
        private System.Windows.Forms.NumericUpDown phaseNumeric;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label frequencyXLabel;
        private System.Windows.Forms.Label frequencyYLabel;
        private System.Windows.Forms.Label PhaseLabel;
    }
}

