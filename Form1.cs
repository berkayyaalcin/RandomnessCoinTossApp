﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomnessCoinTossApp
{
    public partial class MainForm : Form
    {
        Random random = new Random();

        NumericUpDown[] AttemptsList;

        Chart[] ChartList;

        int heads, tails;

        Series headsSeries, tailsSeries;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateHeadOrTails(int attempts, int invalid, Chart chart)
        {
            chart.Series.Clear();
            heads = 0; tails = 0; //Heads : Yazı , Tails ; Tura.

            attempts *= (1 - (invalid / 100));

            headsSeries = new Series();
            tailsSeries = new Series();

            headsSeries.ChartType = SeriesChartType.Line;
            headsSeries.Color = Color.Red;

            tailsSeries.ChartType = SeriesChartType.Line;
            tailsSeries.Color = Color.Black;

            for (int i = 0; i < attempts; i++)
            {
                int rand = random.Next();

                if (rand % 2 == 0)
                {
                    heads++;
                    headsSeries.Points.Add(new DataPoint(heads, i+1));
                }
                else
                {
                    tails++;
                    tailsSeries.Points.Add(new DataPoint(tails, i+1));
                }
            }

            headsSeries.Name = "Yazı " + heads;
            tailsSeries.Name = "Tura " + tails;

            chart.Series.Add(headsSeries);
            chart.Series.Add(tailsSeries);

            chart.DataBind();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AttemptsList = new NumericUpDown[] { numericUpDownTryCount1, numericUpDownTryCount2, numericUpDownTryCount3 };
            ChartList = new Chart[] { graphOfTryCount1, graphOfTryCount2, graphOfTryCount3 };

            try
            {
                for (int i = 0; i < AttemptsList.Length; i++)
                {
                    CalculateHeadOrTails((int)AttemptsList[i].Value, (int)percentNumUpDown.Value, ChartList[i]);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}