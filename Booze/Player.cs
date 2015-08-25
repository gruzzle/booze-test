using System;
using System.Collections.Generic;

namespace Booze
{
	public class Player
	{
		Dictionary<String, int> resources;

		public Player ()
		{
			this.resources = new Dictionary<String, int> ();
		}

		public void AddResource(Resource resource)
		{
			String type = resource.getType ();
			int count = resource.getCount ();

			if (resources.ContainsKey (type)) {
				resources[type] += count;			
			} else {
				resources.Add (type, count);
			}
		}

		public void PrintResources()
		{
			foreach (KeyValuePair<String, int> kv in resources) {
				Console.WriteLine(String.Format("{0}: {1}", kv.Key, kv.Value));
			}
		}
	}
}