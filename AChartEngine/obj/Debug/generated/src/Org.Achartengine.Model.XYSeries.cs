using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']"
	[global::Android.Runtime.Register ("org/achartengine/model/XYSeries", DoNotGenerateAcw=true)]
	public partial class XYSeries : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/XYSeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYSeries); }
		}

		protected XYSeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/constructor[@name='XYSeries' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public XYSeries (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (XYSeries)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/constructor[@name='XYSeries' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public XYSeries (string p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (XYSeries)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getAnnotationCount;
#pragma warning disable 0169
		static Delegate GetGetAnnotationCountHandler ()
		{
			if (cb_getAnnotationCount == null)
				cb_getAnnotationCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAnnotationCount);
			return cb_getAnnotationCount;
		}

		static int n_GetAnnotationCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnnotationCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotationCount;
		public virtual int AnnotationCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getAnnotationCount' and count(parameter)=0]"
			[Register ("getAnnotationCount", "()I", "GetGetAnnotationCountHandler")]
			get {
				if (id_getAnnotationCount == IntPtr.Zero)
					id_getAnnotationCount = JNIEnv.GetMethodID (class_ref, "getAnnotationCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAnnotationCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotationCount", "()I"));
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
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public virtual int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getItemCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
			}
		}

		static Delegate cb_getMaxX;
#pragma warning disable 0169
		static Delegate GetGetMaxXHandler ()
		{
			if (cb_getMaxX == null)
				cb_getMaxX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxX);
			return cb_getMaxX;
		}

		static double n_GetMaxX (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxX;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxX;
		public virtual double MaxX {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getMaxX' and count(parameter)=0]"
			[Register ("getMaxX", "()D", "GetGetMaxXHandler")]
			get {
				if (id_getMaxX == IntPtr.Zero)
					id_getMaxX = JNIEnv.GetMethodID (class_ref, "getMaxX", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaxX);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxX", "()D"));
			}
		}

		static Delegate cb_getMaxY;
#pragma warning disable 0169
		static Delegate GetGetMaxYHandler ()
		{
			if (cb_getMaxY == null)
				cb_getMaxY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxY);
			return cb_getMaxY;
		}

		static double n_GetMaxY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxY;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxY;
		public virtual double MaxY {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getMaxY' and count(parameter)=0]"
			[Register ("getMaxY", "()D", "GetGetMaxYHandler")]
			get {
				if (id_getMaxY == IntPtr.Zero)
					id_getMaxY = JNIEnv.GetMethodID (class_ref, "getMaxY", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaxY);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxY", "()D"));
			}
		}

		static Delegate cb_getMinX;
#pragma warning disable 0169
		static Delegate GetGetMinXHandler ()
		{
			if (cb_getMinX == null)
				cb_getMinX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinX);
			return cb_getMinX;
		}

		static double n_GetMinX (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinX;
		}
#pragma warning restore 0169

		static IntPtr id_getMinX;
		public virtual double MinX {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getMinX' and count(parameter)=0]"
			[Register ("getMinX", "()D", "GetGetMinXHandler")]
			get {
				if (id_getMinX == IntPtr.Zero)
					id_getMinX = JNIEnv.GetMethodID (class_ref, "getMinX", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMinX);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinX", "()D"));
			}
		}

		static Delegate cb_getMinY;
#pragma warning disable 0169
		static Delegate GetGetMinYHandler ()
		{
			if (cb_getMinY == null)
				cb_getMinY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinY);
			return cb_getMinY;
		}

		static double n_GetMinY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinY;
		}
#pragma warning restore 0169

		static IntPtr id_getMinY;
		public virtual double MinY {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getMinY' and count(parameter)=0]"
			[Register ("getMinY", "()D", "GetGetMinYHandler")]
			get {
				if (id_getMinY == IntPtr.Zero)
					id_getMinY = JNIEnv.GetMethodID (class_ref, "getMinY", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMinY);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinY", "()D"));
			}
		}

		static Delegate cb_getPadding;
#pragma warning disable 0169
		static Delegate GetGetPaddingHandler ()
		{
			if (cb_getPadding == null)
				cb_getPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPadding);
			return cb_getPadding;
		}

		static double n_GetPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Padding;
		}
#pragma warning restore 0169

		static IntPtr id_getPadding;
		protected virtual double Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()D", "GetGetPaddingHandler")]
			get {
				if (id_getPadding == IntPtr.Zero)
					id_getPadding = JNIEnv.GetMethodID (class_ref, "getPadding", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getPadding);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPadding", "()D"));
			}
		}

		static Delegate cb_getScaleNumber;
#pragma warning disable 0169
		static Delegate GetGetScaleNumberHandler ()
		{
			if (cb_getScaleNumber == null)
				cb_getScaleNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScaleNumber);
			return cb_getScaleNumber;
		}

		static int n_GetScaleNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleNumber;
		public virtual int ScaleNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getScaleNumber' and count(parameter)=0]"
			[Register ("getScaleNumber", "()I", "GetGetScaleNumberHandler")]
			get {
				if (id_getScaleNumber == IntPtr.Zero)
					id_getScaleNumber = JNIEnv.GetMethodID (class_ref, "getScaleNumber", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getScaleNumber);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleNumber", "()I"));
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_add_DD;
#pragma warning disable 0169
		static Delegate GetAdd_DDHandler ()
		{
			if (cb_add_DD == null)
				cb_add_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_Add_DD);
			return cb_add_DD;
		}

		static void n_Add_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='add' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("add", "(DD)V", "GetAdd_DDHandler")]
		public virtual void Add (double p0, double p1)
		{
			if (id_add_DD == IntPtr.Zero)
				id_add_DD = JNIEnv.GetMethodID (class_ref, "add", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(DD)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_add_IDD;
#pragma warning disable 0169
		static Delegate GetAdd_IDDHandler ()
		{
			if (cb_add_IDD == null)
				cb_add_IDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double, double>) n_Add_IDD);
			return cb_add_IDD;
		}

		static void n_Add_IDD (IntPtr jnienv, IntPtr native__this, int p0, double p1, double p2)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_add_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='add' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("add", "(IDD)V", "GetAdd_IDDHandler")]
		public virtual void Add (int p0, double p1, double p2)
		{
			if (id_add_IDD == IntPtr.Zero)
				id_add_IDD = JNIEnv.GetMethodID (class_ref, "add", "(IDD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_IDD, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(IDD)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_addAnnotation_Ljava_lang_String_DD;
#pragma warning disable 0169
		static Delegate GetAddAnnotation_Ljava_lang_String_DDHandler ()
		{
			if (cb_addAnnotation_Ljava_lang_String_DD == null)
				cb_addAnnotation_Ljava_lang_String_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double, double>) n_AddAnnotation_Ljava_lang_String_DD);
			return cb_addAnnotation_Ljava_lang_String_DD;
		}

		static void n_AddAnnotation_Ljava_lang_String_DD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, double p2)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAnnotation (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addAnnotation_Ljava_lang_String_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='addAnnotation' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("addAnnotation", "(Ljava/lang/String;DD)V", "GetAddAnnotation_Ljava_lang_String_DDHandler")]
		public virtual void AddAnnotation (string p0, double p1, double p2)
		{
			if (id_addAnnotation_Ljava_lang_String_DD == IntPtr.Zero)
				id_addAnnotation_Ljava_lang_String_DD = JNIEnv.GetMethodID (class_ref, "addAnnotation", "(Ljava/lang/String;DD)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAnnotation_Ljava_lang_String_DD, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAnnotation", "(Ljava/lang/String;DD)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
		}

		static Delegate cb_getAnnotationAt_I;
#pragma warning disable 0169
		static Delegate GetGetAnnotationAt_IHandler ()
		{
			if (cb_getAnnotationAt_I == null)
				cb_getAnnotationAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAnnotationAt_I);
			return cb_getAnnotationAt_I;
		}

		static IntPtr n_GetAnnotationAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetAnnotationAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotationAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getAnnotationAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAnnotationAt", "(I)Ljava/lang/String;", "GetGetAnnotationAt_IHandler")]
		public virtual string GetAnnotationAt (int p0)
		{
			if (id_getAnnotationAt_I == IntPtr.Zero)
				id_getAnnotationAt_I = JNIEnv.GetMethodID (class_ref, "getAnnotationAt", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAnnotationAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotationAt", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getAnnotationX_I;
#pragma warning disable 0169
		static Delegate GetGetAnnotationX_IHandler ()
		{
			if (cb_getAnnotationX_I == null)
				cb_getAnnotationX_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetAnnotationX_I);
			return cb_getAnnotationX_I;
		}

		static double n_GetAnnotationX_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAnnotationX (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotationX_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getAnnotationX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAnnotationX", "(I)D", "GetGetAnnotationX_IHandler")]
		public virtual double GetAnnotationX (int p0)
		{
			if (id_getAnnotationX_I == IntPtr.Zero)
				id_getAnnotationX_I = JNIEnv.GetMethodID (class_ref, "getAnnotationX", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getAnnotationX_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotationX", "(I)D"), new JValue (p0));
		}

		static Delegate cb_getAnnotationY_I;
#pragma warning disable 0169
		static Delegate GetGetAnnotationY_IHandler ()
		{
			if (cb_getAnnotationY_I == null)
				cb_getAnnotationY_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetAnnotationY_I);
			return cb_getAnnotationY_I;
		}

		static double n_GetAnnotationY_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAnnotationY (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotationY_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getAnnotationY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAnnotationY", "(I)D", "GetGetAnnotationY_IHandler")]
		public virtual double GetAnnotationY (int p0)
		{
			if (id_getAnnotationY_I == IntPtr.Zero)
				id_getAnnotationY_I = JNIEnv.GetMethodID (class_ref, "getAnnotationY", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getAnnotationY_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotationY", "(I)D"), new JValue (p0));
		}

		static Delegate cb_getIndexForKey_D;
#pragma warning disable 0169
		static Delegate GetGetIndexForKey_DHandler ()
		{
			if (cb_getIndexForKey_D == null)
				cb_getIndexForKey_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, int>) n_GetIndexForKey_D);
			return cb_getIndexForKey_D;
		}

		static int n_GetIndexForKey_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexForKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getIndexForKey_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getIndexForKey' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getIndexForKey", "(D)I", "GetGetIndexForKey_DHandler")]
		public virtual int GetIndexForKey (double p0)
		{
			if (id_getIndexForKey_D == IntPtr.Zero)
				id_getIndexForKey_D = JNIEnv.GetMethodID (class_ref, "getIndexForKey", "(D)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getIndexForKey_D, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexForKey", "(D)I"), new JValue (p0));
		}

		static Delegate cb_getRange_DDZ;
#pragma warning disable 0169
		static Delegate GetGetRange_DDZHandler ()
		{
			if (cb_getRange_DDZ == null)
				cb_getRange_DDZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, bool, IntPtr>) n_GetRange_DDZ);
			return cb_getRange_DDZ;
		}

		static IntPtr n_GetRange_DDZ (IntPtr jnienv, IntPtr native__this, double p0, double p1, bool p2)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Java.Lang.Double, global::Java.Lang.Double>.ToLocalJniHandle (__this.GetRange (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getRange_DDZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getRange' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='boolean']]"
		[Register ("getRange", "(DDZ)Ljava/util/SortedMap;", "GetGetRange_DDZHandler")]
		public virtual global::System.Collections.Generic.IDictionary<global::Java.Lang.Double, global::Java.Lang.Double> GetRange (double p0, double p1, bool p2)
		{
			if (id_getRange_DDZ == IntPtr.Zero)
				id_getRange_DDZ = JNIEnv.GetMethodID (class_ref, "getRange", "(DDZ)Ljava/util/SortedMap;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Double, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRange_DDZ, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Double, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRange", "(DDZ)Ljava/util/SortedMap;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getX_I;
#pragma warning disable 0169
		static Delegate GetGetX_IHandler ()
		{
			if (cb_getX_I == null)
				cb_getX_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetX_I);
			return cb_getX_I;
		}

		static double n_GetX_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getX_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getX", "(I)D", "GetGetX_IHandler")]
		public virtual double GetX (int p0)
		{
			if (id_getX_I == IntPtr.Zero)
				id_getX_I = JNIEnv.GetMethodID (class_ref, "getX", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getX_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "(I)D"), new JValue (p0));
		}

		static Delegate cb_getY_I;
#pragma warning disable 0169
		static Delegate GetGetY_IHandler ()
		{
			if (cb_getY_I == null)
				cb_getY_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetY_I);
			return cb_getY_I;
		}

		static double n_GetY_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getY_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='getY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getY", "(I)D", "GetGetY_IHandler")]
		public virtual double GetY (int p0)
		{
			if (id_getY_I == IntPtr.Zero)
				id_getY_I = JNIEnv.GetMethodID (class_ref, "getY", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getY_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "(I)D"), new JValue (p0));
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)V"), new JValue (p0));
		}

		static Delegate cb_removeAnnotation_I;
#pragma warning disable 0169
		static Delegate GetRemoveAnnotation_IHandler ()
		{
			if (cb_removeAnnotation_I == null)
				cb_removeAnnotation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveAnnotation_I);
			return cb_removeAnnotation_I;
		}

		static void n_RemoveAnnotation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAnnotation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeAnnotation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYSeries']/method[@name='removeAnnotation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAnnotation", "(I)V", "GetRemoveAnnotation_IHandler")]
		public virtual void RemoveAnnotation (int p0)
		{
			if (id_removeAnnotation_I == IntPtr.Zero)
				id_removeAnnotation_I = JNIEnv.GetMethodID (class_ref, "removeAnnotation", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAnnotation_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAnnotation", "(I)V"), new JValue (p0));
		}

	}
}
