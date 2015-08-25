using System;
namespace Booze
{
	public static class Test
	{
		public static void Main() {
			Player player = new Player ();
			GameState.pl
			player.AddResource(new Resource("Wood", 3));
			player.AddResource(new Resource("Gold", 1));
			player.AddResource(new Resource("Wood", 2));
			player.PrintResources ();
		}
	}
}

