using System.Windows.Forms.DataVisualization.Charting;

namespace Theatre
{
    public partial class Form1 : Form
    {
        private double GetRandomDouble(double minValue, double maxValue)
        {
            return minValue + rnd.NextDouble() * (maxValue - minValue);
        }


        private Random rnd = new Random();
        private int xValue = 0;


        // Константы
        private double distanceCoef;
        private double baseTicketPrice;
        private double expanses = 0.6; // Опер. расходы

        // Случайные параметры
        private double advertCoef;
        private int visitorsAmount;

        // Просчитываемые параметры
        double popularityCoef;
        double curTicketPrice;
        double reinvestmentCoef = 1;

        // Прочие
        double ticketPriceCoef;
        double totalSales;
        double freeCapital;
        double reinvestment;
        double finalSum;


        private void CalcPopularity()
        {
            popularityCoef = distanceCoef * advertCoef * reinvestmentCoef;
            popularityLabel.Text = popularityCoef.ToString("F2");
        }

        private void CalcCurTicketPrice()
        {
            curTicketPrice = baseTicketPrice * reinvestmentCoef * popularityCoef;
            ticketPriceLabel.Text = curTicketPrice.ToString("F2") + " ₽";

            ticketPriceCoef = baseTicketPrice / curTicketPrice;
        }

        private void CalcVisitorsAmount()
        {
            visitorsAmount = Convert.ToInt32(rnd.Next(1000, 2000) * popularityCoef * ticketPriceCoef);
            visitorsLabel.Text = visitorsAmount.ToString();
        }

        private void CalcTotalSales()
        {
            totalSales = curTicketPrice * visitorsAmount;
            totalSalesLabel.Text = totalSales.ToString("F2") + " ₽";
        }

        private void CalcFreeCapital()
        {
            // Из прибыли вычисляем издержки
            freeCapital = totalSales - totalSales * expanses;
            freeCapitalLabel.Text = freeCapital.ToString("F2") + " ₽";
        }

        private void CalcReinvestment()
        {
            // Отдаем 30 процентов на реинвестицию
            reinvestment = freeCapital * 0.3;
            reinvestLabel.Text = reinvestment.ToString("F2") + " ₽";
            freeCapital -= reinvestment;
        }



        private void Calculate()
        {
            CalcPopularity();
            CalcCurTicketPrice();
            CalcVisitorsAmount();
            CalcTotalSales();
            CalcFreeCapital();


            // 30 прцоентов забирает самый главный || ПОЛУЧАЕМ ИТОГУВУЮ СУММУ ЗА ДЕНЬ
            finalSum = freeCapital - (freeCapital * 0.3);
            DrawPoint(finalSum);


            CalcReinvestment();
            // Вычисляем коэф реинвестиций для будущих итераций
            if (reinvestment < 100000)
            {
                reinvestmentCoef = 1;
            }
            else
            {
                reinvestmentCoef = reinvestment / 1000000 + 1;
            }
        }

        private void DrawPoint(double yValue)
        {
            // Добавление точки в серию данных
            chart1.Series[0].Points.AddXY(xValue, yValue);

            // Перерисовка графика
            chart1.Invalidate();

            xValue++;
        }


        private void StartButtonModelingText()
        {
            switch (startBtn.Text)
            {
                case "МОДЕЛИРУЕМ.":
                    startBtn.Text = "МОДЕЛИРУЕМ..";
                    break;

                case "МОДЕЛИРУЕМ..":
                    startBtn.Text = "МОДЕЛИРУЕМ...";
                    break;

                case "МОДЕЛИРУЕМ...":
                    startBtn.Text = "МОДЕЛИРУЕМ.";
                    break;
            }
        }


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (startBtn.Text == "CTAРТ")
            {
                startBtn.Text = "МОДЕЛИРУЕМ.";
            }

            else if (startBtn.Text == "ПРОДОЛЖИТЬ")
            {
                startBtn.Text = "МОДЕЛИРУЕМ.";
            }

            restartBtn.Visible = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startBtn.Text = "ПРОДОЛЖИТЬ";
            restartBtn.Visible = true;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            timer1.Start();
            startBtn.Text = "МОДЕЛИРУЕМ.";
            restartBtn.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartButtonModelingText();

            try
            {
                distanceCoef = Convert.ToDouble(distanceTextBox.Text);
                baseTicketPrice = Convert.ToDouble(ticketPriceTextBox.Text);
            }
            catch
            {
                timer1.Stop();
                MessageBox.Show("Неверно указанны значения в полях");
                return;
            }

            //expanses = Convert.ToDouble(expensesTextBox.Text);

            advertCoef = GetRandomDouble(0.7, 2);
            advertСoefLabel.Text = advertCoef.ToString("F2");

            Calculate();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
