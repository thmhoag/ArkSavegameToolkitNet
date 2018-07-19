using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ArkSavegameToolkitNet.Domain
{
	public class MapResources
	{
		public static Bitmap topo_map_ScorchedEarth_P => (Bitmap)Image.FromFile("Resources/Scorched_Earth_Topographic_Map.jpg");
		public static Bitmap topo_map_Ragnarok => (Bitmap)Image.FromFile("Resources/Ragnarok_Topographic_Map.jpg");
		public static Bitmap topo_map_Aberration_P => (Bitmap)Image.FromFile("Resources/Aberration_Topographic_Map.jpg");
		public static Bitmap topo_map_TheCenter => (Bitmap)Image.FromFile("Resources/The_Center_Topographic_Map.jpg");
		public static Bitmap topo_map_TheIsland => (Bitmap)Image.FromFile("Resources/The_Island_Topographic_Map.jpg");
	}
}
