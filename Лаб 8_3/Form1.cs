using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] probs = new double[5];
        int N;
        double checkProbs;

        Random rnd = new Random();
        double probability;

        int[] statistics = new int[5];
        double[] frequency = new double[5];

        private void btStart_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            probs[0] = (double)edProb1.Value;
            probs[1] = (double)edProb2.Value;
            probs[2] = (double)edProb3.Value;
            probs[3] = (double)edProb4.Value;

            N = (int)NumberTrials.Value;

            checkProbs = 0;
            for (int i = 0; i < 4; i++)
                checkProbs += probs[i];
            if (checkProbs > 1)
            {
                labelIns.Visible = true;
                return;
            }
            else
            {
                labelIns.Visible = false;
                probs[4] = 1 - checkProbs;
                edProb5.Value = (decimal)probs[4];
            }

            for (int j = 0; j < N; j++)
            {
                probability = rnd.NextDouble();
                for (int i = 0; i < 5; i++)
                {
                    probability -= probs[i];
                    if (probability <= 0)
                    {
                        statistics[i]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                frequency[i] = (double)statistics[i] / N;
                statistics[i] = 0;
                chart1.Series[0].Points.AddXY(i + 1, frequency[i]);
            }

        }
    }
}
