using System;
using System.Collections.Generic;

namespace Booze
{
	public class Factory
	{
		private String name { get; set; } 			// factory name
		private int laborPerTick { get; set; } 		// labor cost for ticker to tick
		private int upkeep { get; set; } 			// money cost per tick
		private List<Resource> output { get; set; }	// resources output when ticks complete
		private Ticker ticker { get; set; }			// keeps track of ticks etc

		public Factory ()
		{
			output = new List<Resource> ();
		}

		public Factory CreateTestFactory() 
		{
			Factory f = new Factory();
			f.name = "Factory";
			f.laborPerTick = 2;
			f.upkeep = 1;
			f.output.Add(new Resource("Gold", 3));
			f.ticker = new Ticker (5);

			return f;
		}

		public void Tick() 
		{
			Boolean factoryFinished = Ticker.Tick ();

			if (factoryFinished) 
			{

			}
		}
	}

	class Ticker
	{
		int currentTick;
		int length;
		String displayedLabel;
		String[] labels;

		public Ticker(int length) 
		{
			this.currentTick = 0;
			this.length = length;
			this.displayedLabel = null;
			labels = new String[length];
		}

		public void AddLabel(String label, int turn)
		{
			labels [turn] = label;
		}

		// returns true if ticker reaches the end
		public boolean Tick()
		{
			currentTick++;
			if (currentTick > length) {
				currentTick = 0;
				return true;
			} else {
				if (labels[currentTick] != null) {
					displayedLabel = labels[currentTick];
				}
				return false;
			}
		}
	}
}

