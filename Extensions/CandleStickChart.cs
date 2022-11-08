using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask.Extensions
{
    public static class CandleStickChart
    {
        public static PlotModel CreateCandlesticksChartModel(List<Candlestick> candlesticks)
        {
         PlotModel MyModel = new PlotModel();

        DateTimeAxis timeSPanAxis1 = new DateTimeAxis()
            {
                Position = AxisPosition.Bottom,
                MinorIntervalType = DateTimeIntervalType.Hours,
                MajorGridlineStyle = LineStyle.Dot,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColor.FromRgb(44, 44, 44),
                TicklineColor = OxyColor.FromRgb(82, 82, 82)
            };

            LinearAxis linearAxis1 = new LinearAxis()
            {
                Position = AxisPosition.Right,
                MajorGridlineStyle = LineStyle.Dot,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColor.FromRgb(44, 44, 44),
                TicklineColor = OxyColor.FromRgb(82, 82, 82)
            };
            MyModel = new PlotModel { Title = "Chart" };
            MyModel.Axes.Add(timeSPanAxis1);
            MyModel.Axes.Add(linearAxis1);
            MyModel.Series.Add(new CandleStickSeries
            {
                Color = OxyColors.DarkGray,
                DataFieldX = "Time",
                DataFieldHigh = "High",
                DataFieldLow = "Low",
                DataFieldOpen = "Open",
                DataFieldClose = "Close",
                IncreasingColor = OxyColors.DarkGreen,
                DecreasingColor = OxyColors.Red,
                TrackerFormatString = "Time: {2}\nOpen: {5:0.00000}\nHigh: {3:0.00000}\nLow: {4:0.00000}\nClose: {6:0.00000}",
                ItemsSource = candlesticks
            });
            return MyModel;
        }
    }
}
