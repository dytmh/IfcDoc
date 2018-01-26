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

namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("1997b32d-790a-4488-891c-8cff062001ca")]
	public partial class IfcProductRepresentation
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcLabel? _Name;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcText? _Description;
	
		[DataMember(Order=2)] 
		[Required()]
		[MinLength(1)]
		IList<IfcRepresentation> _Representations = new List<IfcRepresentation>();
	
	
		public IfcProductRepresentation()
		{
		}
	
		public IfcProductRepresentation(IfcLabel? __Name, IfcText? __Description, IfcRepresentation[] __Representations)
		{
			this._Name = __Name;
			this._Description = __Description;
			this._Representations = new List<IfcRepresentation>(__Representations);
		}
	
		[Description("The word or group of words by which the product representation is known.")]
		public IfcLabel? Name { get { return this._Name; } set { this._Name = value;} }
	
		[Description("The word or group of words that characterize the product representation. It can b" +
	    "e used to add additional meaning to the name of the product representation.")]
		public IfcText? Description { get { return this._Description; } set { this._Description = value;} }
	
		[Description("Contained list of representations (including shape representations). Each member " +
	    "defines a valid representation of a particular type within a particular represen" +
	    "tation context.")]
		public IList<IfcRepresentation> Representations { get { return this._Representations; } }
	
	
	}
	
}
