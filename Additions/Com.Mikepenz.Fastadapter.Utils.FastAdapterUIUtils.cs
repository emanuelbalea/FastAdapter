using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='FastAdapterUIUtils']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/utils/FastAdapterUIUtils", DoNotGenerateAcw=true)]
	public partial class FastAdapterUIUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/utils/FastAdapterUIUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastAdapterUIUtils); }
		}

		protected FastAdapterUIUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='FastAdapterUIUtils']/constructor[@name='FastAdapterUIUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FastAdapterUIUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FastAdapterUIUtils)) {
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

		static IntPtr id_adjustAlpha_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='FastAdapterUIUtils']/method[@name='adjustAlpha' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("adjustAlpha", "(II)I", "")]
		public static unsafe int AdjustAlpha (int p0, int p1)
		{
			if (id_adjustAlpha_II == IntPtr.Zero)
				id_adjustAlpha_II = JNIEnv.GetStaticMethodID (class_ref, "adjustAlpha", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_adjustAlpha_II, __args);
			} finally {
			}
		}

		static IntPtr id_getSelectableBackground_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='FastAdapterUIUtils']/method[@name='getSelectableBackground' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSelectableBackground", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetSelectableBackground (global::Android.Content.Context p0)
		{
			if (id_getSelectableBackground_Landroid_content_Context_ == IntPtr.Zero)
				id_getSelectableBackground_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSelectableBackground", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getSelectableBackground_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSelectableBackground_Landroid_content_Context_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='FastAdapterUIUtils']/method[@name='getSelectableBackground' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getSelectableBackground", "(Landroid/content/Context;IZ)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetSelectableBackground (global::Android.Content.Context p0, int p1, bool p2)
		{
			if (id_getSelectableBackground_Landroid_content_Context_IZ == IntPtr.Zero)
				id_getSelectableBackground_Landroid_content_Context_IZ = JNIEnv.GetStaticMethodID (class_ref, "getSelectableBackground", "(Landroid/content/Context;IZ)Landroid/graphics/drawable/StateListDrawable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Drawables.StateListDrawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSelectableBackground_Landroid_content_Context_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSelectablePressedBackground_Landroid_content_Context_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='FastAdapterUIUtils']/method[@name='getSelectablePressedBackground' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("getSelectablePressedBackground", "(Landroid/content/Context;IIZ)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetSelectablePressedBackground (global::Android.Content.Context p0, int p1, int p2, bool p3)
		{
			if (id_getSelectablePressedBackground_Landroid_content_Context_IIZ == IntPtr.Zero)
				id_getSelectablePressedBackground_Landroid_content_Context_IIZ = JNIEnv.GetStaticMethodID (class_ref, "getSelectablePressedBackground", "(Landroid/content/Context;IIZ)Landroid/graphics/drawable/StateListDrawable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Drawables.StateListDrawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSelectablePressedBackground_Landroid_content_Context_IIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
