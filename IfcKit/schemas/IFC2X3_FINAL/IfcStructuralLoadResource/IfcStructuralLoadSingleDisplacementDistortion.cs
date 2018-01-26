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

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("9189056f-f8cf-48d3-b5d7-a24b64c69c3b")]
	public partial class IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcCurvatureMeasure? _Distortion;
	
	
		public IfcStructuralLoadSingleDisplacementDistortion()
		{
		}
	
		public IfcStructuralLoadSingleDisplacementDistortion(IfcLabel? __Name, IfcLengthMeasure? __DisplacementX, IfcLengthMeasure? __DisplacementY, IfcLengthMeasure? __DisplacementZ, IfcPlaneAngleMeasure? __RotationalDisplacementRX, IfcPlaneAngleMeasure? __RotationalDisplacementRY, IfcPlaneAngleMeasure? __RotationalDisplacementRZ, IfcCurvatureMeasure? __Distortion)
			: base(__Name, __DisplacementX, __DisplacementY, __DisplacementZ, __RotationalDisplacementRX, __RotationalDisplacementRY, __RotationalDisplacementRZ)
		{
			this._Distortion = __Distortion;
		}
	
		[Description("The distortion curvature given to the displacement load.")]
		public IfcCurvatureMeasure? Distortion { get { return this._Distortion; } set { this._Distortion = value;} }
	
	
	}
	
}
