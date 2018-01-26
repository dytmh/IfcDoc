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


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("0f3a3c99-280c-4438-bec8-7d0531fe8b72")]
	public partial class IfcDimensionalExponents
	{
		[DataMember(Order=0)] 
		[Required()]
		Int64 _LengthExponent;
	
		[DataMember(Order=1)] 
		[Required()]
		Int64 _MassExponent;
	
		[DataMember(Order=2)] 
		[Required()]
		Int64 _TimeExponent;
	
		[DataMember(Order=3)] 
		[Required()]
		Int64 _ElectricCurrentExponent;
	
		[DataMember(Order=4)] 
		[Required()]
		Int64 _ThermodynamicTemperatureExponent;
	
		[DataMember(Order=5)] 
		[Required()]
		Int64 _AmountOfSubstanceExponent;
	
		[DataMember(Order=6)] 
		[Required()]
		Int64 _LuminousIntensityExponent;
	
	
		public IfcDimensionalExponents()
		{
		}
	
		public IfcDimensionalExponents(Int64 __LengthExponent, Int64 __MassExponent, Int64 __TimeExponent, Int64 __ElectricCurrentExponent, Int64 __ThermodynamicTemperatureExponent, Int64 __AmountOfSubstanceExponent, Int64 __LuminousIntensityExponent)
		{
			this._LengthExponent = __LengthExponent;
			this._MassExponent = __MassExponent;
			this._TimeExponent = __TimeExponent;
			this._ElectricCurrentExponent = __ElectricCurrentExponent;
			this._ThermodynamicTemperatureExponent = __ThermodynamicTemperatureExponent;
			this._AmountOfSubstanceExponent = __AmountOfSubstanceExponent;
			this._LuminousIntensityExponent = __LuminousIntensityExponent;
		}
	
		[Description("The power of the length base quantity.")]
		public Int64 LengthExponent { get { return this._LengthExponent; } set { this._LengthExponent = value;} }
	
		[Description("The power of the mass base quantity.")]
		public Int64 MassExponent { get { return this._MassExponent; } set { this._MassExponent = value;} }
	
		[Description("The power of the time base quantity.")]
		public Int64 TimeExponent { get { return this._TimeExponent; } set { this._TimeExponent = value;} }
	
		[Description("The power of the electric current base quantity.")]
		public Int64 ElectricCurrentExponent { get { return this._ElectricCurrentExponent; } set { this._ElectricCurrentExponent = value;} }
	
		[Description("The power of the thermodynamic temperature base quantity.")]
		public Int64 ThermodynamicTemperatureExponent { get { return this._ThermodynamicTemperatureExponent; } set { this._ThermodynamicTemperatureExponent = value;} }
	
		[Description("The power of the amount of substance base quantity.")]
		public Int64 AmountOfSubstanceExponent { get { return this._AmountOfSubstanceExponent; } set { this._AmountOfSubstanceExponent = value;} }
	
		[Description("The power of the luminous intensity base quantity.")]
		public Int64 LuminousIntensityExponent { get { return this._LuminousIntensityExponent; } set { this._LuminousIntensityExponent = value;} }
	
	
	}
	
}
