using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/AbstractAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public abstract partial class AbstractAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter, global::Com.Mikepenz.Fastadapter.IAdapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/AbstractAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractAdapter); }
		}

		protected AbstractAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/constructor[@name='AbstractAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AbstractAdapter)) {
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

		static Delegate cb_getFastAdapter;
#pragma warning disable 0169
		static Delegate GetGetFastAdapterHandler ()
		{
			if (cb_getFastAdapter == null)
				cb_getFastAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFastAdapter);
			return cb_getFastAdapter;
		}

		static IntPtr n_GetFastAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FastAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getFastAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter FastAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getFastAdapter' and count(parameter)=0]"
			[Register ("getFastAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;", "GetGetFastAdapterHandler")]
			get {
				if (id_getFastAdapter == IntPtr.Zero)
					id_getFastAdapter = JNIEnv.GetMethodID (class_ref, "getFastAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFastAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFastAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/mikepenz/fastadapter/IItem;", "GetGetItem_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/mikepenz/fastadapter/IItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Lcom/mikepenz/fastadapter/IItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetMapPossibleType_Lcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_ == null)
				cb_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MapPossibleType_Lcom_mikepenz_fastadapter_IItem_);
			return cb_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_;
		}

		static void n_MapPossibleType_Lcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MapPossibleType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='mapPossibleType' and count(parameter)=1 and parameter[1][@type='Item']]"
		[Register ("mapPossibleType", "(Lcom/mikepenz/fastadapter/IItem;)V", "GetMapPossibleType_Lcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe void MapPossibleType (global::Java.Lang.Object p0)
		{
			if (id_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "mapPossibleType", "(Lcom/mikepenz/fastadapter/IItem;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapPossibleType_Lcom_mikepenz_fastadapter_IItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapPossibleType", "(Lcom/mikepenz/fastadapter/IItem;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_mapPossibleTypes_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetMapPossibleTypes_Ljava_lang_Iterable_Handler ()
		{
			if (cb_mapPossibleTypes_Ljava_lang_Iterable_ == null)
				cb_mapPossibleTypes_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MapPossibleTypes_Ljava_lang_Iterable_);
			return cb_mapPossibleTypes_Ljava_lang_Iterable_;
		}

		static void n_MapPossibleTypes_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MapPossibleTypes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_mapPossibleTypes_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='mapPossibleTypes' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;Item&gt;']]"
		[Register ("mapPossibleTypes", "(Ljava/lang/Iterable;)V", "GetMapPossibleTypes_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void MapPossibleTypes (global::Java.Lang.IIterable p0)
		{
			if (id_mapPossibleTypes_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_mapPossibleTypes_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "mapPossibleTypes", "(Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapPossibleTypes_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapPossibleTypes", "(Ljava/lang/Iterable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I);
			return cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler")]
		public override unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
				cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnCreateViewHolder_Landroid_view_ViewGroup_I);
			return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateViewHolder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_wrap_Lcom_mikepenz_fastadapter_FastAdapter_;
#pragma warning disable 0169
		static Delegate GetWrap_Lcom_mikepenz_fastadapter_FastAdapter_Handler ()
		{
			if (cb_wrap_Lcom_mikepenz_fastadapter_FastAdapter_ == null)
				cb_wrap_Lcom_mikepenz_fastadapter_FastAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Wrap_Lcom_mikepenz_fastadapter_FastAdapter_);
			return cb_wrap_Lcom_mikepenz_fastadapter_FastAdapter_;
		}

		static IntPtr n_Wrap_Lcom_mikepenz_fastadapter_FastAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Wrap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrap_Lcom_mikepenz_fastadapter_FastAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter']]"
		[Register ("wrap", "(Lcom/mikepenz/fastadapter/FastAdapter;)Lcom/mikepenz/fastadapter/AbstractAdapter;", "GetWrap_Lcom_mikepenz_fastadapter_FastAdapter_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.AbstractAdapter Wrap (global::Com.Mikepenz.Fastadapter.FastAdapter p0)
		{
			if (id_wrap_Lcom_mikepenz_fastadapter_FastAdapter_ == IntPtr.Zero)
				id_wrap_Lcom_mikepenz_fastadapter_FastAdapter_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Lcom/mikepenz/fastadapter/FastAdapter;)Lcom/mikepenz/fastadapter/AbstractAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.AbstractAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_wrap_Lcom_mikepenz_fastadapter_FastAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrap", "(Lcom/mikepenz/fastadapter/FastAdapter;)Lcom/mikepenz/fastadapter/AbstractAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_wrap_Lcom_mikepenz_fastadapter_IAdapter_;
#pragma warning disable 0169
		static Delegate GetWrap_Lcom_mikepenz_fastadapter_IAdapter_Handler ()
		{
			if (cb_wrap_Lcom_mikepenz_fastadapter_IAdapter_ == null)
				cb_wrap_Lcom_mikepenz_fastadapter_IAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Wrap_Lcom_mikepenz_fastadapter_IAdapter_);
			return cb_wrap_Lcom_mikepenz_fastadapter_IAdapter_;
		}

		static IntPtr n_Wrap_Lcom_mikepenz_fastadapter_IAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.IAdapter p0 = (global::Com.Mikepenz.Fastadapter.IAdapter)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Wrap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrap_Lcom_mikepenz_fastadapter_IAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.IAdapter']]"
		[Register ("wrap", "(Lcom/mikepenz/fastadapter/IAdapter;)Lcom/mikepenz/fastadapter/AbstractAdapter;", "GetWrap_Lcom_mikepenz_fastadapter_IAdapter_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.AbstractAdapter Wrap (global::Com.Mikepenz.Fastadapter.IAdapter p0)
		{
			if (id_wrap_Lcom_mikepenz_fastadapter_IAdapter_ == IntPtr.Zero)
				id_wrap_Lcom_mikepenz_fastadapter_IAdapter_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Lcom/mikepenz/fastadapter/IAdapter;)Lcom/mikepenz/fastadapter/AbstractAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.AbstractAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_wrap_Lcom_mikepenz_fastadapter_IAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrap", "(Lcom/mikepenz/fastadapter/IAdapter;)Lcom/mikepenz/fastadapter/AbstractAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetGlobalPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getGlobalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGlobalPosition", "(I)I", "GetGetGlobalPosition_IHandler")]
		public abstract int GetGlobalPosition (int p0);

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
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdapterItemCount;
		}
#pragma warning restore 0169

		public abstract int AdapterItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getAdapterItemCount' and count(parameter)=0]"
			[Register ("getAdapterItemCount", "()I", "GetGetAdapterItemCountHandler")] get;
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
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.AdapterItems);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.IList AdapterItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getAdapterItems' and count(parameter)=0]"
			[Register ("getAdapterItems", "()Ljava/util/List;", "GetGetAdapterItemsHandler")] get;
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
			global::Com.Mikepenz.Fastadapter.AbstractAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.AbstractAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Order;
		}
#pragma warning restore 0169

		public abstract int Order {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getOrder' and count(parameter)=0]"
			[Register ("getOrder", "()I", "GetGetOrderHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/AbstractAdapter", DoNotGenerateAcw=true)]
	internal partial class AbstractAdapterInvoker : AbstractAdapter, global::Com.Mikepenz.Fastadapter.IAdapter {

		public AbstractAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractAdapterInvoker); }
		}

		static IntPtr id_getAdapterItemCount;
		public override unsafe int AdapterItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getAdapterItemCount' and count(parameter)=0]"
			[Register ("getAdapterItemCount", "()I", "GetGetAdapterItemCountHandler")]
			get {
				if (id_getAdapterItemCount == IntPtr.Zero)
					id_getAdapterItemCount = JNIEnv.GetMethodID (class_ref, "getAdapterItemCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterItemCount);
				} finally {
				}
			}
		}

		static IntPtr id_getAdapterItems;
		public override unsafe global::System.Collections.IList AdapterItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getAdapterItems' and count(parameter)=0]"
			[Register ("getAdapterItems", "()Ljava/util/List;", "GetGetAdapterItemsHandler")]
			get {
				if (id_getAdapterItems == IntPtr.Zero)
					id_getAdapterItems = JNIEnv.GetMethodID (class_ref, "getAdapterItems", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterItems), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrder;
		public override unsafe int Order {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='AbstractAdapter']/method[@name='getOrder' and count(parameter)=0]"
			[Register ("getOrder", "()I", "GetGetOrderHandler")]
			get {
				if (id_getOrder == IntPtr.Zero)
					id_getOrder = JNIEnv.GetMethodID (class_ref, "getOrder", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrder);
				} finally {
				}
			}
		}

		static IntPtr id_getGlobalPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getGlobalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGlobalPosition", "(I)I", "GetGetGlobalPosition_IHandler")]
		public override unsafe int GetGlobalPosition (int p0)
		{
			if (id_getGlobalPosition_I == IntPtr.Zero)
				id_getGlobalPosition_I = JNIEnv.GetMethodID (class_ref, "getGlobalPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGlobalPosition_I, __args);
			} finally {
			}
		}

	}

}
