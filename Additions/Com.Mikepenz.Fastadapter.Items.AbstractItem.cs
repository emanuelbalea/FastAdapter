using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Items {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/items/AbstractItem", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.items.AbstractItem<?, ?>", "VH extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public abstract partial class AbstractItem : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.IClickable, global::Com.Mikepenz.Fastadapter.IItem {


		static IntPtr mEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mEnabled']"
		[Register ("mEnabled")]
		protected bool MEnabled {
			get {
				if (mEnabled_jfieldId == IntPtr.Zero)
					mEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mEnabled_jfieldId);
			}
			set {
				if (mEnabled_jfieldId == IntPtr.Zero)
					mEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEnabled_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFactory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mFactory']"
		[Register ("mFactory")]
		protected global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory MFactory {
			get {
				if (mFactory_jfieldId == IntPtr.Zero)
					mFactory_jfieldId = JNIEnv.GetFieldID (class_ref, "mFactory", "Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFactory_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFactory_jfieldId == IntPtr.Zero)
					mFactory_jfieldId = JNIEnv.GetFieldID (class_ref, "mFactory", "Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFactory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mIdentifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mIdentifier']"
		[Register ("mIdentifier")]
		protected long MIdentifier {
			get {
				if (mIdentifier_jfieldId == IntPtr.Zero)
					mIdentifier_jfieldId = JNIEnv.GetFieldID (class_ref, "mIdentifier", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mIdentifier_jfieldId);
			}
			set {
				if (mIdentifier_jfieldId == IntPtr.Zero)
					mIdentifier_jfieldId = JNIEnv.GetFieldID (class_ref, "mIdentifier", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIdentifier_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOnItemClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mOnItemClickListener']"
		[Register ("mOnItemClickListener")]
		protected global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener MOnItemClickListener {
			get {
				if (mOnItemClickListener_jfieldId == IntPtr.Zero)
					mOnItemClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnItemClickListener", "Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnItemClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnItemClickListener_jfieldId == IntPtr.Zero)
					mOnItemClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnItemClickListener", "Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnItemClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnItemPreClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mOnItemPreClickListener']"
		[Register ("mOnItemPreClickListener")]
		protected global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener MOnItemPreClickListener {
			get {
				if (mOnItemPreClickListener_jfieldId == IntPtr.Zero)
					mOnItemPreClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnItemPreClickListener", "Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnItemPreClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnItemPreClickListener_jfieldId == IntPtr.Zero)
					mOnItemPreClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnItemPreClickListener", "Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnItemPreClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSelectable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mSelectable']"
		[Register ("mSelectable")]
		protected bool MSelectable {
			get {
				if (mSelectable_jfieldId == IntPtr.Zero)
					mSelectable_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectable", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelectable_jfieldId);
			}
			set {
				if (mSelectable_jfieldId == IntPtr.Zero)
					mSelectable_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectable", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelected_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mSelected']"
		[Register ("mSelected")]
		protected bool MSelected {
			get {
				if (mSelected_jfieldId == IntPtr.Zero)
					mSelected_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelected", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelected_jfieldId);
			}
			set {
				if (mSelected_jfieldId == IntPtr.Zero)
					mSelected_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelected", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelected_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/field[@name='mTag']"
		[Register ("mTag")]
		protected global::Java.Lang.Object MTag {
			get {
				if (mTag_jfieldId == IntPtr.Zero)
					mTag_jfieldId = JNIEnv.GetFieldID (class_ref, "mTag", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTag_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTag_jfieldId == IntPtr.Zero)
					mTag_jfieldId = JNIEnv.GetFieldID (class_ref, "mTag", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem.ReflectionBasedViewHolderFactory']"
		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/items/AbstractItem$ReflectionBasedViewHolderFactory", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"VH extends android.support.v7.widget.RecyclerView.ViewHolder"})]
		protected internal partial class ReflectionBasedViewHolderFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/fastadapter/items/AbstractItem$ReflectionBasedViewHolderFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ReflectionBasedViewHolderFactory); }
			}

			protected ReflectionBasedViewHolderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Class_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem.ReflectionBasedViewHolderFactory']/constructor[@name='AbstractItem.ReflectionBasedViewHolderFactory' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends VH&gt;']]"
			[Register (".ctor", "(Ljava/lang/Class;)V", "")]
			public unsafe ReflectionBasedViewHolderFactory (global::Java.Lang.Class p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ReflectionBasedViewHolderFactory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_, __args);
				} finally {
				}
			}

			static Delegate cb_create_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetCreate_Landroid_view_View_Handler ()
			{
				if (cb_create_Landroid_view_View_ == null)
					cb_create_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Landroid_view_View_);
				return cb_create_Landroid_view_View_;
			}

			static IntPtr n_Create_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Fastadapter.Items.AbstractItem.ReflectionBasedViewHolderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem.ReflectionBasedViewHolderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_create_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem.ReflectionBasedViewHolderFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("create", "(Landroid/view/View;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
			public virtual unsafe global::Java.Lang.Object Create (global::Android.Views.View p0)
			{
				if (id_create_Landroid_view_View_ == IntPtr.Zero)
					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/items/AbstractItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractItem); }
		}

		protected AbstractItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/constructor[@name='AbstractItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AbstractItem)) {
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

		static Delegate cb_getFactory;
#pragma warning disable 0169
		static Delegate GetGetFactoryHandler ()
		{
			if (cb_getFactory == null)
				cb_getFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFactory);
			return cb_getFactory;
		}

		static IntPtr n_GetFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getFactory' and count(parameter)=0]"
			[Register ("getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;", "GetGetFactoryHandler")]
			get {
				if (id_getFactory == IntPtr.Zero)
					id_getFactory = JNIEnv.GetMethodID (class_ref, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static long n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Identifier;
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		public virtual unsafe long Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()J", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentifier", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		public virtual unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
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
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		static IntPtr id_isSelectable;
		public virtual unsafe bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='isSelectable' and count(parameter)=0]"
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

		static Delegate cb_isSelected;
#pragma warning disable 0169
		static Delegate GetIsSelectedHandler ()
		{
			if (cb_isSelected == null)
				cb_isSelected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelected);
			return cb_isSelected;
		}

		static bool n_IsSelected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelected;
		}
#pragma warning restore 0169

		static IntPtr id_isSelected;
		public virtual unsafe bool IsSelected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='isSelected' and count(parameter)=0]"
			[Register ("isSelected", "()Z", "GetIsSelectedHandler")]
			get {
				if (id_isSelected == IntPtr.Zero)
					id_isSelected = JNIEnv.GetMethodID (class_ref, "isSelected", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOnItemClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnItemClickListenerHandler ()
		{
			if (cb_getOnItemClickListener == null)
				cb_getOnItemClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnItemClickListener);
			return cb_getOnItemClickListener;
		}

		static IntPtr n_GetOnItemClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnItemClickListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnItemClickListener;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnItemClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getOnItemClickListener' and count(parameter)=0]"
			[Register ("getOnItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;", "GetGetOnItemClickListenerHandler")]
			get {
				if (id_getOnItemClickListener == IntPtr.Zero)
					id_getOnItemClickListener = JNIEnv.GetMethodID (class_ref, "getOnItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnItemClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnPreItemClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnPreItemClickListenerHandler ()
		{
			if (cb_getOnPreItemClickListener == null)
				cb_getOnPreItemClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnPreItemClickListener);
			return cb_getOnPreItemClickListener;
		}

		static IntPtr n_GetOnPreItemClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnPreItemClickListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnPreItemClickListener;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnPreItemClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getOnPreItemClickListener' and count(parameter)=0]"
			[Register ("getOnPreItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;", "GetGetOnPreItemClickListenerHandler")]
			get {
				if (id_getOnPreItemClickListener == IntPtr.Zero)
					id_getOnPreItemClickListener = JNIEnv.GetMethodID (class_ref, "getOnPreItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPreItemClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnPreItemClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_);
			return cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_BindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='VH']]"
		[Register ("bindView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetBindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Java.Lang.Object p0)
		{
			if (id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_equals_I;
#pragma warning disable 0169
		static Delegate GetEquals_IHandler ()
		{
			if (cb_equals_I == null)
				cb_equals_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Equals_I);
			return cb_equals_I;
		}

		static bool n_Equals_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Equals (p0);
		}
#pragma warning restore 0169

		static IntPtr id_equals_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("equals", "(I)Z", "GetEquals_IHandler")]
		public virtual unsafe bool Equals (int p0)
		{
			if (id_equals_I == IntPtr.Zero)
				id_equals_I = JNIEnv.GetMethodID (class_ref, "equals", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_generateView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGenerateView_Landroid_content_Context_Handler ()
		{
			if (cb_generateView_Landroid_content_Context_ == null)
				cb_generateView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateView_Landroid_content_Context_);
			return cb_generateView_Landroid_content_Context_;
		}

		static IntPtr n_GenerateView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateView_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='generateView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("generateView", "(Landroid/content/Context;)Landroid/view/View;", "GetGenerateView_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Views.View GenerateView (global::Android.Content.Context p0)
		{
			if (id_generateView_Landroid_content_Context_ == IntPtr.Zero)
				id_generateView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "generateView", "(Landroid/content/Context;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateView_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateView", "(Landroid/content/Context;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGenerateView_Landroid_content_Context_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ == null)
				cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateView_Landroid_content_Context_Landroid_view_ViewGroup_);
			return cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GenerateView_Landroid_content_Context_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateView (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='generateView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGenerateView_Landroid_content_Context_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Android.Views.View GenerateView (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1)
		{
			if (id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getViewHolder_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetViewHolder_Landroid_view_View_Handler ()
		{
			if (cb_getViewHolder_Landroid_view_View_ == null)
				cb_getViewHolder_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetViewHolder_Landroid_view_View_);
			return cb_getViewHolder_Landroid_view_View_;
		}

		static IntPtr n_GetViewHolder_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetViewHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getViewHolder_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getViewHolder", "(Landroid/view/View;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetGetViewHolder_Landroid_view_View_Handler")]
		public virtual unsafe global::Java.Lang.Object GetViewHolder (global::Android.Views.View p0)
		{
			if (id_getViewHolder_Landroid_view_View_ == IntPtr.Zero)
				id_getViewHolder_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getViewHolder", "(Landroid/view/View;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewHolder_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewHolder", "(Landroid/view/View;)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetViewHolder_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getViewHolder_Landroid_view_ViewGroup_ == null)
				cb_getViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetViewHolder_Landroid_view_ViewGroup_);
			return cb_getViewHolder_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetViewHolder_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetViewHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getViewHolder_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetGetViewHolder_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Java.Lang.Object GetViewHolder (global::Android.Views.ViewGroup p0)
		{
			if (id_getViewHolder_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getViewHolder_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewHolder_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_viewHolderType;
#pragma warning disable 0169
		static Delegate GetViewHolderTypeHandler ()
		{
			if (cb_viewHolderType == null)
				cb_viewHolderType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ViewHolderType);
			return cb_viewHolderType;
		}

		static IntPtr n_ViewHolderType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewHolderType ());
		}
#pragma warning restore 0169

		static IntPtr id_viewHolderType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='viewHolderType' and count(parameter)=0]"
		[Register ("viewHolderType", "()Ljava/lang/Class;", "GetViewHolderTypeHandler")]
		protected virtual unsafe global::Java.Lang.Class ViewHolderType ()
		{
			if (id_viewHolderType == IntPtr.Zero)
				id_viewHolderType = JNIEnv.GetMethodID (class_ref, "viewHolderType", "()Ljava/lang/Class;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_viewHolderType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "viewHolderType", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithEnabled_ZHandler ()
		{
			if (cb_withEnabled_Z == null)
				cb_withEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithEnabled_Z);
			return cb_withEnabled_Z;
		}

		static IntPtr n_WithEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithEnabled (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withEnabled", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithEnabled_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithEnabled (bool p0)
		{
			if (id_withEnabled_Z == IntPtr.Zero)
				id_withEnabled_Z = JNIEnv.GetMethodID (class_ref, "withEnabled", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEnabled", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_;
#pragma warning disable 0169
		static Delegate GetWithFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_Handler ()
		{
			if (cb_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_ == null)
				cb_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_);
			return cb_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_;
		}

		static IntPtr n_WithFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory p0 = (global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFactory (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withFactory' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.utils.ViewHolderFactory&lt;? extends VH&gt;']]"
		[Register ("withFactory", "(Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_Handler")]
		public virtual unsafe global::Java.Lang.Object WithFactory (global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory p0)
		{
			if (id_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_ == IntPtr.Zero)
				id_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_ = JNIEnv.GetMethodID (class_ref, "withFactory", "(Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFactory_Lcom_mikepenz_fastadapter_utils_ViewHolderFactory_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFactory", "(Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withIdentifier_J;
#pragma warning disable 0169
		static Delegate GetWithIdentifier_JHandler ()
		{
			if (cb_withIdentifier_J == null)
				cb_withIdentifier_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WithIdentifier_J);
			return cb_withIdentifier_J;
		}

		static IntPtr n_WithIdentifier_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIdentifier (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIdentifier_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withIdentifier' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("withIdentifier", "(J)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithIdentifier_JHandler")]
		public virtual unsafe global::Java.Lang.Object WithIdentifier (long p0)
		{
			if (id_withIdentifier_J == IntPtr.Zero)
				id_withIdentifier_J = JNIEnv.GetMethodID (class_ref, "withIdentifier", "(J)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIdentifier_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIdentifier", "(J)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnItemClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withOnItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;Item&gt;']]"
		[Register ("withOnItemClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler")]
		public virtual unsafe global::Java.Lang.Object WithOnItemClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnItemClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnItemClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnItemClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnItemPreClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withOnItemPreClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;Item&gt;']]"
		[Register ("withOnItemPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler")]
		public virtual unsafe global::Java.Lang.Object WithOnItemPreClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnItemPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnItemPreClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnItemPreClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withSelectable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectable", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithSelectable_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectable (bool p0)
		{
			if (id_withSelectable_Z == IntPtr.Zero)
				id_withSelectable_Z = JNIEnv.GetMethodID (class_ref, "withSelectable", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectable_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectable", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSetSelected_Z;
#pragma warning disable 0169
		static Delegate GetWithSetSelected_ZHandler ()
		{
			if (cb_withSetSelected_Z == null)
				cb_withSetSelected_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSetSelected_Z);
			return cb_withSetSelected_Z;
		}

		static IntPtr n_WithSetSelected_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSetSelected (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSetSelected_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withSetSelected' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSetSelected", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithSetSelected_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithSetSelected (bool p0)
		{
			if (id_withSetSelected_Z == IntPtr.Zero)
				id_withSetSelected_Z = JNIEnv.GetMethodID (class_ref, "withSetSelected", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSetSelected_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSetSelected", "(Z)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWithTag_Ljava_lang_Object_Handler ()
		{
			if (cb_withTag_Ljava_lang_Object_ == null)
				cb_withTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTag_Ljava_lang_Object_);
			return cb_withTag_Ljava_lang_Object_;
		}

		static IntPtr n_WithTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withTag_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='withTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("withTag", "(Ljava/lang/Object;)Lcom/mikepenz/fastadapter/items/AbstractItem;", "GetWithTag_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object WithTag (global::Java.Lang.Object p0)
		{
			if (id_withTag_Ljava_lang_Object_ == IntPtr.Zero)
				id_withTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "withTag", "(Ljava/lang/Object;)Lcom/mikepenz/fastadapter/items/AbstractItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTag", "(Ljava/lang/Object;)Lcom/mikepenz/fastadapter/items/AbstractItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLayoutRes;
#pragma warning disable 0169
		static Delegate GetGetLayoutResHandler ()
		{
			if (cb_getLayoutRes == null)
				cb_getLayoutRes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayoutRes);
			return cb_getLayoutRes;
		}

		static int n_GetLayoutRes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		public abstract int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register ("getLayoutRes", "()I", "GetGetLayoutResHandler")] get;
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Items.AbstractItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Items.AbstractItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.items']/class[@name='AbstractItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/items/AbstractItem", DoNotGenerateAcw=true)]
	internal partial class AbstractItemInvoker : AbstractItem, global::Com.Mikepenz.Fastadapter.IClickable, global::Com.Mikepenz.Fastadapter.IItem, global::Com.Mikepenz.Fastadapter.IIdentifyable {

		public AbstractItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractItemInvoker); }
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
