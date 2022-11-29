using System.Runtime.InteropServices;

namespace TensorFlowLiteTaskText
{
	[StructLayout (LayoutKind.Sequential)]
	public struct TFLPos
	{
		public int start;

		public int end;

		public float logit;
	}
}
