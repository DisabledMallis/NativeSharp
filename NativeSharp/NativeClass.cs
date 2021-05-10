using System;

namespace NativeSharp {
	//An attribute used to mark a managed class as a native class
	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public class NativeClass : Attribute {
		public NativeClass() {

		}
	}
}