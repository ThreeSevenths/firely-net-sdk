// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

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
  /// Investigation to increase healthcare-related patient-independent knowledge
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ResearchStudy","http://hl7.org/fhir/StructureDefinition/ResearchStudy", IsResource=true)]
  public partial class ResearchStudy : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ResearchStudy"; } }

    /// <summary>
    /// Codes that convey the current status of the research study
    /// (url: http://hl7.org/fhir/ValueSet/research-study-status)
    /// (system: http://hl7.org/fhir/research-study-status)
    /// </summary>
    [FhirEnumeration("ResearchStudyStatus")]
    public enum ResearchStudyStatus
    {
      /// <summary>
      /// The study is undergoing design but the process of selecting study subjects and capturing data has not yet begun.
      /// (system: http://hl7.org/fhir/research-study-status)
      /// </summary>
      [EnumLiteral("draft", "http://hl7.org/fhir/research-study-status"), Description("Draft")]
      Draft,
      /// <summary>
      /// The study is currently being executed
      /// (system: http://hl7.org/fhir/research-study-status)
      /// </summary>
      [EnumLiteral("in-progress", "http://hl7.org/fhir/research-study-status"), Description("In-progress")]
      InProgress,
      /// <summary>
      /// Execution of the study has been temporarily paused
      /// (system: http://hl7.org/fhir/research-study-status)
      /// </summary>
      [EnumLiteral("suspended", "http://hl7.org/fhir/research-study-status"), Description("Suspended")]
      Suspended,
      /// <summary>
      /// The study was terminated prior to the final determination of results
      /// (system: http://hl7.org/fhir/research-study-status)
      /// </summary>
      [EnumLiteral("stopped", "http://hl7.org/fhir/research-study-status"), Description("Stopped")]
      Stopped,
      /// <summary>
      /// The information sought by the study has been gathered and compiled and no further work is being performed
      /// (system: http://hl7.org/fhir/research-study-status)
      /// </summary>
      [EnumLiteral("completed", "http://hl7.org/fhir/research-study-status"), Description("Completed")]
      Completed,
      /// <summary>
      /// This study never actually existed.  The record is retained for tracking purposes in the event decisions may have been made based on this erroneous information.
      /// (system: http://hl7.org/fhir/research-study-status)
      /// </summary>
      [EnumLiteral("entered-in-error", "http://hl7.org/fhir/research-study-status"), Description("Entered in error")]
      EnteredInError,
    }

    /// <summary>
    /// Defined path through the study for a subject
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ResearchStudy#Arm", IsNestedType=true)]
    public partial class ArmComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ResearchStudy#Arm"; } }

      /// <summary>
      /// Label for study arm
      /// </summary>
      [FhirElement("name", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString NameElement
      {
        get { return _NameElement; }
        set { _NameElement = value; OnPropertyChanged("NameElement"); }
      }

      private Hl7.Fhir.Model.FhirString _NameElement;

      /// <summary>
      /// Label for study arm
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public string Name
      {
        get { return NameElement != null ? NameElement.Value : null; }
        set
        {
          if (value == null)
            NameElement = null;
          else
            NameElement = new Hl7.Fhir.Model.FhirString(value);
          OnPropertyChanged("Name");
        }
      }

      /// <summary>
      /// Categorization of study arm
      /// </summary>
      [FhirElement("code", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// Short explanation of study path
      /// </summary>
      [FhirElement("description", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirString DescriptionElement
      {
        get { return _DescriptionElement; }
        set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
      }

      private Hl7.Fhir.Model.FhirString _DescriptionElement;

      /// <summary>
      /// Short explanation of study path
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

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as ArmComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new ArmComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as ArmComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as ArmComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (NameElement != null) yield return NameElement;
          if (Code != null) yield return Code;
          if (DescriptionElement != null) yield return DescriptionElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (NameElement != null) yield return new ElementValue("name", NameElement);
          if (Code != null) yield return new ElementValue("code", Code);
          if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "name":
            value = NameElement;
            return NameElement is not null;
          case "code":
            value = Code;
            return Code is not null;
          case "description":
            value = DescriptionElement;
            return DescriptionElement is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      }

    }

    /// <summary>
    /// Business Identifier for study
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="id")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Name for this study
    /// </summary>
    [FhirElement("title", InSummary=true, Order=100)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString TitleElement
    {
      get { return _TitleElement; }
      set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
    }

    private Hl7.Fhir.Model.FhirString _TitleElement;

    /// <summary>
    /// Name for this study
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Title
    {
      get { return TitleElement != null ? TitleElement.Value : null; }
      set
      {
        if (value == null)
          TitleElement = null;
        else
          TitleElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Title");
      }
    }

    /// <summary>
    /// Steps followed in executing study
    /// </summary>
    [FhirElement("protocol", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("PlanDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Protocol
    {
      get { if(_Protocol==null) _Protocol = new List<Hl7.Fhir.Model.ResourceReference>(); return _Protocol; }
      set { _Protocol = value; OnPropertyChanged("Protocol"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Protocol;

    /// <summary>
    /// Part of larger study
    /// </summary>
    [FhirElement("partOf", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("ResearchStudy")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> PartOf
    {
      get { if(_PartOf==null) _PartOf = new List<Hl7.Fhir.Model.ResourceReference>(); return _PartOf; }
      set { _PartOf = value; OnPropertyChanged("PartOf"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _PartOf;

    /// <summary>
    /// draft | in-progress | suspended | stopped | completed | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=130, FiveWs="status")]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus> _StatusElement;

    /// <summary>
    /// draft | in-progress | suspended | stopped | completed | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Classifications for the study
    /// </summary>
    [FhirElement("category", InSummary=true, Order=140)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// Drugs, devices, conditions, etc. under study
    /// </summary>
    [FhirElement("focus", InSummary=true, Order=150, FiveWs="what")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Focus
    {
      get { if(_Focus==null) _Focus = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Focus; }
      set { _Focus = value; OnPropertyChanged("Focus"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Focus;

    /// <summary>
    /// Contact details for the study
    /// </summary>
    [FhirElement("contact", InSummary=true, Order=160)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ContactDetail> Contact
    {
      get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ContactDetail>(); return _Contact; }
      set { _Contact = value; OnPropertyChanged("Contact"); }
    }

    private List<Hl7.Fhir.Model.ContactDetail> _Contact;

    /// <summary>
    /// References and dependencies
    /// </summary>
    [FhirElement("relatedArtifact", Order=170)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.RelatedArtifact> RelatedArtifact
    {
      get { if(_RelatedArtifact==null) _RelatedArtifact = new List<Hl7.Fhir.Model.RelatedArtifact>(); return _RelatedArtifact; }
      set { _RelatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
    }

    private List<Hl7.Fhir.Model.RelatedArtifact> _RelatedArtifact;

    /// <summary>
    /// Used to search for the study
    /// </summary>
    [FhirElement("keyword", InSummary=true, Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Keyword
    {
      get { if(_Keyword==null) _Keyword = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Keyword; }
      set { _Keyword = value; OnPropertyChanged("Keyword"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Keyword;

    /// <summary>
    /// Geographic region(s) for study
    /// </summary>
    [FhirElement("jurisdiction", InSummary=true, Order=190)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
    {
      get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
      set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;

    /// <summary>
    /// What this is study doing
    /// </summary>
    [FhirElement("description", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.Markdown _DescriptionElement;

    /// <summary>
    /// What this is study doing
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
          DescriptionElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// Inclusion &amp; exclusion criteria
    /// </summary>
    [FhirElement("enrollment", InSummary=true, Order=210, FiveWs="who.focus")]
    [CLSCompliant(false)]
    [References("Group")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Enrollment
    {
      get { if(_Enrollment==null) _Enrollment = new List<Hl7.Fhir.Model.ResourceReference>(); return _Enrollment; }
      set { _Enrollment = value; OnPropertyChanged("Enrollment"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Enrollment;

    /// <summary>
    /// When the study began and ended
    /// </summary>
    [FhirElement("period", InSummary=true, Order=220, FiveWs="when.done")]
    [DataMember]
    public Hl7.Fhir.Model.Period Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Period _Period;

    /// <summary>
    /// Organization responsible for the study
    /// </summary>
    [FhirElement("sponsor", InSummary=true, Order=230, FiveWs="who.actor")]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Sponsor
    {
      get { return _Sponsor; }
      set { _Sponsor = value; OnPropertyChanged("Sponsor"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Sponsor;

    /// <summary>
    /// The individual responsible for the study
    /// </summary>
    [FhirElement("principalInvestigator", InSummary=true, Order=240, FiveWs="who.actor")]
    [CLSCompliant(false)]
    [References("Practitioner")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference PrincipalInvestigator
    {
      get { return _PrincipalInvestigator; }
      set { _PrincipalInvestigator = value; OnPropertyChanged("PrincipalInvestigator"); }
    }

    private Hl7.Fhir.Model.ResourceReference _PrincipalInvestigator;

    /// <summary>
    /// Location involved in study execution
    /// </summary>
    [FhirElement("site", InSummary=true, Order=250, FiveWs="where")]
    [CLSCompliant(false)]
    [References("Location")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Site
    {
      get { if(_Site==null) _Site = new List<Hl7.Fhir.Model.ResourceReference>(); return _Site; }
      set { _Site = value; OnPropertyChanged("Site"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Site;

    /// <summary>
    /// Reason for terminating study early
    /// </summary>
    [FhirElement("reasonStopped", InSummary=true, Order=260, FiveWs="why")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept ReasonStopped
    {
      get { return _ReasonStopped; }
      set { _ReasonStopped = value; OnPropertyChanged("ReasonStopped"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _ReasonStopped;

    /// <summary>
    /// Comments made about the event
    /// </summary>
    [FhirElement("note", Order=270)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    /// <summary>
    /// Defined path through the study for a subject
    /// </summary>
    [FhirElement("arm", Order=280)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResearchStudy.ArmComponent> Arm
    {
      get { if(_Arm==null) _Arm = new List<Hl7.Fhir.Model.ResearchStudy.ArmComponent>(); return _Arm; }
      set { _Arm = value; OnPropertyChanged("Arm"); }
    }

    private List<Hl7.Fhir.Model.ResearchStudy.ArmComponent> _Arm;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ResearchStudy;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
      if(Protocol != null) dest.Protocol = new List<Hl7.Fhir.Model.ResourceReference>(Protocol.DeepCopy());
      if(PartOf != null) dest.PartOf = new List<Hl7.Fhir.Model.ResourceReference>(PartOf.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ResearchStudy.ResearchStudyStatus>)StatusElement.DeepCopy();
      if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Focus != null) dest.Focus = new List<Hl7.Fhir.Model.CodeableConcept>(Focus.DeepCopy());
      if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ContactDetail>(Contact.DeepCopy());
      if(RelatedArtifact != null) dest.RelatedArtifact = new List<Hl7.Fhir.Model.RelatedArtifact>(RelatedArtifact.DeepCopy());
      if(Keyword != null) dest.Keyword = new List<Hl7.Fhir.Model.CodeableConcept>(Keyword.DeepCopy());
      if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
      if(Enrollment != null) dest.Enrollment = new List<Hl7.Fhir.Model.ResourceReference>(Enrollment.DeepCopy());
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
      if(Sponsor != null) dest.Sponsor = (Hl7.Fhir.Model.ResourceReference)Sponsor.DeepCopy();
      if(PrincipalInvestigator != null) dest.PrincipalInvestigator = (Hl7.Fhir.Model.ResourceReference)PrincipalInvestigator.DeepCopy();
      if(Site != null) dest.Site = new List<Hl7.Fhir.Model.ResourceReference>(Site.DeepCopy());
      if(ReasonStopped != null) dest.ReasonStopped = (Hl7.Fhir.Model.CodeableConcept)ReasonStopped.DeepCopy();
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      if(Arm != null) dest.Arm = new List<Hl7.Fhir.Model.ResearchStudy.ArmComponent>(Arm.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ResearchStudy());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ResearchStudy;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.Matches(Protocol, otherT.Protocol)) return false;
      if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
      if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
      if( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
      if( !DeepComparable.Matches(Keyword, otherT.Keyword)) return false;
      if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(Enrollment, otherT.Enrollment)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(Sponsor, otherT.Sponsor)) return false;
      if( !DeepComparable.Matches(PrincipalInvestigator, otherT.PrincipalInvestigator)) return false;
      if( !DeepComparable.Matches(Site, otherT.Site)) return false;
      if( !DeepComparable.Matches(ReasonStopped, otherT.ReasonStopped)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;
      if( !DeepComparable.Matches(Arm, otherT.Arm)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ResearchStudy;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
      if( !DeepComparable.IsExactly(Protocol, otherT.Protocol)) return false;
      if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
      if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
      if( !DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
      if( !DeepComparable.IsExactly(Keyword, otherT.Keyword)) return false;
      if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(Enrollment, otherT.Enrollment)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(Sponsor, otherT.Sponsor)) return false;
      if( !DeepComparable.IsExactly(PrincipalInvestigator, otherT.PrincipalInvestigator)) return false;
      if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
      if( !DeepComparable.IsExactly(ReasonStopped, otherT.ReasonStopped)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
      if( !DeepComparable.IsExactly(Arm, otherT.Arm)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (TitleElement != null) yield return TitleElement;
        foreach (var elem in Protocol) { if (elem != null) yield return elem; }
        foreach (var elem in PartOf) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        foreach (var elem in Focus) { if (elem != null) yield return elem; }
        foreach (var elem in Contact) { if (elem != null) yield return elem; }
        foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
        foreach (var elem in Keyword) { if (elem != null) yield return elem; }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in Enrollment) { if (elem != null) yield return elem; }
        if (Period != null) yield return Period;
        if (Sponsor != null) yield return Sponsor;
        if (PrincipalInvestigator != null) yield return PrincipalInvestigator;
        foreach (var elem in Site) { if (elem != null) yield return elem; }
        if (ReasonStopped != null) yield return ReasonStopped;
        foreach (var elem in Note) { if (elem != null) yield return elem; }
        foreach (var elem in Arm) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (TitleElement != null) yield return new ElementValue("title", TitleElement);
        foreach (var elem in Protocol) { if (elem != null) yield return new ElementValue("protocol", elem); }
        foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        foreach (var elem in Focus) { if (elem != null) yield return new ElementValue("focus", elem); }
        foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
        foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", elem); }
        foreach (var elem in Keyword) { if (elem != null) yield return new ElementValue("keyword", elem); }
        foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in Enrollment) { if (elem != null) yield return new ElementValue("enrollment", elem); }
        if (Period != null) yield return new ElementValue("period", Period);
        if (Sponsor != null) yield return new ElementValue("sponsor", Sponsor);
        if (PrincipalInvestigator != null) yield return new ElementValue("principalInvestigator", PrincipalInvestigator);
        foreach (var elem in Site) { if (elem != null) yield return new ElementValue("site", elem); }
        if (ReasonStopped != null) yield return new ElementValue("reasonStopped", ReasonStopped);
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
        foreach (var elem in Arm) { if (elem != null) yield return new ElementValue("arm", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "title":
          value = TitleElement;
          return TitleElement is not null;
        case "protocol":
          value = Protocol;
          return Protocol?.Any() == true;
        case "partOf":
          value = PartOf;
          return PartOf?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "focus":
          value = Focus;
          return Focus?.Any() == true;
        case "contact":
          value = Contact;
          return Contact?.Any() == true;
        case "relatedArtifact":
          value = RelatedArtifact;
          return RelatedArtifact?.Any() == true;
        case "keyword":
          value = Keyword;
          return Keyword?.Any() == true;
        case "jurisdiction":
          value = Jurisdiction;
          return Jurisdiction?.Any() == true;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "enrollment":
          value = Enrollment;
          return Enrollment?.Any() == true;
        case "period":
          value = Period;
          return Period is not null;
        case "sponsor":
          value = Sponsor;
          return Sponsor is not null;
        case "principalInvestigator":
          value = PrincipalInvestigator;
          return PrincipalInvestigator is not null;
        case "site":
          value = Site;
          return Site?.Any() == true;
        case "reasonStopped":
          value = ReasonStopped;
          return ReasonStopped is not null;
        case "note":
          value = Note;
          return Note?.Any() == true;
        case "arm":
          value = Arm;
          return Arm?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (TitleElement is not null) yield return new KeyValuePair<string,object>("title",TitleElement);
      if (Protocol?.Any() == true) yield return new KeyValuePair<string,object>("protocol",Protocol);
      if (PartOf?.Any() == true) yield return new KeyValuePair<string,object>("partOf",PartOf);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Focus?.Any() == true) yield return new KeyValuePair<string,object>("focus",Focus);
      if (Contact?.Any() == true) yield return new KeyValuePair<string,object>("contact",Contact);
      if (RelatedArtifact?.Any() == true) yield return new KeyValuePair<string,object>("relatedArtifact",RelatedArtifact);
      if (Keyword?.Any() == true) yield return new KeyValuePair<string,object>("keyword",Keyword);
      if (Jurisdiction?.Any() == true) yield return new KeyValuePair<string,object>("jurisdiction",Jurisdiction);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (Enrollment?.Any() == true) yield return new KeyValuePair<string,object>("enrollment",Enrollment);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (Sponsor is not null) yield return new KeyValuePair<string,object>("sponsor",Sponsor);
      if (PrincipalInvestigator is not null) yield return new KeyValuePair<string,object>("principalInvestigator",PrincipalInvestigator);
      if (Site?.Any() == true) yield return new KeyValuePair<string,object>("site",Site);
      if (ReasonStopped is not null) yield return new KeyValuePair<string,object>("reasonStopped",ReasonStopped);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
      if (Arm?.Any() == true) yield return new KeyValuePair<string,object>("arm",Arm);
    }

  }

}

// end of file
