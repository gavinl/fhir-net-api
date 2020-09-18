// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

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
  /// A reference from one resource to another
  /// </summary>
  [Serializable]
  [FhirType("Reference")]
  [DataContract]
  public partial class ResourceReference : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Reference"; } }

    /// <summary>
    /// Literal reference, Relative, internal or absolute URL
    /// </summary>
    [FhirElement("reference", InSummary=true, Order=30)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString ReferenceElement
    {
      get { return _ReferenceElement; }
      set { _ReferenceElement = value; OnPropertyChanged("ReferenceElement"); }
    }

    private Hl7.Fhir.Model.FhirString _ReferenceElement;

    /// <summary>
    /// Literal reference, Relative, internal or absolute URL
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Reference
    {
      get { return ReferenceElement != null ? ReferenceElement.Value : null; }
      set
      {
        if (value == null)
          ReferenceElement = null;
        else
          ReferenceElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Reference");
      }
    }

    /// <summary>
    /// Type the reference refers to (e.g. "Patient")
    /// </summary>
    [FhirElement("type", InSummary=true, Order=40, Since=FhirRelease.R4)]
    [DataMember]
    public Hl7.Fhir.Model.FhirUri TypeElement
    {
      get { return _TypeElement; }
      set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
    }

    private Hl7.Fhir.Model.FhirUri _TypeElement;

    /// <summary>
    /// Type the reference refers to (e.g. "Patient")
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Type
    {
      get { return TypeElement != null ? TypeElement.Value : null; }
      set
      {
        if (value == null)
          TypeElement = null;
        else
          TypeElement = new Hl7.Fhir.Model.FhirUri(value);
        OnPropertyChanged("Type");
      }
    }

    /// <summary>
    /// Logical reference, when literal reference is not known
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=50)]
    [DataMember]
    public Hl7.Fhir.Model.Identifier Identifier
    {
      get { return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private Hl7.Fhir.Model.Identifier _Identifier;

    /// <summary>
    /// Text alternative for the resource
    /// </summary>
    [FhirElement("display", InSummary=true, Order=60)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DisplayElement
    {
      get { return _DisplayElement; }
      set { _DisplayElement = value; OnPropertyChanged("DisplayElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DisplayElement;

    /// <summary>
    /// Text alternative for the resource
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Display
    {
      get { return DisplayElement != null ? DisplayElement.Value : null; }
      set
      {
        if (value == null)
          DisplayElement = null;
        else
          DisplayElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Display");
      }
    }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ResourceReference;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(ReferenceElement != null) dest.ReferenceElement = (Hl7.Fhir.Model.FhirString)ReferenceElement.DeepCopy();
      if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.FhirUri)TypeElement.DeepCopy();
      if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
      if(DisplayElement != null) dest.DisplayElement = (Hl7.Fhir.Model.FhirString)DisplayElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ResourceReference());
    }

    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ResourceReference;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
      if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ResourceReference;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
      if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (ReferenceElement != null) yield return ReferenceElement;
        if (TypeElement != null) yield return TypeElement;
        if (Identifier != null) yield return Identifier;
        if (DisplayElement != null) yield return DisplayElement;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
        if (TypeElement != null) yield return new ElementValue("type", TypeElement);
        if (Identifier != null) yield return new ElementValue("identifier", Identifier);
        if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
      }
    }

  }

}

// end of file
