using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IIdentifyable']"
	[Register ("com/mikepenz/fastadapter/IIdentifyable", "", "Com.Mikepenz.Fastadapter.IIdentifyableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IIdentifyable : IJavaObject {

		long Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IIdentifyable']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()J", "GetGetIdentifierHandler:Com.Mikepenz.Fastadapter.IIdentifyableInvoker, FastAdapter")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IIdentifyable']/method[@name='withIdentifier' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("withIdentifier", "(J)Ljava/lang/Object;", "GetWithIdentifier_JHandler:Com.Mikepenz.Fastadapter.IIdentifyableInvoker, FastAdapter")]
		global::Java.Lang.Object WithIdentifier (long p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/IIdentifyable", DoNotGenerateAcw=true)]
	internal class IIdentifyableInvoker : global::Java.Lang.Object, IIdentifyable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/IIdentifyable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIdentifyableInvoker); }
		}

		IntPtr class_ref;

		public static IIdentifyable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIdentifyable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.IIdentifyable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIdentifyableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static long n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IIdentifyable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IIdentifyable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Identifier;
		}
#pragma warning restore 0169

		IntPtr id_getIdentifier;
		public unsafe long Identifier {
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier);
			}
		}

		static Delegate cb_withIdentifier_J;
#pragma warning disable 0169
		static Delegate GetWithIdentifier_JHandler ()
		{
			if (cb_withIdentifier_J == null)
				cb_withIdentifier_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WithIdentifier_J);
			return cb_withIdentifier_J;
		}

		static IntPtr n_WithIdentifier_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Fastadapter.IIdentifyable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IIdentifyable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIdentifier (p0));
		}
#pragma warning restore 0169

		IntPtr id_withIdentifier_J;
		public unsafe global::Java.Lang.Object WithIdentifier (long p0)
		{
			if (id_withIdentifier_J == IntPtr.Zero)
				id_withIdentifier_J = JNIEnv.GetMethodID (class_ref, "withIdentifier", "(J)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIdentifier_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
