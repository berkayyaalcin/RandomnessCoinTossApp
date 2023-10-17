using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomnessCoinTossApp
{
    public partial class MainForm : Form
    {
        Random random = new Random();

        ModuleLog moduleLog = new ModuleLog();

        NumericUpDown[] AttemptsList;

        Chart[] ChartList;

        int heads, tails;
        double headsPercent, tailsPercent;

        Series headsSeries, tailsSeries;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateHeadOrTails(int attempts, double invalid, Chart chart)
        {
            chart.Series.Clear();
            heads = 0; tails = 0; //Heads : Yazı , Tails ; Tura.
            
            double newAttempts = attempts * (1 - (invalid / 100));

            headsSeries = new Series();
            tailsSeries = new Series();

            headsSeries.ChartType = SeriesChartType.Column;
            headsSeries.Color = Color.Red;

            tailsSeries.ChartType = SeriesChartType.Column;
            tailsSeries.Color = Color.Turquoise;

            for (int i = 0; i < newAttempts; i++)
            {
                int rand = random.Next();

                if (rand % 2 == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                headsPercent = 100 * ((double)heads / (heads + tails));
                tailsPercent = 100 * ((double)tails / (heads + tails));

                headsSeries.Points.AddXY(i + 1, headsPercent);
                tailsSeries.Points.AddXY(i + 1, tailsPercent);
            }

            headsSeries.Name = "Yazı % " + headsPercent.ToString("F2");
            tailsSeries.Name = "Tura % " + tailsPercent.ToString("F2");

            chart.Series.Add(headsSeries);
            chart.Series.Add(tailsSeries);

            chart.DataBind();

            moduleLog.OutputLog(attempts, heads,tails,newAttempts);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AttemptsList = new NumericUpDown[] { numericUpDownTryCount1, numericUpDownTryCount2, numericUpDownTryCount3 };
            ChartList = new Chart[] { graphOfTryCount1, graphOfTryCount2, graphOfTryCount3 };

            try
            {
                for (int i = 0; i < AttemptsList.Length; i++)
                {
                    CalculateHeadOrTails((int)AttemptsList[i].Value, (double)percentNumUpDown.Value, ChartList[i]);
                }
            }
            catch (Exception ex)
            {
                moduleLog.ErrorLog(ex);
            }
        }
    }
}