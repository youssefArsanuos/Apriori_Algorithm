
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
    public partial class frmShowAssociationRules : Form
    {
        private List<Dictionary<string, int>> FrequentLevels;
        private int TotalTransactions;
        private double MinConfidence;

        public frmShowAssociationRules(List<Dictionary<string, int>> frequentLevels,int totalTransactions,
                                                             double minConfidence) {
            InitializeComponent();

            FrequentLevels = frequentLevels;
            TotalTransactions = totalTransactions;
            MinConfidence = minConfidence;
        }

        private void frmShowAssociationRules_Load(object sender, EventArgs e)
        {
            Display_Association_Rules();
        }

        private void Display_Association_Rules()
        {
            dvgShowAssoc.Rows.Clear();
            dvgShowAssoc.Columns.Clear();

            dvgShowAssoc.Columns.Add("Antecedent", "Antecedent");
            dvgShowAssoc.Columns.Add("Consequent", "Consequent");
            dvgShowAssoc.Columns.Add("Support", "Support");
            dvgShowAssoc.Columns.Add("Confidence", "Confidence");
            dvgShowAssoc.Columns.Add("Lift", "Lift");

            dvgShowAssoc.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dvgShowAssoc.ReadOnly = true;
            dvgShowAssoc.AllowUserToAddRows = false;

            if (TotalTransactions == 0)
                return;

            for (int i = 1; i < FrequentLevels.Count; i++)
            {
                foreach (var itemset in FrequentLevels[i])
                {
                    string[] items = itemset.Key.Split(',');

                    int totalMasks = 1 << items.Length;

                    for (int mask = 1; mask < totalMasks - 1; mask++)
                    {
                        List<string> antecedentItems =
                            new List<string>();

                        List<string> consequentItems =
                            new List<string>();

                        for (int j = 0; j < items.Length; j++)
                        {
                            if ((mask & (1 << j)) != 0)
                                antecedentItems.Add(items[j]);
                            else
                                consequentItems.Add(items[j]);
                        }

                        string antecedent =
                            string.Join(",", antecedentItems);

                        string consequent =
                            string.Join(",", consequentItems);

                        string antecedentKey = string.Join(",",
                            antecedentItems.OrderBy(x => x, StringComparer.Ordinal));

                        string consequentKey = string.Join(",",
                            consequentItems.OrderBy(x => x, StringComparer.Ordinal));

                        int antecedentCount =
                            Get_Support_Count(antecedentKey);

                        int consequentCount =
                            Get_Support_Count(consequentKey);

                        if (antecedentCount == 0 || consequentCount == 0)
                            continue;

                        double support =
                            (double)itemset.Value / TotalTransactions;

                        double confidence =
                            (double)itemset.Value / antecedentCount;

                        double consequentSupport =
                            (double)consequentCount / TotalTransactions;

                        double lift =
                            confidence / consequentSupport;

                        if (confidence >= MinConfidence)
                        {
                            dvgShowAssoc.Rows.Add(
                                antecedent,
                                consequent,
                                (support * 100).ToString("0.##") + "%",
                                (confidence * 100).ToString("0.##") + "%",
                                lift.ToString("0.##")
                            );
                        }
                    }
                }
            }
        }

        private int Get_Support_Count(string itemsetKey)
        {
            foreach (var level in FrequentLevels)
            {
                if (level.ContainsKey(itemsetKey))
                    return level[itemsetKey];
            }

            return 0;
        }
    }
}
