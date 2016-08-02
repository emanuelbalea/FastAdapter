using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/AbstractWrapAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public abstract partial class AbstractWrapAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/AbstractWrapAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWrapAdapter); }
		}

		protected AbstractWrapAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/constructor[@name='AbstractWrapAdapter' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe AbstractWrapAdapter (global::System.Collections.IList p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (AbstractWrapAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler ()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		public virtual unsafe global::Android.Support.V7.Widget.RecyclerView.Adapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Landroid/support/v7/widget/RecyclerView$Adapter;", "GetGetAdapterHandler")]
			get {
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID (class_ref, "getAdapter", "()Landroid/support/v7/widget/RecyclerView$Adapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.Adapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.Adapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapter", "()Landroid/support/v7/widget/RecyclerView$Adapter;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='getItemCount' and count(parameter)=0]"
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

		static Delegate cb_getItems;
#pragma warning disable 0169
		static Delegate GetGetItemsHandler ()
		{
			if (cb_getItems == null)
				cb_getItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItems);
			return cb_getItems;
		}

		static IntPtr n_GetItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Items);
		}
#pragma warning restore 0169

		static Delegate cb_setItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetItems_Ljava_util_List_Handler ()
		{
			if (cb_setItems_Ljava_util_List_ == null)
				cb_setItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetItems_Ljava_util_List_);
			return cb_setItems_Ljava_util_List_;
		}

		static void n_SetItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Items = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItems;
		static IntPtr id_setItems_Ljava_util_List_;
		public virtual unsafe global::System.Collections.IList Items {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='getItems' and count(parameter)=0]"
			[Register ("getItems", "()Ljava/util/List;", "GetGetItemsHandler")]
			get {
				if (id_getItems == IntPtr.Zero)
					id_getItems = JNIEnv.GetMethodID (class_ref, "getItems", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='setItems' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
			[Register ("setItems", "(Ljava/util/List;)V", "GetSetItems_Ljava_util_List_Handler")]
			set {
				if (id_setItems_Ljava_util_List_ == IntPtr.Zero)
					id_setItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setItems", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItems_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItems", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_itemInsertedBeforeCount_I;
#pragma warning disable 0169
		static Delegate GetItemInsertedBeforeCount_IHandler ()
		{
			if (cb_itemInsertedBeforeCount_I == null)
				cb_itemInsertedBeforeCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ItemInsertedBeforeCount_I);
			return cb_itemInsertedBeforeCount_I;
		}

		static int n_ItemInsertedBeforeCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemInsertedBeforeCount (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='itemInsertedBeforeCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("itemInsertedBeforeCount", "(I)I", "GetItemInsertedBeforeCount_IHandler")]
		public abstract int ItemInsertedBeforeCount (int p0);

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
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
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
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateViewHolder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
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

		static Delegate cb_shouldInsertItemAtPosition_I;
#pragma warning disable 0169
		static Delegate GetShouldInsertItemAtPosition_IHandler ()
		{
			if (cb_shouldInsertItemAtPosition_I == null)
				cb_shouldInsertItemAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_ShouldInsertItemAtPosition_I);
			return cb_shouldInsertItemAtPosition_I;
		}

		static bool n_ShouldInsertItemAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldInsertItemAtPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='shouldInsertItemAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shouldInsertItemAtPosition", "(I)Z", "GetShouldInsertItemAtPosition_IHandler")]
		public abstract bool ShouldInsertItemAtPosition (int p0);

		static Delegate cb_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_;
#pragma warning disable 0169
		static Delegate GetWrap_Landroid_support_v7_widget_RecyclerView_Adapter_Handler ()
		{
			if (cb_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_ == null)
				cb_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Wrap_Landroid_support_v7_widget_RecyclerView_Adapter_);
			return cb_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_;
		}

		static IntPtr n_Wrap_Landroid_support_v7_widget_RecyclerView_Adapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.Adapter p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.Adapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Wrap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.Adapter']]"
		[Register ("wrap", "(Landroid/support/v7/widget/RecyclerView$Adapter;)Lcom/mikepenz/fastadapter/adapters/AbstractWrapAdapter;", "GetWrap_Landroid_support_v7_widget_RecyclerView_Adapter_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter Wrap (global::Android.Support.V7.Widget.RecyclerView.Adapter p0)
		{
			if (id_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_ == IntPtr.Zero)
				id_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Landroid/support/v7/widget/RecyclerView$Adapter;)Lcom/mikepenz/fastadapter/adapters/AbstractWrapAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_wrap_Landroid_support_v7_widget_RecyclerView_Adapter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.AbstractWrapAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrap", "(Landroid/support/v7/widget/RecyclerView$Adapter;)Lcom/mikepenz/fastadapter/adapters/AbstractWrapAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/AbstractWrapAdapter", DoNotGenerateAcw=true)]
	internal partial class AbstractWrapAdapterInvoker : AbstractWrapAdapter {

		public AbstractWrapAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWrapAdapterInvoker); }
		}

		static IntPtr id_itemInsertedBeforeCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='itemInsertedBeforeCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("itemInsertedBeforeCount", "(I)I", "GetItemInsertedBeforeCount_IHandler")]
		public override unsafe int ItemInsertedBeforeCount (int p0)
		{
			if (id_itemInsertedBeforeCount_I == IntPtr.Zero)
				id_itemInsertedBeforeCount_I = JNIEnv.GetMethodID (class_ref, "itemInsertedBeforeCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_itemInsertedBeforeCount_I, __args);
			} finally {
			}
		}

		static IntPtr id_shouldInsertItemAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='AbstractWrapAdapter']/method[@name='shouldInsertItemAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shouldInsertItemAtPosition", "(I)Z", "GetShouldInsertItemAtPosition_IHandler")]
		public override unsafe bool ShouldInsertItemAtPosition (int p0)
		{
			if (id_shouldInsertItemAtPosition_I == IntPtr.Zero)
				id_shouldInsertItemAtPosition_I = JNIEnv.GetMethodID (class_ref, "shouldInsertItemAtPosition", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldInsertItemAtPosition_I, __args);
			} finally {
			}
		}

	}

}
