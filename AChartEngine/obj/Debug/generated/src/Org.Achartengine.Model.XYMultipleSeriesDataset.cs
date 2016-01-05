using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']"
	[global::Android.Runtime.Register ("org/achartengine/model/XYMultipleSeriesDataset", DoNotGenerateAcw=true)]
	public partial class XYMultipleSeriesDataset : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/XYMultipleSeriesDataset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYMultipleSeriesDataset); }
		}

		protected XYMultipleSeriesDataset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/constructor[@name='XYMultipleSeriesDataset' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public XYMultipleSeriesDataset () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (XYMultipleSeriesDataset)) {
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

		static Delegate cb_getSeriesCount;
#pragma warning disable 0169
		static Delegate GetGetSeriesCountHandler ()
		{
			if (cb_getSeriesCount == null)
				cb_getSeriesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeriesCount);
			return cb_getSeriesCount;
		}

		static int n_GetSeriesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeriesCount;
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesCount;
		public virtual int SeriesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='getSeriesCount' and count(parameter)=0]"
			[Register ("getSeriesCount", "()I", "GetGetSeriesCountHandler")]
			get {
				if (id_getSeriesCount == IntPtr.Zero)
					id_getSeriesCount = JNIEnv.GetMethodID (class_ref, "getSeriesCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSeriesCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeriesCount", "()I"));
			}
		}

		static Delegate cb_addAllSeries_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddAllSeries_Ljava_util_List_Handler ()
		{
			if (cb_addAllSeries_Ljava_util_List_ == null)
				cb_addAllSeries_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAllSeries_Ljava_util_List_);
			return cb_addAllSeries_Ljava_util_List_;
		}

		static void n_AddAllSeries_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Achartengine.Model.XYSeries> p0 = global::Android.Runtime.JavaList<global::Org.Achartengine.Model.XYSeries>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAllSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAllSeries_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='addAllSeries' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addAllSeries", "(Ljava/util/List;)V", "GetAddAllSeries_Ljava_util_List_Handler")]
		public virtual void AddAllSeries (global::System.Collections.Generic.IList<global::Org.Achartengine.Model.XYSeries> p0)
		{
			if (id_addAllSeries_Ljava_util_List_ == IntPtr.Zero)
				id_addAllSeries_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addAllSeries", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Achartengine.Model.XYSeries>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAllSeries_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAllSeries", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addSeries_ILorg_achartengine_model_XYSeries_;
#pragma warning disable 0169
		static Delegate GetAddSeries_ILorg_achartengine_model_XYSeries_Handler ()
		{
			if (cb_addSeries_ILorg_achartengine_model_XYSeries_ == null)
				cb_addSeries_ILorg_achartengine_model_XYSeries_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddSeries_ILorg_achartengine_model_XYSeries_);
			return cb_addSeries_ILorg_achartengine_model_XYSeries_;
		}

		static void n_AddSeries_ILorg_achartengine_model_XYSeries_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSeries (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addSeries_ILorg_achartengine_model_XYSeries_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='addSeries' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.achartengine.model.XYSeries']]"
		[Register ("addSeries", "(ILorg/achartengine/model/XYSeries;)V", "GetAddSeries_ILorg_achartengine_model_XYSeries_Handler")]
		public virtual void AddSeries (int p0, global::Org.Achartengine.Model.XYSeries p1)
		{
			if (id_addSeries_ILorg_achartengine_model_XYSeries_ == IntPtr.Zero)
				id_addSeries_ILorg_achartengine_model_XYSeries_ = JNIEnv.GetMethodID (class_ref, "addSeries", "(ILorg/achartengine/model/XYSeries;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSeries_ILorg_achartengine_model_XYSeries_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSeries", "(ILorg/achartengine/model/XYSeries;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addSeries_Lorg_achartengine_model_XYSeries_;
#pragma warning disable 0169
		static Delegate GetAddSeries_Lorg_achartengine_model_XYSeries_Handler ()
		{
			if (cb_addSeries_Lorg_achartengine_model_XYSeries_ == null)
				cb_addSeries_Lorg_achartengine_model_XYSeries_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSeries_Lorg_achartengine_model_XYSeries_);
			return cb_addSeries_Lorg_achartengine_model_XYSeries_;
		}

		static void n_AddSeries_Lorg_achartengine_model_XYSeries_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSeries_Lorg_achartengine_model_XYSeries_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='addSeries' and count(parameter)=1 and parameter[1][@type='org.achartengine.model.XYSeries']]"
		[Register ("addSeries", "(Lorg/achartengine/model/XYSeries;)V", "GetAddSeries_Lorg_achartengine_model_XYSeries_Handler")]
		public virtual void AddSeries (global::Org.Achartengine.Model.XYSeries p0)
		{
			if (id_addSeries_Lorg_achartengine_model_XYSeries_ == IntPtr.Zero)
				id_addSeries_Lorg_achartengine_model_XYSeries_ = JNIEnv.GetMethodID (class_ref, "addSeries", "(Lorg/achartengine/model/XYSeries;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSeries_Lorg_achartengine_model_XYSeries_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSeries", "(Lorg/achartengine/model/XYSeries;)V"), new JValue (p0));
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
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_getSeries;
#pragma warning disable 0169
		static Delegate GetGetSeriesHandler ()
		{
			if (cb_getSeries == null)
				cb_getSeries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeries);
			return cb_getSeries;
		}

		static IntPtr n_GetSeries (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSeries ());
		}
#pragma warning restore 0169

		static IntPtr id_getSeries;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='getSeries' and count(parameter)=0]"
		[Register ("getSeries", "()[Lorg/achartengine/model/XYSeries;", "GetGetSeriesHandler")]
		public virtual global::Org.Achartengine.Model.XYSeries[] GetSeries ()
		{
			if (id_getSeries == IntPtr.Zero)
				id_getSeries = JNIEnv.GetMethodID (class_ref, "getSeries", "()[Lorg/achartengine/model/XYSeries;");

			if (GetType () == ThresholdType)
				return (global::Org.Achartengine.Model.XYSeries[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSeries), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Model.XYSeries));
			else
				return (global::Org.Achartengine.Model.XYSeries[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeries", "()[Lorg/achartengine/model/XYSeries;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Model.XYSeries));
		}

		static Delegate cb_getSeriesAt_I;
#pragma warning disable 0169
		static Delegate GetGetSeriesAt_IHandler ()
		{
			if (cb_getSeriesAt_I == null)
				cb_getSeriesAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSeriesAt_I);
			return cb_getSeriesAt_I;
		}

		static IntPtr n_GetSeriesAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeriesAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='getSeriesAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSeriesAt", "(I)Lorg/achartengine/model/XYSeries;", "GetGetSeriesAt_IHandler")]
		public virtual global::Org.Achartengine.Model.XYSeries GetSeriesAt (int p0)
		{
			if (id_getSeriesAt_I == IntPtr.Zero)
				id_getSeriesAt_I = JNIEnv.GetMethodID (class_ref, "getSeriesAt", "(I)Lorg/achartengine/model/XYSeries;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallObjectMethod  (Handle, id_getSeriesAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeriesAt", "(I)Lorg/achartengine/model/XYSeries;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeSeries_I;
#pragma warning disable 0169
		static Delegate GetRemoveSeries_IHandler ()
		{
			if (cb_removeSeries_I == null)
				cb_removeSeries_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveSeries_I);
			return cb_removeSeries_I;
		}

		static void n_RemoveSeries_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSeries_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='removeSeries' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeSeries", "(I)V", "GetRemoveSeries_IHandler")]
		public virtual void RemoveSeries (int p0)
		{
			if (id_removeSeries_I == IntPtr.Zero)
				id_removeSeries_I = JNIEnv.GetMethodID (class_ref, "removeSeries", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSeries_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSeries", "(I)V"), new JValue (p0));
		}

		static Delegate cb_removeSeries_Lorg_achartengine_model_XYSeries_;
#pragma warning disable 0169
		static Delegate GetRemoveSeries_Lorg_achartengine_model_XYSeries_Handler ()
		{
			if (cb_removeSeries_Lorg_achartengine_model_XYSeries_ == null)
				cb_removeSeries_Lorg_achartengine_model_XYSeries_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSeries_Lorg_achartengine_model_XYSeries_);
			return cb_removeSeries_Lorg_achartengine_model_XYSeries_;
		}

		static void n_RemoveSeries_Lorg_achartengine_model_XYSeries_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSeries_Lorg_achartengine_model_XYSeries_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYMultipleSeriesDataset']/method[@name='removeSeries' and count(parameter)=1 and parameter[1][@type='org.achartengine.model.XYSeries']]"
		[Register ("removeSeries", "(Lorg/achartengine/model/XYSeries;)V", "GetRemoveSeries_Lorg_achartengine_model_XYSeries_Handler")]
		public virtual void RemoveSeries (global::Org.Achartengine.Model.XYSeries p0)
		{
			if (id_removeSeries_Lorg_achartengine_model_XYSeries_ == IntPtr.Zero)
				id_removeSeries_Lorg_achartengine_model_XYSeries_ = JNIEnv.GetMethodID (class_ref, "removeSeries", "(Lorg/achartengine/model/XYSeries;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSeries_Lorg_achartengine_model_XYSeries_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSeries", "(Lorg/achartengine/model/XYSeries;)V"), new JValue (p0));
		}

	}
}
