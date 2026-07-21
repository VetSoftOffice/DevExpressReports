using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.CrossTab;
using System;
using System.Collections.Generic;

namespace DevExpressReports.Reports.Hatchery.Summary.SR_HT_WeeklyHatPerf
{
    public partial class SR_HT_WeeklyHatPerf
    {
        private Dictionary<string, decimal> maxAvgSetEggPerFarm = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> totalSettedEggsPerFarm = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> totalChicksPerFarm = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> totalEggsPerFarm = new Dictionary<string, decimal>();

        private void xrCrossTabHatPerf_BeforePrint(object sender, EventArgs e)
        {
            maxAvgSetEggPerFarm.Clear();
            totalSettedEggsPerFarm.Clear();
            totalChicksPerFarm.Clear();
            totalEggsPerFarm.Clear();
        }

        private void crossTabHatPerfDataCell_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            string farmCode = cell.GetCurrentFieldValue<string>("FarmCode");
            decimal avgSetEggGT = cell.GetCurrentFieldValue<decimal>("AverageOfSetEgg_GT");
            decimal settedEggs = cell.GetCurrentFieldValue<decimal>("SettedEggs");
            decimal chicks = cell.GetCurrentFieldValue<decimal>("Chicks");
            decimal totalEggs = cell.GetCurrentFieldValue<decimal>("TotalEggs");

            if (!maxAvgSetEggPerFarm.ContainsKey(farmCode))
                maxAvgSetEggPerFarm[farmCode] = 0;

            if (avgSetEggGT > maxAvgSetEggPerFarm[farmCode])
                maxAvgSetEggPerFarm[farmCode] = avgSetEggGT;

            if (!totalSettedEggsPerFarm.ContainsKey(farmCode))
                totalSettedEggsPerFarm[farmCode] = 0;
            totalSettedEggsPerFarm[farmCode] += settedEggs;

            if (!totalChicksPerFarm.ContainsKey(farmCode))
                totalChicksPerFarm[farmCode] = 0;
            totalChicksPerFarm[farmCode] += chicks;

            if (!totalEggsPerFarm.ContainsKey(farmCode))
                totalEggsPerFarm[farmCode] = 0;
            totalEggsPerFarm[farmCode] += totalEggs;

            decimal chicksPercent = (settedEggs != 0) ? (chicks / settedEggs) * 100 : 0;
            decimal settedEggsPercent = (totalEggs != 0) ? (settedEggs / totalEggs) * 100 : 0;

            decimal maxAvgForFarm = maxAvgSetEggPerFarm[farmCode];
            decimal result = (maxAvgForFarm != 0) ? (chicksPercent / maxAvgForFarm) * settedEggsPercent : 0;

            cell.Text = result.ToString("0.00");
        }

        private void crossTabHatPerfTotalCell_FarmTotal_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            string farmCode = cell.GetCurrentFieldValue<string>("FarmCode");

            decimal totalSettedEggs = totalSettedEggsPerFarm.ContainsKey(farmCode) ? totalSettedEggsPerFarm[farmCode] : 0;
            decimal totalChicks = totalChicksPerFarm.ContainsKey(farmCode) ? totalChicksPerFarm[farmCode] : 0;
            decimal totalEggs = totalEggsPerFarm.ContainsKey(farmCode) ? totalEggsPerFarm[farmCode] : 0;
            decimal maxAvgSetEgg = maxAvgSetEggPerFarm.ContainsKey(farmCode) ? maxAvgSetEggPerFarm[farmCode] : 0;

            decimal chicksPercent = (totalSettedEggs != 0) ? (totalChicks / totalSettedEggs) * 100 : 0;
            decimal settedEggsPercent = (totalEggs != 0) ? (totalSettedEggs / totalEggs) * 100 : 0;

            decimal result = (maxAvgSetEgg != 0) ? (chicksPercent / maxAvgSetEgg) * settedEggsPercent : 0;

            cell.Text = result.ToString("0.00");
        }

        private void crossTabHatPerfTotalCell_GrandTotal_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            decimal grandTotalSettedEggs = 0;
            decimal grandTotalChicks = 0;
            decimal grandTotalEggs = 0;
            decimal grandMaxAvgSetEgg = 0;

            foreach (var kvp in totalSettedEggsPerFarm)
            {
                grandTotalSettedEggs += kvp.Value;
            }
            foreach (var kvp in totalChicksPerFarm)
            {
                grandTotalChicks += kvp.Value;
            }
            foreach (var kvp in totalEggsPerFarm)
            {
                grandTotalEggs += kvp.Value;
            }
            foreach (var kvp in maxAvgSetEggPerFarm)
            {
                if (kvp.Value > grandMaxAvgSetEgg)
                    grandMaxAvgSetEgg = kvp.Value;
            }

            decimal chicksPercent = (grandTotalSettedEggs != 0) ? (grandTotalChicks / grandTotalSettedEggs) * 100 : 0;
            decimal settedEggsPercent = (grandTotalEggs != 0) ? (grandTotalSettedEggs / grandTotalEggs) * 100 : 0;

            decimal result = (grandMaxAvgSetEgg != 0) ? (chicksPercent / grandMaxAvgSetEgg) * settedEggsPercent : 0;

            cell.Text = result.ToString("0.00");
        }

        private void crossTabHatPerfSettedEggsPercentDataCell_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            decimal settedEggs = cell.GetCurrentFieldValue<decimal>("SettedEggs");
            decimal totalEggs = cell.GetCurrentFieldValue<decimal>("TotalEggs");

            decimal result = (totalEggs != 0) ? (settedEggs / totalEggs) * 100 : 0;
            cell.Text = result.ToString("0.00");
        }

        private void crossTabHatPerfChicksPercentDataCell_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            decimal chicks = cell.GetCurrentFieldValue<decimal>("Chicks");
            decimal settedEggs = cell.GetCurrentFieldValue<decimal>("SettedEggs");

            decimal result = (settedEggs != 0) ? (chicks / settedEggs) * 100 : 0;
            cell.Text = result.ToString("0.00");
        }

        private void crossTabHatPerfAvgSetEggGTDataCell_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            decimal avgSetEggGT = cell.GetCurrentFieldValue<decimal>("AverageOfSetEgg_GT");
            cell.Text = avgSetEggGT.ToString("0.00");
        }

        private void crossTabHatPerfMaxAvgSetEggGTTotalCell_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            string farmCode = cell.GetCurrentFieldValue<string>("FarmCode");
            decimal maxAvg = maxAvgSetEggPerFarm.ContainsKey(farmCode) ? maxAvgSetEggPerFarm[farmCode] : 0;
            cell.Text = maxAvg.ToString("0.00");
        }

        private void crossTabHatPerfMaxAvgSetEggGTGrandTotalCell_BeforePrint(object sender, CrossTabCellPrintEventArgs e)
        {
            XRCrossTabCell cell = (XRCrossTabCell)sender;

            decimal grandMaxAvgSetEgg = 0;
            foreach (var kvp in maxAvgSetEggPerFarm)
            {
                if (kvp.Value > grandMaxAvgSetEgg)
                    grandMaxAvgSetEgg = kvp.Value;
            }
            cell.Text = grandMaxAvgSetEgg.ToString("0.00");
        }
    }
}