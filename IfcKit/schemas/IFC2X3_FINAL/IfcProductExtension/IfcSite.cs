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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("5183c1e5-7105-4f4e-9386-5365aa3cd4e2")]
	public partial class IfcSite : IfcSpatialStructureElement
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcCompoundPlaneAngleMeasure? _RefLatitude;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcCompoundPlaneAngleMeasure? _RefLongitude;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLengthMeasure? _RefElevation;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcLabel? _LandTitleNumber;
	
		[DataMember(Order=4)] 
		IfcPostalAddress _SiteAddress;
	
	
		public IfcSite()
		{
		}
	
		public IfcSite(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcObjectPlacement __ObjectPlacement, IfcProductRepresentation __Representation, IfcLabel? __LongName, IfcElementCompositionEnum __CompositionType, IfcCompoundPlaneAngleMeasure? __RefLatitude, IfcCompoundPlaneAngleMeasure? __RefLongitude, IfcLengthMeasure? __RefElevation, IfcLabel? __LandTitleNumber, IfcPostalAddress __SiteAddress)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType, __ObjectPlacement, __Representation, __LongName, __CompositionType)
		{
			this._RefLatitude = __RefLatitude;
			this._RefLongitude = __RefLongitude;
			this._RefElevation = __RefElevation;
			this._LandTitleNumber = __LandTitleNumber;
			this._SiteAddress = __SiteAddress;
		}
	
		[Description(@"<EPM-HTML>
	World Latitude at reference point (most likely defined in legal description). Defined as integer values for degrees, minutes, seconds, and, optionally, millionths of seconds with respect to the world geodetic system WGS84.
	<BLOCKQUOTE> <FONT SIZE=""-1"">Latitudes are measured relative to the geodetic equator, north of the equator by positive values - from 0 till +90,   south of the equator by negative values - from 0 till  -90.</FONT></BLOCKQUOTE>
	</EPM-HTML>")]
		public IfcCompoundPlaneAngleMeasure? RefLatitude { get { return this._RefLatitude; } set { this._RefLatitude = value;} }
	
		[Description(@"<EPM-HTML>
	World Longitude at reference point (most likely defined in legal description). Defined as integer values for degrees, minutes, seconds, and, optionally, millionths of seconds with respect to the world geodetic system WGS84.
	<BLOCKQUOTE> <FONT SIZE=""-1"">Longitudes are measured relative to the geodetic zero meridian, nominally the same as the Greenwich prime meridian: longitudes west of the zero meridian have positive values - from 0 till +180, longitudes east of the zero meridian have negative values - from 0 till -180.</FONT></BLOCKQUOTE>
	</EPM-HTML>")]
		public IfcCompoundPlaneAngleMeasure? RefLongitude { get { return this._RefLongitude; } set { this._RefLongitude = value;} }
	
		[Description("Datum elevation relative to sea level.\r\n")]
		public IfcLengthMeasure? RefElevation { get { return this._RefElevation; } set { this._RefElevation = value;} }
	
		[Description("The land title number (designation of the site within a regional system).")]
		public IfcLabel? LandTitleNumber { get { return this._LandTitleNumber; } set { this._LandTitleNumber = value;} }
	
		[Description("Address given to the site for postal purposes.")]
		public IfcPostalAddress SiteAddress { get { return this._SiteAddress; } set { this._SiteAddress = value;} }
	
	
	}
	
}
