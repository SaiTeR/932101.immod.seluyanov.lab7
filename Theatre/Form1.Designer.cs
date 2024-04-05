namespace Theatre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            timer1 = new System.Windows.Forms.Timer(components);
            stopBtn = new Button();
            startBtn = new Button();
            label1 = new Label();
            ticketPriceTextBox = new TextBox();
            label3 = new Label();
            ticketPriceLabel = new Label();
            totalSalesLabel = new Label();
            label5 = new Label();
            distanceTextBox = new TextBox();
            label4 = new Label();
            popularityLabel = new Label();
            label7 = new Label();
            advertСoefLabel = new Label();
            label8 = new Label();
            visitorsLabel = new Label();
            label10 = new Label();
            freeCapitalLabel = new Label();
            label9 = new Label();
            reinvestLabel = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            restartBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(15, 318);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Выручка";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1291, 360);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // stopBtn
            // 
            stopBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stopBtn.Location = new Point(882, 134);
            stopBtn.Margin = new Padding(4);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(335, 50);
            stopBtn.TabIndex = 1;
            stopBtn.Text = "СТОП";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startBtn.Location = new Point(882, 19);
            startBtn.Margin = new Padding(4);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(335, 50);
            startBtn.TabIndex = 2;
            startBtn.Text = "CTAРТ";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(8, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 3;
            label1.Text = "Базовая цена билета";
            // 
            // ticketPriceTextBox
            // 
            ticketPriceTextBox.Location = new Point(181, 32);
            ticketPriceTextBox.Margin = new Padding(4);
            ticketPriceTextBox.Name = "ticketPriceTextBox";
            ticketPriceTextBox.Size = new Size(127, 24);
            ticketPriceTextBox.TabIndex = 4;
            ticketPriceTextBox.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(7, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 18);
            label3.TabIndex = 7;
            label3.Text = "Текущая цена билета:";
            // 
            // ticketPriceLabel
            // 
            ticketPriceLabel.AutoSize = true;
            ticketPriceLabel.Location = new Point(178, 102);
            ticketPriceLabel.Margin = new Padding(4, 0, 4, 0);
            ticketPriceLabel.Name = "ticketPriceLabel";
            ticketPriceLabel.Size = new Size(18, 18);
            ticketPriceLabel.TabIndex = 8;
            ticketPriceLabel.Text = "--";
            // 
            // totalSalesLabel
            // 
            totalSalesLabel.AutoSize = true;
            totalSalesLabel.Location = new Point(178, 169);
            totalSalesLabel.Margin = new Padding(4, 0, 4, 0);
            totalSalesLabel.Name = "totalSalesLabel";
            totalSalesLabel.Size = new Size(18, 18);
            totalSalesLabel.TabIndex = 10;
            totalSalesLabel.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F);
            label5.Location = new Point(7, 169);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 9;
            label5.Text = "Объем продаж:";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(181, 76);
            distanceTextBox.Margin = new Padding(4);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(127, 24);
            distanceTextBox.TabIndex = 12;
            distanceTextBox.Text = "0,7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(8, 79);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 11;
            label4.Text = "Удаленность тетара";
            // 
            // popularityLabel
            // 
            popularityLabel.AutoSize = true;
            popularityLabel.Location = new Point(178, 58);
            popularityLabel.Margin = new Padding(4, 0, 4, 0);
            popularityLabel.Name = "popularityLabel";
            popularityLabel.Size = new Size(18, 18);
            popularityLabel.TabIndex = 14;
            popularityLabel.Text = "--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F);
            label7.Location = new Point(7, 58);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 18);
            label7.TabIndex = 13;
            label7.Text = "Популярность:";
            // 
            // advertСoefLabel
            // 
            advertСoefLabel.AutoSize = true;
            advertСoefLabel.Location = new Point(178, 26);
            advertСoefLabel.Margin = new Padding(4, 0, 4, 0);
            advertСoefLabel.Name = "advertСoefLabel";
            advertСoefLabel.Size = new Size(18, 18);
            advertСoefLabel.TabIndex = 16;
            advertСoefLabel.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(7, 26);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 15;
            label8.Text = "Влияние рекламы:";
            // 
            // visitorsLabel
            // 
            visitorsLabel.AutoSize = true;
            visitorsLabel.Location = new Point(178, 136);
            visitorsLabel.Margin = new Padding(4, 0, 4, 0);
            visitorsLabel.Name = "visitorsLabel";
            visitorsLabel.Size = new Size(18, 18);
            visitorsLabel.TabIndex = 18;
            visitorsLabel.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F);
            label10.Location = new Point(7, 136);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(154, 18);
            label10.TabIndex = 17;
            label10.Text = "Кол-во посетителей:";
            // 
            // freeCapitalLabel
            // 
            freeCapitalLabel.AutoSize = true;
            freeCapitalLabel.Location = new Point(178, 204);
            freeCapitalLabel.Margin = new Padding(4, 0, 4, 0);
            freeCapitalLabel.Name = "freeCapitalLabel";
            freeCapitalLabel.Size = new Size(18, 18);
            freeCapitalLabel.TabIndex = 20;
            freeCapitalLabel.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F);
            label9.Location = new Point(7, 204);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 18);
            label9.TabIndex = 19;
            label9.Text = "Свободный капитал:";
            // 
            // reinvestLabel
            // 
            reinvestLabel.AutoSize = true;
            reinvestLabel.Location = new Point(178, 238);
            reinvestLabel.Margin = new Padding(4, 0, 4, 0);
            reinvestLabel.Name = "reinvestLabel";
            reinvestLabel.Size = new Size(18, 18);
            reinvestLabel.TabIndex = 22;
            reinvestLabel.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F);
            label11.Location = new Point(7, 238);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 18);
            label11.TabIndex = 21;
            label11.Text = "Реинвестиция:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ticketPriceTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(distanceTextBox);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(327, 120);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(reinvestLabel);
            groupBox2.Controls.Add(ticketPriceLabel);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(freeCapitalLabel);
            groupBox2.Controls.Add(totalSalesLabel);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(visitorsLabel);
            groupBox2.Controls.Add(popularityLabel);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(advertСoefLabel);
            groupBox2.Location = new Point(387, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 284);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Показатели";
            // 
            // restartBtn
            // 
            restartBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            restartBtn.Location = new Point(882, 247);
            restartBtn.Margin = new Padding(4);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(335, 50);
            restartBtn.TabIndex = 25;
            restartBtn.Text = "РЕСТАРТ";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Visible = false;
            restartBtn.Click += restartBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 692);
            Controls.Add(restartBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(startBtn);
            Controls.Add(stopBtn);
            Controls.Add(chart1);
            Font = new Font("Microsoft Sans Serif", 11.25F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Theatre";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private Button stopBtn;
        private Button startBtn;
        private Label label1;
        private TextBox ticketPriceTextBox;
        private Label label3;
        private Label ticketPriceLabel;
        private Label totalSalesLabel;
        private Label label5;
        private TextBox distanceTextBox;
        private Label label4;
        private Label popularityLabel;
        private Label label7;
        private Label advertСoefLabel;
        private Label label8;
        private Label visitorsLabel;
        private Label label10;
        private Label freeCapitalLabel;
        private Label label9;
        private Label reinvestLabel;
        private Label label11;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button restartBtn;
    }
}
