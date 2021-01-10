using System;
using Android.Runtime;
namespace Org.Tensorflow.Lite.Support.Image
{
	public partial class ImageProcessor
	{
		public partial class Builder
		{
			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_Build);
				return cb_build;
			}

			static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Lite.Support.Image.ImageProcessor.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(__this.Build());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.lite.support.image']/class[@name='ImageProcessor.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lorg/tensorflow/lite/support/image/ImageProcessor;", "GetBuildHandler")]
			public virtual unsafe global::Org.Tensorflow.Lite.Support.Image.ImageProcessor Build ()
			{
				const string __id = "build.()Lorg/tensorflow/lite/support/image/ImageProcessor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Tensorflow.Lite.Support.Image.ImageProcessor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}
	}
}
