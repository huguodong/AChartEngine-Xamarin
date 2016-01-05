using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']"
	[global::Android.Runtime.Register ("org/achartengine/model/Point", DoNotGenerateAcw=true)]
	public sealed partial class Point : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/Point", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Point); }
		}

		internal Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']/constructor[@name='Point' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Point () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Point)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_ctor_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']/constructor[@name='Point' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public Point (float p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Point)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FF)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FF)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_FF == IntPtr.Zero)
				id_ctor_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FF, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "")]
		public float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			return JNIEnv.CallFloatMethod  (Handle, id_getX);
		}

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "")]
		public float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			return JNIEnv.CallFloatMethod  (Handle, id_getY);
		}

		static IntPtr id_setX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']/method[@name='setX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setX", "(F)V", "")]
		public void SetX (float p0)
		{
			if (id_setX_F == IntPtr.Zero)
				id_setX_F = JNIEnv.GetMethodID (class_ref, "setX", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_setX_F, new JValue (p0));
		}

		static IntPtr id_setY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='Point']/method[@name='setY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setY", "(F)V", "")]
		public void SetY (float p0)
		{
			if (id_setY_F == IntPtr.Zero)
				id_setY_F = JNIEnv.GetMethodID (class_ref, "setY", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_setY_F, new JValue (p0));
		}

	}
}
