using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='RecyclerViewCacheUtil']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/utils/RecyclerViewCacheUtil", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial class RecyclerViewCacheUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/utils/RecyclerViewCacheUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclerViewCacheUtil); }
		}

		protected RecyclerViewCacheUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='RecyclerViewCacheUtil']/constructor[@name='RecyclerViewCacheUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecyclerViewCacheUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecyclerViewCacheUtil)) {
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

		static Delegate cb_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetApply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_Handler ()
		{
			if (cb_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_ == null)
				cb_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_);
			return cb_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_;
		}

		static void n_Apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p1 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='RecyclerViewCacheUtil']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='java.lang.Iterable&lt;Item&gt;']]"
		[Register ("apply", "(Landroid/support/v7/widget/RecyclerView;Ljava/lang/Iterable;)V", "GetApply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void Apply (global::Android.Support.V7.Widget.RecyclerView p0, global::Java.Lang.IIterable p1)
		{
			if (id_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "apply", "(Landroid/support/v7/widget/RecyclerView;Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Landroid_support_v7_widget_RecyclerView_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "(Landroid/support/v7/widget/RecyclerView;Ljava/lang/Iterable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withCacheSize_I;
#pragma warning disable 0169
		static Delegate GetWithCacheSize_IHandler ()
		{
			if (cb_withCacheSize_I == null)
				cb_withCacheSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithCacheSize_I);
			return cb_withCacheSize_I;
		}

		static IntPtr n_WithCacheSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCacheSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCacheSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='RecyclerViewCacheUtil']/method[@name='withCacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCacheSize", "(I)Lcom/mikepenz/fastadapter/utils/RecyclerViewCacheUtil;", "GetWithCacheSize_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil WithCacheSize (int p0)
		{
			if (id_withCacheSize_I == IntPtr.Zero)
				id_withCacheSize_I = JNIEnv.GetMethodID (class_ref, "withCacheSize", "(I)Lcom/mikepenz/fastadapter/utils/RecyclerViewCacheUtil;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCacheSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.RecyclerViewCacheUtil> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCacheSize", "(I)Lcom/mikepenz/fastadapter/utils/RecyclerViewCacheUtil;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
