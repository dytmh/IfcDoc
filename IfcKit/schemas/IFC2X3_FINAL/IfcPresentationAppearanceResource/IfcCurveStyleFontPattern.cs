// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("b60da0c0-6bac-421c-8fa9-1641c7e78f6b")]
	public partial class IfcCurveStyleFontPattern
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLengthMeasure _VisibleSegmentLength;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _InvisibleSegmentLength;
	
	
		public IfcCurveStyleFontPattern()
		{
		}
	
		public IfcCurveStyleFontPattern(IfcLengthMeasure __VisibleSegmentLength, IfcPositiveLengthMeasure __InvisibleSegmentLength)
		{
			this._VisibleSegmentLength = __VisibleSegmentLength;
			this._InvisibleSegmentLength = __InvisibleSegmentLength;
		}
	
		[Description(@"<EPM-HTML>
	The length of the visible segment in the pattern definition.
	<blockquote><small>
	  NOTE&nbsp; For a visible segment representing a point, the value 0. should be assigned.<br>
	<font color=""#FF0000"">
	  IFC2x Edition 3 CHANGE&nbsp; The datatype has been changed to IfcLengthMeasure with upward compatibility for file-based exchange.
	</font></small></blockquote>
	</EPM-HTML>")]
		public IfcLengthMeasure VisibleSegmentLength { get { return this._VisibleSegmentLength; } set { this._VisibleSegmentLength = value;} }
	
		[Description("The length of the invisible segment in the pattern definition.")]
		public IfcPositiveLengthMeasure InvisibleSegmentLength { get { return this._InvisibleSegmentLength; } set { this._InvisibleSegmentLength = value;} }
	
	
	}
	
}
