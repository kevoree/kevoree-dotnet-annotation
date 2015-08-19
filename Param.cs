using System;

namespace Org.Kevoree.Annotation
{
	[AttributeUsage (AttributeTargets.Field | AttributeTargets.Method)]
	public class Param: Attribute
	{
		public bool Optional = true;
		public bool FragmentDependent = false;
		public string DefaultValue = "";
	}
}