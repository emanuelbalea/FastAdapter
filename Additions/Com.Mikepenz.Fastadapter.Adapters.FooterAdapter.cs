using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FooterAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/FooterAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial class FooterAdapter : global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/FooterAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FooterAdapter); }
		}

		protected FooterAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FooterAdapter']/constructor[@name='FooterAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FooterAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FooterAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
