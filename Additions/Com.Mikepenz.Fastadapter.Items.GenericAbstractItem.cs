using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Items {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='GenericAbstractItem']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/items/GenericAbstractItem", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Model", "Item extends com.mikepenz.fastadapter.items.GenericAbstractItem<?, ?, ?>", "VH extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public abstract partial class GenericAbstractItem : global::Com.Mikepenz.Fastadapter.Items.AbstractItem {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/items/GenericAbstractItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericAbstractItem); }
		}

		protected GenericAbstractItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='GenericAbstractItem']/constructor[@name='GenericAbstractItem' and count(parameter)=1 and parameter[1][@type='Model']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe GenericAbstractItem (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (GenericAbstractItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Model);
		}
#pragma warning restore 0169

		static IntPtr id_getModel;
		public virtual unsafe global::Java.Lang.Object Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='GenericAbstractItem']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/Object;", "GetGetModelHandler")]
			get {
				if (id_getModel == IntPtr.Zero)
					id_getModel = JNIEnv.GetMethodID (class_ref, "getModel", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModel), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModel", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setModel_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetModel_Ljava_lang_Object_Handler ()
		{
			if (cb_setModel_Ljava_lang_Object_ == null)
				cb_setModel_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetModel_Ljava_lang_Object_);
			return cb_setModel_Ljava_lang_Object_;
		}

		static IntPtr n_SetModel_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetModel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setModel_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='GenericAbstractItem']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='Model']]"
		[Register ("setModel", "(Ljava/lang/Object;)Lcom/mikepenz/fastadapter/items/GenericAbstractItem;", "GetSetModel_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem SetModel (global::Java.Lang.Object p0)
		{
			if (id_setModel_Ljava_lang_Object_ == IntPtr.Zero)
				id_setModel_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setModel", "(Ljava/lang/Object;)Lcom/mikepenz/fastadapter/items/GenericAbstractItem;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setModel_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.GenericAbstractItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModel", "(Ljava/lang/Object;)Lcom/mikepenz/fastadapter/items/GenericAbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/items/GenericAbstractItem", DoNotGenerateAcw=true)]
	internal partial class GenericAbstractItemInvoker : GenericAbstractItem {

		public GenericAbstractItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericAbstractItemInvoker); }
		}

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register ("getLayoutRes", "()I", "GetGetLayoutResHandler")]
			get {
				if (id_getLayoutRes == IntPtr.Zero)
					id_getLayoutRes = JNIEnv.GetMethodID (class_ref, "getLayoutRes", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayoutRes);
				} finally {
				}
			}
		}

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
				} finally {
				}
			}
		}

	}

}
