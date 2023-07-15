// <auto-generated/>
// Contents of: hl7.fhir.r4b.core version: 4.3.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// The definition and characteristics of a medicinal manufactured item, such as a tablet or capsule, as contained in a packaged medicinal product
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ManufacturedItemDefinition","http://hl7.org/fhir/StructureDefinition/ManufacturedItemDefinition", IsResource=true)]
  public partial class ManufacturedItemDefinition : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ManufacturedItemDefinition"; } }

    /// <summary>
    /// General characteristics of this item
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ManufacturedItemDefinition#Property", IsNestedType=true)]
    [BackboneType("ManufacturedItemDefinition.property")]
    public partial class PropertyComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ManufacturedItemDefinition#Property"; } }

      /// <summary>
      /// A code expressing the type of characteristic
      /// </summary>
      [FhirElement("type", InSummary=true, Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// A value for the characteristic
      /// </summary>
      [FhirElement("value", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.Quantity),typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Attachment))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.DataType _Value;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PropertyComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.DataType)Value.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PropertyComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Type != null) yield return Type;
          if (Value != null) yield return Value;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Type != null) yield return new ElementValue("type", Type);
          if (Value != null) yield return new ElementValue("value", Value);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "type":
            value = Type;
            return Type is not null;
          case "value":
            value = Value;
            return Value is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
        if (Value is not null) yield return new KeyValuePair<string,object>("value",Value);
      }

    }

    /// <summary>
    /// Unique identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100)]
    [DeclaredType(Type = typeof(Code))]
    [Binding("PublicationStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;

    /// <summary>
    /// draft | active | retired | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.PublicationStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Dose form as manufactured (before any necessary transformation)
    /// </summary>
    [FhirElement("manufacturedDoseForm", InSummary=true, Order=110)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept ManufacturedDoseForm
    {
      get { return _ManufacturedDoseForm; }
      set { _ManufacturedDoseForm = value; OnPropertyChanged("ManufacturedDoseForm"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _ManufacturedDoseForm;

    /// <summary>
    /// The “real world” units in which the quantity of the item is described
    /// </summary>
    [FhirElement("unitOfPresentation", InSummary=true, Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept UnitOfPresentation
    {
      get { return _UnitOfPresentation; }
      set { _UnitOfPresentation = value; OnPropertyChanged("UnitOfPresentation"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _UnitOfPresentation;

    /// <summary>
    /// Manufacturer of the item (Note that this should be named "manufacturer" but it currently causes technical issues)
    /// </summary>
    [FhirElement("manufacturer", InSummary=true, Order=130)]
    [CLSCompliant(false)]
    [References("Organization")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Manufacturer
    {
      get { if(_Manufacturer==null) _Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(); return _Manufacturer; }
      set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Manufacturer;

    /// <summary>
    /// The ingredients of this manufactured item. Only needed if these are not specified by incoming references from the Ingredient resource
    /// </summary>
    [FhirElement("ingredient", InSummary=true, Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Ingredient
    {
      get { if(_Ingredient==null) _Ingredient = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Ingredient; }
      set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Ingredient;

    /// <summary>
    /// General characteristics of this item
    /// </summary>
    [FhirElement("property", InSummary=true, Order=150)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ManufacturedItemDefinition.PropertyComponent> Property
    {
      get { if(_Property==null) _Property = new List<Hl7.Fhir.Model.ManufacturedItemDefinition.PropertyComponent>(); return _Property; }
      set { _Property = value; OnPropertyChanged("Property"); }
    }

    private List<Hl7.Fhir.Model.ManufacturedItemDefinition.PropertyComponent> _Property;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ManufacturedItemDefinition;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
      if(ManufacturedDoseForm != null) dest.ManufacturedDoseForm = (Hl7.Fhir.Model.CodeableConcept)ManufacturedDoseForm.DeepCopy();
      if(UnitOfPresentation != null) dest.UnitOfPresentation = (Hl7.Fhir.Model.CodeableConcept)UnitOfPresentation.DeepCopy();
      if(Manufacturer != null) dest.Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(Manufacturer.DeepCopy());
      if(Ingredient != null) dest.Ingredient = new List<Hl7.Fhir.Model.CodeableConcept>(Ingredient.DeepCopy());
      if(Property != null) dest.Property = new List<Hl7.Fhir.Model.ManufacturedItemDefinition.PropertyComponent>(Property.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ManufacturedItemDefinition());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ManufacturedItemDefinition;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
      if( !DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
      if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
      if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.Matches(Property, otherT.Property)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ManufacturedItemDefinition;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
      if( !DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
      if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
      if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
      if( !DeepComparable.IsExactly(Property, otherT.Property)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        if (ManufacturedDoseForm != null) yield return ManufacturedDoseForm;
        if (UnitOfPresentation != null) yield return UnitOfPresentation;
        foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
        foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
        foreach (var elem in Property) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (ManufacturedDoseForm != null) yield return new ElementValue("manufacturedDoseForm", ManufacturedDoseForm);
        if (UnitOfPresentation != null) yield return new ElementValue("unitOfPresentation", UnitOfPresentation);
        foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
        foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
        foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "manufacturedDoseForm":
          value = ManufacturedDoseForm;
          return ManufacturedDoseForm is not null;
        case "unitOfPresentation":
          value = UnitOfPresentation;
          return UnitOfPresentation is not null;
        case "manufacturer":
          value = Manufacturer;
          return Manufacturer?.Any() == true;
        case "ingredient":
          value = Ingredient;
          return Ingredient?.Any() == true;
        case "property":
          value = Property;
          return Property?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (ManufacturedDoseForm is not null) yield return new KeyValuePair<string,object>("manufacturedDoseForm",ManufacturedDoseForm);
      if (UnitOfPresentation is not null) yield return new KeyValuePair<string,object>("unitOfPresentation",UnitOfPresentation);
      if (Manufacturer?.Any() == true) yield return new KeyValuePair<string,object>("manufacturer",Manufacturer);
      if (Ingredient?.Any() == true) yield return new KeyValuePair<string,object>("ingredient",Ingredient);
      if (Property?.Any() == true) yield return new KeyValuePair<string,object>("property",Property);
    }

  }

}

// end of file