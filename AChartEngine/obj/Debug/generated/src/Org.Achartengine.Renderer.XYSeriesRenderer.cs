using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/XYSeriesRenderer", DoNotGenerateAcw=true)]
	public partial class XYSeriesRenderer : global::Org.Achartengine.Renderer.SimpleSeriesRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']"
		[global::Android.Runtime.Register ("org/achartengine/renderer/XYSeriesRenderer$FillOutsideLine", DoNotGenerateAcw=true)]
		public partial class FillOutsideLine : global::Java.Lang.Object, global::Java.IO.ISerializable {

			// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']"
			[global::Android.Runtime.Register ("org/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type", DoNotGenerateAcw=true)]
			public sealed partial class Type : global::Java.Lang.Enum {


				static IntPtr ABOVE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='ABOVE']"
				[Register ("ABOVE")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type Above {
					get {
						if (ABOVE_jfieldId == IntPtr.Zero)
							ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABOVE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (ABOVE_jfieldId == IntPtr.Zero)
							ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, ABOVE_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr BELOW_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BELOW']"
				[Register ("BELOW")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type Below {
					get {
						if (BELOW_jfieldId == IntPtr.Zero)
							BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BELOW_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (BELOW_jfieldId == IntPtr.Zero)
							BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, BELOW_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr BOUNDS_ABOVE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BOUNDS_ABOVE']"
				[Register ("BOUNDS_ABOVE")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type BoundsAbove {
					get {
						if (BOUNDS_ABOVE_jfieldId == IntPtr.Zero)
							BOUNDS_ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDS_ABOVE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (BOUNDS_ABOVE_jfieldId == IntPtr.Zero)
							BOUNDS_ABOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ABOVE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, BOUNDS_ABOVE_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr BOUNDS_ALL_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BOUNDS_ALL']"
				[Register ("BOUNDS_ALL")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type BoundsAll {
					get {
						if (BOUNDS_ALL_jfieldId == IntPtr.Zero)
							BOUNDS_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ALL", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDS_ALL_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (BOUNDS_ALL_jfieldId == IntPtr.Zero)
							BOUNDS_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_ALL", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, BOUNDS_ALL_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr BOUNDS_BELOW_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='BOUNDS_BELOW']"
				[Register ("BOUNDS_BELOW")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type BoundsBelow {
					get {
						if (BOUNDS_BELOW_jfieldId == IntPtr.Zero)
							BOUNDS_BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDS_BELOW_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (BOUNDS_BELOW_jfieldId == IntPtr.Zero)
							BOUNDS_BELOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDS_BELOW", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, BOUNDS_BELOW_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}

				static IntPtr NONE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/field[@name='NONE']"
				[Register ("NONE")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type None {
					get {
						if (NONE_jfieldId == IntPtr.Zero)
							NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (NONE_jfieldId == IntPtr.Zero)
							NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
						IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
						JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("org/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Type); }
				}

				internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;", "")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					JNIEnv.DeleteLocalRef (native_p0);
					return __ret;
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;", "")]
				public static global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");
					return (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type));
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/achartengine/renderer/XYSeriesRenderer$FillOutsideLine", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FillOutsideLine); }
			}

			protected FillOutsideLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Type_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/constructor[@name='XYSeriesRenderer.FillOutsideLine' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.XYSeriesRenderer.FillOutsideLine.Type']]"
			[Register (".ctor", "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;)V", "")]
			public FillOutsideLine (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (FillOutsideLine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Type_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Type_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Type_, new JValue (p0));
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
				global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Color = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getColor;
			static IntPtr id_setColor_I;
			public virtual int Color {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/method[@name='getColor' and count(parameter)=0]"
				[Register ("getColor", "()I", "GetGetColorHandler")]
				get {
					if (id_getColor == IntPtr.Zero)
						id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
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

			static Delegate cb_GetTypes;
#pragma warning disable 0169
			static Delegate GetGetTypesHandler ()
			{
				if (cb_GetTypes == null)
					cb_GetTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypes);
				return cb_GetTypes;
			}

			static IntPtr n_GetTypes (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Types);
			}
#pragma warning restore 0169

			static IntPtr id_GetTypes;
			public virtual global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type Types {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/method[@name='GetTypes' and count(parameter)=0]"
				[Register ("GetTypes", "()Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;", "GetGetTypesHandler")]
				get {
					if (id_GetTypes == IntPtr.Zero)
						id_GetTypes = JNIEnv.GetMethodID (class_ref, "GetTypes", "()Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (JNIEnv.CallObjectMethod  (Handle, id_GetTypes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTypes", "()Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine$Type;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getFillRange;
#pragma warning disable 0169
			static Delegate GetGetFillRangeHandler ()
			{
				if (cb_getFillRange == null)
					cb_getFillRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillRange);
				return cb_getFillRange;
			}

			static IntPtr n_GetFillRange (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetFillRange ());
			}
#pragma warning restore 0169

			static IntPtr id_getFillRange;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/method[@name='getFillRange' and count(parameter)=0]"
			[Register ("getFillRange", "()[I", "GetGetFillRangeHandler")]
			public virtual int[] GetFillRange ()
			{
				if (id_getFillRange == IntPtr.Zero)
					id_getFillRange = JNIEnv.GetMethodID (class_ref, "getFillRange", "()[I");

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getFillRange), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillRange", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			}

			static Delegate cb_setFillRange_arrayI;
#pragma warning disable 0169
			static Delegate GetSetFillRange_arrayIHandler ()
			{
				if (cb_setFillRange_arrayI == null)
					cb_setFillRange_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillRange_arrayI);
				return cb_setFillRange_arrayI;
			}

			static void n_SetFillRange_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.SetFillRange (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_setFillRange_arrayI;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/method[@name='setFillRange' and count(parameter)=1 and parameter[1][@type='int[]']]"
			[Register ("setFillRange", "([I)V", "GetSetFillRange_arrayIHandler")]
			public virtual void SetFillRange (int[] p0)
			{
				if (id_setFillRange_arrayI == IntPtr.Zero)
					id_setFillRange_arrayI = JNIEnv.GetMethodID (class_ref, "setFillRange", "([I)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillRange_arrayI, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillRange", "([I)V"), new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/XYSeriesRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYSeriesRenderer); }
		}

		protected XYSeriesRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/constructor[@name='XYSeriesRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public XYSeriesRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (XYSeriesRenderer)) {
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

		static Delegate cb_isFillBelowLine;
#pragma warning disable 0169
		static Delegate GetIsFillBelowLineHandler ()
		{
			if (cb_isFillBelowLine == null)
				cb_isFillBelowLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFillBelowLine);
			return cb_isFillBelowLine;
		}

		static bool n_IsFillBelowLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillBelowLine;
		}
#pragma warning restore 0169

		static Delegate cb_setFillBelowLine_Z;
#pragma warning disable 0169
		static Delegate GetSetFillBelowLine_ZHandler ()
		{
			if (cb_setFillBelowLine_Z == null)
				cb_setFillBelowLine_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFillBelowLine_Z);
			return cb_setFillBelowLine_Z;
		}

		static void n_SetFillBelowLine_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillBelowLine = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFillBelowLine;
		static IntPtr id_setFillBelowLine_Z;
		[Obsolete (@"deprecated")]
		public virtual bool FillBelowLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='isFillBelowLine' and count(parameter)=0]"
			[Register ("isFillBelowLine", "()Z", "GetIsFillBelowLineHandler")]
			get {
				if (id_isFillBelowLine == IntPtr.Zero)
					id_isFillBelowLine = JNIEnv.GetMethodID (class_ref, "isFillBelowLine", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFillBelowLine);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFillBelowLine", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillBelowLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFillBelowLine", "(Z)V", "GetSetFillBelowLine_ZHandler")]
			set {
				if (id_setFillBelowLine_Z == IntPtr.Zero)
					id_setFillBelowLine_Z = JNIEnv.GetMethodID (class_ref, "setFillBelowLine", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillBelowLine_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillBelowLine", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isFillPoints;
#pragma warning disable 0169
		static Delegate GetIsFillPointsHandler ()
		{
			if (cb_isFillPoints == null)
				cb_isFillPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFillPoints);
			return cb_isFillPoints;
		}

		static bool n_IsFillPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillPoints;
		}
#pragma warning restore 0169

		static Delegate cb_setFillPoints_Z;
#pragma warning disable 0169
		static Delegate GetSetFillPoints_ZHandler ()
		{
			if (cb_setFillPoints_Z == null)
				cb_setFillPoints_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFillPoints_Z);
			return cb_setFillPoints_Z;
		}

		static void n_SetFillPoints_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillPoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFillPoints;
		static IntPtr id_setFillPoints_Z;
		public virtual bool FillPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='isFillPoints' and count(parameter)=0]"
			[Register ("isFillPoints", "()Z", "GetIsFillPointsHandler")]
			get {
				if (id_isFillPoints == IntPtr.Zero)
					id_isFillPoints = JNIEnv.GetMethodID (class_ref, "isFillPoints", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFillPoints);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFillPoints", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillPoints' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFillPoints", "(Z)V", "GetSetFillPoints_ZHandler")]
			set {
				if (id_setFillPoints_Z == IntPtr.Zero)
					id_setFillPoints_Z = JNIEnv.GetMethodID (class_ref, "setFillPoints", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillPoints_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillPoints", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getLineWidth;
#pragma warning disable 0169
		static Delegate GetGetLineWidthHandler ()
		{
			if (cb_getLineWidth == null)
				cb_getLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLineWidth);
			return cb_getLineWidth;
		}

		static float n_GetLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLineWidth;
		static IntPtr id_setLineWidth_F;
		public virtual float LineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getLineWidth' and count(parameter)=0]"
			[Register ("getLineWidth", "()F", "GetGetLineWidthHandler")]
			get {
				if (id_getLineWidth == IntPtr.Zero)
					id_getLineWidth = JNIEnv.GetMethodID (class_ref, "getLineWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLineWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineWidth", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
			set {
				if (id_setLineWidth_F == IntPtr.Zero)
					id_setLineWidth_F = JNIEnv.GetMethodID (class_ref, "setLineWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLineWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineWidth", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getPointStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetPointStrokeWidthHandler ()
		{
			if (cb_getPointStrokeWidth == null)
				cb_getPointStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPointStrokeWidth);
			return cb_getPointStrokeWidth;
		}

		static float n_GetPointStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointStrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setPointStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetPointStrokeWidth_FHandler ()
		{
			if (cb_setPointStrokeWidth_F == null)
				cb_setPointStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPointStrokeWidth_F);
			return cb_setPointStrokeWidth_F;
		}

		static void n_SetPointStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PointStrokeWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPointStrokeWidth;
		static IntPtr id_setPointStrokeWidth_F;
		public virtual float PointStrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getPointStrokeWidth' and count(parameter)=0]"
			[Register ("getPointStrokeWidth", "()F", "GetGetPointStrokeWidthHandler")]
			get {
				if (id_getPointStrokeWidth == IntPtr.Zero)
					id_getPointStrokeWidth = JNIEnv.GetMethodID (class_ref, "getPointStrokeWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getPointStrokeWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointStrokeWidth", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setPointStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPointStrokeWidth", "(F)V", "GetSetPointStrokeWidth_FHandler")]
			set {
				if (id_setPointStrokeWidth_F == IntPtr.Zero)
					id_setPointStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setPointStrokeWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPointStrokeWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPointStrokeWidth", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getPointStyle;
#pragma warning disable 0169
		static Delegate GetGetPointStyleHandler ()
		{
			if (cb_getPointStyle == null)
				cb_getPointStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointStyle);
			return cb_getPointStyle;
		}

		static IntPtr n_GetPointStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setPointStyle_Lorg_achartengine_chart_PointStyle_;
#pragma warning disable 0169
		static Delegate GetSetPointStyle_Lorg_achartengine_chart_PointStyle_Handler ()
		{
			if (cb_setPointStyle_Lorg_achartengine_chart_PointStyle_ == null)
				cb_setPointStyle_Lorg_achartengine_chart_PointStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPointStyle_Lorg_achartengine_chart_PointStyle_);
			return cb_setPointStyle_Lorg_achartengine_chart_PointStyle_;
		}

		static void n_SetPointStyle_Lorg_achartengine_chart_PointStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Chart.PointStyle p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PointStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPointStyle;
		static IntPtr id_setPointStyle_Lorg_achartengine_chart_PointStyle_;
		public virtual global::Org.Achartengine.Chart.PointStyle PointStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getPointStyle' and count(parameter)=0]"
			[Register ("getPointStyle", "()Lorg/achartengine/chart/PointStyle;", "GetGetPointStyleHandler")]
			get {
				if (id_getPointStyle == IntPtr.Zero)
					id_getPointStyle = JNIEnv.GetMethodID (class_ref, "getPointStyle", "()Lorg/achartengine/chart/PointStyle;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallObjectMethod  (Handle, id_getPointStyle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointStyle", "()Lorg/achartengine/chart/PointStyle;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setPointStyle' and count(parameter)=1 and parameter[1][@type='org.achartengine.chart.PointStyle']]"
			[Register ("setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V", "GetSetPointStyle_Lorg_achartengine_chart_PointStyle_Handler")]
			set {
				if (id_setPointStyle_Lorg_achartengine_chart_PointStyle_ == IntPtr.Zero)
					id_setPointStyle_Lorg_achartengine_chart_PointStyle_ = JNIEnv.GetMethodID (class_ref, "setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPointStyle_Lorg_achartengine_chart_PointStyle_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V"), new JValue (value));
			}
		}

		static Delegate cb_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_;
#pragma warning disable 0169
		static Delegate GetAddFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Handler ()
		{
			if (cb_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_ == null)
				cb_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_);
			return cb_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_;
		}

		static void n_AddFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFillOutsideLine (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='addFillOutsideLine' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.XYSeriesRenderer.FillOutsideLine']]"
		[Register ("addFillOutsideLine", "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine;)V", "GetAddFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_Handler")]
		public virtual void AddFillOutsideLine (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine p0)
		{
			if (id_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_ == IntPtr.Zero)
				id_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_ = JNIEnv.GetMethodID (class_ref, "addFillOutsideLine", "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addFillOutsideLine_Lorg_achartengine_renderer_XYSeriesRenderer_FillOutsideLine_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFillOutsideLine", "(Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine;)V"), new JValue (p0));
		}

		static Delegate cb_getFillOutsideLine;
#pragma warning disable 0169
		static Delegate GetGetFillOutsideLineHandler ()
		{
			if (cb_getFillOutsideLine == null)
				cb_getFillOutsideLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillOutsideLine);
			return cb_getFillOutsideLine;
		}

		static IntPtr n_GetFillOutsideLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFillOutsideLine ());
		}
#pragma warning restore 0169

		static IntPtr id_getFillOutsideLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getFillOutsideLine' and count(parameter)=0]"
		[Register ("getFillOutsideLine", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine;", "GetGetFillOutsideLineHandler")]
		public virtual global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine[] GetFillOutsideLine ()
		{
			if (id_getFillOutsideLine == IntPtr.Zero)
				id_getFillOutsideLine = JNIEnv.GetMethodID (class_ref, "getFillOutsideLine", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine;");

			if (GetType () == ThresholdType)
				return (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getFillOutsideLine), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine));
			else
				return (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillOutsideLine", "()[Lorg/achartengine/renderer/XYSeriesRenderer$FillOutsideLine;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.XYSeriesRenderer.FillOutsideLine));
		}

		static Delegate cb_setFillBelowLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillBelowLineColor_IHandler ()
		{
			if (cb_setFillBelowLineColor_I == null)
				cb_setFillBelowLineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillBelowLineColor_I);
			return cb_setFillBelowLineColor_I;
		}

		static void n_SetFillBelowLineColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFillBelowLineColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFillBelowLineColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillBelowLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFillBelowLineColor", "(I)V", "GetSetFillBelowLineColor_IHandler")]
		public virtual void SetFillBelowLineColor (int p0)
		{
			if (id_setFillBelowLineColor_I == IntPtr.Zero)
				id_setFillBelowLineColor_I = JNIEnv.GetMethodID (class_ref, "setFillBelowLineColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFillBelowLineColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillBelowLineColor", "(I)V"), new JValue (p0));
		}

	}
}
