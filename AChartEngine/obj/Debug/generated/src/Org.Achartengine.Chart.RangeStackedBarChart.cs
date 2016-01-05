using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RangeStackedBarChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/RangeStackedBarChart", DoNotGenerateAcw=true)]
	public partial class RangeStackedBarChart : global::Org.Achartengine.Chart.RangeBarChart {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RangeStackedBarChart']/field[@name='TYPE']"
		[Register ("TYPE")]
		public const string Type = (string) "RangeStackedBar";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/RangeStackedBarChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RangeStackedBarChart); }
		}

		protected RangeStackedBarChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
