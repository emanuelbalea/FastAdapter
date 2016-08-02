using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IDraggable']"
	[Register ("com/mikepenz/fastadapter/IDraggable", "", "Com.Mikepenz.Fastadapter.IDraggableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Item extends com.mikepenz.fastadapter.IItem"})]
	public partial interface IDraggable : IJavaObject {

		bool IsDraggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IDraggable']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler:Com.Mikepenz.Fastadapter.IDraggableInvoker, FastAdapter")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IDraggable']/method[@name='withIsDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withIsDraggable", "(Z)Ljava/lang/Object;", "GetWithIsDraggable_ZHandler:Com.Mikepenz.Fastadapter.IDraggableInvoker, FastAdapter")]
		global::Java.Lang.Object WithIsDraggable (bool p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/IDraggable", DoNotGenerateAcw=true)]
	internal class IDraggableInvoker : global::Java.Lang.Object, IDraggable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/fastadapter/IDraggable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDraggableInvoker); }
		}

		IntPtr class_ref;

		public static IDraggable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDraggable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.fastadapter.IDraggable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDraggableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isDraggable;
#pragma warning disable 0169
		static Delegate GetIsDraggableHandler ()
		{
			if (cb_isDraggable == null)
				cb_isDraggable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDraggable);
			return cb_isDraggable;
		}

		static bool n_IsDraggable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.IDraggable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IDraggable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDraggable;
		}
#pragma warning restore 0169

		IntPtr id_isDraggable;
		public unsafe bool IsDraggable {
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDraggable);
			}
		}

		static Delegate cb_withIsDraggable_Z;
#pragma warning disable 0169
		static Delegate GetWithIsDraggable_ZHandler ()
		{
			if (cb_withIsDraggable_Z == null)
				cb_withIsDraggable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIsDraggable_Z);
			return cb_withIsDraggable_Z;
		}

		static IntPtr n_WithIsDraggable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Fastadapter.IDraggable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IDraggable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIsDraggable (p0));
		}
#pragma warning restore 0169

		IntPtr id_withIsDraggable_Z;
		public unsafe global::Java.Lang.Object WithIsDraggable (bool p0)
		{
			if (id_withIsDraggable_Z == IntPtr.Zero)
				id_withIsDraggable_Z = JNIEnv.GetMethodID (class_ref, "withIsDraggable", "(Z)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIsDraggable_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
