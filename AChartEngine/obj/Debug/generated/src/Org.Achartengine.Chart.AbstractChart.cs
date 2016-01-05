using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/AbstractChart", DoNotGenerateAcw=true)]
	public abstract partial class AbstractChart : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/AbstractChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractChart); }
		}

		protected AbstractChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/constructor[@name='AbstractChart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AbstractChart () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractChart)) {
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

		static Delegate cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ == null)
				cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_);
			return cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		}

		static void n_Draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='draw' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_Handler")]
		public abstract void Draw (global::Android.Graphics.Canvas p0, int p1, int p2, int p3, int p4, global::Android.Graphics.Paint p5);

		static Delegate cb_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI;
#pragma warning disable 0169
		static Delegate GetDrawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZIHandler ()
		{
			if (cb_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI == null)
				cb_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr, bool, int>) n_DrawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI);
			return cb_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI;
		}

		static void n_DrawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, IntPtr native_p6, bool p7, int p8)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.DefaultRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p6 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.DrawBackground (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawBackground' and count(parameter)=9 and parameter[1][@type='org.achartengine.renderer.DefaultRenderer'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='android.graphics.Paint'] and parameter[8][@type='boolean'] and parameter[9][@type='int']]"
		[Register ("drawBackground", "(Lorg/achartengine/renderer/DefaultRenderer;Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;ZI)V", "GetDrawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZIHandler")]
		protected virtual void DrawBackground (global::Org.Achartengine.Renderer.DefaultRenderer p0, global::Android.Graphics.Canvas p1, int p2, int p3, int p4, int p5, global::Android.Graphics.Paint p6, bool p7, int p8)
		{
			if (id_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI == IntPtr.Zero)
				id_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI = JNIEnv.GetMethodID (class_ref, "drawBackground", "(Lorg/achartengine/renderer/DefaultRenderer;Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;ZI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawBackground_Lorg_achartengine_renderer_DefaultRenderer_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ZI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawBackground", "(Lorg/achartengine/renderer/DefaultRenderer;Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;ZI)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8));
		}

		static Delegate cb_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z;
#pragma warning disable 0169
		static Delegate GetDrawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_ZHandler ()
		{
			if (cb_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z == null)
				cb_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, bool, int>) n_DrawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z);
			return cb_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z;
		}

		static int n_DrawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5, int p6, int p7, int p8, IntPtr native_p9, bool p10)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.DefaultRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.Graphics.Paint p9 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p9, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DrawLegend (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawLegend' and count(parameter)=11 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.renderer.DefaultRenderer'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='android.graphics.Paint'] and parameter[11][@type='boolean']]"
		[Register ("drawLegend", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/DefaultRenderer;[Ljava/lang/String;IIIIIILandroid/graphics/Paint;Z)I", "GetDrawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_ZHandler")]
		protected virtual int DrawLegend (global::Android.Graphics.Canvas p0, global::Org.Achartengine.Renderer.DefaultRenderer p1, string[] p2, int p3, int p4, int p5, int p6, int p7, int p8, global::Android.Graphics.Paint p9, bool p10)
		{
			if (id_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z == IntPtr.Zero)
				id_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z = JNIEnv.GetMethodID (class_ref, "drawLegend", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/DefaultRenderer;[Ljava/lang/String;IIIIIILandroid/graphics/Paint;Z)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_drawLegend_Landroid_graphics_Canvas_Lorg_achartengine_renderer_DefaultRenderer_arrayLjava_lang_String_IIIIIILandroid_graphics_Paint_Z, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (p9), new JValue (p10));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawLegend", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/DefaultRenderer;[Ljava/lang/String;IIIIIILandroid/graphics/Paint;Z)I"), new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7), new JValue (p8), new JValue (p9), new JValue (p10));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_Handler ()
		{
			if (cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ == null)
				cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float, int, IntPtr>) n_DrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_);
			return cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
		}

		static void n_DrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3, int p4, IntPtr native_p5)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.DrawLegendShape (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawLegendShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("drawLegendShape", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/SimpleSeriesRenderer;FFILandroid/graphics/Paint;)V", "GetDrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_Handler")]
		public abstract void DrawLegendShape (global::Android.Graphics.Canvas p0, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1, float p2, float p3, int p4, global::Android.Graphics.Paint p5);

		static Delegate cb_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z;
#pragma warning disable 0169
		static Delegate GetDrawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_ZHandler ()
		{
			if (cb_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z == null)
				cb_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_DrawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z);
			return cb_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z;
		}

		static void n_DrawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Android.Graphics.Paint p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DrawPath (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawPath' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float[]'] and parameter[3][@type='android.graphics.Paint'] and parameter[4][@type='boolean']]"
		[Register ("drawPath", "(Landroid/graphics/Canvas;[FLandroid/graphics/Paint;Z)V", "GetDrawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_ZHandler")]
		protected virtual void DrawPath (global::Android.Graphics.Canvas p0, float[] p1, global::Android.Graphics.Paint p2, bool p3)
		{
			if (id_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z == IntPtr.Zero)
				id_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z = JNIEnv.GetMethodID (class_ref, "drawPath", "(Landroid/graphics/Canvas;[FLandroid/graphics/Paint;Z)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawPath_Landroid_graphics_Canvas_arrayFLandroid_graphics_Paint_Z, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawPath", "(Landroid/graphics/Canvas;[FLandroid/graphics/Paint;Z)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z;
#pragma warning disable 0169
		static Delegate GetDrawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_ZHandler ()
		{
			if (cb_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z == null)
				cb_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_DrawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z);
			return cb_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z;
		}

		static void n_DrawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Java.Lang.Float> p1 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DrawPath (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawPath' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.util.List'] and parameter[3][@type='android.graphics.Paint'] and parameter[4][@type='boolean']]"
		[Register ("drawPath", "(Landroid/graphics/Canvas;Ljava/util/List;Landroid/graphics/Paint;Z)V", "GetDrawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_ZHandler")]
		protected virtual void DrawPath (global::Android.Graphics.Canvas p0, global::System.Collections.Generic.IList<global::Java.Lang.Float> p1, global::Android.Graphics.Paint p2, bool p3)
		{
			if (id_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z == IntPtr.Zero)
				id_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z = JNIEnv.GetMethodID (class_ref, "drawPath", "(Landroid/graphics/Canvas;Ljava/util/List;Landroid/graphics/Paint;Z)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawPath_Landroid_graphics_Canvas_Ljava_util_List_Landroid_graphics_Paint_Z, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawPath", "(Landroid/graphics/Canvas;Ljava/util/List;Landroid/graphics/Paint;Z)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_Handler ()
		{
			if (cb_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_ == null)
				cb_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr>) n_DrawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_);
			return cb_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_;
		}

		static void n_DrawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3, IntPtr native_p4)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DrawString (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawString' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.Paint']]"
		[Register ("drawString", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;)V", "GetDrawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_Handler")]
		protected virtual void DrawString (global::Android.Graphics.Canvas p0, string p1, float p2, float p3, global::Android.Graphics.Paint p4)
		{
			if (id_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_ == IntPtr.Zero)
				id_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawString", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawString_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawString", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II;
#pragma warning disable 0169
		static Delegate GetGetExceed_FLorg_achartengine_renderer_DefaultRenderer_IIHandler ()
		{
			if (cb_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II == null)
				cb_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, int, int, bool>) n_GetExceed_FLorg_achartengine_renderer_DefaultRenderer_II);
			return cb_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II;
		}

		static bool n_GetExceed_FLorg_achartengine_renderer_DefaultRenderer_II (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1, int p2, int p3)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.DefaultRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetExceed (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getExceed' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='org.achartengine.renderer.DefaultRenderer'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getExceed", "(FLorg/achartengine/renderer/DefaultRenderer;II)Z", "GetGetExceed_FLorg_achartengine_renderer_DefaultRenderer_IIHandler")]
		protected virtual bool GetExceed (float p0, global::Org.Achartengine.Renderer.DefaultRenderer p1, int p2, int p3)
		{
			if (id_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II == IntPtr.Zero)
				id_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II = JNIEnv.GetMethodID (class_ref, "getExceed", "(FLorg/achartengine/renderer/DefaultRenderer;II)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getExceed_FLorg_achartengine_renderer_DefaultRenderer_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExceed", "(FLorg/achartengine/renderer/DefaultRenderer;II)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_getLabel_Ljava_text_NumberFormat_D;
#pragma warning disable 0169
		static Delegate GetGetLabel_Ljava_text_NumberFormat_DHandler ()
		{
			if (cb_getLabel_Ljava_text_NumberFormat_D == null)
				cb_getLabel_Ljava_text_NumberFormat_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double, IntPtr>) n_GetLabel_Ljava_text_NumberFormat_D);
			return cb_getLabel_Ljava_text_NumberFormat_D;
		}

		static IntPtr n_GetLabel_Ljava_text_NumberFormat_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Text.NumberFormat p0 = global::Java.Lang.Object.GetObject<global::Java.Text.NumberFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLabel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel_Ljava_text_NumberFormat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getLabel' and count(parameter)=2 and parameter[1][@type='java.text.NumberFormat'] and parameter[2][@type='double']]"
		[Register ("getLabel", "(Ljava/text/NumberFormat;D)Ljava/lang/String;", "GetGetLabel_Ljava_text_NumberFormat_DHandler")]
		protected virtual string GetLabel (global::Java.Text.NumberFormat p0, double p1)
		{
			if (id_getLabel_Ljava_text_NumberFormat_D == IntPtr.Zero)
				id_getLabel_Ljava_text_NumberFormat_D = JNIEnv.GetMethodID (class_ref, "getLabel", "(Ljava/text/NumberFormat;D)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel_Ljava_text_NumberFormat_D, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "(Ljava/text/NumberFormat;D)Ljava/lang/String;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getLegendShapeWidth_I;
#pragma warning disable 0169
		static Delegate GetGetLegendShapeWidth_IHandler ()
		{
			if (cb_getLegendShapeWidth_I == null)
				cb_getLegendShapeWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetLegendShapeWidth_I);
			return cb_getLegendShapeWidth_I;
		}

		static int n_GetLegendShapeWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLegendShapeWidth (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getLegendShapeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLegendShapeWidth", "(I)I", "GetGetLegendShapeWidth_IHandler")]
		public abstract int GetLegendShapeWidth (int p0);

		static Delegate cb_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF;
#pragma warning disable 0169
		static Delegate GetGetLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IFHandler ()
		{
			if (cb_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF == null)
				cb_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, int>) n_GetLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF);
			return cb_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF;
		}

		static int n_GetLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.DefaultRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetLegendSize (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getLegendSize' and count(parameter)=3 and parameter[1][@type='org.achartengine.renderer.DefaultRenderer'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("getLegendSize", "(Lorg/achartengine/renderer/DefaultRenderer;IF)I", "GetGetLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IFHandler")]
		protected virtual int GetLegendSize (global::Org.Achartengine.Renderer.DefaultRenderer p0, int p1, float p2)
		{
			if (id_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF == IntPtr.Zero)
				id_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF = JNIEnv.GetMethodID (class_ref, "getLegendSize", "(Lorg/achartengine/renderer/DefaultRenderer;IF)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getLegendSize_Lorg_achartengine_renderer_DefaultRenderer_IF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLegendSize", "(Lorg/achartengine/renderer/DefaultRenderer;IF)I"), new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_;
#pragma warning disable 0169
		static Delegate GetGetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_Handler ()
		{
			if (cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ == null)
				cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_);
			return cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_;
		}

		static IntPtr n_GetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.Point p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSeriesAndPointForScreenCoordinate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getSeriesAndPointForScreenCoordinate' and count(parameter)=1 and parameter[1][@type='org.achartengine.model.Point']]"
		[Register ("getSeriesAndPointForScreenCoordinate", "(Lorg/achartengine/model/Point;)Lorg/achartengine/model/SeriesSelection;", "GetGetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_Handler")]
		public virtual global::Org.Achartengine.Model.SeriesSelection GetSeriesAndPointForScreenCoordinate (global::Org.Achartengine.Model.Point p0)
		{
			if (id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ == IntPtr.Zero)
				id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ = JNIEnv.GetMethodID (class_ref, "getSeriesAndPointForScreenCoordinate", "(Lorg/achartengine/model/Point;)Lorg/achartengine/model/SeriesSelection;");

			global::Org.Achartengine.Model.SeriesSelection __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (JNIEnv.CallObjectMethod  (Handle, id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeriesAndPointForScreenCoordinate", "(Lorg/achartengine/model/Point;)Lorg/achartengine/model/SeriesSelection;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_isNullValue_D;
#pragma warning disable 0169
		static Delegate GetIsNullValue_DHandler ()
		{
			if (cb_isNullValue_D == null)
				cb_isNullValue_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, bool>) n_IsNullValue_D);
			return cb_isNullValue_D;
		}

		static bool n_IsNullValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNullValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isNullValue_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='isNullValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("isNullValue", "(D)Z", "GetIsNullValue_DHandler")]
		public virtual bool IsNullValue (double p0)
		{
			if (id_isNullValue_D == IntPtr.Zero)
				id_isNullValue_D = JNIEnv.GetMethodID (class_ref, "isNullValue", "(D)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isNullValue_D, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNullValue", "(D)Z"), new JValue (p0));
		}

		static Delegate cb_isVertical_Lorg_achartengine_renderer_DefaultRenderer_;
#pragma warning disable 0169
		static Delegate GetIsVertical_Lorg_achartengine_renderer_DefaultRenderer_Handler ()
		{
			if (cb_isVertical_Lorg_achartengine_renderer_DefaultRenderer_ == null)
				cb_isVertical_Lorg_achartengine_renderer_DefaultRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsVertical_Lorg_achartengine_renderer_DefaultRenderer_);
			return cb_isVertical_Lorg_achartengine_renderer_DefaultRenderer_;
		}

		static bool n_IsVertical_Lorg_achartengine_renderer_DefaultRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.AbstractChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.DefaultRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsVertical (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isVertical_Lorg_achartengine_renderer_DefaultRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='isVertical' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.DefaultRenderer']]"
		[Register ("isVertical", "(Lorg/achartengine/renderer/DefaultRenderer;)Z", "GetIsVertical_Lorg_achartengine_renderer_DefaultRenderer_Handler")]
		public virtual bool IsVertical (global::Org.Achartengine.Renderer.DefaultRenderer p0)
		{
			if (id_isVertical_Lorg_achartengine_renderer_DefaultRenderer_ == IntPtr.Zero)
				id_isVertical_Lorg_achartengine_renderer_DefaultRenderer_ = JNIEnv.GetMethodID (class_ref, "isVertical", "(Lorg/achartengine/renderer/DefaultRenderer;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isVertical_Lorg_achartengine_renderer_DefaultRenderer_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVertical", "(Lorg/achartengine/renderer/DefaultRenderer;)Z"), new JValue (p0));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("org/achartengine/chart/AbstractChart", DoNotGenerateAcw=true)]
	internal partial class AbstractChartInvoker : AbstractChart {

		public AbstractChartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractChartInvoker); }
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='draw' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_Handler")]
		public override void Draw (global::Android.Graphics.Canvas p0, int p1, int p2, int p3, int p4, global::Android.Graphics.Paint p5)
		{
			if (id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V");
			JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawLegendShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("drawLegendShape", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/SimpleSeriesRenderer;FFILandroid/graphics/Paint;)V", "GetDrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_Handler")]
		public override void DrawLegendShape (global::Android.Graphics.Canvas p0, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1, float p2, float p3, int p4, global::Android.Graphics.Paint p5)
		{
			if (id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ == IntPtr.Zero)
				id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawLegendShape", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/SimpleSeriesRenderer;FFILandroid/graphics/Paint;)V");
			JNIEnv.CallVoidMethod  (Handle, id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_getLegendShapeWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getLegendShapeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLegendShapeWidth", "(I)I", "GetGetLegendShapeWidth_IHandler")]
		public override int GetLegendShapeWidth (int p0)
		{
			if (id_getLegendShapeWidth_I == IntPtr.Zero)
				id_getLegendShapeWidth_I = JNIEnv.GetMethodID (class_ref, "getLegendShapeWidth", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_getLegendShapeWidth_I, new JValue (p0));
		}

	}

}
