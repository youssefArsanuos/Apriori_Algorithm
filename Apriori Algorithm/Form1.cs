
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;

namespace Apriori_Algorithm
{
    public partial class Form1 : Form
    {
        private string filePath;

        List<List<string>> transactions = new List<List<string>>();
        List<Dictionary<string, int>> FrequentLevels = new List<Dictionary<string, int>>();

        double minSupport;
        double minConfidence;
        int minSupportCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserOldPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }



        private void Load_Data()
        {
            transactions.Clear();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                DataSet result = reader.AsDataSet();
                DataTable table = result.Tables[0];

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Columns.Count < 2)
                        continue;

                    string items = table.Rows[i][1].ToString().Trim();

                    if (string.IsNullOrEmpty(items) ||
                        items.Equals("Items", StringComparison.OrdinalIgnoreCase))
                        continue;

                    List<string> transaction = items
                        .Split(',')
                        .Select(item => item.Trim())
                        .Where(item => !string.IsNullOrEmpty(item))
                        .Distinct()
                        .ToList();

                    transactions.Add(transaction);
                }
            }
        }



        private void btnPCSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;

                gpxValues.Enabled = true;
                btnRun.Enabled = true;

                Load_Data();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Show_Support_And_Sets()
        {
            frmSupportAndSets frm = new frmSupportAndSets(
                FrequentLevels,
                transactions.Count
            );

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filePath = null;

            gpxValues.Enabled = false;

            txtConf.Text = "";
            txtSupp.Text = "";

            btnRun.Enabled = false;

            transactions.Clear();
            FrequentLevels.Clear();

            minConfidence = 0;
            minSupport = 0;
            minSupportCount = 0;

            gpxDetails.Enabled = false;
        }

        private void Run_Apriori()
        {
            FrequentLevels.Clear();

            minSupport = double.Parse(txtSupp.Text);
            minConfidence = double.Parse(txtConf.Text);

            minSupportCount = (int)Math.Ceiling(
                minSupport * transactions.Count
            );

            var L1 = Generate_C1();

            if (L1.Count == 0)
                return;

            FrequentLevels.Add(L1);

            var previousLevel = L1;

            while (previousLevel.Count > 0)
            {
                var candidates = Generate_Candidates(previousLevel);

                var currentLevel = Calculate_Support(candidates);

                if (currentLevel.Count == 0)
                    break;

                FrequentLevels.Add(currentLevel);

                previousLevel = currentLevel;
            }
        }

        private Dictionary<string, int> Generate_C1()
        {
            Dictionary<string, int> C1 = new Dictionary<string, int>();

            foreach (var transaction in transactions)
            {
                foreach (var item in transaction.Distinct())
                {
                    if (C1.ContainsKey(item))
                        C1[item]++;
                    else
                        C1.Add(item, 1);
                }
            }

            Dictionary<string, int> L1 = new Dictionary<string, int>();

            foreach (var item in C1)
            {
                if (item.Value >= minSupportCount)
                    L1.Add(item.Key, item.Value);
            }

            return L1;
        }

        private Dictionary<string, int> Generate_Candidates(
            Dictionary<string, int> previousLevel)
        {
            Dictionary<string, int> candidates =
                new Dictionary<string, int>();

            if (previousLevel.Count < 2)
                return candidates;

            List<string> previousKeys = previousLevel.Keys.ToList();

            int itemsetSize = previousKeys[0].Split(',').Length;

            HashSet<string> previousKeysSet =
                new HashSet<string>(previousKeys);

            for (int i = 0; i < previousKeys.Count; i++)
            {
                for (int j = i + 1; j < previousKeys.Count; j++)
                {
                    List<string> firstItems =
                        previousKeys[i].Split(',').ToList();

                    List<string> secondItems =
                        previousKeys[j].Split(',').ToList();

                    List<string> candidateItems = firstItems
                        .Concat(secondItems)
                        .Distinct()
                        .OrderBy(x => x, StringComparer.Ordinal)
                        .ToList();

                    if (candidateItems.Count != itemsetSize + 1)
                        continue;

                    bool isFrequent = true;

                    for (int k = 0; k < candidateItems.Count; k++)
                    {
                        List<string> subset = candidateItems
                            .Where((item, index) => index != k)
                            .ToList();

                        string subsetKey = string.Join(",", subset);

                        if (!previousKeysSet.Contains(subsetKey))
                        {
                            isFrequent = false;
                            break;
                        }
                    }

                    if (isFrequent)
                    {
                        string candidateKey =
                            string.Join(",", candidateItems);

                        if (!candidates.ContainsKey(candidateKey))
                            candidates.Add(candidateKey, 0);
                    }
                }
            }

            return candidates;
        }

        private Dictionary<string, int> Calculate_Support(
            Dictionary<string, int> candidates)
        {
            Dictionary<string, int> currentLevel =
                new Dictionary<string, int>();

            foreach (var candidate in candidates)
            {
                string[] items = candidate.Key.Split(',');

                int supportCount = 0;

                foreach (var transaction in transactions)
                {
                    if (items.All(item => transaction.Contains(item)))
                        supportCount++;
                }

                if (supportCount >= minSupportCount)
                    currentLevel.Add(candidate.Key, supportCount);
            }

            return currentLevel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run_Apriori();

            gpxDetails.Enabled = FrequentLevels.Count > 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (FrequentLevels.Count > 0)
                Show_Support_And_Sets();
        }

        private void Show_Association_Rules()
        {
            frmShowAssociationRules frm =
                new frmShowAssociationRules(
                    FrequentLevels,
                    transactions.Count,
                    minConfidence
                );

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_Association_Rules();
        }
        private void Show_Visualizations()
        {
            frmShowVisualizations frm =
                new frmShowVisualizations(FrequentLevels, transactions.Count);

            frm.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Show_Visualizations();
        }
    }
}
