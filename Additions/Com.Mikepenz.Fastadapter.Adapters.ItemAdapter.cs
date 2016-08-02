using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/ItemAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial class ItemAdapter : global::Com.Mikepenz.Fastadapter.AbstractAdapter, global::Com.Mikepenz.Fastadapter.IItemAdapter {


		static IntPtr mComparator_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/field[@name='mComparator']"
		[Register ("mComparator")]
		protected global::Java.Util.IComparator MComparator {
			get {
				if (mComparator_jfieldId == IntPtr.Zero)
					mComparator_jfieldId = JNIEnv.GetFieldID (class_ref, "mComparator", "Ljava/util/Comparator;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mComparator_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mComparator_jfieldId == IntPtr.Zero)
					mComparator_jfieldId = JNIEnv.GetFieldID (class_ref, "mComparator", "Ljava/util/Comparator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mComparator_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mItemFilterListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/field[@name='mItemFilterListener']"
		[Register ("mItemFilterListener")]
		protected global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener MItemFilterListener {
			get {
				if (mItemFilterListener_jfieldId == IntPtr.Zero)
					mItemFilterListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemFilterListener", "Lcom/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mItemFilterListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItemFilterListener_jfieldId == IntPtr.Zero)
					mItemFilterListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemFilterListener", "Lcom/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mItemFilterListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter.ItemFilter']"
		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilter", DoNotGenerateAcw=true)]
		public partial class ItemFilter : global::Android.Widget.Filter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ItemFilter); }
			}

			protected ItemFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter.ItemFilter']/constructor[@name='ItemAdapter.ItemFilter' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.adapters.ItemAdapter']]"
			[Register (".ctor", "(Lcom/mikepenz/fastadapter/adapters/ItemAdapter;)V", "")]
			public unsafe ItemFilter (global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (ItemFilter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ == IntPtr.Zero)
						id_ctor_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/fastadapter/adapters/ItemAdapter;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_, __args);
				} finally {
				}
			}

			static Delegate cb_getConstraint;
#pragma warning disable 0169
			static Delegate GetGetConstraintHandler ()
			{
				if (cb_getConstraint == null)
					cb_getConstraint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConstraint);
				return cb_getConstraint;
			}

			static IntPtr n_GetConstraint (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.ConstraintFormatted);
			}
#pragma warning restore 0169

			static IntPtr id_getConstraint;
			public virtual unsafe global::Java.Lang.ICharSequence ConstraintFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter.ItemFilter']/method[@name='getConstraint' and count(parameter)=0]"
				[Register ("getConstraint", "()Ljava/lang/CharSequence;", "GetGetConstraintHandler")]
				get {
					if (id_getConstraint == IntPtr.Zero)
						id_getConstraint = JNIEnv.GetMethodID (class_ref, "getConstraint", "()Ljava/lang/CharSequence;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConstraint), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConstraint", "()Ljava/lang/CharSequence;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public string Constraint {
				get { return ConstraintFormatted == null ? null : ConstraintFormatted.ToString (); }
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
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.Selections);
			}
#pragma warning restore 0169

			static IntPtr id_getSelections;
			public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> Selections {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter.ItemFilter']/method[@name='getSelections' and count(parameter)=0]"
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

			static Delegate cb_performFiltering_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetPerformFiltering_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_performFiltering_Ljava_lang_CharSequence_ == null)
					cb_performFiltering_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformFiltering_Ljava_lang_CharSequence_);
				return cb_performFiltering_Ljava_lang_CharSequence_;
			}

			static IntPtr n_PerformFiltering_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformFiltering (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_performFiltering_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter.ItemFilter']/method[@name='performFiltering' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;", "GetPerformFiltering_Ljava_lang_CharSequence_Handler")]
			protected override unsafe global::Android.Widget.Filter.FilterResults PerformFiltering (global::Java.Lang.ICharSequence p0)
			{
				if (id_performFiltering_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_performFiltering_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Android.Widget.Filter.FilterResults __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.Filter.FilterResults> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_performFiltering_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.Filter.FilterResults> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_;
#pragma warning disable 0169
			static Delegate GetPublishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_Handler ()
			{
				if (cb_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_ == null)
					cb_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PublishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_);
				return cb_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_;
			}

			static void n_PublishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.ItemFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.Filter.FilterResults p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.Filter.FilterResults> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.PublishResults (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter.ItemFilter']/method[@name='publishResults' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.widget.Filter.FilterResults']]"
			[Register ("publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V", "GetPublishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_Handler")]
			protected override unsafe void PublishResults (global::Java.Lang.ICharSequence p0, global::Android.Widget.Filter.FilterResults p1)
			{
				if (id_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_ == IntPtr.Zero)
					id_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_ = JNIEnv.GetMethodID (class_ref, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishResults_Ljava_lang_CharSequence_Landroid_widget_Filter_FilterResults_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/interface[@name='ItemAdapter.ItemFilterListener']"
		[Register ("com/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener", "", "Com.Mikepenz.Fastadapter.Adapters.ItemAdapter/IItemFilterListenerInvoker")]
		public partial interface IItemFilterListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/interface[@name='ItemAdapter.ItemFilterListener']/method[@name='itemsFiltered' and count(parameter)=0]"
			[Register ("itemsFiltered", "()V", "GetItemsFilteredHandler:Com.Mikepenz.Fastadapter.Adapters.ItemAdapter/IItemFilterListenerInvoker, FastAdapter")]
			void ItemsFiltered ();

		}

		[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener", DoNotGenerateAcw=true)]
		internal class IItemFilterListenerInvoker : global::Java.Lang.Object, IItemFilterListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IItemFilterListenerInvoker); }
			}

			IntPtr class_ref;

			public static IItemFilterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IItemFilterListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.adapters.ItemAdapter.ItemFilterListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IItemFilterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_itemsFiltered;
#pragma warning disable 0169
			static Delegate GetItemsFilteredHandler ()
			{
				if (cb_itemsFiltered == null)
					cb_itemsFiltered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ItemsFiltered);
				return cb_itemsFiltered;
			}

			static void n_ItemsFiltered (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ItemsFiltered ();
			}
#pragma warning restore 0169

			IntPtr id_itemsFiltered;
			public unsafe void ItemsFiltered ()
			{
				if (id_itemsFiltered == IntPtr.Zero)
					id_itemsFiltered = JNIEnv.GetMethodID (class_ref, "itemsFiltered", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_itemsFiltered);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/fastadapter/adapters/ItemAdapter_ItemFilterListenerImplementor")]
		internal sealed partial class IItemFilterListenerImplementor : global::Java.Lang.Object, IItemFilterListener {

			object sender;

			public IItemFilterListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/fastadapter/adapters/ItemAdapter_ItemFilterListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void ItemsFiltered ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IItemFilterListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/ItemAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemAdapter); }
		}

		protected ItemAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/constructor[@name='ItemAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ItemAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ItemAdapter)) {
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdapterItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterItemCount;
		public override unsafe int AdapterItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getAdapterItemCount' and count(parameter)=0]"
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.AdapterItems);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterItems;
		public override unsafe global::System.Collections.IList AdapterItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getAdapterItems' and count(parameter)=0]"
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

		static Delegate cb_getComparator;
#pragma warning disable 0169
		static Delegate GetGetComparatorHandler ()
		{
			if (cb_getComparator == null)
				cb_getComparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetComparator);
			return cb_getComparator;
		}

		static IntPtr n_GetComparator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Comparator);
		}
#pragma warning restore 0169

		static IntPtr id_getComparator;
		public virtual unsafe global::Java.Util.IComparator Comparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getComparator' and count(parameter)=0]"
			[Register ("getComparator", "()Ljava/util/Comparator;", "GetGetComparatorHandler")]
			get {
				if (id_getComparator == IntPtr.Zero)
					id_getComparator = JNIEnv.GetMethodID (class_ref, "getComparator", "()Ljava/util/Comparator;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComparator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComparator", "()Ljava/util/Comparator;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Order;
		}
#pragma warning restore 0169

		static IntPtr id_getOrder;
		public override unsafe int Order {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getOrder' and count(parameter)=0]"
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

		static IntPtr id_add_arrayLcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='Item...']]"
		[Register ("add", "([Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "")]
		public unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Add (params global:: Java.Lang.Object[] p0)
		{
			if (id_add_arrayLcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_add_arrayLcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "add", "([Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_arrayLcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_add_IarrayLcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item...']]"
		[Register ("add", "(I[Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "")]
		public unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Add (int p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_add_IarrayLcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_add_IarrayLcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "add", "(I[Lcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_IarrayLcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_ILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;Item&gt;']]"
		[Register ("add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetAdd_ILjava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Add (int p0, global::System.Collections.IList p1)
		{
			if (id_add_ILjava_util_List_ == IntPtr.Zero)
				id_add_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_ILjava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetAdd_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Add (global::System.Collections.IList p0)
		{
			if (id_add_Ljava_util_List_ == IntPtr.Zero)
				id_add_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetClearHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Filter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_filter_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAdapterItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getAdapterItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdapterItem", "(I)Lcom/mikepenz/fastadapter/IItem;", "GetGetAdapterItem_IHandler")]
		public unsafe global::Java.Lang.Object GetAdapterItem (int p0)
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAdapterPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdapterPosition_Lcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getAdapterPosition' and count(parameter)=1 and parameter[1][@type='Item']]"
		[Register ("getAdapterPosition", "(Lcom/mikepenz/fastadapter/IItem;)I", "GetGetAdapterPosition_Lcom_mikepenz_fastadapter_IItem_Handler")]
		public unsafe int GetAdapterPosition (global::Java.Lang.Object p0)
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetGlobalPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getGlobalPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getGlobalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGlobalPosition", "(I)I", "GetGetGlobalPosition_IHandler")]
		public override unsafe int GetGlobalPosition (int p0)
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItemFilter ());
		}
#pragma warning restore 0169

		static IntPtr id_getItemFilter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='getItemFilter' and count(parameter)=0]"
		[Register ("getItemFilter", "()Landroid/widget/Filter;", "GetGetItemFilterHandler")]
		public virtual unsafe global::Android.Widget.Filter GetItemFilter ()
		{
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Move (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_move_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='move' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("move", "(II)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetMove_IIHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter Move (int p0, int p1)
		{
			if (id_move_II == IntPtr.Zero)
				id_move_II = JNIEnv.GetMethodID (class_ref, "move", "(II)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_move_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "move", "(II)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove (p0));
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetRemove_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeRange_II;
#pragma warning disable 0169
		static Delegate GetRemoveRange_IIHandler ()
		{
			if (cb_removeRange_II == null)
				cb_removeRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_RemoveRange_II);
			return cb_removeRange_II;
		}

		static IntPtr n_RemoveRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveRange (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_removeRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='removeRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("removeRange", "(II)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetRemoveRange_IIHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter RemoveRange (int p0, int p1)
		{
			if (id_removeRange_II == IntPtr.Zero)
				id_removeRange_II = JNIEnv.GetMethodID (class_ref, "removeRange", "(II)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeRange_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRange", "(II)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_ILcom_mikepenz_fastadapter_IItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Item']]"
		[Register ("set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetSet_ILcom_mikepenz_fastadapter_IItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Set (int p0, global::Java.Lang.Object p1)
		{
			if (id_set_ILcom_mikepenz_fastadapter_IItem_ == IntPtr.Zero)
				id_set_ILcom_mikepenz_fastadapter_IItem_ = JNIEnv.GetMethodID (class_ref, "set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_ILcom_mikepenz_fastadapter_IItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILcom/mikepenz/fastadapter/IItem;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetSet_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter Set (global::System.Collections.IList p0)
		{
			if (id_set_Ljava_util_List_ == IntPtr.Zero)
				id_set_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNewList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNewList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='setNewList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Item&gt;']]"
		[Register ("setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetSetNewList_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter SetNewList (global::System.Collections.IList p0)
		{
			if (id_setNewList_Ljava_util_List_ == IntPtr.Zero)
				id_setNewList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNewList_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewList", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.IExpandable p0 = (global::Com.Mikepenz.Fastadapter.IExpandable)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IExpandable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSubItems (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSubItems_Lcom_mikepenz_fastadapter_IExpandable_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='setSubItems' and count(parameter)=2 and parameter[1][@type='com.mikepenz.fastadapter.IExpandable&lt;T, Item&gt;'] and parameter[2][@type='java.util.List&lt;Item&gt;']]"
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

		static Delegate cb_withComparator_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetWithComparator_Ljava_util_Comparator_Handler ()
		{
			if (cb_withComparator_Ljava_util_Comparator_ == null)
				cb_withComparator_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithComparator_Ljava_util_Comparator_);
			return cb_withComparator_Ljava_util_Comparator_;
		}

		static IntPtr n_WithComparator_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IComparator p0 = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithComparator (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withComparator_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='withComparator' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;Item&gt;']]"
		[Register ("withComparator", "(Ljava/util/Comparator;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetWithComparator_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter WithComparator (global::Java.Util.IComparator p0)
		{
			if (id_withComparator_Ljava_util_Comparator_ == IntPtr.Zero)
				id_withComparator_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "withComparator", "(Ljava/util/Comparator;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withComparator_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withComparator", "(Ljava/util/Comparator;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withComparator_Ljava_util_Comparator_Z;
#pragma warning disable 0169
		static Delegate GetWithComparator_Ljava_util_Comparator_ZHandler ()
		{
			if (cb_withComparator_Ljava_util_Comparator_Z == null)
				cb_withComparator_Ljava_util_Comparator_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_WithComparator_Ljava_util_Comparator_Z);
			return cb_withComparator_Ljava_util_Comparator_Z;
		}

		static IntPtr n_WithComparator_Ljava_util_Comparator_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IComparator p0 = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithComparator (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withComparator_Ljava_util_Comparator_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='withComparator' and count(parameter)=2 and parameter[1][@type='java.util.Comparator&lt;Item&gt;'] and parameter[2][@type='boolean']]"
		[Register ("withComparator", "(Ljava/util/Comparator;Z)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetWithComparator_Ljava_util_Comparator_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter WithComparator (global::Java.Util.IComparator p0, bool p1)
		{
			if (id_withComparator_Ljava_util_Comparator_Z == IntPtr.Zero)
				id_withComparator_Ljava_util_Comparator_Z = JNIEnv.GetMethodID (class_ref, "withComparator", "(Ljava/util/Comparator;Z)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withComparator_Ljava_util_Comparator_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withComparator", "(Ljava/util/Comparator;Z)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate p0 = (global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilterPredicate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='withFilterPredicate' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.IItemAdapter.Predicate&lt;Item&gt;']]"
		[Register ("withFilterPredicate", "(Lcom/mikepenz/fastadapter/IItemAdapter$Predicate;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetWithFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter WithFilterPredicate (global::Com.Mikepenz.Fastadapter.IItemAdapterPredicate p0)
		{
			if (id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ == IntPtr.Zero)
				id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_ = JNIEnv.GetMethodID (class_ref, "withFilterPredicate", "(Lcom/mikepenz/fastadapter/IItemAdapter$Predicate;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFilterPredicate_Lcom_mikepenz_fastadapter_IItemAdapter_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFilterPredicate", "(Lcom/mikepenz/fastadapter/IItemAdapter$Predicate;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withItemFilter_Landroid_widget_Filter_;
#pragma warning disable 0169
		static Delegate GetWithItemFilter_Landroid_widget_Filter_Handler ()
		{
			if (cb_withItemFilter_Landroid_widget_Filter_ == null)
				cb_withItemFilter_Landroid_widget_Filter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithItemFilter_Landroid_widget_Filter_);
			return cb_withItemFilter_Landroid_widget_Filter_;
		}

		static IntPtr n_WithItemFilter_Landroid_widget_Filter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.Filter p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithItemFilter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withItemFilter_Landroid_widget_Filter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='withItemFilter' and count(parameter)=1 and parameter[1][@type='android.widget.Filter']]"
		[Register ("withItemFilter", "(Landroid/widget/Filter;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetWithItemFilter_Landroid_widget_Filter_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter WithItemFilter (global::Android.Widget.Filter p0)
		{
			if (id_withItemFilter_Landroid_widget_Filter_ == IntPtr.Zero)
				id_withItemFilter_Landroid_widget_Filter_ = JNIEnv.GetMethodID (class_ref, "withItemFilter", "(Landroid/widget/Filter;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withItemFilter_Landroid_widget_Filter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withItemFilter", "(Landroid/widget/Filter;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_;
#pragma warning disable 0169
		static Delegate GetWithItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_Handler ()
		{
			if (cb_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_ == null)
				cb_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_);
			return cb_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_;
		}

		static IntPtr n_WithItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener p0 = (global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithItemFilterListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='withItemFilterListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.adapters.ItemAdapter.ItemFilterListener']]"
		[Register ("withItemFilterListener", "(Lcom/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetWithItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter WithItemFilterListener (global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter.IItemFilterListener p0)
		{
			if (id_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_ == IntPtr.Zero)
				id_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_ = JNIEnv.GetMethodID (class_ref, "withItemFilterListener", "(Lcom/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withItemFilterListener_Lcom_mikepenz_fastadapter_adapters_ItemAdapter_ItemFilterListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withItemFilterListener", "(Lcom/mikepenz/fastadapter/adapters/ItemAdapter$ItemFilterListener;)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithUseIdDistributor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withUseIdDistributor_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='ItemAdapter']/method[@name='withUseIdDistributor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withUseIdDistributor", "(Z)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetWithUseIdDistributor_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter WithUseIdDistributor (bool p0)
		{
			if (id_withUseIdDistributor_Z == IntPtr.Zero)
				id_withUseIdDistributor_Z = JNIEnv.GetMethodID (class_ref, "withUseIdDistributor", "(Z)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withUseIdDistributor_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withUseIdDistributor", "(Z)Lcom/mikepenz/fastadapter/adapters/ItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
