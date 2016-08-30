using System;
using System.Collections.ObjectModel;

namespace ExplorerCity
{
	public class City
	{
		public int Id { get; set;}
		public string Name { get; set; }
		public string Description { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public ObservableCollection<Photo> Photos { get; set; }
	}
}

