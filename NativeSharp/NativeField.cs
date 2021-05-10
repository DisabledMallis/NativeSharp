using System;

namespace NativeSharp {
	//An attribute for where a field is relative to a class pointer
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class FieldOffset : Attribute {
		//The offset for the field
		int offset;
		public FieldOffset(int offset) {
			this.offset = offset;
		}
	}
}