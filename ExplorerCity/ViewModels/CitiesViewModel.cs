using System;
using System.Collections.ObjectModel;

namespace ExplorerCity
{
	public class CitiesViewModel
	{
		public ObservableCollection<City> Cities { get; set;}

		public CitiesViewModel()
		{
			//initialisation de la liste Cities
			Cities = new ObservableCollection<City>
			{
			 new City()
				{
					Id = 1,
					Name = "Rouen",
					Description = "Ville de normandie",
					Latitude = 49.44323199999999,
					Longitude = 1.0999709999999823,
					Photos = new ObservableCollection<Photo>()
					{
						new Photo()
						{
							Description = "Place Jeanne d'arc",
							ImageUrl = "http://www.normandie-tourisme.fr/docs/6353-1-rouen-en-terrasse-philippe-deneufve-jpg.jpg"
						},
						new Photo()
						{
							Description = "Vue aérienne",
							ImageUrl = "http://www.boalingua.ch/uploads/media_tool/images/frankreich_rouen_bruecken.jpg"
						},
						new Photo()
						{
							Description = "Cathédrale",
							ImageUrl = "http://www.tourisme.fr/images/otf_offices/1832/cathedrale-de-rouen1.jpg"
						}
					}
				},
				new City()
				{
					Id = 2,
					Name = "Annecy",
					Description = "Annecy est une commune de la région Auvergne-Rhône-Alpes au sud-est de la France",
					Latitude = 45.899247,
					Longitude = 6.129383999999959,
					Photos = new ObservableCollection<Photo>
					{
						new Photo()
						{
							Description = "Annecy - Ville",
							ImageUrl = "http://locmfr.fr/wp-content/uploads/2013/06/ville3HD-1170x578.jpg"
						},
						new Photo()
						{
							Description = "Le lac d'Annecy",
							ImageUrl = "http://hotelannecy-lac.com/images/hotel-catalpa-lac-annecy.jpg"
						}
					}
				}
			};
		}


	}
}

