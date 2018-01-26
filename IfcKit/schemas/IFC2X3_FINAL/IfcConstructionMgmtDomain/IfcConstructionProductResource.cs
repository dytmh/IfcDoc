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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcConstructionMgmtDomain
{
	[Guid("77890ca9-5e99-4f7c-9ebb-4302d7237001")]
	public partial class IfcConstructionProductResource : IfcConstructionResource
	{
	
		public IfcConstructionProductResource()
		{
		}
	
		public IfcConstructionProductResource(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcIdentifier? __ResourceIdentifier, IfcLabel? __ResourceGroup, IfcResourceConsumptionEnum? __ResourceConsumption, IfcMeasureWithUnit __BaseQuantity)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType, __ResourceIdentifier, __ResourceGroup, __ResourceConsumption, __BaseQuantity)
		{
		}
	
	
	}
	
}
