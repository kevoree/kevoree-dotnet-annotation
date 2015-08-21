using System;

namespace Org.Kevoree.Annotation
{
	[AttributeUsage (AttributeTargets.Field)]
	public class Input : Attribute
	{
		private readonly bool optional;

		public Input ()
		{
			this.optional = true;
		}

		public Input (Boolean optional)
		{
			this.optional = optional;
		}

		public bool Optional {
			get {
				return optional;
			}
		}
	}
}