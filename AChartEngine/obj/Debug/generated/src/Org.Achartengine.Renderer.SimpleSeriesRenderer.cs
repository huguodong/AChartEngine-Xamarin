using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/SimpleSeriesRenderer", DoNotGenerateAcw=true)]
	public partial class SimpleSeriesRenderer : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/SimpleSeriesRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleSeriesRenderer); }
		}

		protected SimpleSeriesRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/constructor[@name='SimpleSeriesRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SimpleSeriesRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleSeriesRenderer)) {
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

		static Delegate cb_getChartValuesFormat;
#pragma warning disable 0169
		static Delegate GetGetChartValuesFormatHandler ()
		{
			if (cb_getChartValuesFormat == null)
				cb_getChartValuesFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChartValuesFormat);
			return cb_getChartValuesFormat;
		}

		static IntPtr n_GetChartValuesFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChartValuesFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setChartValuesFormat_Ljava_text_NumberFormat_;
#pragma warning disable 0169
		static Delegate GetSetChartValuesFormat_Ljava_text_NumberFormat_Handler ()
		{
			if (cb_setChartValuesFormat_Ljava_text_NumberFormat_ == null)
				cb_setChartValuesFormat_Ljava_text_NumberFormat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChartValuesFormat_Ljava_text_NumberFormat_);
			return cb_setChartValuesFormat_Ljava_text_NumberFormat_;
		}

		static void n_SetChartValuesFormat_Ljava_text_NumberFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Text.NumberFormat p0 = global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChartValuesFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChartValuesFormat;
		static IntPtr id_setChartValuesFormat_Ljava_text_NumberFormat_;
		public virtual global::Java.Text.NumberFormat ChartValuesFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getChartValuesFormat' and count(parameter)=0]"
			[Register ("getChartValuesFormat", "()Ljava/text/NumberFormat;", "GetGetChartValuesFormatHandler")]
			get {
				if (id_getChartValuesFormat == IntPtr.Zero)
					id_getChartValuesFormat = JNIEnv.GetMethodID (class_ref, "getChartValuesFormat", "()Ljava/text/NumberFormat;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (JNIEnv.CallObjectMethod  (Handle, id_getChartValuesFormat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChartValuesFormat", "()Ljava/text/NumberFormat;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setChartValuesFormat' and count(parameter)=1 and parameter[1][@type='java.text.NumberFormat']]"
			[Register ("setChartValuesFormat", "(Ljava/text/NumberFormat;)V", "GetSetChartValuesFormat_Ljava_text_NumberFormat_Handler")]
			set {
				if (id_setChartValuesFormat_Ljava_text_NumberFormat_ == IntPtr.Zero)
					id_setChartValuesFormat_Ljava_text_NumberFormat_ = JNIEnv.GetMethodID (class_ref, "setChartValuesFormat", "(Ljava/text/NumberFormat;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChartValuesFormat_Ljava_text_NumberFormat_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChartValuesFormat", "(Ljava/text/NumberFormat;)V"), new JValue (value));
			}
		}

		static Delegate cb_getChartValuesSpacing;
#pragma warning disable 0169
		static Delegate GetGetChartValuesSpacingHandler ()
		{
			if (cb_getChartValuesSpacing == null)
				cb_getChartValuesSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetChartValuesSpacing);
			return cb_getChartValuesSpacing;
		}

		static float n_GetChartValuesSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChartValuesSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setChartValuesSpacing_F;
#pragma warning disable 0169
		static Delegate GetSetChartValuesSpacing_FHandler ()
		{
			if (cb_setChartValuesSpacing_F == null)
				cb_setChartValuesSpacing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetChartValuesSpacing_F);
			return cb_setChartValuesSpacing_F;
		}

		static void n_SetChartValuesSpacing_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChartValuesSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChartValuesSpacing;
		static IntPtr id_setChartValuesSpacing_F;
		public virtual float ChartValuesSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getChartValuesSpacing' and count(parameter)=0]"
			[Register ("getChartValuesSpacing", "()F", "GetGetChartValuesSpacingHandler")]
			get {
				if (id_getChartValuesSpacing == IntPtr.Zero)
					id_getChartValuesSpacing = JNIEnv.GetMethodID (class_ref, "getChartValuesSpacing", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getChartValuesSpacing);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChartValuesSpacing", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setChartValuesSpacing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setChartValuesSpacing", "(F)V", "GetSetChartValuesSpacing_FHandler")]
			set {
				if (id_setChartValuesSpacing_F == IntPtr.Zero)
					id_setChartValuesSpacing_F = JNIEnv.GetMethodID (class_ref, "setChartValuesSpacing", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChartValuesSpacing_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChartValuesSpacing", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getChartValuesTextAlign;
#pragma warning disable 0169
		static Delegate GetGetChartValuesTextAlignHandler ()
		{
			if (cb_getChartValuesTextAlign == null)
				cb_getChartValuesTextAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChartValuesTextAlign);
			return cb_getChartValuesTextAlign;
		}

		static IntPtr n_GetChartValuesTextAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChartValuesTextAlign);
		}
#pragma warning restore 0169

		static Delegate cb_setChartValuesTextAlign_Landroid_graphics_Paint_Align_;
#pragma warning disable 0169
		static Delegate GetSetChartValuesTextAlign_Landroid_graphics_Paint_Align_Handler ()
		{
			if (cb_setChartValuesTextAlign_Landroid_graphics_Paint_Align_ == null)
				cb_setChartValuesTextAlign_Landroid_graphics_Paint_Align_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChartValuesTextAlign_Landroid_graphics_Paint_Align_);
			return cb_setChartValuesTextAlign_Landroid_graphics_Paint_Align_;
		}

		static void n_SetChartValuesTextAlign_Landroid_graphics_Paint_Align_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Align p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChartValuesTextAlign = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChartValuesTextAlign;
		static IntPtr id_setChartValuesTextAlign_Landroid_graphics_Paint_Align_;
		public virtual global::Android.Graphics.Paint.Align ChartValuesTextAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getChartValuesTextAlign' and count(parameter)=0]"
			[Register ("getChartValuesTextAlign", "()Landroid/graphics/Paint$Align;", "GetGetChartValuesTextAlignHandler")]
			get {
				if (id_getChartValuesTextAlign == IntPtr.Zero)
					id_getChartValuesTextAlign = JNIEnv.GetMethodID (class_ref, "getChartValuesTextAlign", "()Landroid/graphics/Paint$Align;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallObjectMethod  (Handle, id_getChartValuesTextAlign), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChartValuesTextAlign", "()Landroid/graphics/Paint$Align;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setChartValuesTextAlign' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Align']]"
			[Register ("setChartValuesTextAlign", "(Landroid/graphics/Paint$Align;)V", "GetSetChartValuesTextAlign_Landroid_graphics_Paint_Align_Handler")]
			set {
				if (id_setChartValuesTextAlign_Landroid_graphics_Paint_Align_ == IntPtr.Zero)
					id_setChartValuesTextAlign_Landroid_graphics_Paint_Align_ = JNIEnv.GetMethodID (class_ref, "setChartValuesTextAlign", "(Landroid/graphics/Paint$Align;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChartValuesTextAlign_Landroid_graphics_Paint_Align_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChartValuesTextAlign", "(Landroid/graphics/Paint$Align;)V"), new JValue (value));
			}
		}

		static Delegate cb_getChartValuesTextSize;
#pragma warning disable 0169
		static Delegate GetGetChartValuesTextSizeHandler ()
		{
			if (cb_getChartValuesTextSize == null)
				cb_getChartValuesTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetChartValuesTextSize);
			return cb_getChartValuesTextSize;
		}

		static float n_GetChartValuesTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChartValuesTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setChartValuesTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetChartValuesTextSize_FHandler ()
		{
			if (cb_setChartValuesTextSize_F == null)
				cb_setChartValuesTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetChartValuesTextSize_F);
			return cb_setChartValuesTextSize_F;
		}

		static void n_SetChartValuesTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChartValuesTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChartValuesTextSize;
		static IntPtr id_setChartValuesTextSize_F;
		public virtual float ChartValuesTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getChartValuesTextSize' and count(parameter)=0]"
			[Register ("getChartValuesTextSize", "()F", "GetGetChartValuesTextSizeHandler")]
			get {
				if (id_getChartValuesTextSize == IntPtr.Zero)
					id_getChartValuesTextSize = JNIEnv.GetMethodID (class_ref, "getChartValuesTextSize", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getChartValuesTextSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChartValuesTextSize", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setChartValuesTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setChartValuesTextSize", "(F)V", "GetSetChartValuesTextSize_FHandler")]
			set {
				if (id_setChartValuesTextSize_F == IntPtr.Zero)
					id_setChartValuesTextSize_F = JNIEnv.GetMethodID (class_ref, "setChartValuesTextSize", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChartValuesTextSize_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChartValuesTextSize", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public virtual int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_isDisplayBoundingPoints;
#pragma warning disable 0169
		static Delegate GetIsDisplayBoundingPointsHandler ()
		{
			if (cb_isDisplayBoundingPoints == null)
				cb_isDisplayBoundingPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisplayBoundingPoints);
			return cb_isDisplayBoundingPoints;
		}

		static bool n_IsDisplayBoundingPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayBoundingPoints;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayBoundingPoints_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayBoundingPoints_ZHandler ()
		{
			if (cb_setDisplayBoundingPoints_Z == null)
				cb_setDisplayBoundingPoints_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayBoundingPoints_Z);
			return cb_setDisplayBoundingPoints_Z;
		}

		static void n_SetDisplayBoundingPoints_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayBoundingPoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDisplayBoundingPoints;
		static IntPtr id_setDisplayBoundingPoints_Z;
		public virtual bool DisplayBoundingPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='isDisplayBoundingPoints' and count(parameter)=0]"
			[Register ("isDisplayBoundingPoints", "()Z", "GetIsDisplayBoundingPointsHandler")]
			get {
				if (id_isDisplayBoundingPoints == IntPtr.Zero)
					id_isDisplayBoundingPoints = JNIEnv.GetMethodID (class_ref, "isDisplayBoundingPoints", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDisplayBoundingPoints);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisplayBoundingPoints", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setDisplayBoundingPoints' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDisplayBoundingPoints", "(Z)V", "GetSetDisplayBoundingPoints_ZHandler")]
			set {
				if (id_setDisplayBoundingPoints_Z == IntPtr.Zero)
					id_setDisplayBoundingPoints_Z = JNIEnv.GetMethodID (class_ref, "setDisplayBoundingPoints", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayBoundingPoints_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayBoundingPoints", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isDisplayChartValues;
#pragma warning disable 0169
		static Delegate GetIsDisplayChartValuesHandler ()
		{
			if (cb_isDisplayChartValues == null)
				cb_isDisplayChartValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisplayChartValues);
			return cb_isDisplayChartValues;
		}

		static bool n_IsDisplayChartValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayChartValues;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayChartValues_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayChartValues_ZHandler ()
		{
			if (cb_setDisplayChartValues_Z == null)
				cb_setDisplayChartValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayChartValues_Z);
			return cb_setDisplayChartValues_Z;
		}

		static void n_SetDisplayChartValues_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayChartValues = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDisplayChartValues;
		static IntPtr id_setDisplayChartValues_Z;
		public virtual bool DisplayChartValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='isDisplayChartValues' and count(parameter)=0]"
			[Register ("isDisplayChartValues", "()Z", "GetIsDisplayChartValuesHandler")]
			get {
				if (id_isDisplayChartValues == IntPtr.Zero)
					id_isDisplayChartValues = JNIEnv.GetMethodID (class_ref, "isDisplayChartValues", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDisplayChartValues);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisplayChartValues", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setDisplayChartValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDisplayChartValues", "(Z)V", "GetSetDisplayChartValues_ZHandler")]
			set {
				if (id_setDisplayChartValues_Z == IntPtr.Zero)
					id_setDisplayChartValues_Z = JNIEnv.GetMethodID (class_ref, "setDisplayChartValues", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayChartValues_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayChartValues", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getDisplayChartValuesDistance;
#pragma warning disable 0169
		static Delegate GetGetDisplayChartValuesDistanceHandler ()
		{
			if (cb_getDisplayChartValuesDistance == null)
				cb_getDisplayChartValuesDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayChartValuesDistance);
			return cb_getDisplayChartValuesDistance;
		}

		static int n_GetDisplayChartValuesDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayChartValuesDistance;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayChartValuesDistance_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayChartValuesDistance_IHandler ()
		{
			if (cb_setDisplayChartValuesDistance_I == null)
				cb_setDisplayChartValuesDistance_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayChartValuesDistance_I);
			return cb_setDisplayChartValuesDistance_I;
		}

		static void n_SetDisplayChartValuesDistance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayChartValuesDistance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayChartValuesDistance;
		static IntPtr id_setDisplayChartValuesDistance_I;
		public virtual int DisplayChartValuesDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getDisplayChartValuesDistance' and count(parameter)=0]"
			[Register ("getDisplayChartValuesDistance", "()I", "GetGetDisplayChartValuesDistanceHandler")]
			get {
				if (id_getDisplayChartValuesDistance == IntPtr.Zero)
					id_getDisplayChartValuesDistance = JNIEnv.GetMethodID (class_ref, "getDisplayChartValuesDistance", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDisplayChartValuesDistance);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayChartValuesDistance", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setDisplayChartValuesDistance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayChartValuesDistance", "(I)V", "GetSetDisplayChartValuesDistance_IHandler")]
			set {
				if (id_setDisplayChartValuesDistance_I == IntPtr.Zero)
					id_setDisplayChartValuesDistance_I = JNIEnv.GetMethodID (class_ref, "setDisplayChartValuesDistance", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayChartValuesDistance_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayChartValuesDistance", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_isGradientEnabled;
#pragma warning disable 0169
		static Delegate GetIsGradientEnabledHandler ()
		{
			if (cb_isGradientEnabled == null)
				cb_isGradientEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGradientEnabled);
			return cb_isGradientEnabled;
		}

		static bool n_IsGradientEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setGradientEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetGradientEnabled_ZHandler ()
		{
			if (cb_setGradientEnabled_Z == null)
				cb_setGradientEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGradientEnabled_Z);
			return cb_setGradientEnabled_Z;
		}

		static void n_SetGradientEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GradientEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isGradientEnabled;
		static IntPtr id_setGradientEnabled_Z;
		public virtual bool GradientEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='isGradientEnabled' and count(parameter)=0]"
			[Register ("isGradientEnabled", "()Z", "GetIsGradientEnabledHandler")]
			get {
				if (id_isGradientEnabled == IntPtr.Zero)
					id_isGradientEnabled = JNIEnv.GetMethodID (class_ref, "isGradientEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isGradientEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGradientEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setGradientEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGradientEnabled", "(Z)V", "GetSetGradientEnabled_ZHandler")]
			set {
				if (id_setGradientEnabled_Z == IntPtr.Zero)
					id_setGradientEnabled_Z = JNIEnv.GetMethodID (class_ref, "setGradientEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGradientEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGradientEnabled", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getGradientStartColor;
#pragma warning disable 0169
		static Delegate GetGetGradientStartColorHandler ()
		{
			if (cb_getGradientStartColor == null)
				cb_getGradientStartColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGradientStartColor);
			return cb_getGradientStartColor;
		}

		static int n_GetGradientStartColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientStartColor;
		}
#pragma warning restore 0169

		static IntPtr id_getGradientStartColor;
		public virtual int GradientStartColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getGradientStartColor' and count(parameter)=0]"
			[Register ("getGradientStartColor", "()I", "GetGetGradientStartColorHandler")]
			get {
				if (id_getGradientStartColor == IntPtr.Zero)
					id_getGradientStartColor = JNIEnv.GetMethodID (class_ref, "getGradientStartColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getGradientStartColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGradientStartColor", "()I"));
			}
		}

		static Delegate cb_getGradientStartValue;
#pragma warning disable 0169
		static Delegate GetGetGradientStartValueHandler ()
		{
			if (cb_getGradientStartValue == null)
				cb_getGradientStartValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetGradientStartValue);
			return cb_getGradientStartValue;
		}

		static double n_GetGradientStartValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientStartValue;
		}
#pragma warning restore 0169

		static IntPtr id_getGradientStartValue;
		public virtual double GradientStartValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getGradientStartValue' and count(parameter)=0]"
			[Register ("getGradientStartValue", "()D", "GetGetGradientStartValueHandler")]
			get {
				if (id_getGradientStartValue == IntPtr.Zero)
					id_getGradientStartValue = JNIEnv.GetMethodID (class_ref, "getGradientStartValue", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getGradientStartValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGradientStartValue", "()D"));
			}
		}

		static Delegate cb_getGradientStopColor;
#pragma warning disable 0169
		static Delegate GetGetGradientStopColorHandler ()
		{
			if (cb_getGradientStopColor == null)
				cb_getGradientStopColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGradientStopColor);
			return cb_getGradientStopColor;
		}

		static int n_GetGradientStopColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientStopColor;
		}
#pragma warning restore 0169

		static IntPtr id_getGradientStopColor;
		public virtual int GradientStopColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getGradientStopColor' and count(parameter)=0]"
			[Register ("getGradientStopColor", "()I", "GetGetGradientStopColorHandler")]
			get {
				if (id_getGradientStopColor == IntPtr.Zero)
					id_getGradientStopColor = JNIEnv.GetMethodID (class_ref, "getGradientStopColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getGradientStopColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGradientStopColor", "()I"));
			}
		}

		static Delegate cb_getGradientStopValue;
#pragma warning disable 0169
		static Delegate GetGetGradientStopValueHandler ()
		{
			if (cb_getGradientStopValue == null)
				cb_getGradientStopValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetGradientStopValue);
			return cb_getGradientStopValue;
		}

		static double n_GetGradientStopValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientStopValue;
		}
#pragma warning restore 0169

		static IntPtr id_getGradientStopValue;
		public virtual double GradientStopValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getGradientStopValue' and count(parameter)=0]"
			[Register ("getGradientStopValue", "()D", "GetGetGradientStopValueHandler")]
			get {
				if (id_getGradientStopValue == IntPtr.Zero)
					id_getGradientStopValue = JNIEnv.GetMethodID (class_ref, "getGradientStopValue", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getGradientStopValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGradientStopValue", "()D"));
			}
		}

		static Delegate cb_isHighlighted;
#pragma warning disable 0169
		static Delegate GetIsHighlightedHandler ()
		{
			if (cb_isHighlighted == null)
				cb_isHighlighted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHighlighted);
			return cb_isHighlighted;
		}

		static bool n_IsHighlighted (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Highlighted;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlighted_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlighted_ZHandler ()
		{
			if (cb_setHighlighted_Z == null)
				cb_setHighlighted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHighlighted_Z);
			return cb_setHighlighted_Z;
		}

		static void n_SetHighlighted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Highlighted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHighlighted;
		static IntPtr id_setHighlighted_Z;
		public virtual bool Highlighted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='isHighlighted' and count(parameter)=0]"
			[Register ("isHighlighted", "()Z", "GetIsHighlightedHandler")]
			get {
				if (id_isHighlighted == IntPtr.Zero)
					id_isHighlighted = JNIEnv.GetMethodID (class_ref, "isHighlighted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isHighlighted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHighlighted", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setHighlighted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHighlighted", "(Z)V", "GetSetHighlighted_ZHandler")]
			set {
				if (id_setHighlighted_Z == IntPtr.Zero)
					id_setHighlighted_Z = JNIEnv.GetMethodID (class_ref, "setHighlighted", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHighlighted_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHighlighted", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isShowLegendItem;
#pragma warning disable 0169
		static Delegate GetIsShowLegendItemHandler ()
		{
			if (cb_isShowLegendItem == null)
				cb_isShowLegendItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowLegendItem);
			return cb_isShowLegendItem;
		}

		static bool n_IsShowLegendItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowLegendItem;
		}
#pragma warning restore 0169

		static Delegate cb_setShowLegendItem_Z;
#pragma warning disable 0169
		static Delegate GetSetShowLegendItem_ZHandler ()
		{
			if (cb_setShowLegendItem_Z == null)
				cb_setShowLegendItem_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowLegendItem_Z);
			return cb_setShowLegendItem_Z;
		}

		static void n_SetShowLegendItem_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLegendItem = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowLegendItem;
		static IntPtr id_setShowLegendItem_Z;
		public virtual bool ShowLegendItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='isShowLegendItem' and count(parameter)=0]"
			[Register ("isShowLegendItem", "()Z", "GetIsShowLegendItemHandler")]
			get {
				if (id_isShowLegendItem == IntPtr.Zero)
					id_isShowLegendItem = JNIEnv.GetMethodID (class_ref, "isShowLegendItem", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowLegendItem);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowLegendItem", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setShowLegendItem' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowLegendItem", "(Z)V", "GetSetShowLegendItem_ZHandler")]
			set {
				if (id_setShowLegendItem_Z == IntPtr.Zero)
					id_setShowLegendItem_Z = JNIEnv.GetMethodID (class_ref, "setShowLegendItem", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowLegendItem_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowLegendItem", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getStroke;
#pragma warning disable 0169
		static Delegate GetGetStrokeHandler ()
		{
			if (cb_getStroke == null)
				cb_getStroke = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStroke);
			return cb_getStroke;
		}

		static IntPtr n_GetStroke (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Stroke);
		}
#pragma warning restore 0169

		static Delegate cb_setStroke_Lorg_achartengine_renderer_BasicStroke_;
#pragma warning disable 0169
		static Delegate GetSetStroke_Lorg_achartengine_renderer_BasicStroke_Handler ()
		{
			if (cb_setStroke_Lorg_achartengine_renderer_BasicStroke_ == null)
				cb_setStroke_Lorg_achartengine_renderer_BasicStroke_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStroke_Lorg_achartengine_renderer_BasicStroke_);
			return cb_setStroke_Lorg_achartengine_renderer_BasicStroke_;
		}

		static void n_SetStroke_Lorg_achartengine_renderer_BasicStroke_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.BasicStroke p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Stroke = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStroke;
		static IntPtr id_setStroke_Lorg_achartengine_renderer_BasicStroke_;
		public virtual global::Org.Achartengine.Renderer.BasicStroke Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()Lorg/achartengine/renderer/BasicStroke;", "GetGetStrokeHandler")]
			get {
				if (id_getStroke == IntPtr.Zero)
					id_getStroke = JNIEnv.GetMethodID (class_ref, "getStroke", "()Lorg/achartengine/renderer/BasicStroke;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (JNIEnv.CallObjectMethod  (Handle, id_getStroke), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStroke", "()Lorg/achartengine/renderer/BasicStroke;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setStroke' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.BasicStroke']]"
			[Register ("setStroke", "(Lorg/achartengine/renderer/BasicStroke;)V", "GetSetStroke_Lorg_achartengine_renderer_BasicStroke_Handler")]
			set {
				if (id_setStroke_Lorg_achartengine_renderer_BasicStroke_ == IntPtr.Zero)
					id_setStroke_Lorg_achartengine_renderer_BasicStroke_ = JNIEnv.GetMethodID (class_ref, "setStroke", "(Lorg/achartengine/renderer/BasicStroke;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStroke_Lorg_achartengine_renderer_BasicStroke_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStroke", "(Lorg/achartengine/renderer/BasicStroke;)V"), new JValue (value));
			}
		}

		static Delegate cb_setGradientStart_DI;
#pragma warning disable 0169
		static Delegate GetSetGradientStart_DIHandler ()
		{
			if (cb_setGradientStart_DI == null)
				cb_setGradientStart_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_SetGradientStart_DI);
			return cb_setGradientStart_DI;
		}

		static void n_SetGradientStart_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGradientStart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setGradientStart_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setGradientStart' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("setGradientStart", "(DI)V", "GetSetGradientStart_DIHandler")]
		public virtual void SetGradientStart (double p0, int p1)
		{
			if (id_setGradientStart_DI == IntPtr.Zero)
				id_setGradientStart_DI = JNIEnv.GetMethodID (class_ref, "setGradientStart", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setGradientStart_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGradientStart", "(DI)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setGradientStop_DI;
#pragma warning disable 0169
		static Delegate GetSetGradientStop_DIHandler ()
		{
			if (cb_setGradientStop_DI == null)
				cb_setGradientStop_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, int>) n_SetGradientStop_DI);
			return cb_setGradientStop_DI;
		}

		static void n_SetGradientStop_DI (IntPtr jnienv, IntPtr native__this, double p0, int p1)
		{
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGradientStop (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setGradientStop_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='SimpleSeriesRenderer']/method[@name='setGradientStop' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("setGradientStop", "(DI)V", "GetSetGradientStop_DIHandler")]
		public virtual void SetGradientStop (double p0, int p1)
		{
			if (id_setGradientStop_DI == IntPtr.Zero)
				id_setGradientStop_DI = JNIEnv.GetMethodID (class_ref, "setGradientStop", "(DI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setGradientStop_DI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGradientStop", "(DI)V"), new JValue (p0), new JValue (p1));
		}

	}
}
