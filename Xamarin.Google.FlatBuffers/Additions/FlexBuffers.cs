using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Flatbuffers
{
	public partial class FlexBuffers
	{
		public partial class Map
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.flatbuffers']/class[@name='FlexBuffers.Map']/method[@name='empty' and count(parameter)=0]"
			[Register ("empty", "()Lcom/google/flatbuffers/FlexBuffers$Map;", "")]
			public static new unsafe global::Com.Google.Flatbuffers.FlexBuffers.Map Empty ()
			{
				const string __id = "empty.()Lcom/google/flatbuffers/FlexBuffers$Map;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Flatbuffers.FlexBuffers.Map> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public partial class TypedVector
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.flatbuffers']/class[@name='FlexBuffers.TypedVector']/method[@name='empty' and count(parameter)=0]"
			[Register ("empty", "()Lcom/google/flatbuffers/FlexBuffers$TypedVector;", "")]
			public static new unsafe global::Com.Google.Flatbuffers.FlexBuffers.TypedVector Empty ()
			{
				const string __id = "empty.()Lcom/google/flatbuffers/FlexBuffers$TypedVector;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Flatbuffers.FlexBuffers.TypedVector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}
	}
}
