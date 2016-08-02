using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/FastItemAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial class FastItemAdapter : global::Com.Mikepenz.Fastadapter.FastAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/FastItemAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastItemAdapter); }
		}

		protected FastItemAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/constructor[@name='FastItemAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FastItemAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FastItemAdapter)) {
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

		static Delegate cb_getAdapterItemCount;
#pragma warning disable 0169
		static Delegate GetGetAdapterItemCountHandler ()
		{
			if (cb_getAdapterItemCount == null)
				cb_getAdapterItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdapterItemCount);
			return cb_getAdapterItemCount;
		}

		static int n_GetAdapterItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdapterItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterItemCount;
		public virtual unsafe int AdapterItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getAdapterItemCount' and count(parameter)=0]"
			[Register ("getAdapterItemCount", "()I", "GetGetAdapterItemCountHandler")]
			get {
				if (id_getAdapterItemCount == IntPtr.Zero)
					id_getAdapterItemCount = JNIEnv.GetMethodID (class_ref, "getAdapterItemCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapterItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdapterItems;
#pragma warning disable 0169
		static Delegate GetGetAdapterItemsHandler ()
		{
			if (cb_getAdapterItems == null)
				cb_getAdapterItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapterItems);
			return cb_getAdapterItems;
		}

		static IntPtr n_GetAdapterItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.AdapterItems);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterItems;
		public virtual unsafe global::System.Collections.IList AdapterItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getAdapterItems' and count(parameter)=0]"
			[Register ("getAdapterItems", "()Ljava/util/List;", "GetGetAdapterItemsHandler")]
			get {
				if (id_getAdapterItems == IntPtr.Zero)
					id_getAdapterItems = JNIEnv.GetMethodID (class_ref, "getAdapterItems", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapterItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItemAdapter;
#pragma warning disable 0169
		static Delegate GetGetItemAdapterHandler ()
		{
			if (cb_getItemAdapter == null)
				cb_getItemAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItemAdapter);
			return cb_getItemAdapter;
		}

		static IntPtr n_GetItemAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getItemAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter ItemAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getItemAdapter' and count(parameter)=0]"
			[Register ("getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetGetItemAdapterHandler")]
			get {
				if (id_getItemAdapter == IntPtr.Zero)
					id_getItemAdapter = JNIEnv.GetMethodID (class_ref, "getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItemFilter;
#pragma warning disable 0169
		static Delegate GetGetItemFilterHandler ()
		{
			if (cb_getItemFilter == null)
				cb_getItemFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItemFilter);
			return cb_getItemFilter;
		}

		static IntPtr n_GetItemFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemFilter);
		}
#pragma warning restore 0169

		static IntPtr id_getItemFilter;
		public virtual unsafe global::Android.Widget.Filter ItemFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getItemFilter' and count(parameter)=0]"
			[Register ("getItemFilter", "()Landroid/widget/Filter;", "GetGetItemFilterHandler")]
			get {
				if (id_getItemFilter == IntPtr.Zero)
					id_getItemFilter = JNIEnv.GetMethodID (class_ref, "getItemFilter", "()Landroid/widget/Filter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemFilter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemFilter", "()Landroid/widget/Filter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrder;
#pragma warning disable 0169
		static Delegate GetGetOrderHandler ()
		{
			if (cb_getOrder == null)
				cb_getOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrder);
			return cb_getOrder;
		}

		static int n_GetOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Order;
		}
#pragma warning restore 0169

		static IntPtr id_getOrder;
		public virtual unsafe int Order {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getOrder' and count(parameter)=0]"
			[Register ("getOrder", "()I", "GetGetOrderHandler")]
			get {
				if (id_getOrder == IntPtr.Zero)
					id_getOrder = JNIEnv.GetMethodID (class_ref, "getOrder", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrder);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrder", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_add_Lcom_mikepenz_fastadapter_IItem_ == null)
				cb_add_Lcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_mikepenz_fastadapter_IItem_);
			return cb_add_Lcom_mikepenz_fastadapter_IItem_;
		}

		static IntPtr n_Add_Lcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='Item']]"
		[Register ("add", "(Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetAdd_Lcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Add (global::Java.Lang.Object p0)
		{
			if (id_add_Lcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_add_Lcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_add_arrayLcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='Item...']]"
		[Register ("add", "([Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "")]
		public unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Add (params global:: Java.Lang.Object[] p0)
		{
			if (id_add_arrayLcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_add_arrayLcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "add", "([Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_arrayLcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_add_ILcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetAdd_ILcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_add_ILcom_mikepenz_fastadapter_IItem_ == null)
				cb_add_ILcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Add_ILcom_mikepenz_fastadapter_IItem_);
			return cb_add_ILcom_mikepenz_fastadapter_IItem_;
		}

		static IntPtr n_Add_ILcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_ILcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item']]"
		[Register ("add", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetAdd_ILcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Add (int p0, global::Java.Lang.Object p1)
		{
			if (id_add_ILcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_add_ILcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "add", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_ILcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_add_IarrayLcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item...']]"
		[Register ("add", "(I[Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "")]
		public unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Add (int p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_add_IarrayLcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_add_IarrayLcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "add", "(I[Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_IarrayLcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_add_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetAdd_ILjava_util_List_Handler ()
		{
			if (cb_add_ILjava_util_List_ == null)
				cb_add_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Add_ILjava_util_List_);
			return cb_add_ILjava_util_List_;
		}

		static IntPtr n_Add_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_ILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;Item&gt;']]"
		[Register ("add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetAdd_ILjava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Add (int p0, global::System.Collections.IList p1)
		{
			if (id_add_ILjava_util_List_ == IntPtr.Zero)
				id_add_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_ILjava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_add_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_util_List_Handler ()
		{
			if (cb_add_Ljava_util_List_ == null)
				cb_add_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_util_List_);
			return cb_add_Ljava_util_List_;
		}

		static IntPtr n_Add_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetAdd_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Add (global::System.Collections.IList p0)
		{
			if (id_add_Ljava_util_List_ == IntPtr.Zero)
				id_add_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetClearHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_filter_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetFilter_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_filter_Ljava_lang_CharSequence_ == null)
				cb_filter_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Filter_Ljava_lang_CharSequence_);
			return cb_filter_Ljava_lang_CharSequence_;
		}

		static void n_Filter_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Filter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_filter_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("filter", "(Ljava/lang/CharSequence;)V", "GetFilter_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void Filter (global::Java.Lang.ICharSequence p0)
		{
			if (id_filter_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_filter_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "filter", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_filter_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filter", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void Filter (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			Filter (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_getAdapterItem_I;
#pragma warning disable 0169
		static Delegate GetGetAdapterItem_IHandler ()
		{
			if (cb_getAdapterItem_I == null)
				cb_getAdapterItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAdapterItem_I);
			return cb_getAdapterItem_I;
		}

		static IntPtr n_GetAdapterItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAdapterItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getAdapterItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdapterItem", "(I)Lcom/mikepenz/fastadapter/IItem;", "GetGetAdapterItem_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetAdapterItem (int p0)
		{
			if (id_getAdapterItem_I == IntPtr.Zero)
				id_getAdapterItem_I = JNIEnv.GetMethodID (class_ref, "getAdapterItem", "(I)Lcom/mikepenz/fastadapter/IItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapterItem", "(I)Lcom/mikepenz/fastadapter/IItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetGetAdapterPosition_Lcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_ == null)
				cb_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetAdapterPosition_Lcom_mikepenz_fastadapter_IItem_);
			return cb_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_;
		}

		static int n_GetAdapterPosition_Lcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAdapterPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getAdapterPosition' and count(parameter)=1 and parameter[1][@type='Item']]"
		[Register ("getAdapterPosition", "(Lcom/mikepenz/fastadapter/IItem;)I", "GetGetAdapterPosition_Lcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe int GetAdapterPosition (global::Java.Lang.Object p0)
		{
			if (id_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "getAdapterPosition", "(Lcom/mikepenz/fastadapter/IItem;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapterPosition", "(Lcom/mikepenz/fastadapter/IItem;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGlobalPosition_I;
#pragma warning disable 0169
		static Delegate GetGetGlobalPosition_IHandler ()
		{
			if (cb_getGlobalPosition_I == null)
				cb_getGlobalPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetGlobalPosition_I);
			return cb_getGlobalPosition_I;
		}

		static int n_GetGlobalPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetGlobalPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getGlobalPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='getGlobalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGlobalPosition", "(I)I", "GetGetGlobalPosition_IHandler")]
		public virtual unsafe int GetGlobalPosition (int p0)
		{
			if (id_getGlobalPosition_I == IntPtr.Zero)
				id_getGlobalPosition_I = JNIEnv.GetMethodID (class_ref, "getGlobalPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGlobalPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGlobalPosition", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_move_II;
#pragma warning disable 0169
		static Delegate GetMove_IIHandler ()
		{
			if (cb_move_II == null)
				cb_move_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Move_II);
			return cb_move_II;
		}

		static IntPtr n_Move_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Move (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_move_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='move' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("move", "(II)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetMove_IIHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Move (int p0, int p1)
		{
			if (id_move_II == IntPtr.Zero)
				id_move_II = JNIEnv.GetMethodID (class_ref, "move", "(II)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_move_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "move", "(II)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Remove_I);
			return cb_remove_I;
		}

		static IntPtr n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove (p0));
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetRemove_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeItemRange_II;
#pragma warning disable 0169
		static Delegate GetRemoveItemRange_IIHandler ()
		{
			if (cb_removeItemRange_II == null)
				cb_removeItemRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_RemoveItemRange_II);
			return cb_removeItemRange_II;
		}

		static IntPtr n_RemoveItemRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveItemRange (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_removeItemRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='removeItemRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("removeItemRange", "(II)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetRemoveItemRange_IIHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter RemoveItemRange (int p0, int p1)
		{
			if (id_removeItemRange_II == IntPtr.Zero)
				id_removeItemRange_II = JNIEnv.GetMethodID (class_ref, "removeItemRange", "(II)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeItemRange_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItemRange", "(II)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_ILcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetSet_ILcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_set_ILcom_mikepenz_fastadapter_IItem_ == null)
				cb_set_ILcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Set_ILcom_mikepenz_fastadapter_IItem_);
			return cb_set_ILcom_mikepenz_fastadapter_IItem_;
		}

		static IntPtr n_Set_ILcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_ILcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item']]"
		[Register ("set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetSet_ILcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Set (int p0, global::Java.Lang.Object p1)
		{
			if (id_set_ILcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_set_ILcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_ILcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_set_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_util_List_Handler ()
		{
			if (cb_set_Ljava_util_List_ == null)
				cb_set_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_util_List_);
			return cb_set_Ljava_util_List_;
		}

		static IntPtr n_Set_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetSet_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter Set (global::System.Collections.IList p0)
		{
			if (id_set_Ljava_util_List_ == IntPtr.Zero)
				id_set_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNewList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetNewList_Ljava_util_List_Handler ()
		{
			if (cb_setNewList_Ljava_util_List_ == null)
				cb_setNewList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNewList_Ljava_util_List_);
			return cb_setNewList_Ljava_util_List_;
		}

		static IntPtr n_SetNewList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNewList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNewList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='setNewList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetSetNewList_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter SetNewList (global::System.Collections.IList p0)
		{
			if (id_setNewList_Ljava_util_List_ == IntPtr.Zero)
				id_setNewList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNewList_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_Handler ()
		{
			if (cb_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_ == null)
				cb_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_);
			return cb_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_;
		}

		static IntPtr n_SetSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.IExpandable p0 = (global::Com.Mikepenz.Fastadapter.IExpandable)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSubItems (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='setSubItems' and count(parameter)=2 and parameter[1][@type='com.mikepenz.fastadapter.IExpandable&lt;T, Item&gt;'] and parameter[2][@type='java.util.List&lt;Item&gt;']]"
		[Register ("setSubItems", "(Lcom/mikepenz/fastadapter/IExpandable;Ljava/util/List;)Ljava/lang/Object;", "GetSetSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object SetSubItems (global::Com.Mikepenz.Fastadapter.IExpandable p0, global::System.Collections.IList p1)
		{
			if (id_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_ == IntPtr.Zero)
				id_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSubItems", "(Lcom/mikepenz/fastadapter/IExpandable;Ljava/util/List;)Ljava/lang/Object;");
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubItems", "(Lcom/mikepenz/fastadapter/IExpandable;Ljava/util/List;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_;
#pragma warning disable 0169
		static Delegate GetWithFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_Handler ()
		{
			if (cb_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ == null)
				cb_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_);
			return cb_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_;
		}

		static IntPtr n_WithFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate p0 = (global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilterPredicate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='withFilterPredicate' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.IItemAdapter.Predicate&lt;Item&gt;']]"
		[Register ("withFilterPredicate", "(Lcom/mikepenz/fastadapter/IItemAdapter$Predicate;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetWithFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter WithFilterPredicate (global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate p0)
		{
			if (id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ == IntPtr.Zero)
				id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ = JNIEnv.GetMethodID (class_ref, "withFilterPredicate", "(Lcom/mikepenz/fastadapter/IItemAdapter$Predicate;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFilterPredicate", "(Lcom/mikepenz/fastadapter/IItemAdapter$Predicate;)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withUseIdDistributor_Z;
#pragma warning disable 0169
		static Delegate GetWithUseIdDistributor_ZHandler ()
		{
			if (cb_withUseIdDistributor_Z == null)
				cb_withUseIdDistributor_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithUseIdDistributor_Z);
			return cb_withUseIdDistributor_Z;
		}

		static IntPtr n_WithUseIdDistributor_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithUseIdDistributor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withUseIdDistributor_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='FastItemAdapter']/method[@name='withUseIdDistributor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withUseIdDistributor", "(Z)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;", "GetWithUseIdDistributor_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter WithUseIdDistributor (bool p0)
		{
			if (id_withUseIdDistributor_Z == IntPtr.Zero)
				id_withUseIdDistributor_Z = JNIEnv.GetMethodID (class_ref, "withUseIdDistributor", "(Z)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withUseIdDistributor_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withUseIdDistributor", "(Z)Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
