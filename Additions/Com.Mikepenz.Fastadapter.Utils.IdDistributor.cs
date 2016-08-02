using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='IdDistributor']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/utils/IdDistributor", DoNotGenerateAcw=true)]
	public partial class IdDistributor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/utils/IdDistributor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdDistributor); }
		}

		protected IdDistributor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='IdDistributor']/constructor[@name='IdDistributor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IdDistributor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IdDistributor)) {
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

		static IntPtr id_checkId_Lcom_mikepenz_fastadapter_IIdentifyable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='IdDistributor']/method[@name='checkId' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkId", "(Lcom/mikepenz/fastadapter/IIdentifyable;)Lcom/mikepenz/fastadapter/IIdentifyable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mikepenz.fastadapter.IIdentifyable"})]
		public static unsafe global::Java.Lang.Object CheckId (global::Java.Lang.Object p0)
		{
			if (id_checkId_Lcom_mikepenz_fastadapter_IIdentifyable_ == IntPtr.Zero)
				id_checkId_Lcom_mikepenz_fastadapter_IIdentifyable_ = JNIEnv.GetStaticMethodID (class_ref, "checkId", "(Lcom/mikepenz/fastadapter/IIdentifyable;)Lcom/mikepenz/fastadapter/IIdentifyable;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkId_Lcom_mikepenz_fastadapter_IIdentifyable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkIds_arrayLcom_mikepenz_fastadapter_IIdentifyable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='IdDistributor']/method[@name='checkIds' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("checkIds", "([Lcom/mikepenz/fastadapter/IIdentifyable;)[Lcom/mikepenz/fastadapter/IIdentifyable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mikepenz.fastadapter.IIdentifyable"})]
		public static unsafe global::Java.Lang.Object[] CheckIds (params global:: Java.Lang.Object[] p0)
		{
			if (id_checkIds_arrayLcom_mikepenz_fastadapter_IIdentifyable_ == IntPtr.Zero)
				id_checkIds_arrayLcom_mikepenz_fastadapter_IIdentifyable_ = JNIEnv.GetStaticMethodID (class_ref, "checkIds", "([Lcom/mikepenz/fastadapter/IIdentifyable;)[Lcom/mikepenz/fastadapter/IIdentifyable;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkIds_arrayLcom_mikepenz_fastadapter_IIdentifyable_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_checkIds_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='IdDistributor']/method[@name='checkIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("checkIds", "(Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mikepenz.fastadapter.IIdentifyable"})]
		public static unsafe global::System.Collections.IList CheckIds (global::System.Collections.IList p0)
		{
			if (id_checkIds_Ljava_util_List_ == IntPtr.Zero)
				id_checkIds_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "checkIds", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkIds_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
