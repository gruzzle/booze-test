using System;
namespace Booze
{
	public class Resource
	{
		private String type;
		private int count;

		public String getType() {
			return type;
		}
		public int getCount() {
			return count;
		}

		public Resource (String type)
		{
			this.type = type;
			this.count = 1;
		}

		public Resource(String type, int count) {
			this.type = type;
			this.count = count;
		}
	}
}