using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RollDice_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void bStart_Click(object sender, EventArgs e)
        {
            Dice _dice = new Dice();

            bStart.Enabled = false;
            await Task.Run(()=> 
            {
                for (int i = 1; i <= 100; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        UpdateLoadingBar(i);
                        this.Text = $"{i}%";
                    }));
                    Thread.Sleep(10);
                }
            });

            int resultD4 = _dice.D4((int)nudD4.Value);
            int resultD6 = _dice.D6((int)nudD6.Value);
            int resultD8 = _dice.D8((int)nudD8.Value);
            int resultD10 = _dice.D10((int)nudD10.Value);
            int resultD12 = _dice.D12((int)nudD12.Value);
            int resultD20 = _dice.D20((int)nudD20.Value);
            int resultD100 = _dice.D100((int)nudD100.Value);

            int allDiceResult = resultD10 + resultD100 + resultD12 + resultD20 
                + resultD4 + resultD6 + resultD8;

            if (allDiceResult==0)
                MessageBox.Show($"Не указано сколько и каких кубов кидать!");
            else
                MessageBox.Show($"Выпало {allDiceResult}");

            loading.Value = 0;
            this.Text = "Roll Dice v2.0";
            bStart.Enabled = true;
        }

        private void UpdateLoadingBar(int i)
        {
            if (i==loading.Maximum)
            {
                loading.Maximum = i + 1;
                loading.Value = i + 1;
                loading.Maximum = i;
            } 
            else
                loading.Value = i + 1;
            loading.Value = i;
        }
    }
}
