using System;

namespace Org.Kevoree.Annotation
{
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Interface)]
	public class ComponentType : Attribute { 
		private readonly string version;
		private readonly string ns;

		public ComponentType ()
		{
			this.version = "1.0";
			this.ns = "dotnetdefault";
		}

		public ComponentType (String version)
		{
			this.version = version;
		}

		public ComponentType (String version, String ns)
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
