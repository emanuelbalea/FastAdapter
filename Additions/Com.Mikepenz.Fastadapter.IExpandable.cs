using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']"
	[Register ("com/mikepenz/fastadapter/IExpandable", "", "Com.Mikepenz.Fastadapter.IExpandableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Item extends com.mikepenz.fastadapter.IItem"})]
	public partial interface IExpandable : IJavaObject {

		bool IsAutoExpanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='isAutoExpanding' and count(parameter)=0]"
			[Register ("isAutoExpanding", "()Z", "GetIsAutoExpandingHandler:Com.Mikepenz.Fastadapter.IExpandableInvoker, FastAdapter")] get;
		}

		bool IsExpanded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='isExpanded' and count(parameter)=0]"
			[Register ("isExpanded", "()Z", "GetIsExpandedHandler:Com.Mikepenz.Fastadapter.IExpandableInvoker, FastAdapter")] get;
		}

		global::System.Collections.IList SubItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='getSubItems' and count(parameter)=0]"
			[Register ("getSubItems", "()Ljava/util/List;", "GetGetSubItemsHandler:Com.Mikepenz.Fastadapter.IExpandableInvoker, FastAdapter")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='withIsExpanded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withIsExpanded", "(Z)Ljava/lang/Object;", "GetWithIsExpanded_ZHandler:Com.Mikepenz.Fastadapter.IExpandableInvoker, FastAdapter")]
		global::Java.Lang.Object WithIsExpanded (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='withSubItems' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("withSubItems", "(Ljava/util/List;)Ljava/lang/Object;", "GetWithSubItems_Ljava_util_List_Handler:Com.Mikepenz.Fastadapter.IExpandableInvoker, FastAdapter")]
		global::Java.Lang.Object WithSubItems (global::System.Collections.IList p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/IExpandable", DoNotGenerateAcw=true)]
	internal class IExpandableInvoker : global::Java.Lang.Object, IExpandable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/IExpandable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExpandableInvoker); }
		}

		IntPtr class_ref;

		public static IExpandable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpandable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.IExpandable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpandableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAutoExpanding;
#pragma warning disable 0169
		static Delegate GetIsAutoExpandingHandler ()
		{
			if (cb_isAutoExpanding == null)
				cb_isAutoExpanding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoExpanding);
			return cb_isAutoExpanding;
		}

		static bool n_IsAutoExpanding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IExpandable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoExpanding;
		}
#pragma warning restore 0169

		IntPtr id_isAutoExpanding;
		public unsafe bool IsAutoExpanding {
			get {
				if (id_isAutoExpanding == IntPtr.Zero)
					id_isAutoExpanding = JNIEnv.GetMethodID (class_ref, "isAutoExpanding", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoExpanding);
			}
		}

		static Delegate cb_isExpanded;
#pragma warning disable 0169
		static Delegate GetIsExpandedHandler ()
		{
			if (cb_isExpanded == null)
				cb_isExpanded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpanded);
			return cb_isExpanded;
		}

		static bool n_IsExpanded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IExpandable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpanded;
		}
#pragma warning restore 0169

		IntPtr id_isExpanded;
		public unsafe bool IsExpanded {
			get {
				if (id_isExpanded == IntPtr.Zero)
					id_isExpanded = JNIEnv.GetMethodID (class_ref, "isExpanded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpanded);
			}
		}

		static Delegate cb_getSubItems;
#pragma warning disable 0169
		static Delegate GetGetSubItemsHandler ()
		{
			if (cb_getSubItems == null)
				cb_getSubItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubItems);
			return cb_getSubItems;
		}

		static IntPtr n_GetSubItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IExpandable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.SubItems);
		}
#pragma warning restore 0169

		IntPtr id_getSubItems;
		public unsafe global::System.Collections.IList SubItems {
			get {
				if (id_getSubItems == IntPtr.Zero)
					id_getSubItems = JNIEnv.GetMethodID (class_ref, "getSubItems", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubItems), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_withIsExpanded_Z;
#pragma warning disable 0169
		static Delegate GetWithIsExpanded_ZHandler ()
		{
			if (cb_withIsExpanded_Z == null)
				cb_withIsExpanded_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIsExpanded_Z);
			return cb_withIsExpanded_Z;
		}

		static IntPtr n_WithIsExpanded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.IExpandable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIsExpanded (p0));
		}
#pragma warning restore 0169

		IntPtr id_withIsExpanded_Z;
		public unsafe global::Java.Lang.Object WithIsExpanded (bool p0)
		{
			if (id_withIsExpanded_Z == IntPtr.Zero)
				id_withIsExpanded_Z = JNIEnv.GetMethodID (class_ref, "withIsExpanded", "(Z)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIsExpanded_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_withSubItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithSubItems_Ljava_util_List_Handler ()
		{
			if (cb_withSubItems_Ljava_util_List_ == null)
				cb_withSubItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSubItems_Ljava_util_List_);
			return cb_withSubItems_Ljava_util_List_;
		}

		static IntPtr n_WithSubItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.IExpandable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSubItems (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withSubItems_Ljava_util_List_;
		public unsafe global::Java.Lang.Object WithSubItems (global::System.Collections.IList p0)
		{
			if (id_withSubItems_Ljava_util_List_ == IntPtr.Zero)
				id_withSubItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withSubItems", "(Ljava/util/List;)Ljava/lang/Object;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSubItems_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
