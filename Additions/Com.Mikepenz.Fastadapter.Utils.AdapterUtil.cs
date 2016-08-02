using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/utils/AdapterUtil", DoNotGenerateAcw=true)]
	public partial class AdapterUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/utils/AdapterUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdapterUtil); }
		}

		protected AdapterUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/constructor[@name='AdapterUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdapterUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdapterUtil)) {
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

		static IntPtr id_addAllSubItems_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='addAllSubItems' and count(parameter)=2 and parameter[1][@type='com.mikepenz.fastadapter.IItem'] and parameter[2][@type='java.util.List&lt;com.mikepenz.fastadapter.IItem&gt;']]"
		[Register ("addAllSubItems", "(Lcom/mikepenz/fastadapter/IItem;Ljava/util/List;)V", "")]
		public static unsafe void AddAllSubItems (global::Com.Mikepenz.Fastadapter.IItem p0, global::System.Collections.Generic.IList<global::Com.Mikepenz.Fastadapter.IItem> p1)
		{
			if (id_addAllSubItems_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_ == IntPtr.Zero)
				id_addAllSubItems_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "addAllSubItems", "(Lcom/mikepenz/fastadapter/IItem;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Fastadapter.IItem>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addAllSubItems_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_adjustPosition_Landroid_util_SparseIntArray_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='adjustPosition' and count(parameter)=4 and parameter[1][@type='android.util.SparseIntArray'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("adjustPosition", "(Landroid/util/SparseIntArray;III)Landroid/util/SparseIntArray;", "")]
		public static unsafe global::Android.Util.SparseIntArray AdjustPosition (global::Android.Util.SparseIntArray p0, int p1, int p2, int p3)
		{
			if (id_adjustPosition_Landroid_util_SparseIntArray_III == IntPtr.Zero)
				id_adjustPosition_Landroid_util_SparseIntArray_III = JNIEnv.GetStaticMethodID (class_ref, "adjustPosition", "(Landroid/util/SparseIntArray;III)Landroid/util/SparseIntArray;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Util.SparseIntArray __ret = global::Java.Lang.Object.GetObject<global::Android.Util.SparseIntArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_adjustPosition_Landroid_util_SparseIntArray_III, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_adjustPosition_Ljava_util_Set_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='adjustPosition' and count(parameter)=4 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("adjustPosition", "(Ljava/util/Set;III)Ljava/util/SortedSet;", "")]
		public static unsafe global::Java.Util.ISortedSet AdjustPosition (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0, int p1, int p2, int p3)
		{
			if (id_adjustPosition_Ljava_util_Set_III == IntPtr.Zero)
				id_adjustPosition_Ljava_util_Set_III = JNIEnv.GetStaticMethodID (class_ref, "adjustPosition", "(Ljava/util/Set;III)Ljava/util/SortedSet;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Java.Util.ISortedSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_adjustPosition_Ljava_util_Set_III, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_findSubItemSelections_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='findSubItemSelections' and count(parameter)=2 and parameter[1][@type='com.mikepenz.fastadapter.IItem'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("findSubItemSelections", "(Lcom/mikepenz/fastadapter/IItem;Ljava/util/List;)V", "")]
		public static unsafe void FindSubItemSelections (global::Com.Mikepenz.Fastadapter.IItem p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_findSubItemSelections_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_ == IntPtr.Zero)
				id_findSubItemSelections_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "findSubItemSelections", "(Lcom/mikepenz/fastadapter/IItem;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_findSubItemSelections_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAllItems_Lcom_mikepenz_fastadapter_FastAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='getAllItems' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter']]"
		[Register ("getAllItems", "(Lcom/mikepenz/fastadapter/FastAdapter;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mikepenz.Fastadapter.IItem> GetAllItems (global::Com.Mikepenz.Fastadapter.FastAdapter p0)
		{
			if (id_getAllItems_Lcom_mikepenz_fastadapter_FastAdapter_ == IntPtr.Zero)
				id_getAllItems_Lcom_mikepenz_fastadapter_FastAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "getAllItems", "(Lcom/mikepenz/fastadapter/FastAdapter;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Mikepenz.Fastadapter.IItem> __ret = global::Android.Runtime.JavaList<global::Com.Mikepenz.Fastadapter.IItem>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllItems_Lcom_mikepenz_fastadapter_FastAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_handleStates_Lcom_mikepenz_fastadapter_FastAdapter_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='handleStates' and count(parameter)=3 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("handleStates", "(Lcom/mikepenz/fastadapter/FastAdapter;II)V", "")]
		public static unsafe void HandleStates (global::Com.Mikepenz.Fastadapter.FastAdapter p0, int p1, int p2)
		{
			if (id_handleStates_Lcom_mikepenz_fastadapter_FastAdapter_II == IntPtr.Zero)
				id_handleStates_Lcom_mikepenz_fastadapter_FastAdapter_II = JNIEnv.GetStaticMethodID (class_ref, "handleStates", "(Lcom/mikepenz/fastadapter/FastAdapter;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleStates_Lcom_mikepenz_fastadapter_FastAdapter_II, __args);
			} finally {
			}
		}

		static IntPtr id_restoreSubItemSelectionStatesForAlternativeStateManagement_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.utils']/class[@name='AdapterUtil']/method[@name='restoreSubItemSelectionStatesForAlternativeStateManagement' and count(parameter)=2 and parameter[1][@type='com.mikepenz.fastadapter.IItem'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("restoreSubItemSelectionStatesForAlternativeStateManagement", "(Lcom/mikepenz/fastadapter/IItem;Ljava/util/List;)V", "")]
		public static unsafe void RestoreSubItemSelectionStatesForAlternativeStateManagement (global::Com.Mikepenz.Fastadapter.IItem p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_restoreSubItemSelectionStatesForAlternativeStateManagement_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_ == IntPtr.Zero)
				id_restoreSubItemSelectionStatesForAlternativeStateManagement_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "restoreSubItemSelectionStatesForAlternativeStateManagement", "(Lcom/mikepenz/fastadapter/IItem;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_restoreSubItemSelectionStatesForAlternativeStateManagement_Lcom_mikepenz_fastadapter_IItem_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
