---
layout: default
title: Welcome
---

This is the support API for working with the DSTU (0.80) version of [HL7 FHIR][1] on the Microsoft .NET (dotnet) platform. The API deals with the HTTP and wire format, so you can write code like this to manipulate a patient's data: 

```csharp
var client = new FhirClient("http://spark.furore.com/fhir");

var pat = client.Read<Patient>("Patient/1");
pat.Resource.Name.Add(HumanName.ForFamily("Kramer")
   	 .WithGiven("Ewout"));

client.Update<Patient>(pat);
```

This library provides:

* Class models for working with the FHIR data model using POCO's
* Xml and Json parsers and serializers
* Validation functionality for instances created with the model classes
* A REST client for working with FHIR-compliant servers

We'll soon be adding handling of ValueSets and Profile validation.

### What's new?
The FHIR client is still under development. Check out [what's new](whats-new.html) in this latest release.

### Get Started
Get started by reading the [online documentation](docu-index.html), downloading the [NuGet package][2] or getting [the sourcecode][3].


[1]: http://www.hl7.org/fhir
[2]: http://www.nuget.org/packages/Hl7.Fhir
[3]: http://www.github.com/ewoutkramer/fhir-net-api