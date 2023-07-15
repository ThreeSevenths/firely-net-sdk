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
  /// Guidance or advice relating to an immunization
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ImmunizationRecommendation","http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation", IsResource=true)]
  public partial class ImmunizationRecommendation : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ImmunizationRecommendation"; } }

    /// <summary>
    /// Vaccine administration recommendations
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ImmunizationRecommendation#Recommendation", IsNestedType=true)]
    [BackboneType("ImmunizationRecommendation.recommendation")]
    public partial class RecommendationComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ImmunizationRecommendation#Recommendation"; } }

      /// <summary>
      /// Vaccine  or vaccine group recommendation applies to
      /// </summary>
      [FhirElement("vaccineCode", InSummary=true, Order=40)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> VaccineCode
      {
        get { if(_VaccineCode==null) _VaccineCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _VaccineCode; }
        set { _VaccineCode = value; OnPropertyChanged("VaccineCode"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _VaccineCode;

      /// <summary>
      /// Disease to be immunized against
      /// </summary>
      [FhirElement("targetDisease", InSummary=true, Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept TargetDisease
      {
        get { return _TargetDisease; }
        set { _TargetDisease = value; OnPropertyChanged("TargetDisease"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _TargetDisease;

      /// <summary>
      /// Vaccine which is contraindicated to fulfill the recommendation
      /// </summary>
      [FhirElement("contraindicatedVaccineCode", InSummary=true, Order=60)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> ContraindicatedVaccineCode
      {
        get { if(_ContraindicatedVaccineCode==null) _ContraindicatedVaccineCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ContraindicatedVaccineCode; }
        set { _ContraindicatedVaccineCode = value; OnPropertyChanged("ContraindicatedVaccineCode"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _ContraindicatedVaccineCode;

      /// <summary>
      /// Vaccine recommendation status
      /// </summary>
      [FhirElement("forecastStatus", InSummary=true, IsModifier=true, Order=70)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept ForecastStatus
      {
        get { return _ForecastStatus; }
        set { _ForecastStatus = value; OnPropertyChanged("ForecastStatus"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _ForecastStatus;

      /// <summary>
      /// Vaccine administration status reason
      /// </summary>
      [FhirElement("forecastReason", InSummary=true, Order=80)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.CodeableConcept> ForecastReason
      {
        get { if(_ForecastReason==null) _ForecastReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ForecastReason; }
        set { _ForecastReason = value; OnPropertyChanged("ForecastReason"); }
      }

      private List<Hl7.Fhir.Model.CodeableConcept> _ForecastReason;

      /// <summary>
      /// Dates governing proposed immunization
      /// </summary>
      [FhirElement("dateCriterion", Order=90)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent> DateCriterion
      {
        get { if(_DateCriterion==null) _DateCriterion = new List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent>(); return _DateCriterion; }
        set { _DateCriterion = value; OnPropertyChanged("DateCriterion"); }
      }

      private List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent> _DateCriterion;

      /// <summary>
      /// Protocol details
      /// </summary>
      [FhirElement("description", Order=100)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString DescriptionElement
      {
        get { return _DescriptionElement; }
        set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
      }

      private Hl7.Fhir.Model.FhirString _DescriptionElement;

      /// <summary>
      /// Protocol details
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Description
      {
        get { return DescriptionElement != null ? DescriptionElement.Value : null; }
        set
        {
          if (value == null)
            DescriptionElement = null;
          else
            DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Description");
        }
      }

      /// <summary>
      /// Name of vaccination series
      /// </summary>
      [FhirElement("series", Order=110)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString SeriesElement
      {
        get { return _SeriesElement; }
        set { _SeriesElement = value; OnPropertyChanged("SeriesElement"); }
      }

      private Hl7.Fhir.Model.FhirString _SeriesElement;

      /// <summary>
      /// Name of vaccination series
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Series
      {
        get { return SeriesElement != null ? SeriesElement.Value : null; }
        set
        {
          if (value == null)
            SeriesElement = null;
          else
            SeriesElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Series");
        }
      }

      /// <summary>
      /// Recommended dose number within series
      /// </summary>
      [FhirElement("doseNumber", InSummary=true, Order=120, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.PositiveInt),typeof(Hl7.Fhir.Model.FhirString))]
      [DataMember]
      public Hl7.Fhir.Model.DataType DoseNumber
      {
        get { return _DoseNumber; }
        set { _DoseNumber = value; OnPropertyChanged("DoseNumber"); }
      }

      private Hl7.Fhir.Model.DataType _DoseNumber;

      /// <summary>
      /// Recommended number of doses for immunity
      /// </summary>
      [FhirElement("seriesDoses", Order=130, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.PositiveInt),typeof(Hl7.Fhir.Model.FhirString))]
      [DataMember]
      public Hl7.Fhir.Model.DataType SeriesDoses
      {
        get { return _SeriesDoses; }
        set { _SeriesDoses = value; OnPropertyChanged("SeriesDoses"); }
      }

      private Hl7.Fhir.Model.DataType _SeriesDoses;

      /// <summary>
      /// Past immunizations supporting recommendation
      /// </summary>
      [FhirElement("supportingImmunization", Order=140)]
      [CLSCompliant(false)]
      [References("Immunization","ImmunizationEvaluation")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> SupportingImmunization
      {
        get { if(_SupportingImmunization==null) _SupportingImmunization = new List<Hl7.Fhir.Model.ResourceReference>(); return _SupportingImmunization; }
        set { _SupportingImmunization = value; OnPropertyChanged("SupportingImmunization"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _SupportingImmunization;

      /// <summary>
      /// Patient observations supporting recommendation
      /// </summary>
      [FhirElement("supportingPatientInformation", Order=150)]
      [CLSCompliant(false)]
      [References("Resource")]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.ResourceReference> SupportingPatientInformation
      {
        get { if(_SupportingPatientInformation==null) _SupportingPatientInformation = new List<Hl7.Fhir.Model.ResourceReference>(); return _SupportingPatientInformation; }
        set { _SupportingPatientInformation = value; OnPropertyChanged("SupportingPatientInformation"); }
      }

      private List<Hl7.Fhir.Model.ResourceReference> _SupportingPatientInformation;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as RecommendationComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(VaccineCode != null) dest.VaccineCode = new List<Hl7.Fhir.Model.CodeableConcept>(VaccineCode.DeepCopy());
        if(TargetDisease != null) dest.TargetDisease = (Hl7.Fhir.Model.CodeableConcept)TargetDisease.DeepCopy();
        if(ContraindicatedVaccineCode != null) dest.ContraindicatedVaccineCode = new List<Hl7.Fhir.Model.CodeableConcept>(ContraindicatedVaccineCode.DeepCopy());
        if(ForecastStatus != null) dest.ForecastStatus = (Hl7.Fhir.Model.CodeableConcept)ForecastStatus.DeepCopy();
        if(ForecastReason != null) dest.ForecastReason = new List<Hl7.Fhir.Model.CodeableConcept>(ForecastReason.DeepCopy());
        if(DateCriterion != null) dest.DateCriterion = new List<Hl7.Fhir.Model.ImmunizationRecommendation.DateCriterionComponent>(DateCriterion.DeepCopy());
        if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
        if(SeriesElement != null) dest.SeriesElement = (Hl7.Fhir.Model.FhirString)SeriesElement.DeepCopy();
        if(DoseNumber != null) dest.DoseNumber = (Hl7.Fhir.Model.DataType)DoseNumber.DeepCopy();
        if(SeriesDoses != null) dest.SeriesDoses = (Hl7.Fhir.Model.DataType)SeriesDoses.DeepCopy();
        if(SupportingImmunization != null) dest.SupportingImmunization = new List<Hl7.Fhir.Model.ResourceReference>(SupportingImmunization.DeepCopy());
        if(SupportingPatientInformation != null) dest.SupportingPatientInformation = new List<Hl7.Fhir.Model.ResourceReference>(SupportingPatientInformation.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new RecommendationComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as RecommendationComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
        if( !DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
        if( !DeepComparable.Matches(ContraindicatedVaccineCode, otherT.ContraindicatedVaccineCode)) return false;
        if( !DeepComparable.Matches(ForecastStatus, otherT.ForecastStatus)) return false;
        if( !DeepComparable.Matches(ForecastReason, otherT.ForecastReason)) return false;
        if( !DeepComparable.Matches(DateCriterion, otherT.DateCriterion)) return false;
        if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
        if( !DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
        if( !DeepComparable.Matches(DoseNumber, otherT.DoseNumber)) return false;
        if( !DeepComparable.Matches(SeriesDoses, otherT.SeriesDoses)) return false;
        if( !DeepComparable.Matches(SupportingImmunization, otherT.SupportingImmunization)) return false;
        if( !DeepComparable.Matches(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as RecommendationComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
        if( !DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
        if( !DeepComparable.IsExactly(ContraindicatedVaccineCode, otherT.ContraindicatedVaccineCode)) return false;
        if( !DeepComparable.IsExactly(ForecastStatus, otherT.ForecastStatus)) return false;
        if( !DeepComparable.IsExactly(ForecastReason, otherT.ForecastReason)) return false;
        if( !DeepComparable.IsExactly(DateCriterion, otherT.DateCriterion)) return false;
        if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
        if( !DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
        if( !DeepComparable.IsExactly(DoseNumber, otherT.DoseNumber)) return false;
        if( !DeepComparable.IsExactly(SeriesDoses, otherT.SeriesDoses)) return false;
        if( !DeepComparable.IsExactly(SupportingImmunization, otherT.SupportingImmunization)) return false;
        if( !DeepComparable.IsExactly(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          foreach (var elem in VaccineCode) { if (elem != null) yield return elem; }
          if (TargetDisease != null) yield return TargetDisease;
          foreach (var elem in ContraindicatedVaccineCode) { if (elem != null) yield return elem; }
          if (ForecastStatus != null) yield return ForecastStatus;
          foreach (var elem in ForecastReason) { if (elem != null) yield return elem; }
          foreach (var elem in DateCriterion) { if (elem != null) yield return elem; }
          if (DescriptionElement != null) yield return DescriptionElement;
          if (SeriesElement != null) yield return SeriesElement;
          if (DoseNumber != null) yield return DoseNumber;
          if (SeriesDoses != null) yield return SeriesDoses;
          foreach (var elem in SupportingImmunization) { if (elem != null) yield return elem; }
          foreach (var elem in SupportingPatientInformation) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          foreach (var elem in VaccineCode) { if (elem != null) yield return new ElementValue("vaccineCode", elem); }
          if (TargetDisease != null) yield return new ElementValue("targetDisease", TargetDisease);
          foreach (var elem in ContraindicatedVaccineCode) { if (elem != null) yield return new ElementValue("contraindicatedVaccineCode", elem); }
          if (ForecastStatus != null) yield return new ElementValue("forecastStatus", ForecastStatus);
          foreach (var elem in ForecastReason) { if (elem != null) yield return new ElementValue("forecastReason", elem); }
          foreach (var elem in DateCriterion) { if (elem != null) yield return new ElementValue("dateCriterion", elem); }
          if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
          if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
          if (DoseNumber != null) yield return new ElementValue("doseNumber", DoseNumber);
          if (SeriesDoses != null) yield return new ElementValue("seriesDoses", SeriesDoses);
          foreach (var elem in SupportingImmunization) { if (elem != null) yield return new ElementValue("supportingImmunization", elem); }
          foreach (var elem in SupportingPatientInformation) { if (elem != null) yield return new ElementValue("supportingPatientInformation", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "vaccineCode":
            value = VaccineCode;
            return VaccineCode?.Any() == true;
          case "targetDisease":
            value = TargetDisease;
            return TargetDisease is not null;
          case "contraindicatedVaccineCode":
            value = ContraindicatedVaccineCode;
            return ContraindicatedVaccineCode?.Any() == true;
          case "forecastStatus":
            value = ForecastStatus;
            return ForecastStatus is not null;
          case "forecastReason":
            value = ForecastReason;
            return ForecastReason?.Any() == true;
          case "dateCriterion":
            value = DateCriterion;
            return DateCriterion?.Any() == true;
          case "description":
            value = DescriptionElement;
            return DescriptionElement is not null;
          case "series":
            value = SeriesElement;
            return SeriesElement is not null;
          case "doseNumber":
            value = DoseNumber;
            return DoseNumber is not null;
          case "seriesDoses":
            value = SeriesDoses;
            return SeriesDoses is not null;
          case "supportingImmunization":
            value = SupportingImmunization;
            return SupportingImmunization?.Any() == true;
          case "supportingPatientInformation":
            value = SupportingPatientInformation;
            return SupportingPatientInformation?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (VaccineCode?.Any() == true) yield return new KeyValuePair<string,object>("vaccineCode",VaccineCode);
        if (TargetDisease is not null) yield return new KeyValuePair<string,object>("targetDisease",TargetDisease);
        if (ContraindicatedVaccineCode?.Any() == true) yield return new KeyValuePair<string,object>("contraindicatedVaccineCode",ContraindicatedVaccineCode);
        if (ForecastStatus is not null) yield return new KeyValuePair<string,object>("forecastStatus",ForecastStatus);
        if (ForecastReason?.Any() == true) yield return new KeyValuePair<string,object>("forecastReason",ForecastReason);
        if (DateCriterion?.Any() == true) yield return new KeyValuePair<string,object>("dateCriterion",DateCriterion);
        if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
        if (SeriesElement is not null) yield return new KeyValuePair<string,object>("series",SeriesElement);
        if (DoseNumber is not null) yield return new KeyValuePair<string,object>("doseNumber",DoseNumber);
        if (SeriesDoses is not null) yield return new KeyValuePair<string,object>("seriesDoses",SeriesDoses);
        if (SupportingImmunization?.Any() == true) yield return new KeyValuePair<string,object>("supportingImmunization",SupportingImmunization);
        if (SupportingPatientInformation?.Any() == true) yield return new KeyValuePair<string,object>("supportingPatientInformation",SupportingPatientInformation);
      }

    }

    /// <summary>
    /// Dates governing proposed immunization
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ImmunizationRecommendation#DateCriterion", IsNestedType=true)]
    [BackboneType("ImmunizationRecommendation.recommendation.dateCriterion")]
    public partial class DateCriterionComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ImmunizationRecommendation#DateCriterion"; } }

      /// <summary>
      /// Type of date
      /// </summary>
      [FhirElement("code", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// Recommended date
      /// </summary>
      [FhirElement("value", Order=50)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirDateTime ValueElement
      {
        get { return _ValueElement; }
        set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
      }

      private Hl7.Fhir.Model.FhirDateTime _ValueElement;

      /// <summary>
      /// Recommended date
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Value
      {
        get { return ValueElement != null ? ValueElement.Value : null; }
        set
        {
          if (value == null)
            ValueElement = null;
          else
            ValueElement = new Hl7.Fhir.Model.FhirDateTime(value);
          OnPropertyChanged("Value");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as DateCriterionComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirDateTime)ValueElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new DateCriterionComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as DateCriterionComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as DateCriterionComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (ValueElement != null) yield return ValueElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (ValueElement != null) yield return new ElementValue("value", ValueElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "value":
            value = ValueElement;
            return ValueElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (ValueElement is not null) yield return new KeyValuePair<string,object>("value",ValueElement);
      }

    }

    /// <summary>
    /// Business identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Who this profile is for
    /// </summary>
    [FhirElement("patient", InSummary=true, Order=100, FiveWs="FiveWs.subject")]
    [CLSCompliant(false)]
    [References("Patient")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Patient
    {
      get { return _Patient; }
      set { _Patient = value; OnPropertyChanged("Patient"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Patient;

    /// <summary>
    /// Date recommendation(s) created
    /// </summary>
    [FhirElement("date", InSummary=true, Order=110)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateElement
    {
      get { return _DateElement; }
      set { _DateElement = value; OnPropertyChanged("DateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateElement;

    /// <summary>
    /// Date recommendation(s) created
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Date
    {
      get { return DateElement != null ? DateElement.Value : null; }
      set
      {
        if (value == null)
          DateElement = null;
        else
          DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Date");
      }
    }

    /// <summary>
    /// Who is responsible for protocol
    /// </summary>
    [FhirElement("authority", Order=120)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Authority
    {
      get { return _Authority; }
      set { _Authority = value; OnPropertyChanged("Authority"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Authority;

    /// <summary>
    /// Vaccine administration recommendations
    /// </summary>
    [FhirElement("recommendation", InSummary=true, Order=130)]
    [Cardinality(Min=1,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent> Recommendation
    {
      get { if(_Recommendation==null) _Recommendation = new List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent>(); return _Recommendation; }
      set { _Recommendation = value; OnPropertyChanged("Recommendation"); }
    }

    private List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent> _Recommendation;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ImmunizationRecommendation;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
      if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
      if(Authority != null) dest.Authority = (Hl7.Fhir.Model.ResourceReference)Authority.DeepCopy();
      if(Recommendation != null) dest.Recommendation = new List<Hl7.Fhir.Model.ImmunizationRecommendation.RecommendationComponent>(Recommendation.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ImmunizationRecommendation());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ImmunizationRecommendation;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
      if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
      if( !DeepComparable.Matches(Recommendation, otherT.Recommendation)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ImmunizationRecommendation;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
      if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
      if( !DeepComparable.IsExactly(Recommendation, otherT.Recommendation)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (Patient != null) yield return Patient;
        if (DateElement != null) yield return DateElement;
        if (Authority != null) yield return Authority;
        foreach (var elem in Recommendation) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (Patient != null) yield return new ElementValue("patient", Patient);
        if (DateElement != null) yield return new ElementValue("date", DateElement);
        if (Authority != null) yield return new ElementValue("authority", Authority);
        foreach (var elem in Recommendation) { if (elem != null) yield return new ElementValue("recommendation", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "patient":
          value = Patient;
          return Patient is not null;
        case "date":
          value = DateElement;
          return DateElement is not null;
        case "authority":
          value = Authority;
          return Authority is not null;
        case "recommendation":
          value = Recommendation;
          return Recommendation?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Patient is not null) yield return new KeyValuePair<string,object>("patient",Patient);
      if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
      if (Authority is not null) yield return new KeyValuePair<string,object>("authority",Authority);
      if (Recommendation?.Any() == true) yield return new KeyValuePair<string,object>("recommendation",Recommendation);
    }

  }

}

// end of file
