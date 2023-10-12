using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace WinFormsApp1.graphing
{
    public partial class EnergyBalanceGraph : Form
    {
        List<int> _xValues;
        List<int> _yValues;

        public EnergyBalanceGraph(List<int> xValues, List<int> yValues)
        {
            _xValues = xValues;
            _yValues = yValues;
            InitializeComponent();
            redoPlot();
        }

        private void redoPlot()
        {
            // Sample data points (replace this with your data)
            List<ScatterPoint> dataPoints = new List<ScatterPoint>();
            for (int i = 0; i < _xValues.Count; i++)
            {
                dataPoints.Add(new ScatterPoint(_xValues[i], _yValues[i]));
            }
            int max = Math.Max(_xValues.Max(), _yValues.Max());
            // Create the plot model
            var plotModel = new PlotModel { Title = "Energy Balance Graph" };

            // Create the scatter series
            var scatterSeries = new ScatterSeries
            {
                MarkerType = MarkerType.Circle, // Use a circle marker for dots
                MarkerSize = 2, // Adjust the size of the dots
                MarkerFill = OxyColors.Blue, // Adjust the color of the dots
                MarkerStroke = OxyColors.Black, // Adjust the color of the dot outline
                ItemsSource = dataPoints
            };

            // Add the scatter series to the plot model
            plotModel.Series.Add(scatterSeries);

            //Find max values
            //int max = Math.Max(_xValues.Max(), _yValues.Max());
            // Set the X-axis and Y-axis properties (optional)
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Consumpiton and Delivery to storage", AbsoluteMaximum = max });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Generation and Retrieval from storage", AbsoluteMaximum = max });

            // Set the model to the existing plot view (plotView1)
            plotView1.Model = plotModel;
        }

        public void addPoints(List<int> xValues, List<int> yValues)
        {
            for(int i = 0; i < xValues.Count; i++) 
            {
                _xValues.Add(xValues[i]);
                _yValues.Add(yValues[i]);
            }
            redoPlot();
        }
    }
}
