using Android.Runtime;
namespace TensorFlow.Lite.Support.Common
{
    public partial class TensorProcessor
	{
		public partial class Builder
		{
			static Delegate? cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::TensorFlow.Lite.Support.Common.TensorProcessor.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.tensorflow.lite.support.common']/class[@name='TensorProcessor.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lorg/tensorflow/lite/support/common/TensorProcessor;", "GetBuildHandler")]
			public virtual unsafe global::TensorFlow.Lite.Support.Common.TensorProcessor? Build ()
			{
				const string __id = "build.()Lorg/tensorflow/lite/support/common/TensorProcessor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::TensorFlow.Lite.Support.Common.TensorProcessor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}
	}
}
