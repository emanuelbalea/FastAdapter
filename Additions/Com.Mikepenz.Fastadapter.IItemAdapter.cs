using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter.Predicate']"
	[Register ("com/mikepenz/fastadapter/IItemAdapter$Predicate", "", "Com.Mikepenz.Fastadapter.IItemAdapterPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial interface IItemAdapterPredicate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter.Predicate']/method[@name='filter' and count(parameter)=2 and parameter[1][@type='Item'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("filter", "(Lcom/mikepenz/fastadapter/IItem;Ljava/lang/CharSequence;)Z", "GetFilter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_Handler:Com.Mikepenz.Fastadapter.IItemAdapterPredicateInvoker, FastAdapter")]
		bool Filter (global::Java.Lang.Object p0, global::Java.Lang.ICharSequence p1);

	}

	public static partial class IItemAdapterPredicateExtensions {

		public static bool Filter (this Com.Mikepenz.Fastadapter.IItemAdapterPredicate self, global::Java.Lang.Object p0, string p1)
		{
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			bool __result = self.Filter (p0, jls_p1);
			if (jls_p1 != null) jls_p1.Dispose ();
			return __result;
		}
	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/IItemAdapter$Predicate", DoNotGenerateAcw=true)]
	internal class IItemAdapterPredicateInvoker : global::Java.Lang.Object, IItemAdapterPredicate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/IItemAdapter$Predicate");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IItemAdapterPredicateInvoker); }
		}

		IntPtr class_ref;

		public static IItemAdapterPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IItemAdapterPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.IItemAdapter.Predicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IItemAdapterPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetFilter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_ == null)
				cb_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_);
			return cb_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_;
		}

		static bool n_Filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Filter (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_;
		public unsafe bool Filter (global::Java.Lang.Object p0, global::Java.Lang.ICharSequence p1)
		{
			if (id_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lcom/mikepenz/fastadapter/IItem;Ljava/lang/CharSequence;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_filter_Lcom_mikepenz_fastadapter_IItem_Ljava_lang_CharSequence_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']"
	[Register ("com/mikepenz/fastadapter/IItemAdapter", "", "Com.Mikepenz.Fastadapter.IItemAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial interface IItemAdapter : global::Com.Mikepenz.Fastadapter.IAdapter {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='Item...']]"
		[Register ("add", "([Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetAdd_arrayLcom_mikepenz_fastadapter_IItem_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Add (params global:: Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item...']]"
		[Register ("add", "(I[Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetAdd_IarrayLcom_mikepenz_fastadapter_IItem_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Add (int p0, params global:: Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;Item&gt;']]"
		[Register ("add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetAdd_ILjava_util_List_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Add (int p0, global::System.Collections.IList p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetAdd_Ljava_util_List_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Add (global::System.Collections.IList p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lcom/mikepenz/fastadapter/IItemAdapter;", "GetClearHandler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetRemove_IHandler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Remove (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='removeRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("removeRange", "(II)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetRemoveRange_IIHandler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter RemoveRange (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item']]"
		[Register ("set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetSet_ILcom_mikepenz_fastadapter_IItem_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Set (int p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetSet_Ljava_util_List_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter Set (global::System.Collections.IList p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='setNewList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/IItemAdapter;", "GetSetNewList_Ljava_util_List_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		global::Com.Mikepenz.Fastadapter.IItemAdapter SetNewList (global::System.Collections.IList p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItemAdapter']/method[@name='setSubItems' and count(parameter)=2 and parameter[1][@type='com.mikepenz.fastadapter.IExpandable&lt;T, Item&gt;'] and parameter[2][@type='java.util.List&lt;Item&gt;']]"
		[Register ("setSubItems", "(Lcom/mikepenz/fastadapter/IExpandable;Ljava/util/List;)Ljava/lang/Object;", "GetSetSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_Handler:Com.Mikepenz.Fastadapter.IItemAdapterInvoker, FastAdapter")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object SetSubItems (global::Com.Mikepenz.Fastadapter.IExpandable p0, global::System.Collections.IList p1);

	}
}
