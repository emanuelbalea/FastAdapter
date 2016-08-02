using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IClickable']"
	[Register ("com/mikepenz/fastadapter/IClickable", "", "Com.Mikepenz.Fastadapter.IClickableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial interface IClickable : IJavaObject {

		global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnItemClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IClickable']/method[@name='getOnItemClickListener' and count(parameter)=0]"
			[Register ("getOnItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;", "GetGetOnItemClickListenerHandler:Com.Mikepenz.Fastadapter.IClickableInvoker, FastAdapter")] get;
		}

		global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnPreItemClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IClickable']/method[@name='getOnPreItemClickListener' and count(parameter)=0]"
			[Register ("getOnPreItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;", "GetGetOnPreItemClickListenerHandler:Com.Mikepenz.Fastadapter.IClickableInvoker, FastAdapter")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IClickable']/method[@name='withOnItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;Item&gt;']]"
		[Register ("withOnItemClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/IItem;", "GetWithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler:Com.Mikepenz.Fastadapter.IClickableInvoker, FastAdapter")]
		global::Java.Lang.Object WithOnItemClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IClickable']/method[@name='withOnItemPreClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;Item&gt;']]"
		[Register ("withOnItemPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/IItem;", "GetWithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler:Com.Mikepenz.Fastadapter.IClickableInvoker, FastAdapter")]
		global::Java.Lang.Object WithOnItemPreClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/IClickable", DoNotGenerateAcw=true)]
	internal class IClickableInvoker : global::Java.Lang.Object, IClickable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/IClickable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IClickableInvoker); }
		}

		IntPtr class_ref;

		public static IClickable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClickable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.IClickable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClickableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getOnItemClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnItemClickListenerHandler ()
		{
			if (cb_getOnItemClickListener == null)
				cb_getOnItemClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnItemClickListener);
			return cb_getOnItemClickListener;
		}

		static IntPtr n_GetOnItemClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IClickable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IClickable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnItemClickListener);
		}
#pragma warning restore 0169

		IntPtr id_getOnItemClickListener;
		public unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnItemClickListener {
			get {
				if (id_getOnItemClickListener == IntPtr.Zero)
					id_getOnItemClickListener = JNIEnv.GetMethodID (class_ref, "getOnItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnItemClickListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOnPreItemClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnPreItemClickListenerHandler ()
		{
			if (cb_getOnPreItemClickListener == null)
				cb_getOnPreItemClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnPreItemClickListener);
			return cb_getOnPreItemClickListener;
		}

		static IntPtr n_GetOnPreItemClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IClickable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IClickable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnPreItemClickListener);
		}
#pragma warning restore 0169

		IntPtr id_getOnPreItemClickListener;
		public unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnPreItemClickListener {
			get {
				if (id_getOnPreItemClickListener == IntPtr.Zero)
					id_getOnPreItemClickListener = JNIEnv.GetMethodID (class_ref, "getOnPreItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPreItemClickListener), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.IClickable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IClickable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnItemClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		public unsafe global::Java.Lang.Object WithOnItemClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnItemClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/IItem;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.IClickable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IClickable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnItemPreClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		public unsafe global::Java.Lang.Object WithOnItemPreClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnItemPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/IItem;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
