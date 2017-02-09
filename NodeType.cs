using System;

namespace Org.Kevoree.Annotation
{
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Interface)]
	public class NodeType : Attribute
	{

		private readonly string version;
		private readonly string ns;

		public NodeType ()
		{
			this.version = "1.0";
			this.ns = "dotnetdefault";
		}

		public NodeType (String version)
		{
			this.version = version;
		}

		public NodeType (String version, String ns)
		{
			this.version = version;
			this.ns = ns;
		}


		public string Version {
			get {
				return version;
			}
		}
		public string Ns {
			get {
				return ns;
			}
		}
	}

}
