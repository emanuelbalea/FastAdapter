using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.helpers']/class[@name='ClickListenerHelper']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/helpers/ClickListenerHelper", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial class ClickListenerHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter.helpers']/interface[@name='ClickListenerHelper.OnClickListener']"
		[Register ("com/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener", "", "Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper/IOnClickListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
		public partial interface IOnClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.helpers']/interface[@name='ClickListenerHelper.OnClickListener']/method[@name='onClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='Item']]"
			[Register ("onClick", "(Landroid/view/View;ILcom/mikepenz/fastadapter/IItem;)V", "GetOnClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_Handler:Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper/IOnClickListenerInvoker, FastAdapter")]
			void OnClick (global::Android.Views.View p0, int p1, global::Java.Lang.Object p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener", DoNotGenerateAcw=true)]
		internal class IOnClickListenerInvoker : global::Java.Lang.Object, IOnClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.helpers.ClickListenerHelper.OnClickListener"));
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

			static Delegate cb_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_ == null)
					cb_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_);
				return cb_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_;
			}

			static void n_OnClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_;
			public unsafe void OnClick (global::Android.Views.View p0, int p1, global::Java.Lang.Object p2)
			{
				if (id_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;ILcom/mikepenz/fastadapter/IItem;)V");
				IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_ILcom_mikepenz_fastadapter_IItem_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		public partial class ClickEventArgs : global::System.EventArgs {

			public ClickEventArgs (global::Android.Views.View p0, int p1, global::Java.Lang.Object p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			global::Java.Lang.Object p2;
			public global::Java.Lang.Object P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/helpers/ClickListenerHelper_OnClickListenerImplementor")]
		internal sealed partial class IOnClickListenerImplementor : global::Java.Lang.Object, IOnClickListener {

			object sender;

			public IOnClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/helpers/ClickListenerHelper_OnClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnClick (global::Android.Views.View p0, int p1, global::Java.Lang.Object p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ClickEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/helpers/ClickListenerHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickListenerHelper); }
		}

		protected ClickListenerHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mikepenz_fastadapter_FastAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.helpers']/class[@name='ClickListenerHelper']/constructor[@name='ClickListenerHelper' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter&lt;Item&gt;']]"
		[Register (".ctor", "(Lcom/mikepenz/fastadapter/FastAdapter;)V", "")]
		public unsafe ClickListenerHelper (global::Com.Mikepenz.Fastadapter.FastAdapter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ClickListenerHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/fastadapter/FastAdapter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/fastadapter/FastAdapter;)V", __args);
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

		static Delegate cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetListen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_Handler ()
		{
			if (cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ == null)
				cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_);
			return cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_;
		}

		static void n_Listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener p2 = (global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Listen (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.helpers']/class[@name='ClickListenerHelper']/method[@name='listen' and count(parameter)=3 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.mikepenz.fastadapter.helpers.ClickListenerHelper.OnClickListener&lt;Item&gt;']]"
		[Register ("listen", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/view/View;Lcom/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener;)V", "GetListen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_Handler")]
		public virtual unsafe void Listen (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, global::Android.Views.View p1, global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener p2)
		{
			if (id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ == IntPtr.Zero)
				id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "listen", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/view/View;Lcom/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_view_View_Lcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listen", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/view/View;Lcom/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetListen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_Handler ()
		{
			if (cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ == null)
				cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_);
			return cb_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_;
		}

		static void n_Listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener p2 = (global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Listen (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.helpers']/class[@name='ClickListenerHelper']/method[@name='listen' and count(parameter)=3 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int'] and parameter[3][@type='com.mikepenz.fastadapter.helpers.ClickListenerHelper.OnClickListener&lt;Item&gt;']]"
		[Register ("listen", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;ILcom/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener;)V", "GetListen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_Handler")]
		public virtual unsafe void Listen (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1, global::Com.Mikepenz.Fastadapter.Helpers.ClickListenerHelper.IOnClickListener p2)
		{
			if (id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ == IntPtr.Zero)
				id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "listen", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;ILcom/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_listen_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILcom_mikepenz_fastadapter_helpers_ClickListenerHelper_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listen", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;ILcom/mikepenz/fastadapter/helpers/ClickListenerHelper$OnClickListener;)V"), __args);
			} finally {
			}
		}

	}
}
