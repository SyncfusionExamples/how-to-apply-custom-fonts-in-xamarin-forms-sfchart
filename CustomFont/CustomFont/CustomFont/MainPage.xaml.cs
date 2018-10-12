using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomFont
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			/* C# code snippet
            chart.Legend = new ChartLegend();
            chart.Legend.LabelStyle.TextColor = Color.Blue;

            if (Device.RuntimePlatform == Device.Android)
                chart.Legend.LabelStyle.FontFamily = "Lobster-Regular.ttf#Lobster-Regular";
            else if (Device.RuntimePlatform == Device.iOS)
                chart.Legend.LabelStyle.FontFamily = "Lobster-Regular";
            else if (Device.RuntimePlatform == Device.UWP)
                chart.Legend.LabelStyle.FontFamily = "Assets/Fonts/Lobster-Regular.ttf#Lobster";
           */
        }
	}
}
