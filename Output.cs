using System;

namespace Org.Kevoree.Annotation
{
	[AttributeUsage (AttributeTargets.Field)]
	public class Output : Attribute
	{
		private readonly bool optional;

		public Output ()
		{
			this.optional = true;
		}

		public Output (bool optional)
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
