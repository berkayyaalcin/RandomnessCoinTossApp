using System;
using System.Windows.Forms;

namespace RandomnessCoinTossApp
{
    public partial class MainForm : Form
    {
        Random random = new Random();

        NumericUpDown[] AttemptsList;

        int heads, tails;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateHeadOrTails(int attempts, int invalid)
        {
            heads = 0; tails = 0; //Heads : Yazı , Tails ; Tura.

            attempts *= (1 - (invalid / 100));

            for (int i = 0; i < attempts; i++)
            {
                int rand = random.Next();

                if (rand % 2 == 0)
                    heads++;
                else
                    tails++;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AttemptsList = new NumericUpDown[] { numericUpDownTryCount1, numericUpDownTryCount2, numericUpDownTryCount3 };

            try
            {
                for (int i = 0; i < AttemptsList.Length; i++)
                {
                    CalculateHeadOrTails((int)AttemptsList[i].Value, (int)percentNumUpDown.Value);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}