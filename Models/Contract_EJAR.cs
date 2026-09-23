using System;

namespace GTSErpSystem.Models;

public class Contract_EJAR
{
    public string CommercialRegistrationNumberOfTheTenant { get; set; } = string.Empty;
    public string ContractRegistryNumber { get; set; } = string.Empty;
    public int ID { get; set; }
    public string LandlordNationalAddress { get; set; } = string.Empty;
    public string LandlordsEmail { get; set; } = string.Empty;
    public string LessorIDType { get; set; } = string.Empty;
    public string LessorIdentificationNumber { get; set; } = string.Empty;
    public string LessorsName { get; set; } = string.Empty;
    public string MethodOfPaymentOfContractFees { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public string TenantAreaType { get; set; } = string.Empty;
    public string TheDateOfTheCommercialRegistrationOfTheTenant { get; set; } = string.Empty;
    public DateTime? TheDateOfTheContract { get; set; }
    public DateTime? TheEndDateOfTheLeaseTerm { get; set; }
    public string TheIssuingEntityOfTheTenant { get; set; } = string.Empty;
    public string TheLessorIsRepresentedByHimselfOrHerself { get; set; } = string.Empty;
    public string TheNameOfTheTenantCompany { get; set; } = string.Empty;
    public string TheNameOfTheTenantsRepresentative { get; set; } = string.Empty;
    public string TheNationalityOfTheTenantsRepresentative { get; set; } = string.Empty;
    public string ThePlaceOfConclusionOfTheContract { get; set; } = string.Empty;
    public DateTime? TheStartDateOftheLeaseTerm { get; set; }
    public string ThelandlordsMobileNumber { get; set; } = string.Empty;
    public string ThelessorsNationality { get; set; } = string.Empty;
    public string TypeOfContract { get; set; } = string.Empty;
    public string UnifiedNumberOfTheTenant { get; set; } = string.Empty;
    public string conditionallySuspended { get; set; } = string.Empty;
}