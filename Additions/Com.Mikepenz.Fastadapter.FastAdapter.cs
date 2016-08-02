using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial class FastAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/field[@name='BUNDLE_EXPANDED']"
		[Register ("BUNDLE_EXPANDED")]
		protected const string BundleExpanded = (string) "bundle_expanded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/field[@name='BUNDLE_SELECTIONS']"
		[Register ("BUNDLE_SELECTIONS")]
		protected const string BundleSelections = (string) "bundle_selections";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnBindViewHolderListener']"
		[Register ("com/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListener", "", "Com.Mikepenz.Fastadapter.FastAdapter/IOnBindViewHolderListenerInvoker")]
		public partial interface IOnBindViewHolderListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnBindViewHolderListener']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
			[Register ("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Mikepenz.Fastadapter.FastAdapter/IOnBindViewHolderListenerInvoker, FastAdapter")]
			void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1);

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListener", DoNotGenerateAcw=true)]
		internal class IOnBindViewHolderListenerInvoker : global::Java.Lang.Object, IOnBindViewHolderListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnBindViewHolderListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnBindViewHolderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnBindViewHolderListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.FastAdapter.OnBindViewHolderListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnBindViewHolderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBindViewHolder (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
			public unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
			{
				if (id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
					id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
			}

		}

		public partial class BindViewHolderEventArgs : global::System.EventArgs {

			public BindViewHolderEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0;
			public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/FastAdapter_OnBindViewHolderListenerImplementor")]
		internal sealed partial class IOnBindViewHolderListenerImplementor : global::Java.Lang.Object, IOnBindViewHolderListener {

			object sender;

			public IOnBindViewHolderListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/FastAdapter_OnBindViewHolderListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BindViewHolderEventArgs> Handler;
#pragma warning restore 0649

			public void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BindViewHolderEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnBindViewHolderListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnBindViewHolderListenerImpl']"
		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListenerImpl", DoNotGenerateAcw=true)]
		public partial class OnBindViewHolderListenerImpl : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListenerImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnBindViewHolderListenerImpl); }
			}

			protected OnBindViewHolderListenerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnBindViewHolderListenerImpl']/constructor[@name='FastAdapter.OnBindViewHolderListenerImpl' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter']]"
			[Register (".ctor", "(Lcom/mikepenz/fastadapter/FastAdapter;)V", "")]
			public unsafe OnBindViewHolderListenerImpl (global::Com.Mikepenz.Fastadapter.FastAdapter __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (OnBindViewHolderListenerImpl)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_ == IntPtr.Zero)
						id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/fastadapter/FastAdapter;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_, __args);
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
				global::Com.Mikepenz.Fastadapter.FastAdapter.OnBindViewHolderListenerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.OnBindViewHolderListenerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBindViewHolder (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnBindViewHolderListenerImpl']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
			[Register ("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler")]
			public virtual unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
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

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnClickListener']"
		[Register ("com/mikepenz/fastadapter/FastAdapter$OnClickListener", "", "Com.Mikepenz.Fastadapter.FastAdapter/IOnClickListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
		public partial interface IOnClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnClickListener']/method[@name='onClick' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.fastadapter.IAdapter&lt;Item&gt;'] and parameter[3][@type='Item'] and parameter[4][@type='int']]"
			[Register ("onClick", "(Landroid/view/View;Lcom/mikepenz/fastadapter/IAdapter;Lcom/mikepenz/fastadapter/IItem;I)Z", "GetOnClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_IHandler:Com.Mikepenz.Fastadapter.FastAdapter/IOnClickListenerInvoker, FastAdapter")]
			bool OnClick (global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3);

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnClickListener", DoNotGenerateAcw=true)]
		internal class IOnClickListenerInvoker : global::Java.Lang.Object, IOnClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.FastAdapter.OnClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_IHandler ()
			{
				if (cb_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I == null)
					cb_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_OnClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I);
				return cb_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
			}

			static bool n_OnClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Fastadapter.IAdapter p1 = (global::Com.Mikepenz.Fastadapter.IAdapter)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnClick (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
			public unsafe bool OnClick (global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3)
			{
				if (id_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I == IntPtr.Zero)
					id_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;Lcom/mikepenz/fastadapter/IAdapter;Lcom/mikepenz/fastadapter/IItem;I)Z");
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I, __args);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

		}

		public partial class ClickEventArgs : global::System.EventArgs {

			public ClickEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			global::Com.Mikepenz.Fastadapter.IAdapter p1;
			public global::Com.Mikepenz.Fastadapter.IAdapter P1 {
				get { return p1; }
			}

			global::Java.Lang.Object p2;
			public global::Java.Lang.Object P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/FastAdapter_OnClickListenerImplementor")]
		internal sealed partial class IOnClickListenerImplementor : global::Java.Lang.Object, IOnClickListener {

			object sender;

			public IOnClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/FastAdapter_OnClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnClick (global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new ClickEventArgs (true, p0, p1, p2, p3);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnCreateViewHolderListener']"
		[Register ("com/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListener", "", "Com.Mikepenz.Fastadapter.FastAdapter/IOnCreateViewHolderListenerInvoker")]
		public partial interface IOnCreateViewHolderListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnCreateViewHolderListener']/method[@name='onPostCreateViewHolder' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
			[Register ("onPostCreateViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler:Com.Mikepenz.Fastadapter.FastAdapter/IOnCreateViewHolderListenerInvoker, FastAdapter")]
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnPostCreateViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnCreateViewHolderListener']/method[@name='onPreCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
			[Register ("onPreCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnPreCreateViewHolder_Landroid_view_ViewGroup_IHandler:Com.Mikepenz.Fastadapter.FastAdapter/IOnCreateViewHolderListenerInvoker, FastAdapter")]
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnPreCreateViewHolder (global::Android.Views.ViewGroup p0, int p1);

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListener", DoNotGenerateAcw=true)]
		internal class IOnCreateViewHolderListenerInvoker : global::Java.Lang.Object, IOnCreateViewHolderListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnCreateViewHolderListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnCreateViewHolderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCreateViewHolderListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.FastAdapter.OnCreateViewHolderListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCreateViewHolderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
			static Delegate GetOnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
			{
				if (cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
					cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_);
				return cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
			}

			static IntPtr n_OnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnPostCreateViewHolder (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
			public unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnPostCreateViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
			{
				if (id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
					id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "onPostCreateViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
			static Delegate GetOnPreCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
			{
				if (cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I == null)
					cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnPreCreateViewHolder_Landroid_view_ViewGroup_I);
				return cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I;
			}

			static IntPtr n_OnPreCreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnPreCreateViewHolder (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPreCreateViewHolder_Landroid_view_ViewGroup_I;
			public unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnPreCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
			{
				if (id_onPreCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
					id_onPreCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onPreCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onPreCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		public delegate global::Android.Support.V7.Widget.RecyclerView.ViewHolder CreateViewHolderOnPostCreateViewHolderHandler (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

		public delegate global::Android.Support.V7.Widget.RecyclerView.ViewHolder CreateViewHolderOnPreCreateViewHolderHandler (global::Android.Views.ViewGroup p0, int p1);

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/FastAdapter_OnCreateViewHolderListenerImplementor")]
		internal sealed partial class IOnCreateViewHolderListenerImplementor : global::Java.Lang.Object, IOnCreateViewHolderListener {

			public IOnCreateViewHolderListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/FastAdapter_OnCreateViewHolderListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			}

#pragma warning disable 0649
			public CreateViewHolderOnPostCreateViewHolderHandler OnPostCreateViewHolderHandler;
#pragma warning restore 0649

			public Android.Support.V7.Widget.RecyclerView.ViewHolder OnPostCreateViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
			{
				var __h = OnPostCreateViewHolderHandler;
				return __h != null ? __h (p0) : default (global::Android.Support.V7.Widget.RecyclerView.ViewHolder);
			}
#pragma warning disable 0649
			public CreateViewHolderOnPreCreateViewHolderHandler OnPreCreateViewHolderHandler;
#pragma warning restore 0649

			public Android.Support.V7.Widget.RecyclerView.ViewHolder OnPreCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
			{
				var __h = OnPreCreateViewHolderHandler;
				return __h != null ? __h (p0, p1) : default (global::Android.Support.V7.Widget.RecyclerView.ViewHolder);
			}

			internal static bool __IsEmpty (IOnCreateViewHolderListenerImplementor value)
			{
				return value.OnPostCreateViewHolderHandler == null && value.OnPreCreateViewHolderHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnCreateViewHolderListenerImpl']"
		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListenerImpl", DoNotGenerateAcw=true)]
		public partial class OnCreateViewHolderListenerImpl : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListenerImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnCreateViewHolderListenerImpl); }
			}

			protected OnCreateViewHolderListenerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnCreateViewHolderListenerImpl']/constructor[@name='FastAdapter.OnCreateViewHolderListenerImpl' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter']]"
			[Register (".ctor", "(Lcom/mikepenz/fastadapter/FastAdapter;)V", "")]
			public unsafe OnCreateViewHolderListenerImpl (global::Com.Mikepenz.Fastadapter.FastAdapter __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (OnCreateViewHolderListenerImpl)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_ == IntPtr.Zero)
						id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/fastadapter/FastAdapter;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_, __args);
				} finally {
				}
			}

			static Delegate cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
			static Delegate GetOnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
			{
				if (cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
					cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_);
				return cb_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
			}

			static IntPtr n_OnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.OnCreateViewHolderListenerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.OnCreateViewHolderListenerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnPostCreateViewHolder (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnCreateViewHolderListenerImpl']/method[@name='onPostCreateViewHolder' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
			[Register ("onPostCreateViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
			public virtual unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnPostCreateViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
			{
				if (id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
					id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "onPostCreateViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onPostCreateViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostCreateViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
			static Delegate GetOnPreCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
			{
				if (cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I == null)
					cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnPreCreateViewHolder_Landroid_view_ViewGroup_I);
				return cb_onPreCreateViewHolder_Landroid_view_ViewGroup_I;
			}

			static IntPtr n_OnPreCreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.OnCreateViewHolderListenerImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.OnCreateViewHolderListenerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnPreCreateViewHolder (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPreCreateViewHolder_Landroid_view_ViewGroup_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.OnCreateViewHolderListenerImpl']/method[@name='onPreCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
			[Register ("onPreCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnPreCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
			public virtual unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnPreCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
			{
				if (id_onPreCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
					id_onPreCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onPreCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onPreCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnLongClickListener']"
		[Register ("com/mikepenz/fastadapter/FastAdapter$OnLongClickListener", "", "Com.Mikepenz.Fastadapter.FastAdapter/IOnLongClickListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
		public partial interface IOnLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnLongClickListener']/method[@name='onLongClick' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.fastadapter.IAdapter&lt;Item&gt;'] and parameter[3][@type='Item'] and parameter[4][@type='int']]"
			[Register ("onLongClick", "(Landroid/view/View;Lcom/mikepenz/fastadapter/IAdapter;Lcom/mikepenz/fastadapter/IItem;I)Z", "GetOnLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_IHandler:Com.Mikepenz.Fastadapter.FastAdapter/IOnLongClickListenerInvoker, FastAdapter")]
			bool OnLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3);

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnLongClickListenerInvoker : global::Java.Lang.Object, IOnLongClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnLongClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnLongClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.FastAdapter.OnLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
#pragma warning disable 0169
			static Delegate GetOnLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_IHandler ()
			{
				if (cb_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I == null)
					cb_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_OnLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I);
				return cb_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
			}

			static bool n_OnLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Fastadapter.IAdapter p1 = (global::Com.Mikepenz.Fastadapter.IAdapter)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnLongClick (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
			public unsafe bool OnLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3)
			{
				if (id_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I == IntPtr.Zero)
					id_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I = JNIEnv.GetMethodID (class_ref, "onLongClick", "(Landroid/view/View;Lcom/mikepenz/fastadapter/IAdapter;Lcom/mikepenz/fastadapter/IItem;I)Z");
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onLongClick_Landroid_view_View_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I, __args);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

		}

		public partial class LongClickEventArgs : global::System.EventArgs {

			public LongClickEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			global::Com.Mikepenz.Fastadapter.IAdapter p1;
			public global::Com.Mikepenz.Fastadapter.IAdapter P1 {
				get { return p1; }
			}

			global::Java.Lang.Object p2;
			public global::Java.Lang.Object P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/FastAdapter_OnLongClickListenerImplementor")]
		internal sealed partial class IOnLongClickListenerImplementor : global::Java.Lang.Object, IOnLongClickListener {

			object sender;

			public IOnLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/FastAdapter_OnLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LongClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Fastadapter.IAdapter p1, global::Java.Lang.Object p2, int p3)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new LongClickEventArgs (true, p0, p1, p2, p3);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnTouchListener']"
		[Register ("com/mikepenz/fastadapter/FastAdapter$OnTouchListener", "", "Com.Mikepenz.Fastadapter.FastAdapter/IOnTouchListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
		public partial interface IOnTouchListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='FastAdapter.OnTouchListener']/method[@name='onTouch' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='com.mikepenz.fastadapter.IAdapter&lt;Item&gt;'] and parameter[4][@type='Item'] and parameter[5][@type='int']]"
			[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;Lcom/mikepenz/fastadapter/IAdapter;Lcom/mikepenz/fastadapter/IItem;I)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_IHandler:Com.Mikepenz.Fastadapter.FastAdapter/IOnTouchListenerInvoker, FastAdapter")]
			bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1, global::Com.Mikepenz.Fastadapter.IAdapter p2, global::Java.Lang.Object p3, int p4);

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$OnTouchListener", DoNotGenerateAcw=true)]
		internal class IOnTouchListenerInvoker : global::Java.Lang.Object, IOnTouchListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$OnTouchListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnTouchListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnTouchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTouchListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.FastAdapter.OnTouchListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_IHandler ()
			{
				if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I == null)
					cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I);
				return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
			}

			static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4)
			{
				global::Com.Mikepenz.Fastadapter.FastAdapter.IOnTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Fastadapter.IAdapter p2 = (global::Com.Mikepenz.Fastadapter.IAdapter)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouch (p0, p1, p2, p3, p4);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I;
			public unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1, global::Com.Mikepenz.Fastadapter.IAdapter p2, global::Java.Lang.Object p3, int p4)
			{
				if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I == IntPtr.Zero)
					id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;Lcom/mikepenz/fastadapter/IAdapter;Lcom/mikepenz/fastadapter/IItem;I)Z");
				IntPtr native_p3 = JNIEnv.ToLocalJniHandle (p3);
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_Lcom_mikepenz_fastadapter_IAdapter_Lcom_mikepenz_fastadapter_IItem_I, __args);
				JNIEnv.DeleteLocalRef (native_p3);
				return __ret;
			}

		}

		public partial class TouchEventArgs : global::System.EventArgs {

			public TouchEventArgs (bool handled, global::Android.Views.View p0, global::Android.Views.MotionEvent p1, global::Com.Mikepenz.Fastadapter.IAdapter p2, global::Java.Lang.Object p3, int p4)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			global::Android.Views.MotionEvent p1;
			public global::Android.Views.MotionEvent P1 {
				get { return p1; }
			}

			global::Com.Mikepenz.Fastadapter.IAdapter p2;
			public global::Com.Mikepenz.Fastadapter.IAdapter P2 {
				get { return p2; }
			}

			global::Java.Lang.Object p3;
			public global::Java.Lang.Object P3 {
				get { return p3; }
			}

			int p4;
			public int P4 {
				get { return p4; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/FastAdapter_OnTouchListenerImplementor")]
		internal sealed partial class IOnTouchListenerImplementor : global::Java.Lang.Object, IOnTouchListener {

			object sender;

			public IOnTouchListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/FastAdapter_OnTouchListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TouchEventArgs> Handler;
#pragma warning restore 0649

			public bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1, global::Com.Mikepenz.Fastadapter.IAdapter p2, global::Java.Lang.Object p3, int p4)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new TouchEventArgs (true, p0, p1, p2, p3, p4);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnTouchListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.RelativeInfo']"
		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/FastAdapter$RelativeInfo", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
		public partial class RelativeInfo : global::Java.Lang.Object {


			static IntPtr adapter_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.RelativeInfo']/field[@name='adapter']"
			[Register ("adapter")]
			public global::Com.Mikepenz.Fastadapter.IAdapter Adapter {
				get {
					if (adapter_jfieldId == IntPtr.Zero)
						adapter_jfieldId = JNIEnv.GetFieldID (class_ref, "adapter", "Lcom/mikepenz/fastadapter/IAdapter;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adapter_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adapter_jfieldId == IntPtr.Zero)
						adapter_jfieldId = JNIEnv.GetFieldID (class_ref, "adapter", "Lcom/mikepenz/fastadapter/IAdapter;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adapter_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr item_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.RelativeInfo']/field[@name='item']"
			[Register ("item")]
			public global::Com.Mikepenz.Fastadapter.IItem Item {
				get {
					if (item_jfieldId == IntPtr.Zero)
						item_jfieldId = JNIEnv.GetFieldID (class_ref, "item", "Lcom/mikepenz/fastadapter/IItem;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, item_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItem> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (item_jfieldId == IntPtr.Zero)
						item_jfieldId = JNIEnv.GetFieldID (class_ref, "item", "Lcom/mikepenz/fastadapter/IItem;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, item_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr position_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.RelativeInfo']/field[@name='position']"
			[Register ("position")]
			public int Position {
				get {
					if (position_jfieldId == IntPtr.Zero)
						position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, position_jfieldId);
				}
				set {
					if (position_jfieldId == IntPtr.Zero)
						position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, position_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter$RelativeInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RelativeInfo); }
			}

			protected RelativeInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter.RelativeInfo']/constructor[@name='FastAdapter.RelativeInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RelativeInfo ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (RelativeInfo)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/FastAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastAdapter); }
		}

		protected FastAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/constructor[@name='FastAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FastAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FastAdapter)) {
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

		static Delegate cb_getExpanded;
#pragma warning disable 0169
		static Delegate GetGetExpandedHandler ()
		{
			if (cb_getExpanded == null)
				cb_getExpanded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpanded);
			return cb_getExpanded;
		}

		static IntPtr n_GetExpanded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Expanded);
		}
#pragma warning restore 0169

		static IntPtr id_getExpanded;
		public virtual unsafe global::Android.Util.SparseIntArray Expanded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getExpanded' and count(parameter)=0]"
			[Register ("getExpanded", "()Landroid/util/SparseIntArray;", "GetGetExpandedHandler")]
			get {
				if (id_getExpanded == IntPtr.Zero)
					id_getExpanded = JNIEnv.GetMethodID (class_ref, "getExpanded", "()Landroid/util/SparseIntArray;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.SparseIntArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpanded), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.SparseIntArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpanded", "()Landroid/util/SparseIntArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isOnlyOneExpandedItem;
#pragma warning disable 0169
		static Delegate GetIsOnlyOneExpandedItemHandler ()
		{
			if (cb_isOnlyOneExpandedItem == null)
				cb_isOnlyOneExpandedItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnlyOneExpandedItem);
			return cb_isOnlyOneExpandedItem;
		}

		static bool n_IsOnlyOneExpandedItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnlyOneExpandedItem;
		}
#pragma warning restore 0169

		static IntPtr id_isOnlyOneExpandedItem;
		public virtual unsafe bool IsOnlyOneExpandedItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='isOnlyOneExpandedItem' and count(parameter)=0]"
			[Register ("isOnlyOneExpandedItem", "()Z", "GetIsOnlyOneExpandedItemHandler")]
			get {
				if (id_isOnlyOneExpandedItem == IntPtr.Zero)
					id_isOnlyOneExpandedItem = JNIEnv.GetMethodID (class_ref, "isOnlyOneExpandedItem", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnlyOneExpandedItem);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnlyOneExpandedItem", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPositionBasedStateManagement;
#pragma warning disable 0169
		static Delegate GetIsPositionBasedStateManagementHandler ()
		{
			if (cb_isPositionBasedStateManagement == null)
				cb_isPositionBasedStateManagement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPositionBasedStateManagement);
			return cb_isPositionBasedStateManagement;
		}

		static bool n_IsPositionBasedStateManagement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPositionBasedStateManagement;
		}
#pragma warning restore 0169

		static IntPtr id_isPositionBasedStateManagement;
		public virtual unsafe bool IsPositionBasedStateManagement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='isPositionBasedStateManagement' and count(parameter)=0]"
			[Register ("isPositionBasedStateManagement", "()Z", "GetIsPositionBasedStateManagementHandler")]
			get {
				if (id_isPositionBasedStateManagement == IntPtr.Zero)
					id_isPositionBasedStateManagement = JNIEnv.GetMethodID (class_ref, "isPositionBasedStateManagement", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPositionBasedStateManagement);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPositionBasedStateManagement", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSelectable;
#pragma warning disable 0169
		static Delegate GetIsSelectableHandler ()
		{
			if (cb_isSelectable == null)
				cb_isSelectable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectable);
			return cb_isSelectable;
		}

		static bool n_IsSelectable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		static IntPtr id_isSelectable;
		public virtual unsafe bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler")]
			get {
				if (id_isSelectable == IntPtr.Zero)
					id_isSelectable = JNIEnv.GetMethodID (class_ref, "isSelectable", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelectable", "()Z"));
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
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getItemCount' and count(parameter)=0]"
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

		static Delegate cb_getSelectedItems;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemsHandler ()
		{
			if (cb_getSelectedItems == null)
				cb_getSelectedItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedItems);
			return cb_getSelectedItems;
		}

		static IntPtr n_GetSelectedItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet.ToLocalJniHandle (__this.SelectedItems);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItems;
		public virtual unsafe global::System.Collections.ICollection SelectedItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getSelectedItems' and count(parameter)=0]"
			[Register ("getSelectedItems", "()Ljava/util/Set;", "GetGetSelectedItemsHandler")]
			get {
				if (id_getSelectedItems == IntPtr.Zero)
					id_getSelectedItems = JNIEnv.GetMethodID (class_ref, "getSelectedItems", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItems", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelections;
#pragma warning disable 0169
		static Delegate GetGetSelectionsHandler ()
		{
			if (cb_getSelections == null)
				cb_getSelections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelections);
			return cb_getSelections;
		}

		static IntPtr n_GetSelections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.Selections);
		}
#pragma warning restore 0169

		static IntPtr id_getSelections;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> Selections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getSelections' and count(parameter)=0]"
			[Register ("getSelections", "()Ljava/util/Set;", "GetGetSelectionsHandler")]
			get {
				if (id_getSelections == IntPtr.Zero)
					id_getSelections = JNIEnv.GetMethodID (class_ref, "getSelections", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelections), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelections", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_collapse;
#pragma warning disable 0169
		static Delegate GetCollapseHandler ()
		{
			if (cb_collapse == null)
				cb_collapse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Collapse);
			return cb_collapse;
		}

		static void n_Collapse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse ();
		}
#pragma warning restore 0169

		static IntPtr id_collapse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='collapse' and count(parameter)=0]"
		[Register ("collapse", "()V", "GetCollapseHandler")]
		public virtual unsafe void Collapse ()
		{
			if (id_collapse == IntPtr.Zero)
				id_collapse = JNIEnv.GetMethodID (class_ref, "collapse", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collapse);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "()V"));
			} finally {
			}
		}

		static Delegate cb_collapse_Z;
#pragma warning disable 0169
		static Delegate GetCollapse_ZHandler ()
		{
			if (cb_collapse_Z == null)
				cb_collapse_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Collapse_Z);
			return cb_collapse_Z;
		}

		static void n_Collapse_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_collapse_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='collapse' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("collapse", "(Z)V", "GetCollapse_ZHandler")]
		public virtual unsafe void Collapse (bool p0)
		{
			if (id_collapse_Z == IntPtr.Zero)
				id_collapse_Z = JNIEnv.GetMethodID (class_ref, "collapse", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collapse_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_collapse_I;
#pragma warning disable 0169
		static Delegate GetCollapse_IHandler ()
		{
			if (cb_collapse_I == null)
				cb_collapse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Collapse_I);
			return cb_collapse_I;
		}

		static void n_Collapse_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_collapse_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='collapse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("collapse", "(I)V", "GetCollapse_IHandler")]
		public virtual unsafe void Collapse (int p0)
		{
			if (id_collapse_I == IntPtr.Zero)
				id_collapse_I = JNIEnv.GetMethodID (class_ref, "collapse", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collapse_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_collapse_IZ;
#pragma warning disable 0169
		static Delegate GetCollapse_IZHandler ()
		{
			if (cb_collapse_IZ == null)
				cb_collapse_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Collapse_IZ);
			return cb_collapse_IZ;
		}

		static void n_Collapse_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_collapse_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='collapse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("collapse", "(IZ)V", "GetCollapse_IZHandler")]
		public virtual unsafe void Collapse (int p0, bool p1)
		{
			if (id_collapse_IZ == IntPtr.Zero)
				id_collapse_IZ = JNIEnv.GetMethodID (class_ref, "collapse", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collapse_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteAllSelectedItems;
#pragma warning disable 0169
		static Delegate GetDeleteAllSelectedItemsHandler ()
		{
			if (cb_deleteAllSelectedItems == null)
				cb_deleteAllSelectedItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DeleteAllSelectedItems);
			return cb_deleteAllSelectedItems;
		}

		static IntPtr n_DeleteAllSelectedItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.DeleteAllSelectedItems ());
		}
#pragma warning restore 0169

		static IntPtr id_deleteAllSelectedItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='deleteAllSelectedItems' and count(parameter)=0]"
		[Register ("deleteAllSelectedItems", "()Ljava/util/List;", "GetDeleteAllSelectedItemsHandler")]
		public virtual unsafe global::System.Collections.IList DeleteAllSelectedItems ()
		{
			if (id_deleteAllSelectedItems == IntPtr.Zero)
				id_deleteAllSelectedItems = JNIEnv.GetMethodID (class_ref, "deleteAllSelectedItems", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteAllSelectedItems), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAllSelectedItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deselect;
#pragma warning disable 0169
		static Delegate GetDeselectHandler ()
		{
			if (cb_deselect == null)
				cb_deselect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deselect);
			return cb_deselect;
		}

		static void n_Deselect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deselect ();
		}
#pragma warning restore 0169

		static IntPtr id_deselect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='deselect' and count(parameter)=0]"
		[Register ("deselect", "()V", "GetDeselectHandler")]
		public virtual unsafe void Deselect ()
		{
			if (id_deselect == IntPtr.Zero)
				id_deselect = JNIEnv.GetMethodID (class_ref, "deselect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselect", "()V"));
			} finally {
			}
		}

		static Delegate cb_deselect_I;
#pragma warning disable 0169
		static Delegate GetDeselect_IHandler ()
		{
			if (cb_deselect_I == null)
				cb_deselect_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Deselect_I);
			return cb_deselect_I;
		}

		static void n_Deselect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deselect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deselect_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='deselect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deselect", "(I)V", "GetDeselect_IHandler")]
		public virtual unsafe void Deselect (int p0)
		{
			if (id_deselect_I == IntPtr.Zero)
				id_deselect_I = JNIEnv.GetMethodID (class_ref, "deselect", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselect_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselect", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deselect_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetDeselect_Ljava_lang_Iterable_Handler ()
		{
			if (cb_deselect_Ljava_lang_Iterable_ == null)
				cb_deselect_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Deselect_Ljava_lang_Iterable_);
			return cb_deselect_Ljava_lang_Iterable_;
		}

		static void n_Deselect_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Deselect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deselect_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='deselect' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;java.lang.Integer&gt;']]"
		[Register ("deselect", "(Ljava/lang/Iterable;)V", "GetDeselect_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void Deselect (global::Java.Lang.IIterable p0)
		{
			if (id_deselect_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_deselect_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "deselect", "(Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselect_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselect", "(Ljava/lang/Iterable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_expand_I;
#pragma warning disable 0169
		static Delegate GetExpand_IHandler ()
		{
			if (cb_expand_I == null)
				cb_expand_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Expand_I);
			return cb_expand_I;
		}

		static void n_Expand_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_expand_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='expand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("expand", "(I)V", "GetExpand_IHandler")]
		public virtual unsafe void Expand (int p0)
		{
			if (id_expand_I == IntPtr.Zero)
				id_expand_I = JNIEnv.GetMethodID (class_ref, "expand", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_expand_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "expand", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_expand_IZ;
#pragma warning disable 0169
		static Delegate GetExpand_IZHandler ()
		{
			if (cb_expand_IZ == null)
				cb_expand_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Expand_IZ);
			return cb_expand_IZ;
		}

		static void n_Expand_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_expand_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='expand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("expand", "(IZ)V", "GetExpand_IZHandler")]
		public virtual unsafe void Expand (int p0, bool p1)
		{
			if (id_expand_IZ == IntPtr.Zero)
				id_expand_IZ = JNIEnv.GetMethodID (class_ref, "expand", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_expand_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "expand", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAdapter_I;
#pragma warning disable 0169
		static Delegate GetGetAdapter_IHandler ()
		{
			if (cb_getAdapter_I == null)
				cb_getAdapter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAdapter_I);
			return cb_getAdapter_I;
		}

		static IntPtr n_GetAdapter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAdapter (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdapter", "(I)Lcom/mikepenz/fastadapter/IAdapter;", "GetGetAdapter_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IAdapter GetAdapter (int p0)
		{
			if (id_getAdapter_I == IntPtr.Zero)
				id_getAdapter_I = JNIEnv.GetMethodID (class_ref, "getAdapter", "(I)Lcom/mikepenz/fastadapter/IAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapter", "(I)Lcom/mikepenz/fastadapter/IAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getExpandedItems;
#pragma warning disable 0169
		static Delegate GetGetExpandedItemsHandler ()
		{
			if (cb_getExpandedItems == null)
				cb_getExpandedItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpandedItems);
			return cb_getExpandedItems;
		}

		static IntPtr n_GetExpandedItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExpandedItems ());
		}
#pragma warning restore 0169

		static IntPtr id_getExpandedItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getExpandedItems' and count(parameter)=0]"
		[Register ("getExpandedItems", "()[I", "GetGetExpandedItemsHandler")]
		public virtual unsafe int[] GetExpandedItems ()
		{
			if (id_getExpandedItems == IntPtr.Zero)
				id_getExpandedItems = JNIEnv.GetMethodID (class_ref, "getExpandedItems", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpandedItems), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpandedItems", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getExpandedItemsCount_II;
#pragma warning disable 0169
		static Delegate GetGetExpandedItemsCount_IIHandler ()
		{
			if (cb_getExpandedItemsCount_II == null)
				cb_getExpandedItemsCount_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetExpandedItemsCount_II);
			return cb_getExpandedItemsCount_II;
		}

		static int n_GetExpandedItemsCount_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetExpandedItemsCount (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getExpandedItemsCount_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getExpandedItemsCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getExpandedItemsCount", "(II)I", "GetGetExpandedItemsCount_IIHandler")]
		public virtual unsafe int GetExpandedItemsCount (int p0, int p1)
		{
			if (id_getExpandedItemsCount_II == IntPtr.Zero)
				id_getExpandedItemsCount_II = JNIEnv.GetMethodID (class_ref, "getExpandedItemsCount", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getExpandedItemsCount_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpandedItemsCount", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetGetHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_);
			return cb_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static int n_GetHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetHolderAdapterPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getHolderAdapterPosition' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("getHolderAdapterPosition", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)I", "GetGetHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public virtual unsafe int GetHolderAdapterPosition (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			if (id_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "getHolderAdapterPosition", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHolderAdapterPosition_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHolderAdapterPosition", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)I"), __args);
				return __ret;
			} finally {
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
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getPosition_Lcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetGetPosition_Lcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_getPosition_Lcom_mikepenz_fastadapter_IItem_ == null)
				cb_getPosition_Lcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetPosition_Lcom_mikepenz_fastadapter_IItem_);
			return cb_getPosition_Lcom_mikepenz_fastadapter_IItem_;
		}

		static int n_GetPosition_Lcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition_Lcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='Item']]"
		[Register ("getPosition", "(Lcom/mikepenz/fastadapter/IItem;)I", "GetGetPosition_Lcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe int GetPosition (global::Java.Lang.Object p0)
		{
			if (id_getPosition_Lcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_getPosition_Lcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "getPosition", "(Lcom/mikepenz/fastadapter/IItem;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosition_Lcom_mikepenz_fastadapter_IItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "(Lcom/mikepenz/fastadapter/IItem;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPreItemCount_I;
#pragma warning disable 0169
		static Delegate GetGetPreItemCount_IHandler ()
		{
			if (cb_getPreItemCount_I == null)
				cb_getPreItemCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPreItemCount_I);
			return cb_getPreItemCount_I;
		}

		static int n_GetPreItemCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPreItemCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPreItemCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getPreItemCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPreItemCount", "(I)I", "GetGetPreItemCount_IHandler")]
		public virtual unsafe int GetPreItemCount (int p0)
		{
			if (id_getPreItemCount_I == IntPtr.Zero)
				id_getPreItemCount_I = JNIEnv.GetMethodID (class_ref, "getPreItemCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreItemCount_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreItemCount", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getPreItemCountByOrder_I;
#pragma warning disable 0169
		static Delegate GetGetPreItemCountByOrder_IHandler ()
		{
			if (cb_getPreItemCountByOrder_I == null)
				cb_getPreItemCountByOrder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPreItemCountByOrder_I);
			return cb_getPreItemCountByOrder_I;
		}

		static int n_GetPreItemCountByOrder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPreItemCountByOrder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPreItemCountByOrder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getPreItemCountByOrder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPreItemCountByOrder", "(I)I", "GetGetPreItemCountByOrder_IHandler")]
		public virtual unsafe int GetPreItemCountByOrder (int p0)
		{
			if (id_getPreItemCountByOrder_I == IntPtr.Zero)
				id_getPreItemCountByOrder_I = JNIEnv.GetMethodID (class_ref, "getPreItemCountByOrder", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreItemCountByOrder_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreItemCountByOrder", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getRelativeInfo_I;
#pragma warning disable 0169
		static Delegate GetGetRelativeInfo_IHandler ()
		{
			if (cb_getRelativeInfo_I == null)
				cb_getRelativeInfo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetRelativeInfo_I);
			return cb_getRelativeInfo_I;
		}

		static IntPtr n_GetRelativeInfo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRelativeInfo (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getRelativeInfo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getRelativeInfo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRelativeInfo", "(I)Lcom/mikepenz/fastadapter/FastAdapter$RelativeInfo;", "GetGetRelativeInfo_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.RelativeInfo GetRelativeInfo (int p0)
		{
			if (id_getRelativeInfo_I == IntPtr.Zero)
				id_getRelativeInfo_I = JNIEnv.GetMethodID (class_ref, "getRelativeInfo", "(I)Lcom/mikepenz/fastadapter/FastAdapter$RelativeInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.RelativeInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRelativeInfo_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.RelativeInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativeInfo", "(I)Lcom/mikepenz/fastadapter/FastAdapter$RelativeInfo;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTypeInstance_I;
#pragma warning disable 0169
		static Delegate GetGetTypeInstance_IHandler ()
		{
			if (cb_getTypeInstance_I == null)
				cb_getTypeInstance_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTypeInstance_I);
			return cb_getTypeInstance_I;
		}

		static IntPtr n_GetTypeInstance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTypeInstance (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTypeInstance_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='getTypeInstance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTypeInstance", "(I)Lcom/mikepenz/fastadapter/IItem;", "GetGetTypeInstance_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetTypeInstance (int p0)
		{
			if (id_getTypeInstance_I == IntPtr.Zero)
				id_getTypeInstance_I = JNIEnv.GetMethodID (class_ref, "getTypeInstance", "(I)Lcom/mikepenz/fastadapter/IItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeInstance_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeInstance", "(I)Lcom/mikepenz/fastadapter/IItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterDataSetChangedHandler ()
		{
			if (cb_notifyAdapterDataSetChanged == null)
				cb_notifyAdapterDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyAdapterDataSetChanged);
			return cb_notifyAdapterDataSetChanged;
		}

		static void n_NotifyAdapterDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterDataSetChanged' and count(parameter)=0]"
		[Register ("notifyAdapterDataSetChanged", "()V", "GetNotifyAdapterDataSetChangedHandler")]
		public virtual unsafe void NotifyAdapterDataSetChanged ()
		{
			if (id_notifyAdapterDataSetChanged == IntPtr.Zero)
				id_notifyAdapterDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyAdapterDataSetChanged", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterDataSetChanged);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterDataSetChanged", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemChanged_I;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemChanged_IHandler ()
		{
			if (cb_notifyAdapterItemChanged_I == null)
				cb_notifyAdapterItemChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyAdapterItemChanged_I);
			return cb_notifyAdapterItemChanged_I;
		}

		static void n_NotifyAdapterItemChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyAdapterItemChanged", "(I)V", "GetNotifyAdapterItemChanged_IHandler")]
		public virtual unsafe void NotifyAdapterItemChanged (int p0)
		{
			if (id_notifyAdapterItemChanged_I == IntPtr.Zero)
				id_notifyAdapterItemChanged_I = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemChanged_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemChanged_ILjava_lang_Object_Handler ()
		{
			if (cb_notifyAdapterItemChanged_ILjava_lang_Object_ == null)
				cb_notifyAdapterItemChanged_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_NotifyAdapterItemChanged_ILjava_lang_Object_);
			return cb_notifyAdapterItemChanged_ILjava_lang_Object_;
		}

		static void n_NotifyAdapterItemChanged_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemChanged_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("notifyAdapterItemChanged", "(ILjava/lang/Object;)V", "GetNotifyAdapterItemChanged_ILjava_lang_Object_Handler")]
		public virtual unsafe void NotifyAdapterItemChanged (int p0, global::Java.Lang.Object p1)
		{
			if (id_notifyAdapterItemChanged_ILjava_lang_Object_ == IntPtr.Zero)
				id_notifyAdapterItemChanged_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemChanged", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemChanged_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemChanged", "(ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemInserted_I;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemInserted_IHandler ()
		{
			if (cb_notifyAdapterItemInserted_I == null)
				cb_notifyAdapterItemInserted_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyAdapterItemInserted_I);
			return cb_notifyAdapterItemInserted_I;
		}

		static void n_NotifyAdapterItemInserted_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemInserted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemInserted_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemInserted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyAdapterItemInserted", "(I)V", "GetNotifyAdapterItemInserted_IHandler")]
		public virtual unsafe void NotifyAdapterItemInserted (int p0)
		{
			if (id_notifyAdapterItemInserted_I == IntPtr.Zero)
				id_notifyAdapterItemInserted_I = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemInserted", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemInserted_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemInserted", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemMoved_II;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemMoved_IIHandler ()
		{
			if (cb_notifyAdapterItemMoved_II == null)
				cb_notifyAdapterItemMoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifyAdapterItemMoved_II);
			return cb_notifyAdapterItemMoved_II;
		}

		static void n_NotifyAdapterItemMoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemMoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemMoved_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemMoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifyAdapterItemMoved", "(II)V", "GetNotifyAdapterItemMoved_IIHandler")]
		public virtual unsafe void NotifyAdapterItemMoved (int p0, int p1)
		{
			if (id_notifyAdapterItemMoved_II == IntPtr.Zero)
				id_notifyAdapterItemMoved_II = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemMoved", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemMoved_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemMoved", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemRangeChanged_II;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemRangeChanged_IIHandler ()
		{
			if (cb_notifyAdapterItemRangeChanged_II == null)
				cb_notifyAdapterItemRangeChanged_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifyAdapterItemRangeChanged_II);
			return cb_notifyAdapterItemRangeChanged_II;
		}

		static void n_NotifyAdapterItemRangeChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemRangeChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemRangeChanged_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemRangeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifyAdapterItemRangeChanged", "(II)V", "GetNotifyAdapterItemRangeChanged_IIHandler")]
		public virtual unsafe void NotifyAdapterItemRangeChanged (int p0, int p1)
		{
			if (id_notifyAdapterItemRangeChanged_II == IntPtr.Zero)
				id_notifyAdapterItemRangeChanged_II = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemRangeChanged", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemRangeChanged_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemRangeChanged", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemRangeChanged_IILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemRangeChanged_IILjava_lang_Object_Handler ()
		{
			if (cb_notifyAdapterItemRangeChanged_IILjava_lang_Object_ == null)
				cb_notifyAdapterItemRangeChanged_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_NotifyAdapterItemRangeChanged_IILjava_lang_Object_);
			return cb_notifyAdapterItemRangeChanged_IILjava_lang_Object_;
		}

		static void n_NotifyAdapterItemRangeChanged_IILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemRangeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemRangeChanged_IILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemRangeChanged' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("notifyAdapterItemRangeChanged", "(IILjava/lang/Object;)V", "GetNotifyAdapterItemRangeChanged_IILjava_lang_Object_Handler")]
		public virtual unsafe void NotifyAdapterItemRangeChanged (int p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_notifyAdapterItemRangeChanged_IILjava_lang_Object_ == IntPtr.Zero)
				id_notifyAdapterItemRangeChanged_IILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemRangeChanged", "(IILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemRangeChanged_IILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemRangeChanged", "(IILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemRangeInserted_II;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemRangeInserted_IIHandler ()
		{
			if (cb_notifyAdapterItemRangeInserted_II == null)
				cb_notifyAdapterItemRangeInserted_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifyAdapterItemRangeInserted_II);
			return cb_notifyAdapterItemRangeInserted_II;
		}

		static void n_NotifyAdapterItemRangeInserted_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemRangeInserted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemRangeInserted_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemRangeInserted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifyAdapterItemRangeInserted", "(II)V", "GetNotifyAdapterItemRangeInserted_IIHandler")]
		public virtual unsafe void NotifyAdapterItemRangeInserted (int p0, int p1)
		{
			if (id_notifyAdapterItemRangeInserted_II == IntPtr.Zero)
				id_notifyAdapterItemRangeInserted_II = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemRangeInserted", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemRangeInserted_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemRangeInserted", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemRangeRemoved_II;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemRangeRemoved_IIHandler ()
		{
			if (cb_notifyAdapterItemRangeRemoved_II == null)
				cb_notifyAdapterItemRangeRemoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifyAdapterItemRangeRemoved_II);
			return cb_notifyAdapterItemRangeRemoved_II;
		}

		static void n_NotifyAdapterItemRangeRemoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemRangeRemoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemRangeRemoved_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemRangeRemoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifyAdapterItemRangeRemoved", "(II)V", "GetNotifyAdapterItemRangeRemoved_IIHandler")]
		public virtual unsafe void NotifyAdapterItemRangeRemoved (int p0, int p1)
		{
			if (id_notifyAdapterItemRangeRemoved_II == IntPtr.Zero)
				id_notifyAdapterItemRangeRemoved_II = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemRangeRemoved", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemRangeRemoved_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemRangeRemoved", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterItemRemoved_I;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterItemRemoved_IHandler ()
		{
			if (cb_notifyAdapterItemRemoved_I == null)
				cb_notifyAdapterItemRemoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyAdapterItemRemoved_I);
			return cb_notifyAdapterItemRemoved_I;
		}

		static void n_NotifyAdapterItemRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterItemRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterItemRemoved_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterItemRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyAdapterItemRemoved", "(I)V", "GetNotifyAdapterItemRemoved_IHandler")]
		public virtual unsafe void NotifyAdapterItemRemoved (int p0)
		{
			if (id_notifyAdapterItemRemoved_I == IntPtr.Zero)
				id_notifyAdapterItemRemoved_I = JNIEnv.GetMethodID (class_ref, "notifyAdapterItemRemoved", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterItemRemoved_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterItemRemoved", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterSubItemsChanged_I;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterSubItemsChanged_IHandler ()
		{
			if (cb_notifyAdapterSubItemsChanged_I == null)
				cb_notifyAdapterSubItemsChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyAdapterSubItemsChanged_I);
			return cb_notifyAdapterSubItemsChanged_I;
		}

		static void n_NotifyAdapterSubItemsChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyAdapterSubItemsChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterSubItemsChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterSubItemsChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyAdapterSubItemsChanged", "(I)V", "GetNotifyAdapterSubItemsChanged_IHandler")]
		public virtual unsafe void NotifyAdapterSubItemsChanged (int p0)
		{
			if (id_notifyAdapterSubItemsChanged_I == IntPtr.Zero)
				id_notifyAdapterSubItemsChanged_I = JNIEnv.GetMethodID (class_ref, "notifyAdapterSubItemsChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterSubItemsChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterSubItemsChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyAdapterSubItemsChanged_II;
#pragma warning disable 0169
		static Delegate GetNotifyAdapterSubItemsChanged_IIHandler ()
		{
			if (cb_notifyAdapterSubItemsChanged_II == null)
				cb_notifyAdapterSubItemsChanged_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_NotifyAdapterSubItemsChanged_II);
			return cb_notifyAdapterSubItemsChanged_II;
		}

		static int n_NotifyAdapterSubItemsChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyAdapterSubItemsChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyAdapterSubItemsChanged_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='notifyAdapterSubItemsChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifyAdapterSubItemsChanged", "(II)I", "GetNotifyAdapterSubItemsChanged_IIHandler")]
		public virtual unsafe int NotifyAdapterSubItemsChanged (int p0, int p1)
		{
			if (id_notifyAdapterSubItemsChanged_II == IntPtr.Zero)
				id_notifyAdapterSubItemsChanged_II = JNIEnv.GetMethodID (class_ref, "notifyAdapterSubItemsChanged", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdapterSubItemsChanged_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyAdapterSubItemsChanged", "(II)I"), __args);
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
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
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
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateViewHolder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
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

		static Delegate cb_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_;
#pragma warning disable 0169
		static Delegate GetRegisterAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_Handler ()
		{
			if (cb_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_ == null)
				cb_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_);
			return cb_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_;
		}

		static void n_RegisterAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='registerAdapter' and count(parameter)=1 and parameter[1][@type='A']]"
		[Register ("registerAdapter", "(Lcom/mikepenz/fastadapter/AbstractAdapter;)V", "GetRegisterAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A extends com.mikepenz.fastadapter.AbstractAdapter<Item>"})]
		public virtual unsafe void RegisterAdapter (global::Java.Lang.Object p0)
		{
			if (id_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_ == IntPtr.Zero)
				id_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_ = JNIEnv.GetMethodID (class_ref, "registerAdapter", "(Lcom/mikepenz/fastadapter/AbstractAdapter;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAdapter_Lcom_mikepenz_fastadapter_AbstractAdapter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerAdapter", "(Lcom/mikepenz/fastadapter/AbstractAdapter;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
		static Delegate GetRegisterTypeInstance_Lcom_mikepenz_fastadapter_IItem_Handler ()
		{
			if (cb_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_ == null)
				cb_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterTypeInstance_Lcom_mikepenz_fastadapter_IItem_);
			return cb_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_;
		}

		static void n_RegisterTypeInstance_Lcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterTypeInstance (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='registerTypeInstance' and count(parameter)=1 and parameter[1][@type='Item']]"
		[Register ("registerTypeInstance", "(Lcom/mikepenz/fastadapter/IItem;)V", "GetRegisterTypeInstance_Lcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe void RegisterTypeInstance (global::Java.Lang.Object p0)
		{
			if (id_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "registerTypeInstance", "(Lcom/mikepenz/fastadapter/IItem;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerTypeInstance_Lcom_mikepenz_fastadapter_IItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerTypeInstance", "(Lcom/mikepenz/fastadapter/IItem;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveInstanceState_Landroid_os_Bundle_ == null)
				cb_saveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveInstanceState_Landroid_os_Bundle_);
			return cb_saveInstanceState_Landroid_os_Bundle_;
		}

		static IntPtr n_SaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SaveInstanceState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='saveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveInstanceState", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle SaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_saveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "saveInstanceState", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveInstanceState_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveInstanceState", "(Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveInstanceState_Landroid_os_Bundle_Ljava_lang_String_Handler ()
		{
			if (cb_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_ == null)
				cb_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveInstanceState_Landroid_os_Bundle_Ljava_lang_String_);
			return cb_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_;
		}

		static IntPtr n_SaveInstanceState_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SaveInstanceState (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='saveInstanceState' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveInstanceState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;", "GetSaveInstanceState_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.OS.Bundle SaveInstanceState (global::Android.OS.Bundle p0, string p1)
		{
			if (id_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveInstanceState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveInstanceState_Landroid_os_Bundle_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveInstanceState", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_select;
#pragma warning disable 0169
		static Delegate GetSelectHandler ()
		{
			if (cb_select == null)
				cb_select = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Select);
			return cb_select;
		}

		static void n_Select (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Select ();
		}
#pragma warning restore 0169

		static IntPtr id_select;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='select' and count(parameter)=0]"
		[Register ("select", "()V", "GetSelectHandler")]
		public virtual unsafe void Select ()
		{
			if (id_select == IntPtr.Zero)
				id_select = JNIEnv.GetMethodID (class_ref, "select", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_select);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "()V"));
			} finally {
			}
		}

		static Delegate cb_select_I;
#pragma warning disable 0169
		static Delegate GetSelect_IHandler ()
		{
			if (cb_select_I == null)
				cb_select_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Select_I);
			return cb_select_I;
		}

		static void n_Select_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Select (p0);
		}
#pragma warning restore 0169

		static IntPtr id_select_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='select' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("select", "(I)V", "GetSelect_IHandler")]
		public virtual unsafe void Select (int p0)
		{
			if (id_select_I == IntPtr.Zero)
				id_select_I = JNIEnv.GetMethodID (class_ref, "select", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_select_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_select_IZ;
#pragma warning disable 0169
		static Delegate GetSelect_IZHandler ()
		{
			if (cb_select_IZ == null)
				cb_select_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Select_IZ);
			return cb_select_IZ;
		}

		static void n_Select_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Select (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_select_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='select' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("select", "(IZ)V", "GetSelect_IZHandler")]
		public virtual unsafe void Select (int p0, bool p1)
		{
			if (id_select_IZ == IntPtr.Zero)
				id_select_IZ = JNIEnv.GetMethodID (class_ref, "select", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_select_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_select_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetSelect_Ljava_lang_Iterable_Handler ()
		{
			if (cb_select_Ljava_lang_Iterable_ == null)
				cb_select_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Select_Ljava_lang_Iterable_);
			return cb_select_Ljava_lang_Iterable_;
		}

		static void n_Select_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Select (p0);
		}
#pragma warning restore 0169

		static IntPtr id_select_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='select' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;java.lang.Integer&gt;']]"
		[Register ("select", "(Ljava/lang/Iterable;)V", "GetSelect_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void Select (global::Java.Lang.IIterable p0)
		{
			if (id_select_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_select_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "select", "(Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_select_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "(Ljava/lang/Iterable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggleExpandable_I;
#pragma warning disable 0169
		static Delegate GetToggleExpandable_IHandler ()
		{
			if (cb_toggleExpandable_I == null)
				cb_toggleExpandable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ToggleExpandable_I);
			return cb_toggleExpandable_I;
		}

		static void n_ToggleExpandable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleExpandable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toggleExpandable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='toggleExpandable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toggleExpandable", "(I)V", "GetToggleExpandable_IHandler")]
		public virtual unsafe void ToggleExpandable (int p0)
		{
			if (id_toggleExpandable_I == IntPtr.Zero)
				id_toggleExpandable_I = JNIEnv.GetMethodID (class_ref, "toggleExpandable", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggleExpandable_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleExpandable", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggleSelection_I;
#pragma warning disable 0169
		static Delegate GetToggleSelection_IHandler ()
		{
			if (cb_toggleSelection_I == null)
				cb_toggleSelection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ToggleSelection_I);
			return cb_toggleSelection_I;
		}

		static void n_ToggleSelection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleSelection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toggleSelection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='toggleSelection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toggleSelection", "(I)V", "GetToggleSelection_IHandler")]
		public virtual unsafe void ToggleSelection (int p0)
		{
			if (id_toggleSelection_I == IntPtr.Zero)
				id_toggleSelection_I = JNIEnv.GetMethodID (class_ref, "toggleSelection", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggleSelection_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleSelection", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withAllowDeselection_Z;
#pragma warning disable 0169
		static Delegate GetWithAllowDeselection_ZHandler ()
		{
			if (cb_withAllowDeselection_Z == null)
				cb_withAllowDeselection_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithAllowDeselection_Z);
			return cb_withAllowDeselection_Z;
		}

		static IntPtr n_WithAllowDeselection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithAllowDeselection (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withAllowDeselection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withAllowDeselection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withAllowDeselection", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithAllowDeselection_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithAllowDeselection (bool p0)
		{
			if (id_withAllowDeselection_Z == IntPtr.Zero)
				id_withAllowDeselection_Z = JNIEnv.GetMethodID (class_ref, "withAllowDeselection", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAllowDeselection_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAllowDeselection", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMultiSelect_Z;
#pragma warning disable 0169
		static Delegate GetWithMultiSelect_ZHandler ()
		{
			if (cb_withMultiSelect_Z == null)
				cb_withMultiSelect_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithMultiSelect_Z);
			return cb_withMultiSelect_Z;
		}

		static IntPtr n_WithMultiSelect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMultiSelect (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withMultiSelect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withMultiSelect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withMultiSelect", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithMultiSelect_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithMultiSelect (bool p0)
		{
			if (id_withMultiSelect_Z == IntPtr.Zero)
				id_withMultiSelect_Z = JNIEnv.GetMethodID (class_ref, "withMultiSelect", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMultiSelect_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMultiSelect", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_;
#pragma warning disable 0169
		static Delegate GetWithOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_Handler ()
		{
			if (cb_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_ == null)
				cb_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_);
			return cb_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_;
		}

		static IntPtr n_WithOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnBindViewHolderListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnBindViewHolderListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnBindViewHolderListener']]"
		[Register ("withOnBindViewHolderListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnBindViewHolderListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnBindViewHolderListener p0)
		{
			if (id_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_ == IntPtr.Zero)
				id_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_ = JNIEnv.GetMethodID (class_ref, "withOnBindViewHolderListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnBindViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnBindViewHolderListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnBindViewHolderListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnBindViewHolderListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;Item&gt;']]"
		[Register ("withOnClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_;
#pragma warning disable 0169
		static Delegate GetWithOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_Handler ()
		{
			if (cb_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_ == null)
				cb_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_);
			return cb_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_;
		}

		static IntPtr n_WithOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnCreateViewHolderListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnCreateViewHolderListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnCreateViewHolderListener']]"
		[Register ("withOnCreateViewHolderListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnCreateViewHolderListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnCreateViewHolderListener p0)
		{
			if (id_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_ == IntPtr.Zero)
				id_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_ = JNIEnv.GetMethodID (class_ref, "withOnCreateViewHolderListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnCreateViewHolderListener_Lcom_mikepenz_fastadapter_FastAdapter_OnCreateViewHolderListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnCreateViewHolderListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnCreateViewHolderListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_Handler ()
		{
			if (cb_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ == null)
				cb_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_);
			return cb_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
		}

		static IntPtr n_WithOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnLongClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnLongClickListener&lt;Item&gt;']]"
		[Register ("withOnLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnLongClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener p0)
		{
			if (id_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ == IntPtr.Zero)
				id_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnPreClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnPreClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;Item&gt;']]"
		[Register ("withOnPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnPreClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_Handler ()
		{
			if (cb_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ == null)
				cb_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_);
			return cb_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
		}

		static IntPtr n_WithOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnPreLongClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnPreLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnLongClickListener&lt;Item&gt;']]"
		[Register ("withOnPreLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnPreLongClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener p0)
		{
			if (id_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ == IntPtr.Zero)
				id_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnPreLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnPreLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnPreLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_;
#pragma warning disable 0169
		static Delegate GetWithOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_Handler ()
		{
			if (cb_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_ == null)
				cb_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_);
			return cb_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_;
		}

		static IntPtr n_WithOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnTouchListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnTouchListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnTouchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnTouchListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnTouchListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnTouchListener&lt;Item&gt;']]"
		[Register ("withOnTouchListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnTouchListener;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnTouchListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnTouchListener p0)
		{
			if (id_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_ == IntPtr.Zero)
				id_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_ = JNIEnv.GetMethodID (class_ref, "withOnTouchListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnTouchListener;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnTouchListener_Lcom_mikepenz_fastadapter_FastAdapter_OnTouchListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnTouchListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnTouchListener;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnlyOneExpandedItem_Z;
#pragma warning disable 0169
		static Delegate GetWithOnlyOneExpandedItem_ZHandler ()
		{
			if (cb_withOnlyOneExpandedItem_Z == null)
				cb_withOnlyOneExpandedItem_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithOnlyOneExpandedItem_Z);
			return cb_withOnlyOneExpandedItem_Z;
		}

		static IntPtr n_WithOnlyOneExpandedItem_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithOnlyOneExpandedItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withOnlyOneExpandedItem_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withOnlyOneExpandedItem' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withOnlyOneExpandedItem", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithOnlyOneExpandedItem_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithOnlyOneExpandedItem (bool p0)
		{
			if (id_withOnlyOneExpandedItem_Z == IntPtr.Zero)
				id_withOnlyOneExpandedItem_Z = JNIEnv.GetMethodID (class_ref, "withOnlyOneExpandedItem", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnlyOneExpandedItem_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnlyOneExpandedItem", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPositionBasedStateManagement_Z;
#pragma warning disable 0169
		static Delegate GetWithPositionBasedStateManagement_ZHandler ()
		{
			if (cb_withPositionBasedStateManagement_Z == null)
				cb_withPositionBasedStateManagement_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithPositionBasedStateManagement_Z);
			return cb_withPositionBasedStateManagement_Z;
		}

		static IntPtr n_WithPositionBasedStateManagement_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPositionBasedStateManagement (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPositionBasedStateManagement_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withPositionBasedStateManagement' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withPositionBasedStateManagement", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithPositionBasedStateManagement_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithPositionBasedStateManagement (bool p0)
		{
			if (id_withPositionBasedStateManagement_Z == IntPtr.Zero)
				id_withPositionBasedStateManagement_Z = JNIEnv.GetMethodID (class_ref, "withPositionBasedStateManagement", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPositionBasedStateManagement_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPositionBasedStateManagement", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSavedInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetWithSavedInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_withSavedInstanceState_Landroid_os_Bundle_ == null)
				cb_withSavedInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSavedInstanceState_Landroid_os_Bundle_);
			return cb_withSavedInstanceState_Landroid_os_Bundle_;
		}

		static IntPtr n_WithSavedInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSavedInstanceState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSavedInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withSavedInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("withSavedInstanceState", "(Landroid/os/Bundle;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithSavedInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithSavedInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_withSavedInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_withSavedInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "withSavedInstanceState", "(Landroid/os/Bundle;)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSavedInstanceState_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSavedInstanceState", "(Landroid/os/Bundle;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_Handler ()
		{
			if (cb_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_ == null)
				cb_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_);
			return cb_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_;
		}

		static IntPtr n_WithSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSavedInstanceState (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withSavedInstanceState' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("withSavedInstanceState", "(Landroid/os/Bundle;Ljava/lang/String;)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithSavedInstanceState (global::Android.OS.Bundle p0, string p1)
		{
			if (id_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSavedInstanceState", "(Landroid/os/Bundle;Ljava/lang/String;)Lcom/mikepenz/fastadapter/FastAdapter;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.FastAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSavedInstanceState_Landroid_os_Bundle_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSavedInstanceState", "(Landroid/os/Bundle;Ljava/lang/String;)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_withSelectOnLongClick_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectOnLongClick_ZHandler ()
		{
			if (cb_withSelectOnLongClick_Z == null)
				cb_withSelectOnLongClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectOnLongClick_Z);
			return cb_withSelectOnLongClick_Z;
		}

		static IntPtr n_WithSelectOnLongClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectOnLongClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectOnLongClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withSelectOnLongClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectOnLongClick", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithSelectOnLongClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithSelectOnLongClick (bool p0)
		{
			if (id_withSelectOnLongClick_Z == IntPtr.Zero)
				id_withSelectOnLongClick_Z = JNIEnv.GetMethodID (class_ref, "withSelectOnLongClick", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectOnLongClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectOnLongClick", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectWithItemUpdate_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectWithItemUpdate_ZHandler ()
		{
			if (cb_withSelectWithItemUpdate_Z == null)
				cb_withSelectWithItemUpdate_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectWithItemUpdate_Z);
			return cb_withSelectWithItemUpdate_Z;
		}

		static IntPtr n_WithSelectWithItemUpdate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectWithItemUpdate (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectWithItemUpdate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withSelectWithItemUpdate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectWithItemUpdate", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithSelectWithItemUpdate_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithSelectWithItemUpdate (bool p0)
		{
			if (id_withSelectWithItemUpdate_Z == IntPtr.Zero)
				id_withSelectWithItemUpdate_Z = JNIEnv.GetMethodID (class_ref, "withSelectWithItemUpdate", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectWithItemUpdate_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectWithItemUpdate", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectable_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectable_ZHandler ()
		{
			if (cb_withSelectable_Z == null)
				cb_withSelectable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectable_Z);
			return cb_withSelectable_Z;
		}

		static IntPtr n_WithSelectable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.FastAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/class[@name='FastAdapter']/method[@name='withSelectable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectable", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;", "GetWithSelectable_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter WithSelectable (bool p0)
		{
			if (id_withSelectable_Z == IntPtr.Zero)
				id_withSelectable_Z = JNIEnv.GetMethodID (class_ref, "withSelectable", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectable_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectable", "(Z)Lcom/mikepenz/fastadapter/FastAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
