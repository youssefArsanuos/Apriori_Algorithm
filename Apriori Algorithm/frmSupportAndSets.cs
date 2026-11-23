
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apriori_Algorithm
{
    public partial class frmSupportAndSets : Form
    {
        private List<Dictionary<string, int>> FrequentLevels;
        private int TotalTransactions;

        public frmSupportAndSets(
            List<Dictionary<string, int>> frequentLevels,
            int totalTransactions)
        {
            InitializeComponent();

            FrequentLevels = frequentLevels;
            TotalTransactions = totalTransactions;
        }

        private void frmSupportAndSets_Load(object sender, EventArgs e)
        {
            Display_Frequent_Levels();
        }

        private void Display_Frequent_Levels()
        {
            dvgSetsAndSupp.Rows.Clear();
            dvgSetsAndSupp.Columns.Clear();

            dvgSetsAndSupp.Columns.Add("Level", "Level");
            dvgSetsAndSupp.Columns.Add("Itemset", "Itemset");
            dvgSetsAndSupp.Columns.Add("SupportCount", "Support Count");
            dvgSetsAndSupp.Columns.Add("Support", "Support");

            if (TotalTransactions == 0)
                return;

            for (int i = 0; i < FrequentLevels.Count; i++)
            {
                Dictionary<string, int> currentLevel = FrequentLevels[i];

                foreach (var itemset in currentLevel)
                {
                    double support =
                        (double)itemset.Value / TotalTransactions;

                    dvgSetsAndSupp.Rows.Add(
                        "L" + (i + 1),
                        itemset.Key,
                        itemset.Value,
                        (support * 100).ToString("0.##") + "%"
                    );
                }
            }
        }
    }
}
