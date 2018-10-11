using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CustomFont
{
    public class ViewModel
    {
		public ObservableCollection<Model> GoldData { get; set; }

		public ObservableCollection<Model> SilverData { get; set; }

		public ObservableCollection<Model> BronzeData { get; set; }

		public ViewModel()
		{
			GoldData = new ObservableCollection<Model>
			{
				new Model("USA", 46),
				new Model("GBR", 27),
				new Model("CHN", 26),
			};

			SilverData = new ObservableCollection<Model>
			{
				new Model("USA", 37),
				new Model("GBR", 23),
				new Model("CHN", 18),
			};

			BronzeData = new ObservableCollection<Model>
			{
				new Model("USA", 38),
				new Model("GBR", 17),
				new Model("CHN", 26),
			};
		}
    }
}
