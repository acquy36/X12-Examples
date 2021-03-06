namespace EdiFabric.Templates.Hipaa5010
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using EdiFabric.Core.Model.Edi.ErrorContexts;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Dependent Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_DependentRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_DependentRequestValidation_2 : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_DependentRequestValidation_3 : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_InformationReceiverRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_PatientEventProviderRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_PatientEventRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Location Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_PatientEventTransportLocationRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_RequesterRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_RequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_RequestValidation_2 : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_RequestValidation_3 : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Service Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_ServiceRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_4), typeof(X12_ID_559))]
    public class AAA_SubscriberRequestValidation : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_SubscriberRequestValidation_2 : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA", typeof(X12_ID_1073_3), typeof(X12_ID_559))]
    public class AAA_UtilizationManagementOrganization : AAA, I_AAA
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ValidRequestIndicator_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FollowupActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// TPA/Broker Account Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ACT")]
    public class ACT_TPA : ACT, I_ACT
    {
        
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TPAorBrokerAccountNumber_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Name_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string AccountNumberQualifier_05 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TPAorBrokerAccountNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Payment Method Type Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PaymentMethodTypeCode_08 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string BenefitStatusCode_09 { get; set; }
    }
    
    /// <summary>
    /// Individual Premium Adjustment for Current Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADX")]
    public class ADX_IndividualPremiumAdjustmentforCurrentPayment : ADX, I_ADX
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdjustmentAmount_01 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Individual Premium Adjustment for Previous Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADX")]
    public class ADX_IndividualPremiumAdjustmentforPreviousPayment : ADX, I_ADX
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdjustmentAmount_01 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Organization Summary Remittance Level Adjustment for Previous Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADX")]
    public class ADX_OrganizationSummaryRemittanceLevelAdjustmentforPreviousPayment : ADX, I_ADX
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdjustmentAmount_01 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Submitted Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_12))]
    public class AMT_ClaimSubmittedCharges : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_15))]
    public class AMT_ClaimSupplementalInformation : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Payer Paid Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_CoordinationofBenefits : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits (COB) Total Non-covered Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_6))]
    public class AMT_CoordinationofBenefits_2 : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Facility Tax Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_9))]
    public class AMT_FacilityTaxAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage Policy
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_14))]
    public class AMT_HealthCoveragePolicy : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Patient Amount Paid
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_16))]
    public class AMT_PatientAmountPaid : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Patient Estimated Amount Due
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_17))]
    public class AMT_PatientEstimatedAmountDue : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Postage Claimed Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_10))]
    public class AMT_PostageClaimedAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Remaining Patient Liability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_5))]
    public class AMT_RemainingPatientLiability : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Sales Tax Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_7))]
    public class AMT_SalesTaxAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Service Supplemental Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_3))]
    public class AMT_ServiceSupplementalAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Service Tax Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_8))]
    public class AMT_ServiceTaxAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Spend Down Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_11))]
    public class AMT_SubscriberSpendDownAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Spend Down Total Billed Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_SubscriberSpendDownTotalBilledAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Total Accepted Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_13))]
    public class AMT_TotalAcceptedAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Total Accepted Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Total Rejected Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT", typeof(X12_ID_522_2))]
    public class AMT_TotalRejectedAmount : AMT, I_AMT
    {
        
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Total Rejected Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditDebitFlagCode_03 { get; set; }
    }
    
    /// <summary>
    /// Beginning Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGN", typeof(X12_ID_353_6))]
    public class BGN_BeginningSegment : BGN, I_BGN
    {
        
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetReferenceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string TransactionSetCreationDate_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationTime_04 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TimeZoneCode_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string OriginalTransactionSetReferenceNumber_06 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string TransactionTypeCode_07 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ActionCode_08 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SecurityLevelCode_09 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005), typeof(X12_ID_353))]
    public class BHT_BeginningOfHierarchicalTransaction : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005), typeof(X12_ID_353_2))]
    public class BHT_BeginningOfHierarchicalTransaction_2 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005_2), typeof(X12_ID_353_3))]
    public class BHT_BeginningOfHierarchicalTransaction_3 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005_2), typeof(X12_ID_353_4))]
    public class BHT_BeginningOfHierarchicalTransaction_4 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005_3), typeof(X12_ID_353_4))]
    public class BHT_BeginningOfHierarchicalTransaction_5 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Transaction Set Creation Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Transaction Set Creation Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005_6), typeof(X12_ID_353_8))]
    public class BHT_BeginningOfHierarchicalTransaction_6 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005_4), typeof(X12_ID_353_5))]
    public class BHT_BeginningOfHierarchicalTransaction_7 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Beginning of Hierarchical Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BHT", typeof(X12_ID_1005_5), typeof(X12_ID_353_7))]
    public class BHT_BeginningOfHierarchicalTransaction_8 : BHT, I_BHT
    {
        
        /// <summary>
        /// Hierarchical Structure Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalStructureCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TransactionSetPurposeCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubmitterTransactionIdentifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TransactionSetCreationDate_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TransactionSetCreationTime_05 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransactionTypeCode_06 { get; set; }
    }
    
    /// <summary>
    /// Financial Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPR", typeof(X12_ID_305))]
    public class BPR_FinancialInformation : BPR, I_BPR
    {
        
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TransactionHandlingCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalPremiumPaymentAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditorDebitFlagCode_03 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PaymentMethodCode_04 { get; set; }
        /// <summary>
        /// Payment Format Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PaymentFormatCode_05 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AccountNumberQualifier_08 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SenderBankAccountNumber_09 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PayerIdentifier_10 { get; set; }
        /// <summary>
        /// Originating Company Supplemental Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string OriginatingCompanySupplementalCode_11 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string AccountNumberQualifier_14 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ReceiverBankAccountNumber_15 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CheckIssueorEFTEffectiveDate_16 { get; set; }
        /// <summary>
        /// Business Function Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BusinessFunctionCode_17 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string DFIIDNumberQualifier_18 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string DFIIdentificationNumber_19 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string AccountNumberQualifier_20 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string AccountNumber_21 { get; set; }
    }
    
    /// <summary>
    /// Financial Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPR", typeof(X12_ID_305_2))]
    public class BPR_FinancialInformation_2 : BPR, I_BPR
    {
        
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TransactionHandlingCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalPremiumPaymentAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CreditorDebitFlagCode_03 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PaymentMethodCode_04 { get; set; }
        /// <summary>
        /// Payment Format Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PaymentFormatCode_05 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_06 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string OriginatingDepositoryFinancialInstitutionDFIIdentifier_07 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AccountNumberQualifier_08 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SenderBankAccountNumber_09 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PayerIdentifier_10 { get; set; }
        /// <summary>
        /// Originating Company Supplemental Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string OriginatingCompanySupplementalCode_11 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DepositoryFinancialInstitutionDFIIdentificationNumberQualifier_12 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ReceivingDepositoryFinancialInstitutionDFIIdentifier_13 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string AccountNumberQualifier_14 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ReceiverBankAccountNumber_15 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CheckIssueorEFTEffectiveDate_16 { get; set; }
        /// <summary>
        /// Business Function Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BusinessFunctionCode_17 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string DFIIDNumberQualifier_18 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string DFIIdentificationNumber_19 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string AccountNumberQualifier_20 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string AccountNumber_21 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Adjustments
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAS", typeof(X12_ID_1033_2))]
    public class CAS_ClaimLevelAdjustments : CAS, I_CAS
    {
        
        /// <summary>
        /// Claim Adjustment Group Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ClaimAdjustmentGroupCode_01 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdjustmentAmount_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string AdjustmentQuantity_04 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string AdjustmentReasonCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AdjustmentQuantity_07 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AdjustmentReasonCode_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string AdjustmentAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string AdjustmentQuantity_10 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string AdjustmentReasonCode_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string AdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string AdjustmentQuantity_13 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string AdjustmentReasonCode_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string AdjustmentAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string AdjustmentQuantity_16 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string AdjustmentReasonCode_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string AdjustmentAmount_18 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string AdjustmentQuantity_19 { get; set; }
    }
    
    /// <summary>
    /// Claims Adjustment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_ClaimsAdjustment : CAS, I_CAS
    {
        
        /// <summary>
        /// Claim Adjustment Group Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ClaimAdjustmentGroupCode_01 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdjustmentReasonCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdjustmentAmount_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string AdjustmentQuantity_04 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string AdjustmentReasonCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AdjustmentQuantity_07 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AdjustmentReasonCode_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string AdjustmentAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string AdjustmentQuantity_10 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string AdjustmentReasonCode_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string AdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string AdjustmentQuantity_13 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string AdjustmentReasonCode_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string AdjustmentAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string AdjustmentQuantity_16 { get; set; }
        /// <summary>
        /// Claim Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string AdjustmentReasonCode_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string AdjustmentAmount_18 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string AdjustmentQuantity_19 { get; set; }
    }
    
    /// <summary>
    /// Institutional Claim Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CL1")]
    public class CL1_InstitutionalClaimCode : CL1, I_CL1
    {
        
        /// <summary>
        /// Admission Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdmissionTypeCode_01 { get; set; }
        /// <summary>
        /// Admission Source Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdmissionSourceCode_02 { get; set; }
        /// <summary>
        /// Patient Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PatientStatusCode_03 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    /// <summary>
    /// Institutional Claim Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CL1")]
    public class CL1_InstitutionalClaimCode_2 : CL1, I_CL1
    {
        
        /// <summary>
        /// Admission Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdmissionTypeCode_01 { get; set; }
        /// <summary>
        /// Admission Source Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdmissionSourceCode_02 { get; set; }
        /// <summary>
        /// Patient Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PatientStatusCode_03 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    /// <summary>
    /// Institutional Claim Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CL1")]
    public class CL1_InstitutionalClaimCode_3 : CL1, I_CL1
    {
        
        /// <summary>
        /// Admission Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdmissionTypeCode_01 { get; set; }
        /// <summary>
        /// Admission Source Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdmissionSourceCode_02 { get; set; }
        /// <summary>
        /// Patient Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PatientStatusCode_03 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NursingHomeResidentialStatusCode_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLM")]
    public class CLM_ClaimInformation : CLM, I_CLM<C023_HealthCareServiceLocationInformation_2, C024_RelatedCausesInformation_3>
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFilingIndicatorCode_03 { get; set; }
        /// <summary>
        /// Non-Institutional Claim Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NonInstitutionalClaimTypeCode_04 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C023_HealthCareServiceLocationInformation_2 HealthCareServiceLocationInformation_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderorSupplierSignatureIndicator_06 { get; set; }
        /// <summary>
        /// Provider Accept Assignment Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AssignmentorPlanParticipationCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientSignatureSourceCode_10 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C024_RelatedCausesInformation_3 RelatedCausesInformation_11 { get; set; }
        /// <summary>
        /// Special Program Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string SpecialProgramIndicator_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string LevelofServiceCode_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string YesNoConditionorResponseCode_15 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProviderAgreementCode_16 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ClaimStatusCode_17 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string YesNoConditionorResponseCode_18 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string PredeterminationofBenefitsCode_19 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string DelayReasonCode_20 { get; set; }
    }
    
    /// <summary>
    /// Claim information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLM")]
    public class CLM_ClaimInformation_2 : CLM, I_CLM<C023_HealthCareServiceLocationInformation_3, C024_RelatedCausesInformation_3>
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFilingIndicatorCode_03 { get; set; }
        /// <summary>
        /// Non-Institutional Claim Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NonInstitutionalClaimTypeCode_04 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C023_HealthCareServiceLocationInformation_3 HealthCareServiceLocationInformation_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderorSupplierSignatureIndicator_06 { get; set; }
        /// <summary>
        /// Provider Accept Assignment Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AssignmentorPlanParticipationCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientSignatureSourceCode_10 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C024_RelatedCausesInformation_3 RelatedCausesInformation_11 { get; set; }
        /// <summary>
        /// Special Program Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string SpecialProgramIndicator_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string LevelofServiceCode_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string YesNoConditionorResponseCode_15 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProviderAgreementCode_16 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ClaimStatusCode_17 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string YesNoConditionorResponseCode_18 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string PredeterminationofBenefitsCode_19 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string DelayReasonCode_20 { get; set; }
    }
    
    /// <summary>
    /// Claim Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLM")]
    public class CLM_ClaimInformation_3 : CLM, I_CLM<C023_HealthCareServiceLocationInformation_2, C024_RelatedCausesInformation_3>
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalClaimChargeAmount_02 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimFilingIndicatorCode_03 { get; set; }
        /// <summary>
        /// Non-Institutional Claim Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NonInstitutionalClaimTypeCode_04 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C023_HealthCareServiceLocationInformation_2 HealthCareServiceLocationInformation_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderorSupplierSignatureIndicator_06 { get; set; }
        /// <summary>
        /// Provider Accept Assignment Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AssignmentorPlanParticipationCode_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientSignatureSourceCode_10 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C024_RelatedCausesInformation_3 RelatedCausesInformation_11 { get; set; }
        /// <summary>
        /// Special Program Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string SpecialProgramIndicator_12 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string YesNoConditionorResponseCode_13 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string LevelofServiceCode_14 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string YesNoConditionorResponseCode_15 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProviderAgreementCode_16 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ClaimStatusCode_17 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string YesNoConditionorResponseCode_18 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string PredeterminationofBenefitsCode_19 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string DelayReasonCode_20 { get; set; }
    }
    
    /// <summary>
    /// Claim Payment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLP")]
    public class CLP_ClaimPaymentInformation : CLP, I_CLP
    {
        
        /// <summary>
        /// Claim Submitter's Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PatientControlNumber_01 { get; set; }
        /// <summary>
        /// Claim Status Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ClaimStatusCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string TotalClaimChargeAmount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ClaimPaymentAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PatientResponsibilityAmount_05 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ClaimFilingIndicatorCode_06 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PayerClaimControlNumber_07 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string FacilityTypeCode_08 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ClaimFrequencyCode_09 { get; set; }
        /// <summary>
        /// Patient Status Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientStatusCode_10 { get; set; }
        /// <summary>
        /// Diagnosis Related Group (DRG) Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DiagnosisRelatedGroupDRGCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DiagnosisRelatedGroupDRGWeight_12 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string DischargeFraction_13 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string YesNoConditionorResponseCode_14 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation : CN1, I_CN1
    {
        
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ContractAmount_02 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ContractPercentage_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ContractCode_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TermsDiscountPercentage_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ContractVersionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Contract Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CN1", typeof(X12_ID_1166_2))]
    public class CN1_ContractInformation_2 : CN1, I_CN1
    {
        
        /// <summary>
        /// Contract Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContractTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ContractAmount_02 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ContractPercentage_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ContractCode_04 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TermsDiscountPercentage_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ContractVersionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COB", typeof(X12_ID_1138))]
    public class COB_CoordinationofBenefits : COB, I_COB
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CoordinationofBenefitsCode_03 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<string> ServiceTypeCode_04
        {
            get { return _serviceTypeCode; }
            set { _serviceTypeCode = value; }
        }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR1", typeof(X12_ID_355_7))]
    public class CR1_AmbulanceTransportInformation : CR1, I_CR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR1", typeof(X12_ID_355_17))]
    public class CR1_AmbulanceTransportInformation_2 : CR1, I_CR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR1", typeof(X12_ID_355))]
    public class CR1_AmbulanceTransportInformation_3 : CR1, I_CR1
    {
        
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PatientWeight_02 { get; set; }
        /// <summary>
        /// Ambulance Transport Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AmbulanceTransportCode_03 { get; set; }
        /// <summary>
        /// Ambulance Transport Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string AmbulanceTransportReasonCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TransportDistance_06 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AddressInformation_07 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string AddressInformation_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RoundTripPurposeDescription_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string StretcherPurposeDescription_10 { get; set; }
    }
    
    /// <summary>
    /// Spinal Manipulation Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation : CR2, I_CR2
    {
        
        /// <summary>
        /// Count
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string Count_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Quantity_02 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubluxationLevelCode_03 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SubluxationLevelCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Quantity_07 { get; set; }
        /// <summary>
        /// Nature of Condition Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PatientConditionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientConditionDescription_10 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string PatientConditionDescription_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    /// <summary>
    /// Spinal Manipulation Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation_2 : CR2, I_CR2
    {
        
        /// <summary>
        /// Count
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string Count_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Quantity_02 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubluxationLevelCode_03 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SubluxationLevelCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Quantity_07 { get; set; }
        /// <summary>
        /// Nature of Condition Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PatientConditionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientConditionDescription_10 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string PatientConditionDescription_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    /// <summary>
    /// Spinal Manipulation Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation_3 : CR2, I_CR2
    {
        
        /// <summary>
        /// Count
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string Count_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Quantity_02 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string SubluxationLevelCode_03 { get; set; }
        /// <summary>
        /// Subluxation Level Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SubluxationLevelCode_04 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string UnitorBasisforMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Quantity_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Quantity_07 { get; set; }
        /// <summary>
        /// Nature of Condition Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PatientConditionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string YesNoConditionorResponseCode_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PatientConditionDescription_10 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string PatientConditionDescription_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR3", typeof(X12_ID_1322_4), typeof(X12_ID_355_13))]
    public class CR3_DurableMedicalEquipmentCertification : CR3, I_CR3
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DurableMedicalEquipmentDuration_03 { get; set; }
        /// <summary>
        /// Insulin Dependent Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InsulinDependentCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Description_05 { get; set; }
    }
    
    /// <summary>
    /// Home Oxygen Therapy Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR5", typeof(X12_ID_1322_5))]
    public class CR5_HomeOxygenTherapyInformation : CR5, I_CR5
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Quantity_02 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OxygenEquipmentTypeCode_03 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OxygenEquipmentTypeCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EquipmentReasonDescription_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string OxygenFlowRate_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DailyOxygenUseCount_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string OxygenUsePeriodHourCount_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RespiratoryTherapistOrderText_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ArterialBloodGasQuantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string OxygenSaturationQuantity_11 { get; set; }
        /// <summary>
        /// Oxygen Test Condition Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string OxygenTestConditionCode_12 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string OxygenTestFindingsCode_13 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string OxygenTestFindingsCode_14 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string OxygenTestFindingsCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string PortableOxygenSystemFlowRate_16 { get; set; }
        /// <summary>
        /// Oxygen Delivery System Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string OxygenDeliverySystemCode_17 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    /// <summary>
    /// Home Oxygen Therapy Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR5", typeof(X12_ID_1322))]
    public class CR5_HomeOxygenTherapyInformation_2 : CR5, I_CR5
    {
        
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CertificationTypeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Quantity_02 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OxygenEquipmentTypeCode_03 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OxygenEquipmentTypeCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EquipmentReasonDescription_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string OxygenFlowRate_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DailyOxygenUseCount_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string OxygenUsePeriodHourCount_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RespiratoryTherapistOrderText_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ArterialBloodGasQuantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string OxygenSaturationQuantity_11 { get; set; }
        /// <summary>
        /// Oxygen Test Condition Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string OxygenTestConditionCode_12 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string OxygenTestFindingsCode_13 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string OxygenTestFindingsCode_14 { get; set; }
        /// <summary>
        /// Oxygen Test Findings Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string OxygenTestFindingsCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string PortableOxygenSystemFlowRate_16 { get; set; }
        /// <summary>
        /// Oxygen Delivery System Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string OxygenDeliverySystemCode_17 { get; set; }
        /// <summary>
        /// Oxygen Equipment Type Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string OxygenEquipmentTypeCode_18 { get; set; }
    }
    
    /// <summary>
    /// Home Health Care Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR6", typeof(X12_ID_1337_2))]
    public class CR6_HomeHealthCareInformation : CR6, I_CR6
    {
        
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PrognosisCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HomeHealthStartDate_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HomeHealthCertificationPeriod_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Date_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string YesNoConditionorResponseCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MedicareCoverageIndicator_07 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string CertificationTypeCode_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SurgeryDate_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductorServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Medical Code Value
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string SurgicalProcedureCode_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string PhysicianOrderDate_12 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string LastVisitDate_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PhysicianContactDate_14 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string DateTimePeriodFormatQualifier_15 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string LastAdmissionPeriod_16 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string PatientLocationCode_17 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string Date_18 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string Date_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string Date_20 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string Date_21 { get; set; }
    }
    
    /// <summary>
    /// Home Health Care Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CR6", typeof(X12_ID_923))]
    public class CR6_HomeHealthCareInformation_2 : CR6, I_CR6
    {
        
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PrognosisCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HomeHealthStartDate_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HomeHealthCertificationPeriod_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Date_05 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string YesNoConditionorResponseCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MedicareCoverageIndicator_07 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string CertificationTypeCode_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SurgeryDate_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductorServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Medical Code Value
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string SurgicalProcedureCode_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string PhysicianOrderDate_12 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string LastVisitDate_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PhysicianContactDate_14 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string DateTimePeriodFormatQualifier_15 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string LastAdmissionPeriod_16 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string PatientLocationCode_17 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string Date_18 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string Date_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string Date_20 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string Date_21 { get; set; }
    }
    
    /// <summary>
    /// Activities Permitted Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_13), typeof(X12_ID_1073_10))]
    public class CRC_ActivitiesPermittedInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Certification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_8), typeof(X12_ID_1073_4))]
    public class CRC_AmbulanceCertification : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Certification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_15), typeof(X12_ID_1073_10))]
    public class CRC_AmbulanceCertificationInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Chiropractic Certification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_9), typeof(X12_ID_1073_10))]
    public class CRC_ChiropracticCertificationInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Condition Indicator/Durable Medical Equipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_5), typeof(X12_ID_1073_4))]
    public class CRC_ConditionIndicator : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_10), typeof(X12_ID_1073_10))]
    public class CRC_DurableMedicalEquipmentInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// EPSDT Referral
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_3), typeof(X12_ID_1073_4))]
    public class CRC_EPSDTReferral : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Functional Limitations Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_12), typeof(X12_ID_1073_10))]
    public class CRC_FunctionalLimitationsInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Homebound Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_2), typeof(X12_ID_1073))]
    public class CRC_HomeboundIndicator : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Hospice Employee Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_4), typeof(X12_ID_1073_4))]
    public class CRC_HospiceEmployeeIndicator : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Mental Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_14), typeof(X12_ID_1073_10))]
    public class CRC_MentalStatusInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Oxygen Therapy Certification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136_11), typeof(X12_ID_1073_10))]
    public class CRC_OxygenTherapyCertificationInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Patient Condition Information: Vision
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_4))]
    public class CRC_PatientConditionInformation : CRC, I_CRC
    {
        
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeCategory_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ConditionCode_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ConditionCode_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ConditionCode_05 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ConditionCode_06 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConditionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Drug Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTP", typeof(X12_ID_687), typeof(X12_ID_236))]
    public class CTP_DrugQuantity : CTP, I_CTP<C001_CompositeUnitOfMeasure_2>
    {
        
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ClassofTradeCode_01 { get; set; }
        /// <summary>
        /// Price Identifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PriceIdentifierCode_02 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitPrice_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string NationalDrugUnitCount_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C001_CompositeUnitOfMeasure_2 CompositeUnitOfMeasure_05 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PriceMultiplierQualifier_06 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Multiplier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string BasisofUnitPriceCode_09 { get; set; }
        /// <summary>
        /// Condition Value
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ConditionValue_10 { get; set; }
        /// <summary>
        /// Multiple Price Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string MultiplePriceQuantity_11 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUR", typeof(X12_ID_98_59))]
    public class CUR_ForeignCurrencyInformation : CUR, I_CUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUR", typeof(X12_ID_98_29))]
    public class CUR_ForeignCurrencyInformation_2 : CUR, I_CUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Foreign Currency Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUR", typeof(X12_ID_98_31))]
    public class CUR_ForeignCurrencyInformation_3 : CUR, I_CUR
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string Time_21 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_DependentDemographicInformation : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_DependentDemographicInformation_2 : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_DependentDemographicInformation_3 : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_10))]
    public class DMG_DependentDemographicInformation_4 : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation_2>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation_2> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Dependent Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_DependentDemographicInformation_5 : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Incorrect Member Demographics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_IncorrectMemberDemographics : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation_3>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation_3> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Member Demographics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_MemberDemographics : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation_3>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation_3> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Patient Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMG", typeof(X12_ID_1250_6))]
    public class DMG_PatientDemographicInformation : DMG, I_DMG<C056_CompositeRaceOrEthnicityInformation>
    {
        
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimePeriodFormatQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DependentBirthDate_02 { get; set; }
        /// <summary>
        /// Gender Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DependentGenderCode_03 { get; set; }
        /// <summary>
        /// Marital Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaritalStatusCode_04 { get; set; }
        /// <summary>
        /// Composite Race or Ethnicity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<C056_CompositeRaceOrEthnicityInformation> CompositeRaceOrEthnicityInformation_05 { get; set; }
        /// <summary>
        /// Citizenship Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CitizenshipStatusCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountryCode_07 { get; set; }
        /// <summary>
        /// Basis of Verification Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BasisofVerificationCode_08 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string Quantity_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string CodeListQualifierCode_10 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string IndustryCode_11 { get; set; }
    }
    
    /// <summary>
    /// Orthodontic Total Months of Treatment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DN1")]
    public class DN1_OrthodonticTotalMonthsofTreatment : DN1, I_DN1
    {
        
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string OrthodonticTreatmentMonthsCount_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string OrthodonticTreatmentMonthsRemainingCount_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string YesNoConditionorResponseCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OrthodonticTreatmentIndicator_04 { get; set; }
    }
    
    /// <summary>
    /// Tooth Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DN2")]
    public class DN2_ToothStatus : DN2, I_DN2
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ToothNumber_01 { get; set; }
        /// <summary>
        /// Tooth Status Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ToothStatusCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Quantity_03 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DateTimePeriodFormatQualifier_04 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriod_05 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CodeListQualifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Disability Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DSB", typeof(X12_ID_1146))]
    public class DSB_DisabilityInformation : DSB, I_DSB
    {
        
        /// <summary>
        /// Disability Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DisabilityTypeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Quantity_02 { get; set; }
        /// <summary>
        /// Occupation Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OccupationCode_03 { get; set; }
        /// <summary>
        /// Work Intensity Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string WorkIntensityCode_04 { get; set; }
        /// <summary>
        /// Product Option Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProductOptionCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ProductorServiceIDQualifier_07 { get; set; }
        /// <summary>
        /// Medical Code Value
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string DiagnosisCode_08 { get; set; }
    }
    
    /// <summary>
    /// Claim Received Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_11))]
    public class DTM_ClaimReceivedDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Coverage Expiration Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_35))]
    public class DTM_CoverageExpirationDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Coverage Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_33))]
    public class DTM_CoveragePeriod : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Creation Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_38))]
    public class DTM_CreationDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Delivery Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_27))]
    public class DTM_DeliveryDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Individual Coverage Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_41))]
    public class DTM_IndividualCoveragePeriod : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Process Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_15))]
    public class DTM_ProcessDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Production Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_18))]
    public class DTM_ProductionDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Service Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_42))]
    public class DTM_ServiceDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Statement From or To Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM", typeof(X12_ID_374_29))]
    public class DTM_StatementFromorToDate : DTM, I_DTM
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TimeCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriod_06 { get; set; }
    }
    
    /// <summary>
    /// Accident Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_61), typeof(X12_ID_1250_10))]
    public class DTP_AccidentDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Accident Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_19), typeof(X12_ID_1250_6))]
    public class DTP_AccidentDate_2 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Acute Manifestation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_40), typeof(X12_ID_1250_6))]
    public class DTP_AcuteManifestation : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Admission Date/Hour
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_5))]
    public class DTP_AdmissionDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Admission Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_57), typeof(X12_ID_1250_8))]
    public class DTP_AdmissionDate_2 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Admission Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_2))]
    public class DTP_AdmissionDate_3 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Admission
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250_6))]
    public class DTP_AdmissionDate_4 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Appliance Placement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_30), typeof(X12_ID_1250_6))]
    public class DTP_AppliancePlacement : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Assumed and Relinquished Care Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250_6))]
    public class DTP_AssumedandRelinquishedCareDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Authorized Return to Work
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250_6))]
    public class DTP_AuthorizedReturntoWork : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Begin Therapy Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_22), typeof(X12_ID_1250_6))]
    public class DTP_BeginTherapyDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Certification Effective Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374), typeof(X12_ID_1250_2))]
    public class DTP_CertificationEffectiveDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Certification Expiration Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_35), typeof(X12_ID_1250_6))]
    public class DTP_CertificationExpirationDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Certification Issue Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_44), typeof(X12_ID_1250_6))]
    public class DTP_CertificationIssueDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// DATE - Certification Revision/Recertification Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_21), typeof(X12_ID_1250_6))]
    public class DTP_CertificationRevision : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Check Or Remittance Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_12), typeof(X12_ID_1250_6))]
    public class DTP_ClaimCheckOrRemittanceDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Service Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250_2))]
    public class DTP_ClaimLevelServiceDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Claim Service Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits Eligibility Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_39), typeof(X12_ID_1250_6))]
    public class DTP_CoordinationofBenefitsEligibilityDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_49), typeof(X12_ID_1250_2))]
    public class DTP_SubscriberOrDependentDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_50), typeof(X12_ID_1250_2))]
    public class DTP_EligibilityOrBenefitDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility/Benefit Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_13), typeof(X12_ID_1250_2))]
    public class DTP_DependentEligibility : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility/Benefit Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_14), typeof(X12_ID_1250_2))]
    public class DTP_DependentEligibility_2 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Disability Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250_2))]
    public class DTP_DisabilityDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Disability Eligibility Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_28), typeof(X12_ID_1250_6))]
    public class DTP_DisabilityEligibilityDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Discharge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250_6))]
    public class DTP_Discharge : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Discharge Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_58), typeof(X12_ID_1250_10))]
    public class DTP_DischargeDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Discharge Hour
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250_4))]
    public class DTP_DischargeHour : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Estimated Date of Birth
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_54), typeof(X12_ID_1250_10))]
    public class DTP_EstimatedDateofBirth : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Estimated Date of Birth
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_26), typeof(X12_ID_1250_6))]
    public class DTP_EstimatedDateofBirth_2 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Event Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_56), typeof(X12_ID_1250_8))]
    public class DTP_EventDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Event Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_37), typeof(X12_ID_1250_2))]
    public class DTP_EventDate_2 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// File Effective Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_52), typeof(X12_ID_1250_6))]
    public class DTP_FileEffectiveDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_34), typeof(X12_ID_1250_2))]
    public class DTP_HealthCoverageDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Hearing and Vision Prescription Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_48), typeof(X12_ID_1250_6))]
    public class DTP_HearingandVisionPrescriptionDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Information Source Process Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_15), typeof(X12_ID_1250_6))]
    public class DTP_InformationSourceProcessDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Information Source Process Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Initial Treatment Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_32), typeof(X12_ID_1250_6))]
    public class DTP_InitialTreatmentDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Certification Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_23), typeof(X12_ID_1250_6))]
    public class DTP_LastCertificationDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Menstrual Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_16), typeof(X12_ID_1250_6))]
    public class DTP_LastMenstrualPeriod : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Last Menstrual Period Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_53), typeof(X12_ID_1250_10))]
    public class DTP_LastMenstrualPeriodDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Seen Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_36), typeof(X12_ID_1250_6))]
    public class DTP_LastSeenDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last Worked
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250_6))]
    public class DTP_LastWorked : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Last X-ray Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_46), typeof(X12_ID_1250_6))]
    public class DTP_LastXrayDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Member Level Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_17), typeof(X12_ID_1250_6))]
    public class DTP_MemberLevelDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Onset of Current Illness or Symptom
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_20), typeof(X12_ID_1250_6))]
    public class DTP_OnsetofCurrentIllnessorSymptom : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Onset of Current Symptoms or Illness Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_55), typeof(X12_ID_1250_10))]
    public class DTP_OnsetofCurrentSymptomsorIllnessDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Other UMO Denial Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_59), typeof(X12_ID_1250_10))]
    public class DTP_OtherUMODenialDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Prior Placement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_43), typeof(X12_ID_1250_6))]
    public class DTP_PriorPlacement : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Date of First Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_10), typeof(X12_ID_1250_6))]
    public class DTP_PropertyandCasualtyDateofFirstContact : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Replacement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_45), typeof(X12_ID_1250_6))]
    public class DTP_Replacement : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Repricer Received Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_11), typeof(X12_ID_1250_6))]
    public class DTP_RepricerReceivedDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Service Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250_6))]
    public class DTP_ServiceDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Service Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_60), typeof(X12_ID_1250_8))]
    public class DTP_ServiceDate_2 : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Shipped Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_25), typeof(X12_ID_1250_6))]
    public class DTP_ShippedDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Statement Dates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_31), typeof(X12_ID_1250_3))]
    public class DTP_StatementDates : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Test Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_24), typeof(X12_ID_1250_6))]
    public class DTP_TestDate : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Treatment Completion
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_2), typeof(X12_ID_1250_6))]
    public class DTP_TreatmentCompletion : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Date - Treatment Start
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTP", typeof(X12_ID_374_47), typeof(X12_ID_1250_6))]
    public class DTP_TreatmentStart : DTP, I_DTP
    {
        
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string DateTimePeriodFormatQualifier_02 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string DateTimePeriod_03 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EB", typeof(X12_ID_1390), typeof(X12_ID_1207_2))]
    public class EB_DependentEligibilityorBenefitInformation : EB, I_EB<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Eligibility or Benefit Information Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EligibilityorBenefitInformation_01 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BenefitCoverageLevelCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<string> ServiceTypeCode_03
        {
            get { return _serviceTypeCode; }
            set { _serviceTypeCode = value; }
        }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PlanCoverageDescription_05 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TimePeriodQualifier_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string BenefitAmount_07 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BenefitPercent_08 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string QuantityQualifier_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string BenefitQuantity_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string AuthorizationorCertificationIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string InPlanNetworkIndicator_12 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_13 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_14 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EB", typeof(X12_ID_1390), typeof(X12_ID_1207_4))]
    public class EB_SubscriberEligibilityorBenefitInformation : EB, I_EB<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Eligibility or Benefit Information Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EligibilityorBenefitInformation_01 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BenefitCoverageLevelCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<string> ServiceTypeCode_03
        {
            get { return _serviceTypeCode; }
            set { _serviceTypeCode = value; }
        }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PlanCoverageDescription_05 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TimePeriodQualifier_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string BenefitAmount_07 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string BenefitPercent_08 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string QuantityQualifier_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string BenefitQuantity_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string AuthorizationorCertificationIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string InPlanNetworkIndicator_12 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_13 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_14 { get; set; }
    }
    
    /// <summary>
    /// Employment Class
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EC", typeof(X12_ID_1176), typeof(X12_ID_1176))]
    public class EC_EmploymentClass : EC, I_EC
    {
        
        /// <summary>
        /// Employment Class Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EmploymentClassCode_01 { get; set; }
        /// <summary>
        /// Employment Class Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EmploymentClassCode_02 { get; set; }
        /// <summary>
        /// Employment Class Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EmploymentClassCode_03 { get; set; }
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PercentageasDecimal_04 { get; set; }
        /// <summary>
        /// Information Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string InformationStatusCode_05 { get; set; }
        /// <summary>
        /// Occupation Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string OccupationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Individual Remittance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ENT")]
    public class ENT_IndividualRemittance : ENT, I_ENT
    {
        
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityIdentifierCode_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReceiversIndividualIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityIdentifierCode_05 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string IdentificationCodeQualifier_06 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string IdentificationCode_07 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ReferenceIdentificationQualifier_08 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReferenceIdentification_09 { get; set; }
    }
    
    /// <summary>
    /// Organization Summary Remittance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ENT")]
    public class ENT_OrganizationSummaryRemittance : ENT, I_ENT
    {
        
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AssignedNumber_01 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityIdentifierCode_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReceiversIndividualIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityIdentifierCode_05 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string IdentificationCodeQualifier_06 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string IdentificationCode_07 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ReferenceIdentificationQualifier_08 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReferenceIdentification_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQ", typeof(X12_ID_1365_3), typeof(X12_ID_235_12))]
    public class EQ_DependentEligibilityorBenefitInquiry : EQ, I_EQ<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<string> ServiceTypeCode_01
        {
            get { return _serviceTypeCode; }
            set { _serviceTypeCode = value; }
        }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CoverageLevelCode_03 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_05 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQ", typeof(X12_ID_1365_3), typeof(X12_ID_235_12))]
    public class EQ_SubscriberEligibilityorBenefitInquiry : EQ, I_EQ<C003_CompositeMedicalProcedureIdentifier, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual List<string> ServiceTypeCode_01
        {
            get { return _serviceTypeCode; }
            set { _serviceTypeCode = value; }
        }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CoverageLevelCode_03 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InsuranceTypeCode_04 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_05 { get; set; }
    }
    
    /// <summary>
    /// Supporting Documentation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation : FRM, I_FRM
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuestionNumberLetter_01 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string QuestionResponse_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string QuestionResponse_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string QuestionResponse_04 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string QuestionResponse_05 { get; set; }
    }
    
    /// <summary>
    /// Claim Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCP", typeof(X12_ID_1473_2))]
    public class HCP_ClaimPricing : HCP, I_HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Claim Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_ClaimPricing_2 : HCP, I_HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Line Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_LinePricing : HCP, I_HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Line Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_LinePricing_2 : HCP, I_HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Line Pricing/Repricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_LinePricing_3 : HCP, I_HCP
    {
        
        /// <summary>
        /// Pricing Methodology
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PricingMethodology_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RepricedAllowedAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string RepricedSavingAmount_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RepricingOrganizationIdentifier_04 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string UnitorBasisforMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string Quantity_12 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string RejectReasonCode_13 { get; set; }
        /// <summary>
        /// Policy Compliance Code
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PolicyComplianceCode_14 { get; set; }
        /// <summary>
        /// Exception Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ExceptionCode_15 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCR", typeof(X12_ID_306_2))]
    public class HCR_HealthCareServicesReview : HCR, I_HCR
    {
        
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ActionCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReviewIdentificationNumber_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<string> ReviewDecisionReasonCode_03
        {
            get { return _reviewDecisionReasonCode; }
            set { _reviewDecisionReasonCode = value; }
        }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SecondSurgicalOpinionIndicator_04 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HCR", typeof(X12_ID_306_7))]
    public class HCR_HealthCareServicesReview_2 : HCR, I_HCR
    {
        
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ActionCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReviewIdentificationNumber_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<string> ReviewDecisionReasonCode_03
        {
            get { return _reviewDecisionReasonCode; }
            set { _reviewDecisionReasonCode = value; }
        }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SecondSurgicalOpinionIndicator_04 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HD", typeof(X12_ID_875), typeof(X12_ID_1203))]
    public class HD_HealthCoverage : HD, I_HD
    {
        
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string MaintenanceTypeCode_01 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MaintenanceReasonCode_02 { get; set; }
        /// <summary>
        /// Insurance Line Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string InsuranceLineCode_03 { get; set; }
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PlanCoverageDescription_04 { get; set; }
        /// <summary>
        /// Coverage Level Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CoverageLevelCode_05 { get; set; }
        /// <summary>
        /// Count
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Count_06 { get; set; }
        /// <summary>
        /// Count
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Count_07 { get; set; }
        /// <summary>
        /// Underwriting Decision Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string UnderwritingDecisionCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string LateEnrollmentIndicator_09 { get; set; }
        /// <summary>
        /// Drug House Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DrugHouseCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    /// <summary>
    /// Admitting Diagnosis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_14), typeof(X12_ID_1270_28))]
    public class HI_AdmittingDiagnosis : HI, I_HI<C022_HealthCareCodeInformation_11, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_11 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Anesthesia Related Procedure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_20), typeof(X12_ID_1270_23))]
    public class HI_AnesthesiaRelatedProcedure : HI, I_HI<C022_HealthCareCodeInformation_12, C022_HealthCareCodeInformation_15, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_12 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_15 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Condition Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_4), typeof(X12_ID_1270_4))]
    public class HI_ConditionInformation : HI, I_HI<C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13, C022_HealthCareCodeInformation_13>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_13 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Health Care Diagnosis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_11))]
    public class HI_DependentHealthCareDiagnosisCode : HI, I_HI<C022_HealthCareCodeInformation_8, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_8 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Diagnosis Related Group (DRG) Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_24), typeof(X12_ID_1270_28))]
    public class HI_DiagnosisRelatedGroup : HI, I_HI<C022_HealthCareCodeInformation_21, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_21 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// External Cause of Injury
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_22), typeof(X12_ID_1270_22))]
    public class HI_ExternalCauseofInjury : HI, I_HI<C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18, C022_HealthCareCodeInformation_18>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_18 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Health Care Diagnosis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_13), typeof(X12_ID_1270_18))]
    public class HI_HealthCareDiagnosisCode : HI, I_HI<C022_HealthCareCodeInformation_10, C022_HealthCareCodeInformation_14, C022_HealthCareCodeInformation_14, C022_HealthCareCodeInformation_14, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_10 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_14 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_14 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_14 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Occurrence Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_2), typeof(X12_ID_1270_2))]
    public class HI_OccurrenceInformation : HI, I_HI<C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6, C022_HealthCareCodeInformation_6>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_6 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Occurrence Span Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270), typeof(X12_ID_1270))]
    public class HI_OccurrenceSpanInformation : HI, I_HI<C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5, C022_HealthCareCodeInformation_5>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_5 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Other Diagnosis Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_11), typeof(X12_ID_1270_11))]
    public class HI_OtherDiagnosisInformation : HI, I_HI<C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4, C022_HealthCareCodeInformation_4>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_4 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Other Procedure Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_27), typeof(X12_ID_1270_27))]
    public class HI_OtherProcedureInformation : HI, I_HI<C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23, C022_HealthCareCodeInformation_23>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_23 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Patient's Reason For Visit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_19), typeof(X12_ID_1270_19))]
    public class HI_Patient : HI, I_HI<C022_HealthCareCodeInformation_17, C022_HealthCareCodeInformation_17, C022_HealthCareCodeInformation_17, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_17 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_17 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_17 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Diagnosis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_31), typeof(X12_ID_1270_32))]
    public class HI_PatientDiagnosis : HI, I_HI<C022_HealthCareCodeInformation_24, C022_HealthCareCodeInformation_19, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2, C022_HealthCareCodeInformation_2>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_24 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_19 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_2 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Diagnosis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_8), typeof(X12_ID_1270_12))]
    public class HI_PatientDiagnosis_2 : HI, I_HI<C022_HealthCareCodeInformation_25, C022_HealthCareCodeInformation_20, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3, C022_HealthCareCodeInformation_3>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_25 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_20 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_3 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Principal Diagnosis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_28))]
    public class HI_PrincipalDiagnosis : HI, I_HI<C022_HealthCareCodeInformation_8, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_8 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Principal Procedure Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_26), typeof(X12_ID_1270_28))]
    public class HI_PrincipalProcedureInformation : HI, I_HI<C022_HealthCareCodeInformation_22, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation, C022_HealthCareCodeInformation>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_22 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Request For Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_21), typeof(X12_ID_1270_21))]
    public class HI_RequestForAdditionalInformation : HI, I_HI<C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9, C022_HealthCareCodeInformation_9>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_9 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Treatment Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_5), typeof(X12_ID_1270_5))]
    public class HI_TreatmentCodeInformation : HI, I_HI<C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16, C022_HealthCareCodeInformation_16>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_16 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Value Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HI", typeof(X12_ID_1270_3), typeof(X12_ID_1270_3))]
    public class HI_ValueInformation : HI, I_HI<C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7, C022_HealthCareCodeInformation_7>
    {
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_01 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_02 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_03 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_04 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_05 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_06 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_07 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_08 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_09 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_10 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_11 { get; set; }
        /// <summary>
        /// Health Care Code Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C022_HealthCareCodeInformation_7 HealthCareCodeInformation_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_8))]
    public class HL_BillingProviderHierarchicalLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Of Service Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_3))]
    public class HL_BillingProviderOfServiceLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_4))]
    public class HL_DependentLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_4))]
    public class HL_DependentLevel_2 : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_11))]
    public class HL_DependentLevel_3 : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_4))]
    public class HL_DependentLevel_4 : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735))]
    public class HL_InformationReceiverLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735))]
    public class HL_InformationReceiverLevel_2 : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Information Source Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_8))]
    public class HL_InformationSourceLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_12))]
    public class HL_PatientEventLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_6))]
    public class HL_PatientEventLevel_2 : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_5))]
    public class HL_PatientLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_9))]
    public class HL_RequesterLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Service Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_13))]
    public class HL_ServiceLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Service Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_7))]
    public class HL_ServiceLevel_2 : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_3))]
    public class HL_ServiceProviderLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_2))]
    public class HL_SubscriberHierarchicalLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_10))]
    public class HL_SubscriberLevel : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL", typeof(X12_ID_735_14))]
    public class HL_UtilizationManagementOrganization : HL, I_HL
    {
        
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HierarchicalChildCode_04 { get; set; }
    }
    
    /// <summary>
    /// Member Health Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HLH", typeof(X12_ID_1212))]
    public class HLH_MemberHealthInformation : HLH, I_HLH
    {
        
        /// <summary>
        /// Health-Related Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string HealthRelatedCode_01 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberHeight_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MemberWeight_03 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string Weight_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Description_05 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CurrentHealthConditionCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HSD", typeof(X12_ID_673))]
    public class HSD_HealthCareServicesDelivery : HSD, I_HSD
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BenefitQuantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Sample Selection Modulus
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SampleSelectionModulus_04 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TimePeriodQualifier_05 { get; set; }
        /// <summary>
        /// Number of Periods
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PeriodCount_06 { get; set; }
        /// <summary>
        /// Ship/Delivery or Calendar Pattern Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DeliveryFrequencyCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HSD", typeof(X12_ID_673_12))]
    public class HSD_HealthCareServicesDelivery_2 : HSD, I_HSD
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BenefitQuantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Sample Selection Modulus
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SampleSelectionModulus_04 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TimePeriodQualifier_05 { get; set; }
        /// <summary>
        /// Number of Periods
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PeriodCount_06 { get; set; }
        /// <summary>
        /// Ship/Delivery or Calendar Pattern Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DeliveryFrequencyCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HSD", typeof(X12_ID_673))]
    public class HSD_HealthCareServicesDelivery_3 : HSD, I_HSD
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BenefitQuantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Sample Selection Modulus
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SampleSelectionModulus_04 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TimePeriodQualifier_05 { get; set; }
        /// <summary>
        /// Number of Periods
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PeriodCount_06 { get; set; }
        /// <summary>
        /// Ship/Delivery or Calendar Pattern Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DeliveryFrequencyCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HSD", typeof(X12_ID_673))]
    public class HSD_HealthCareServicesDelivery_4 : HSD, I_HSD
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BenefitQuantity_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Sample Selection Modulus
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string SampleSelectionModulus_04 { get; set; }
        /// <summary>
        /// Time Period Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TimePeriodQualifier_05 { get; set; }
        /// <summary>
        /// Number of Periods
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PeriodCount_06 { get; set; }
        /// <summary>
        /// Ship/Delivery or Calendar Pattern Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DeliveryFrequencyCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    /// <summary>
    /// Member Income
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ICM", typeof(X12_ID_594))]
    public class ICM_MemberIncome : ICM, I_ICM
    {
        
        /// <summary>
        /// Frequency Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FrequencyCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string WageAmount_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string WorkHoursCount_03 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string LocationIdentificationCode_04 { get; set; }
        /// <summary>
        /// Salary Grade
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string SalaryGradeCode_05 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CurrencyCode_06 { get; set; }
    }
    
    /// <summary>
    /// Identification Card
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IDC")]
    public class IDC_IdentificationCard : IDC, I_IDC
    {
        
        /// <summary>
        /// Plan Coverage Description
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PlanCoverageDescription_01 { get; set; }
        /// <summary>
        /// Identification Card Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IdentificationCardTypeCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCardCount_03 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ActionCode_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("III", typeof(X12_ID_1270_16))]
    public class III_DependentEligibilityorBenefitAdditionalInformation : III, I_III<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CodeCategory_03 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InjuredBodyPartName_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_06 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string SurfaceLayerPositionCode_07 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string SurfaceLayerPositionCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Eligibility or Benefit Additional Inquiry Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("III", typeof(X12_ID_1270_15))]
    public class III_DependentEligibilityorBenefitAdditionalInquiryInformation : III, I_III<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndustryCode_02 { get; set; }
        /// <summary>
        /// Code Category
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CodeCategory_03 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string InjuredBodyPartName_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_06 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string SurfaceLayerPositionCode_07 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string SurfaceLayerPositionCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073_3), typeof(X12_ID_1069))]
    public class INS_DependentRelationship : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073_3), typeof(X12_ID_1069_2))]
    public class INS_DependentRelationship_2 : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073_9), typeof(X12_ID_1069_8))]
    public class INS_DependentRelationship_3 : INS, I_INS<C052_MedicareStatusCode_2>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode_2 MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Dependent Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073_3), typeof(X12_ID_1069_3))]
    public class INS_DependentRelationship_4 : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Member Level Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073_4), typeof(X12_ID_1069_7))]
    public class INS_MemberLevelDetail : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Multiple Birth Sequence Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073), typeof(X12_ID_1069_6))]
    public class INS_MultipleBirthSequenceNumber : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073), typeof(X12_ID_1069_6))]
    public class INS_SubscriberRelationship : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073_8), typeof(X12_ID_1069_9))]
    public class INS_SubscriberRelationship_2 : INS, I_INS<C052_MedicareStatusCode_2>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode_2 MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INS", typeof(X12_ID_1073), typeof(X12_ID_1069_6))]
    public class INS_SubscriberRelationship_3 : INS, I_INS<C052_MedicareStatusCode>
    {
        
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InsuredIndicator_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Maintenance Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MaintenanceTypeCode_03 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string MaintenanceReasonCode_04 { get; set; }
        /// <summary>
        /// Benefit Status Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BenefitStatusCode_05 { get; set; }
        /// <summary>
        /// Medicare Status Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string StudentStatusCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string DateTimePeriodFormatQualifier_11 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string DateTimePeriod_12 { get; set; }
        /// <summary>
        /// Confidentiality Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ConfidentialityCode_13 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string CityName_14 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string StateorProvinceCode_15 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string CountryCode_16 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string BirthSequenceNumber_17 { get; set; }
    }
    
    /// <summary>
    /// Summary Line Item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT1")]
    public class IT1_SummaryLineItem : IT1, I_IT1
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string LineItemControlNumber_01 { get; set; }
        /// <summary>
        /// Quantity Invoiced
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string QuantityInvoiced_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public override string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public override string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public override string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(25)]
        public override string ProductServiceID_25 { get; set; }
    }
    
    /// <summary>
    /// File Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("K3")]
    public class K3_FileInformation : K3, I_K3<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Fixed Format Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FixedFormatInformation_01 { get; set; }
        /// <summary>
        /// Record Format Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string RecordFormatCode_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_03 { get; set; }
    }
    
    /// <summary>
    /// Additional Reporting Categories Termination
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LE")]
    public class LE_AdditionalReportingCategoriesTermination : LE, I_LE
    {
        
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Drug Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN_DrugIdentification : LIN, I_LIN
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProductorServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string NationalDrugCode_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public override string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public override string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public override string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(25)]
        public override string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(26)]
        public override string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(27)]
        public override string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(28)]
        public override string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(29)]
        public override string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(30)]
        public override string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(31)]
        public override string ProductServiceID_31 { get; set; }
    }
    
    /// <summary>
    /// Drug Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN_DrugIdentification_2 : LIN, I_LIN
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ProductorServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string NationalDrugCode_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(22)]
        public override string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(23)]
        public override string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(24)]
        public override string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(25)]
        public override string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(26)]
        public override string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(27)]
        public override string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(28)]
        public override string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(29)]
        public override string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(30)]
        public override string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(31)]
        public override string ProductServiceID_31 { get; set; }
    }
    
    /// <summary>
    /// Form Identification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LQ", typeof(X12_ID_1270_25))]
    public class LQ_FormIdentificationCode : LQ, I_LQ
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FormIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Health Care Remark Codes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LQ", typeof(X12_ID_1270_30))]
    public class LQ_HealthCareRemarkCodes : LQ, I_LQ
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FormIdentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Reporting Categories
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LS")]
    public class LS_AdditionalReportingCategories : LS, I_LS
    {
        
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string LoopIdentifierCode_01 { get; set; }
    }
    
    /// <summary>
    /// Member Language
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LUI", typeof(X12_ID_66_23))]
    public class LUI_MemberLanguage : LUI, I_LUI
    {
        
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string IdentificationCodeQualifier_01 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LanguageCode_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string LanguageDescription_03 { get; set; }
        /// <summary>
        /// Use of Language Indicator
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string LanguageUseIndicator_04 { get; set; }
        /// <summary>
        /// Language Proficiency Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    /// <summary>
    /// Header Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LX")]
    public class LX_HeaderNumber : LX, I_LX
    {
        
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AssignedNumber_01 { get; set; }
    }
    
    /// <summary>
    /// Test Result
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA", typeof(X12_ID_737), typeof(X12_ID_738))]
    public class MEA_TestResult : MEA, I_MEA<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string MeasurementReferenceIdentificationCode_01 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MeasurementQualifier_02 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string TestResults_03 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_04 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string RangeMinimum_05 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RangeMaximum_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MeasurementAttributeCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string SurfaceLayerPositionCode_09 { get; set; }
        /// <summary>
        /// Measurement Method or Device
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string MeasurementMethodorDevice_10 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string CodeListQualifierCode_11 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string IndustryCode_12 { get; set; }
    }
    
    /// <summary>
    /// Inpatient Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MIA")]
    public class MIA_InpatientAdjudicationInformation : MIA, I_MIA
    {
        
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CoveredDaysorVisitsCount_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string LifetimePsychiatricDaysCount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ClaimDRGAmount_04 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ClaimPaymentRemarkCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ClaimDisproportionateShareAmount_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ClaimMSPPassthroughAmount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ClaimPPSCapitalAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string PPSCapitalFSPDRGAmount_09 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string PPSCapitalHSPDRGAmount_10 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string PPSCapitalDSHDRGAmount_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string OldCapitalAmount_12 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string PPSCapitalIMEamount_13 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string PPSOperatingHospitalSpecificDRGAmount_14 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string CostReportDayCount_15 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string PPSOperatingFederalSpecificDRGAmount_16 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ClaimPPSCapitalOutlierAmount_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string ClaimIndirectTeachingAmount_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string NonpayableProfessionalComponentAmount_19 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string ClaimPaymentRemarkCode_20 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ClaimPaymentRemarkCode_21 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(22)]
        public override string ClaimPaymentRemarkCode_22 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(23)]
        public override string ClaimPaymentRemarkCode_23 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(24)]
        public override string PPSCapitalExceptionAmount_24 { get; set; }
    }
    
    /// <summary>
    /// Outpatient Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_OutpatientAdjudicationInformation : MOA, I_MOA
    {
        
        /// <summary>
        /// Percentage as Decimal
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReimbursementRate_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string HCPCSPayableAmount_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ClaimPaymentRemarkCode_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ClaimPaymentRemarkCode_04 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ClaimPaymentRemarkCode_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ClaimPaymentRemarkCode_06 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ClaimPaymentRemarkCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Military Personnel Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MPI", typeof(X12_ID_1201), typeof(X12_ID_584))]
    public class MPI_DependentMilitaryPersonnelInformation : MPI, I_MPI
    {
        
        /// <summary>
        /// Information Status Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string InformationStatusCode_01 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EmploymentStatusCode_02 { get; set; }
        /// <summary>
        /// Government Service Affiliation Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string GovernmentServiceAffiliationCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string Description_04 { get; set; }
        /// <summary>
        /// Military Service Rank Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MilitaryServiceRankCode_05 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string DateTimePeriodFormatQualifier_06 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string DateTimePeriod_07 { get; set; }
    }
    
    /// <summary>
    /// Message Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSG")]
    public class MSG_MessageText : MSG, I_MSG
    {
        
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FreeFormMessageText_01 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PrinterCarriageControlCode_02 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Number_03 { get; set; }
    }
    
    /// <summary>
    /// Message Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSG")]
    public class MSG_MessageText_2 : MSG, I_MSG
    {
        
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string FreeFormMessageText_01 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PrinterCarriageControlCode_02 { get; set; }
        /// <summary>
        /// Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Number_03 { get; set; }
    }
    
    /// <summary>
    /// Intermediary Bank Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_34))]
    public class N1_IntermediaryBankInformation : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Payee Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_23))]
    public class N1_PayeeIdentification : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Payer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_24))]
    public class N1_Payer : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Payer Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_29))]
    public class N1_PayerIdentification : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Premium Payer's Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_29))]
    public class N1_PremiumPayer : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Premium Receiver's Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_23))]
    public class N1_PremiumReceiver : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Reporting Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_17))]
    public class N1_ReportingCategory : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Sponsor Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_60))]
    public class N1_SponsorName : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// TPA/Broker Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1", typeof(X12_ID_98_30))]
    public class N1_TPA : N1, I_N1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumPayerName_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string IntermediaryBankIdentifier_04 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string EntityRelationshipCode_05 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string EntityIdentifierCode_06 { get; set; }
    }
    
    /// <summary>
    /// Intermediary Bank Additional Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N2")]
    public class N2_IntermediaryBankAdditionalName : N2, I_N2
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string IntermediaryBankAdditionalName_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Name_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N3")]
    public class N3_AdditionalPatientInformationContactAddress : N3, I_N3
    {
        
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ResponseContactAddressLine_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactAddressLine_02 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_AdditionalPatientInformationContactCity : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Dependent Benefit Related Entity City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_DependentBenefitRelatedEntityCity : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Dependent City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_DependentCity : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Member City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_MemberCity : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Location City/State/ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_PatientEventTransportLocationCity : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Location City/State/ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_PatientEventTransportLocationCity_2 : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Provider City, State, ZIP Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4_ProviderCity : N4, I_N4
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AdditionalPatientInformationContactCityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AdditionalPatientInformationContactStateCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AdditionalPatientInformationContactPostalZoneorZIPCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LocationIdentifier_06 { get; set; }
        /// <summary>
        /// Country Subdivision Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CountrySubdivisionCode_07 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_43), typeof(X12_ID_1065_2))]
    public class NM1_AdditionalPatientInformationContactName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Drop-off Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065_3))]
    public class NM1_AmbulanceDrop : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Pick-up Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_3))]
    public class NM1_AmbulancePick : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065))]
    public class NM1_AssistantSurgeonName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Attending Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_55), typeof(X12_ID_1065))]
    public class NM1_AttendingProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_2))]
    public class NM1_BillingProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Provider Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Provider First Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Provider Middle Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Provider Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Billing Provider Identifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_2))]
    public class NM1_BillingProviderName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_3))]
    public class NM1_BillingProviderName_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Coordination of Benefits Related Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_15), typeof(X12_ID_1065_3))]
    public class NM1_CoordinationofBenefitsRelatedEntity : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Corrected Patient/Insured Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_41), typeof(X12_ID_1065_2))]
    public class NM1_CorrectedPatient : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Corrected Priority Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_29), typeof(X12_ID_1065_3))]
    public class NM1_CorrectedPriorityPayerName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Crossover Carrier Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_50), typeof(X12_ID_1065_3))]
    public class NM1_CrossoverCarrierName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Custodial Parent
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98), typeof(X12_ID_1065))]
    public class NM1_CustodialParent : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Benefit Related Entity Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_33), typeof(X12_ID_1065_2))]
    public class NM1_DependentBenefitRelatedEntityName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_32), typeof(X12_ID_1065))]
    public class NM1_DependentName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_DependentName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_64), typeof(X12_ID_1065_4))]
    public class NM1_DependentName_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Dependent Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_DependentName_4 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Drop Off Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065))]
    public class NM1_DropOffLocation : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Incorrect Member Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_40), typeof(X12_ID_1065))]
    public class NM1_IncorrectMemberName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Individual Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_48), typeof(X12_ID_1065))]
    public class NM1_IndividualName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_20), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_20), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_21), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_21), typeof(X12_ID_1065_2))]
    public class NM1_InformationReceiverName_4 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Information Receiver Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Information Receiver First Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Information Receiver Middle Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Information Receiver Primary Identifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Source Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_56), typeof(X12_ID_1065_2))]
    public class NM1_InformationSourceName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Information Source Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_57), typeof(X12_ID_1065_3))]
    public class NM1_InformationSourceName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Information Source Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Information Source Identifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Insured Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_InsuredName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member Employer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_49), typeof(X12_ID_1065_2))]
    public class NM1_MemberEmployer : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member Mailing Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_45), typeof(X12_ID_1065))]
    public class NM1_MemberMailingAddress : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_35), typeof(X12_ID_1065))]
    public class NM1_MemberName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Member School
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_52), typeof(X12_ID_1065_3))]
    public class NM1_MemberSchool : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Operating Physician Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_3), typeof(X12_ID_1065))]
    public class NM1_OperatingPhysicianName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_18), typeof(X12_ID_1065))]
    public class NM1_OrderingProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Operating Physician Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_6), typeof(X12_ID_1065))]
    public class NM1_OtherOperatingPhysicianName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Assistant Surgeon
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerAssistantSurgeon : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Attending Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_55), typeof(X12_ID_1065))]
    public class NM1_OtherPayerAttendingProvider : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerBillingProvider : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Billing Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_31), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerBillingProvider_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_29), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Operating Physician
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_3), typeof(X12_ID_1065))]
    public class NM1_OtherPayerOperatingPhysician : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Other Operating Physician
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_6), typeof(X12_ID_1065))]
    public class NM1_OtherPayerOtherOperatingPhysician : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_54), typeof(X12_ID_1065))]
    public class NM1_OtherPayerReferringProvider : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referring Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065))]
    public class NM1_OtherPayerReferringProvider_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065))]
    public class NM1_OtherPayerRenderingProvider : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Rendering Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerRenderingProvider_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerServiceFacilityLocation : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Supervising Provider
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_OtherPayerSupervisingProvider : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_OtherSubscriberName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_53), typeof(X12_ID_1065_2))]
    public class NM1_OtherSubscriberName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Other UMO Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_67), typeof(X12_ID_1065_5))]
    public class NM1_PatientEventOtherUMOName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_65), typeof(X12_ID_1065_6))]
    public class NM1_PatientEventProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_38), typeof(X12_ID_1065_2))]
    public class NM1_PatientEventProviderName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_66), typeof(X12_ID_1065_5))]
    public class NM1_PatientEventTransportInformation : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Transport Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_47), typeof(X12_ID_1065_3))]
    public class NM1_PatientEventTransportInformation_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_PatientName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Patient Last Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Patient First Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Patient Middle Name or Initial
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Patient Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Patient Identification Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_PatientName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Patient Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065))]
    public class NM1_PatientName_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-to Address Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_36), typeof(X12_ID_1065_2))]
    public class NM1_Pay : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-to Address Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_36), typeof(X12_ID_1065_3))]
    public class NM1_Pay_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_23), typeof(X12_ID_1065_3))]
    public class NM1_Pay_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_2))]
    public class NM1_ProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065_2))]
    public class NM1_ProviderName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_2))]
    public class NM1_PurchasedServiceProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Receiver Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_25), typeof(X12_ID_1065_3))]
    public class NM1_ReceiverName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_54), typeof(X12_ID_1065))]
    public class NM1_ReferringProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Referring Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065))]
    public class NM1_ReferringProviderName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065_2))]
    public class NM1_RenderingProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065))]
    public class NM1_RenderingProviderName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Requester Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_62), typeof(X12_ID_1065_6))]
    public class NM1_RequesterName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Requester Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_22), typeof(X12_ID_1065_2))]
    public class NM1_RequesterName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Responsible Person
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_4), typeof(X12_ID_1065))]
    public class NM1_ResponsiblePerson : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Service Facility Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065_3))]
    public class NM1_ServiceFacilityLocation : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_68), typeof(X12_ID_1065_6))]
    public class NM1_ServiceProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_51), typeof(X12_ID_1065_2))]
    public class NM1_ServiceProviderName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_2), typeof(X12_ID_1065_2))]
    public class NM1_ServiceProviderName_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_SubscriberName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_SubscriberName_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_63), typeof(X12_ID_1065_4))]
    public class NM1_SubscriberName_3 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065))]
    public class NM1_SubscriberName_4 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_26), typeof(X12_ID_1065_2))]
    public class NM1_SubscriberName_5 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Supervising Provider Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065))]
    public class NM1_SupervisingProviderName : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_69), typeof(X12_ID_1065_6))]
    public class NM1_UtilizationManagementOrganization : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Utilization Management Organization (UMO) Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NM1", typeof(X12_ID_98_58), typeof(X12_ID_1065_2))]
    public class NM1_UtilizationManagementOrganization_2 : NM1, I_NM1
    {
        
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Entity Type Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityTypeQualifier_02 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ResponseContactLastorOrganizationName_03 { get; set; }
        /// <summary>
        /// Name First
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactFirstName_04 { get; set; }
        /// <summary>
        /// Name Middle
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ResponseContactMiddleName_05 { get; set; }
        /// <summary>
        /// Name Prefix
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string NamePrefix_06 { get; set; }
        /// <summary>
        /// Name Suffix
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string ResponseContactNameSuffix_07 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string IdentificationCodeQualifier_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ResponseContactIdentifier_09 { get; set; }
        /// <summary>
        /// Entity Relationship Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string EntityRelationshipCode_10 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EntityIdentifierCode_11 { get; set; }
        /// <summary>
        /// Name Last or Organization Name
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string NameLastorOrganizationName_12 { get; set; }
    }
    
    /// <summary>
    /// Billing Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE", typeof(X12_ID_363))]
    public class NTE_BillingNote : NTE, I_NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Claim Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE", typeof(X12_ID_363_4))]
    public class NTE_ClaimNote : NTE, I_NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Claim Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE", typeof(X12_ID_363_5))]
    public class NTE_ClaimNote_2 : NTE, I_NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Line Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE", typeof(X12_ID_363_2))]
    public class NTE_LineNote : NTE, I_NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Third Party Organization Notes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE", typeof(X12_ID_363_3))]
    public class NTE_ThirdPartyOrganizationNotes : NTE, I_NTE
    {
        
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string BillingNoteText_02 { get; set; }
    }
    
    /// <summary>
    /// Other Insurance Coverage Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OI", typeof(X12_ID_1032), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation : OI, I_OI
    {
        
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ClaimFilingIndicatorCode_01 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ClaimSubmissionReasonCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PatientSignatureSourceCode_04 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProviderAgreementCode_05 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ReleaseofInformationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Other Insurance Coverage Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OI", typeof(X12_ID_1032), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation_2 : OI, I_OI
    {
        
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ClaimFilingIndicatorCode_01 { get; set; }
        /// <summary>
        /// Claim Submission Reason Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ClaimSubmissionReasonCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        /// <summary>
        /// Patient Signature Source Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string PatientSignatureSourceCode_04 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProviderAgreementCode_05 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ReleaseofInformationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT", typeof(X12_ID_1069_2), typeof(X12_ID_1384))]
    public class PAT_PatientInformation : PAT, I_PAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT", typeof(X12_ID_1069_2), typeof(X12_ID_1384))]
    public class PAT_PatientInformation_2 : PAT, I_PAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Patient Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT", typeof(X12_ID_1069_5), typeof(X12_ID_1384))]
    public class PAT_PatientInformation_3 : PAT, I_PAT
    {
        
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string IndividualRelationshipCode_01 { get; set; }
        /// <summary>
        /// Patient Location Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PatientLocationCode_02 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string EmploymentStatusCode_03 { get; set; }
        /// <summary>
        /// Student Status Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StudentStatusCode_04 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DateTimePeriodFormatQualifier_05 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string PatientDeathDate_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PatientWeight_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string PregnancyIndicator_09 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_AdditionalPatientInformationContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Additional Service Information Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_AdditionalServiceInformationContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Administrative Communications Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_7))]
    public class PER_AdministrativeCommunicationsContact : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_BillingProviderContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_9))]
    public class PER_ClaimContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Custodial Parent Communications Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_5))]
    public class PER_CustodialParentCommunicationsNumbers : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Dependent Benefit Related Entity Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_DependentBenefitRelatedEntityContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Information Source Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_InformationSourceContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Intermediary Bank's Administrative Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_IntermediaryBank : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Member Communications Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_8))]
    public class PER_MemberCommunicationsNumbers : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Member Employer Communications Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_MemberEmployerCommunicationsNumbers : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Member School Commmunications Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_3))]
    public class PER_MemberSchoolCommmunicationsNumbers : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_10))]
    public class PER_PatientEventProviderContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Payer Business Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_9))]
    public class PER_PayerBusinessContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Payer Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_PayerContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Payer Technical Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_2))]
    public class PER_PayerTechnicalContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Payer WEB Site
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_PayerWEBSite : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_PropertyandCasualtyPatientContactInformation : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Provider Communications Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_ProviderCommunicationsNumbers : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Responsible Person Communications Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER", typeof(X12_ID_366_6))]
    public class PER_ResponsiblePersonCommunicationsNumbers : PER, I_PER
    {
        
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ResponseContactName_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ResponseContactCommunicationNumber_04 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string CommunicationNumberQualifier_05 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ResponseContactCommunicationNumber_06 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CommunicationNumberQualifier_07 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ResponseContactCommunicationNumber_08 { get; set; }
        /// <summary>
        /// Contact Inquiry Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ContactInquiryReference_09 { get; set; }
    }
    
    /// <summary>
    /// Provider Change Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PLA", typeof(X12_ID_306_4), typeof(X12_ID_98_12))]
    public class PLA_ProviderChangeReason : PLA, I_PLA
    {
        
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ActionCode_01 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string EntityIdentifierCode_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderEffectiveDate_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string Time_04 { get; set; }
        /// <summary>
        /// Maintenance Reason Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MaintenanceReasonCode_05 { get; set; }
    }
    
    /// <summary>
    /// Provider Adjustment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PLB")]
    public class PLB_ProviderAdjustment : PLB, I_PLB<C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier, C042_AdjustmentIdentifier>
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FiscalPeriodDate_02 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C042_AdjustmentIdentifier AdjustmentIdentifier_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProviderAdjustmentAmount_04 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C042_AdjustmentIdentifier AdjustmentIdentifier_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderAdjustmentAmount_06 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C042_AdjustmentIdentifier AdjustmentIdentifier_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string ProviderAdjustmentAmount_08 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C042_AdjustmentIdentifier AdjustmentIdentifier_09 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProviderAdjustmentAmount_10 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C042_AdjustmentIdentifier AdjustmentIdentifier_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string ProviderAdjustmentAmount_12 { get; set; }
        /// <summary>
        /// Adjustment Identifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual C042_AdjustmentIdentifier AdjustmentIdentifier_13 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string ProviderAdjustmentAmount_14 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_7), typeof(X12_ID_128_35))]
    public class PRV_AssistantSurgeonSpecialtyInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Attending Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_4), typeof(X12_ID_128_35))]
    public class PRV_AttendingProviderSpecialtyInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_10), typeof(X12_ID_128_35))]
    public class PRV_BillingProviderSpecialtyInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Dependent Benefit Related Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_8), typeof(X12_ID_128_35))]
    public class PRV_DependentBenefitRelatedProviderInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_11), typeof(X12_ID_128_88))]
    public class PRV_PatientEventProviderInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation_2>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation_2 ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128_35))]
    public class PRV_PatientEventProviderInformation_2 : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221), typeof(X12_ID_128_52))]
    public class PRV_ProviderInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221), typeof(X12_ID_128_35))]
    public class PRV_ProviderInformation_2 : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Referring Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_3), typeof(X12_ID_128_35))]
    public class PRV_ReferringProviderSpecialtyInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_5), typeof(X12_ID_128_35))]
    public class PRV_RenderingProviderSpecialtyInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Requester Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_13), typeof(X12_ID_128_88))]
    public class PRV_RequesterProviderInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation_2>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation_2 ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Requester Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_9), typeof(X12_ID_128_35))]
    public class PRV_RequesterProviderInformation_2 : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_12), typeof(X12_ID_128_88))]
    public class PRV_ServiceProviderInformation : PRV, I_PRV<C035_ProviderSpecialtyInformation_2>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation_2 ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV", typeof(X12_ID_1221_6), typeof(X12_ID_128_35))]
    public class PRV_ServiceProviderInformation_2 : PRV, I_PRV<C035_ProviderSpecialtyInformation>
    {
        
        /// <summary>
        /// Provider Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderCode_01 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReferenceIdentificationQualifier_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ProviderTaxonomyCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Provider Specialty Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        /// <summary>
        /// Provider Organization Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProviderOrganizationCode_06 { get; set; }
    }
    
    /// <summary>
    /// Purchased Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation : PS1, I_PS1
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PurchasedServiceProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PurchasedServiceChargeAmount_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string StateorProvinceCode_03 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK", typeof(X12_ID_755_6), typeof(X12_ID_756_6))]
    public class PWK_AdditionalPatientInformation : PWK, I_PWK<C002_ActionsIndicated>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Additional Patient Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK", typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
    public class PWK_AdditionalPatientInformation_2 : PWK, I_PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK", typeof(X12_ID_755_4), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation : PWK, I_PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK", typeof(X12_ID_755), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation_2 : PWK, I_PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK", typeof(X12_ID_755_5), typeof(X12_ID_756_5))]
    public class PWK_ClaimSupplementalInformation_3 : PWK, I_PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Certificate of Medical Necessity Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK", typeof(X12_ID_755_2), typeof(X12_ID_756))]
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator : PWK, I_PWK<C002_ActionsIndicated_2>
    {
        
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AttachmentReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AttachmentControlNumber_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AttachmentDescription_07 { get; set; }
        /// <summary>
        /// Actions Indicated
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string RequestCategoryCode_09 { get; set; }
    }
    
    /// <summary>
    /// Ambulance Patient Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_11))]
    public class QTY_AmbulancePatientCount : QTY, I_QTY<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Supplemental Information Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_10))]
    public class QTY_ClaimSupplementalInformationQuantity : QTY, I_QTY<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Obstetric Anesthesia Additional Units
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_4))]
    public class QTY_ObstetricAnesthesiaAdditionalUnits : QTY, I_QTY<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Service Supplemental Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_3))]
    public class QTY_ServiceSupplementalQuantity : QTY, I_QTY<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Accepted Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_5))]
    public class QTY_TotalAcceptedQuantity : QTY, I_QTY<C001_CompositeUnitOfMeasure_3>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure_3 CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Accepted Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_8))]
    public class QTY_TotalAcceptedQuantity_2 : QTY, I_QTY<C001_CompositeUnitOfMeasure_3>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Accepted Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure_3 CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Rejected Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_6))]
    public class QTY_TotalRejectedQuantity : QTY, I_QTY<C001_CompositeUnitOfMeasure_3>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure_3 CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Total Rejected Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_2))]
    public class QTY_TotalRejectedQuantity_2 : QTY, I_QTY<C001_CompositeUnitOfMeasure_3>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Total Rejected Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure_3 CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Transaction Set Control Totals
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY", typeof(X12_ID_673_9))]
    public class QTY_TransactionSetControlTotals : QTY, I_QTY<C001_CompositeUnitOfMeasure>
    {
        
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AmbulancePatientCount_02 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C001_CompositeUnitOfMeasure CompositeUnitOfMeasure_03 { get; set; }
        /// <summary>
        /// Free-form Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string FreeformInformation_04 { get; set; }
    }
    
    /// <summary>
    /// Premium Receiver's Remittance Delivery Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RDM", typeof(X12_ID_756_3))]
    public class RDM_PremiumReceiver : RDM, I_RDM<C040_ReferenceIdentifier, C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RemittanceDeliveryMethodCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumReceiversLastorOrganizationName_02 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PremiumReceiversCommunicationNumber_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_05 { get; set; }
    }
    
    /// <summary>
    /// Remittance Delivery Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RDM", typeof(X12_ID_756_4))]
    public class RDM_RemittanceDeliveryMethod : RDM, I_RDM<C040_ReferenceIdentifier, C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RemittanceDeliveryMethodCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string PremiumReceiversLastorOrganizationName_02 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PremiumReceiversCommunicationNumber_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_05 { get; set; }
    }
    
    /// <summary>
    /// Additional Coordination of Benefits Identifiers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_77))]
    public class REF_AdditionalCoordinationofBenefitsIdentifiers : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Additional Payer Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_49))]
    public class REF_AdditionalPayerIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Claim Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_12))]
    public class REF_AdjustedRepricedClaimNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Adjusted Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_33))]
    public class REF_AdjustedRepricedLineItemReferenceNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Administrative Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_65))]
    public class REF_AdministrativeReferenceNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Application or Location System Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_ApplicationorLocationSystemIdentifier : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Assistant Surgeon Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_23))]
    public class REF_AssistantSurgeonSecondaryIdentification : REF, I_REF<C040_ReferenceIdentifier_3>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_2))]
    public class REF_BillingProviderSecondaryIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_21))]
    public class REF_BillingProviderTaxIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Tax Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_22))]
    public class REF_BillingProviderTaxIdentification_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider UPIN/License Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_50))]
    public class REF_BillingProviderUPIN : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Care Plan Oversight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_29))]
    public class REF_CarePlanOversight : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Identification Number For Clearinghouses and Other Transmission Intermediaries
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ClaimIdentificationNumberForClearinghousesAndOtherTransmissionIntermediaries : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Clinical Laboratory Improvement Amendment (CLIA) Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_ClinicalLaboratoryImprovementAmendment : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Demonstration Project Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_19))]
    public class REF_DemonstrationProjectIdentifier : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_71))]
    public class REF_DependentAdditionalIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_70))]
    public class REF_DependentAdditionalIdentification_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_62))]
    public class REF_DependentAdditionalIdentification_3 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Additional Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_61))]
    public class REF_DependentAdditionalInformation : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_90))]
    public class REF_DependentSupplementalIdentification : REF, I_REF<C040_ReferenceIdentifier_2>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_56))]
    public class REF_DependentSupplementalIdentification_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Group Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_54))]
    public class REF_GroupNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// HealthCare Policy Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_4))]
    public class REF_HealthCarePolicyIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Health Coverage Policy Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_67))]
    public class REF_HealthCoveragePolicyNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Immunization Batch Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_42))]
    public class REF_ImmunizationBatchNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Information Receiver Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_81))]
    public class REF_InformationReceiverAdditionalIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Institutional Bill Type Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_36))]
    public class REF_InstitutionalBillTypeIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Investigational Device Exemption Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_InvestigationalDeviceExemptionNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Line Item Control Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_28))]
    public class REF_LineItemControlNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Mammography Certification Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_11))]
    public class REF_MammographyCertificationNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Mandatory Medicare (Section 4081) Crossover Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_9), typeof(X12_ID_127_2))]
    public class REF_MandatoryMedicare : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Medical Record Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_MedicalRecordNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Member Policy Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_48))]
    public class REF_MemberPolicyNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Member Supplemental Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_58))]
    public class REF_MemberSupplementalIdentifier : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Ordering Provider Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_18))]
    public class REF_OrderingProviderSecondaryIdentification : REF, I_REF<C040_ReferenceIdentifier_3>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Claim Related Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_68))]
    public class REF_OtherClaimRelatedIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Adjustment Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_OtherPayerClaimAdjustmentIndicator : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Claim Control Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_OtherPayerClaimControlNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Predetermination Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_5))]
    public class REF_OtherPayerPredeterminationIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Prior Authorization Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_6))]
    public class REF_OtherPayerPriorAuthorizationNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Referral Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_3))]
    public class REF_OtherPayerReferralNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Secondary Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_75))]
    public class REF_OtherPayerSecondaryIdentifier : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Payer Service Facility Location Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_60))]
    public class REF_OtherSubscriberSecondaryIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Other UMO Denial Reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_94))]
    public class REF_OtherUMODenialReason : REF, I_REF<C040_ReferenceIdentifier_8>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_8 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Control Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_45))]
    public class REF_PatientControlNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_76))]
    public class REF_PatientEventProviderSupplementalIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Provider Supplemental Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_93))]
    public class REF_PatientEventProviderSupplementalInformation : REF, I_REF<C040_ReferenceIdentifier_2>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Pay-To Plan Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_51))]
    public class REF_Pay : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Payee Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_59))]
    public class REF_PayeeAdditionalIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Payer Claim Control Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_37))]
    public class REF_PayerClaimControlNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Peer Review Organization (PRO) Approval Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_24))]
    public class REF_PeerReviewOrganization : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Pharmacy Prescription Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_55))]
    public class REF_PharmacyPrescriptionNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Premium Receivers Identification Key
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_84))]
    public class REF_PremiumReceiversIdentificationKey : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Prescription or Compound Drug Association Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_34))]
    public class REF_PrescriptionorCompoundDrugAssociationNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Previous Review Administrative Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_92))]
    public class REF_PreviousReviewAdministrativeReferenceNumber : REF, I_REF<C040_ReferenceIdentifier_2>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Previous Review Authorization Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_91))]
    public class REF_PreviousReviewAuthorizationNumber : REF, I_REF<C040_ReferenceIdentifier_2>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Previous Review Authorization Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_72))]
    public class REF_PreviousReviewAuthorizationNumber_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Prior Coverage Months
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_73))]
    public class REF_PriorCoverageMonths : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Claim Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_69))]
    public class REF_PropertyandCasualtyClaimNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Patient Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_31))]
    public class REF_PropertyandCasualtyPatientIdentifier : REF, I_REF<C040_ReferenceIdentifier_7>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_7 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Provider Secondary Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_82))]
    public class REF_ProviderSecondaryIdentifier : REF, I_REF<C040_ReferenceIdentifier_5>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Billing Provider Additional Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_5 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Receiver Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_86))]
    public class REF_ReceiverIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_66))]
    public class REF_ReferenceInformation : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_47))]
    public class REF_ReferenceInformation_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_41))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendment : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_74))]
    public class REF_RenderingProviderIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Rendering Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128))]
    public class REF_RenderingProviderInformation : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Reporting Category Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_80))]
    public class REF_ReportingCategoryReference : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Claim Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_RepricedClaimNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Repriced Line Item Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_32))]
    public class REF_RepricedLineItemReferenceNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_95))]
    public class REF_RequesterSupplementalIdentification : REF, I_REF<C040_ReferenceIdentifier_2>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Requester Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_83))]
    public class REF_RequesterSupplementalIdentification_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Authorization Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_7), typeof(X12_ID_127))]
    public class REF_ServiceAuthorizationExceptionCode : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Facility Location Secondary Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_30))]
    public class REF_ServiceFacilityLocationSecondaryIdentification : REF, I_REF<C040_ReferenceIdentifier_3>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_78))]
    public class REF_ServiceIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Line Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_64))]
    public class REF_ServiceLineItemIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Service Provider Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_79))]
    public class REF_ServiceProviderSupplementalIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_53))]
    public class REF_SubscriberAdditionalIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_43))]
    public class REF_SubscriberAdditionalIdentification_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Additional Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_44))]
    public class REF_SubscriberAdditionalIdentification_3 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_39))]
    public class REF_SubscriberIdentifier : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_89))]
    public class REF_SubscriberSupplementalIdentification : REF, I_REF<C040_ReferenceIdentifier_2>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Supplemental Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_46))]
    public class REF_SubscriberSupplementalIdentification_2 : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Transaction Set Policy Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_85))]
    public class REF_TransactionSetPolicyNumber : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Version Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_40))]
    public class REF_VersionIdentification : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Voucher Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF", typeof(X12_ID_128_63))]
    public class REF_VoucherIdentifier : REF, I_REF<C040_ReferenceIdentifier>
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string MemberGrouporPolicyNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string Description_03 { get; set; }
        /// <summary>
        /// Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Individual Premium Remittance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RMR", typeof(X12_ID_128_57))]
    public class RMR_IndividualPremiumRemittanceDetail : RMR, I_RMR
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string InsuranceRemittanceReferenceNumber_02 { get; set; }
        /// <summary>
        /// Payment Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PaymentActionCode_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DetailPremiumPaymentAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BilledPremiumAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AdjustmentReasonCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
    }
    
    /// <summary>
    /// Organization Summary Remittance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RMR", typeof(X12_ID_128_38))]
    public class RMR_OrganizationSummaryRemittanceDetail : RMR, I_RMR
    {
        
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string InsuranceRemittanceReferenceNumber_02 { get; set; }
        /// <summary>
        /// Payment Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PaymentActionCode_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DetailPremiumPaymentAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string BilledPremiumAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string AdjustmentReasonCode_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
    }
    
    /// <summary>
    /// Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SAC", typeof(X12_ID_248), typeof(X12_ID_1300))]
    public class SAC_Service : SAC, I_SAC
    {
        
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string AllowanceorChargeIndicator_01 { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ServicePromotionAllowanceorChargeCode_02 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string AgencyQualifierCode_03 { get; set; }
        /// <summary>
        /// Agency Service, Promotion, Allowance, or Charge Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Amount_05 { get; set; }
        /// <summary>
        /// Allowance/Charge Percent Qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string AllowanceChargePercentQualifier_06 { get; set; }
        /// <summary>
        /// Percent, Decimal Format
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PercentDecimalFormat_07 { get; set; }
        /// <summary>
        /// Rate
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Rate_08 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string UnitorBasisforMeasurementCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string Quantity_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string Quantity_11 { get; set; }
        /// <summary>
        /// Allowance or Charge Method of Handling Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ReferenceIdentification_13 { get; set; }
        /// <summary>
        /// Option Number
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string OptionNumber_14 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string Description_15 { get; set; }
        /// <summary>
        /// Language Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string LanguageCode_16 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_4))]
    public class SBR_OtherSubscriberInformation : SBR, I_SBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Other Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_4))]
    public class SBR_OtherSubscriberInformation_2 : SBR, I_SBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_6))]
    public class SBR_SubscriberInformation : SBR, I_SBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SBR", typeof(X12_ID_1138_2), typeof(X12_ID_1069_6))]
    public class SBR_SubscriberInformation_2 : SBR, I_SBR
    {
        
        /// <summary>
        /// Payer Responsibility Sequence Number Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        /// <summary>
        /// Individual Relationship Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string IndividualRelationshipCode_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string InsuredGrouporPolicyNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string OtherInsuredGroupName_04 { get; set; }
        /// <summary>
        /// Insurance Type Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string InsuranceTypeCode_05 { get; set; }
        /// <summary>
        /// Coordination of Benefits Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string CoordinationofBenefitsCode_06 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string YesNoConditionorResponseCode_07 { get; set; }
        /// <summary>
        /// Employment Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string EmploymentStatusCode_08 { get; set; }
        /// <summary>
        /// Claim Filing Indicator Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    /// <summary>
    /// Member Count
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SLN")]
    public class SLN_MemberCount : SLN, I_SLN<C001_CompositeUnitOfMeasure_4>
    {
        
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string LineItemControlNumber_01 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string AssignedIdentification_02 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string InformationOnlyIndicator_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string HeadCount_04 { get; set; }
        /// <summary>
        /// Composite Unit of Measure
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C001_CompositeUnitOfMeasure_4 CompositeUnitOfMeasure_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string UnitPrice_06 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string BasisofUnitPriceCode_07 { get; set; }
        /// <summary>
        /// Relationship Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string RelationshipCode_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(22)]
        public override string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(23)]
        public override string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(24)]
        public override string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(25)]
        public override string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(26)]
        public override string ProductServiceID_26 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Pos(27)]
        public override string ProductServiceIDQualifier_27 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(28)]
        public override string ProductServiceID_28 { get; set; }
    }
    
    /// <summary>
    /// Billing Provider Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STC")]
    public class STC_BillingProviderStatusInformation : STC, I_STC<C043_HealthCareClaimStatus_6, C043_HealthCareClaimStatus_6, C043_HealthCareClaimStatus_6>
    {
        
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C043_HealthCareClaimStatus_6 HealthCareClaimStatus_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ActionCode_03 { get; set; }
        /// <summary>
        /// Total Submitted Charges for Unit Work
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TotalSubmittedChargesForUnitWork_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Date_06 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PaymentMethodCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Check Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string CheckNumber_09 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C043_HealthCareClaimStatus_6 HealthCareClaimStatus_10 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C043_HealthCareClaimStatus_6 HealthCareClaimStatus_11 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FreeformMessageText_12 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STC")]
    public class STC_ClaimLevelStatusInformation : STC, I_STC<C043_HealthCareClaimStatus, C043_HealthCareClaimStatus, C043_HealthCareClaimStatus>
    {
        
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C043_HealthCareClaimStatus HealthCareClaimStatus_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ActionCode_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TotalSubmittedChargesForUnitWork_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Date_06 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PaymentMethodCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Check Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string CheckNumber_09 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C043_HealthCareClaimStatus HealthCareClaimStatus_10 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C043_HealthCareClaimStatus HealthCareClaimStatus_11 { get; set; }
        /// <summary>
        /// Free-form Message Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FreeformMessageText_12 { get; set; }
    }
    
    /// <summary>
    /// Claim Level Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STC")]
    public class STC_ClaimLevelStatusInformation_2 : STC, I_STC<C043_HealthCareClaimStatus_2, C043_HealthCareClaimStatus_2, C043_HealthCareClaimStatus_2>
    {
        
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C043_HealthCareClaimStatus_2 HealthCareClaimStatus_01 { get; set; }
        /// <summary>
        /// Status Information Effective Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Status Information Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ActionCode_03 { get; set; }
        /// <summary>
        /// Total Claim Charge Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TotalSubmittedChargesForUnitWork_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Date_06 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PaymentMethodCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Check Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string CheckNumber_09 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C043_HealthCareClaimStatus_2 HealthCareClaimStatus_10 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C043_HealthCareClaimStatus_2 HealthCareClaimStatus_11 { get; set; }
        /// <summary>
        /// Free Form Message Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FreeformMessageText_12 { get; set; }
    }
    
    /// <summary>
    /// Service Line Level Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STC")]
    public class STC_ServiceLineLevelStatusInformation : STC, I_STC<C043_HealthCareClaimStatus_2, C043_HealthCareClaimStatus_2, C043_HealthCareClaimStatus_2>
    {
        
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C043_HealthCareClaimStatus_2 HealthCareClaimStatus_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string Date_02 { get; set; }
        /// <summary>
        /// Action Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ActionCode_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TotalSubmittedChargesForUnitWork_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string Date_06 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PaymentMethodCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string Date_08 { get; set; }
        /// <summary>
        /// Check Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string CheckNumber_09 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C043_HealthCareClaimStatus_2 HealthCareClaimStatus_10 { get; set; }
        /// <summary>
        /// Health Care Claim Status
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C043_HealthCareClaimStatus_2 HealthCareClaimStatus_11 { get; set; }
        /// <summary>
        /// Free Form Message Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FreeformMessageText_12 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV1", typeof(X12_ID_235_6))]
    public class SV1_ProfessionalService : SV1, I_SV1<C003_CompositeMedicalProcedureIdentifier_12, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_12 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV1", typeof(X12_ID_235_16))]
    public class SV1_ProfessionalService_2 : SV1, I_SV1<C003_CompositeMedicalProcedureIdentifier_14, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_14 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Professional Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV1", typeof(X12_ID_235_2))]
    public class SV1_ProfessionalService_3 : SV1, I_SV1<C003_CompositeMedicalProcedureIdentifier_15, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_15 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string UnitorBasisforMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ServiceUnitCount_04 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PlaceofServiceCode_05 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ServiceTypeCode_06 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string EmergencyIndicator_09 { get; set; }
        /// <summary>
        /// Multiple Procedure Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string MultipleProcedureCode_10 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string EPSDTIndicator_11 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string FamilyPlanningIndicator_12 { get; set; }
        /// <summary>
        /// Review Code
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string ReviewCode_13 { get; set; }
        /// <summary>
        /// National or Local Assigned Review Value
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string NationalorLocalAssignedReviewValue_14 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string CoPayStatusCode_15 { get; set; }
        /// <summary>
        /// Health Care Professional Shortage Area Code
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string ReferenceIdentification_17 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string PostalCode_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string LevelofCareCode_20 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string ProviderAgreementCode_21 { get; set; }
    }
    
    /// <summary>
    /// Institutional Service Line
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV2")]
    public class SV2_InstitutionalServiceLine : SV2, I_SV2<C003_CompositeMedicalProcedureIdentifier_8>
    {
        
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ServiceLineRevenueCode_01 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C003_CompositeMedicalProcedureIdentifier_8 CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string LineItemChargeAmount_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Unit Rate
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string UnitRate_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string LineItemDeniedChargeorNonCoveredChargeAmount_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string YesNoConditionorResponseCode_08 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string NursingHomeResidentialStatusCode_09 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string LevelofCareCode_10 { get; set; }
    }
    
    /// <summary>
    /// Institutional Service Line
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV2")]
    public class SV2_InstitutionalServiceLine_2 : SV2, I_SV2<C003_CompositeMedicalProcedureIdentifier_4>
    {
        
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ServiceLineRevenueCode_01 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C003_CompositeMedicalProcedureIdentifier_4 CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string LineItemChargeAmount_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Unit Rate
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string UnitRate_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string LineItemDeniedChargeorNonCoveredChargeAmount_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string YesNoConditionorResponseCode_08 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string NursingHomeResidentialStatusCode_09 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string LevelofCareCode_10 { get; set; }
    }
    
    /// <summary>
    /// Institutional Service Line
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV2")]
    public class SV2_InstitutionalServiceLine_3 : SV2, I_SV2<C003_CompositeMedicalProcedureIdentifier_5>
    {
        
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ServiceLineRevenueCode_01 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C003_CompositeMedicalProcedureIdentifier_5 CompositeMedicalProcedureIdentifier_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string LineItemChargeAmount_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Unit Rate
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string UnitRate_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string LineItemDeniedChargeorNonCoveredChargeAmount_07 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string YesNoConditionorResponseCode_08 { get; set; }
        /// <summary>
        /// Nursing Home Residential Status Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string NursingHomeResidentialStatusCode_09 { get; set; }
        /// <summary>
        /// Level of Care Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string LevelofCareCode_10 { get; set; }
    }
    
    /// <summary>
    /// Dental Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV3", typeof(X12_ID_235_4))]
    public class SV3_DentalService : SV3, I_SV3<C003_CompositeMedicalProcedureIdentifier_11, C006_OralCavityDesignation, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_11 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PlaceofServiceCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C006_OralCavityDesignation OralCavityDesignation_04 { get; set; }
        /// <summary>
        /// Prosthesis, Crown or Inlay Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProsthesisCrownorInlayCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureCount_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string CopayStatusCode_08 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProviderAgreementCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    /// <summary>
    /// Dental Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV3", typeof(X12_ID_235_18))]
    public class SV3_DentalService_2 : SV3, I_SV3<C003_CompositeMedicalProcedureIdentifier_10, C006_OralCavityDesignation, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_10 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PlaceofServiceCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C006_OralCavityDesignation OralCavityDesignation_04 { get; set; }
        /// <summary>
        /// Prosthesis, Crown or Inlay Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProsthesisCrownorInlayCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureCount_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string CopayStatusCode_08 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProviderAgreementCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    /// <summary>
    /// Dental Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV3", typeof(X12_ID_235_4))]
    public class SV3_DentalService_3 : SV3, I_SV3<C003_CompositeMedicalProcedureIdentifier_11, C006_OralCavityDesignation, C004_CompositeDiagnosisCodePointer>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_11 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string PlaceofServiceCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C006_OralCavityDesignation OralCavityDesignation_04 { get; set; }
        /// <summary>
        /// Prosthesis, Crown or Inlay Code
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string ProsthesisCrownorInlayCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string ProcedureCount_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string Description_07 { get; set; }
        /// <summary>
        /// Copay Status Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string CopayStatusCode_08 { get; set; }
        /// <summary>
        /// Provider Agreement Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ProviderAgreementCode_09 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string YesNoConditionorResponseCode_10 { get; set; }
        /// <summary>
        /// Composite Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_11 { get; set; }
    }
    
    /// <summary>
    /// Durable Medical Equipment Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SV5", typeof(X12_ID_235_10), typeof(X12_ID_355_12))]
    public class SV5_DurableMedicalEquipmentService : SV5, I_SV5<C003_CompositeMedicalProcedureIdentifier_9>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_9 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string UnitorBasisforMeasurementCode_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string LengthofMedicalNecessity_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string DMERentalPrice_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string DMEPurchasePrice_05 { get; set; }
        /// <summary>
        /// Frequency Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string RentalUnitPriceIndicator_06 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string PrognosisCode_07 { get; set; }
    }
    
    /// <summary>
    /// Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SVC", typeof(X12_ID_235_3))]
    public class SVC_ServiceLineInformation : SVC, I_SVC<C003_CompositeMedicalProcedureIdentifier_6, C003_CompositeMedicalProcedureIdentifier_2>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_6 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C003_CompositeMedicalProcedureIdentifier_2 CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SVC", typeof(X12_ID_235_3))]
    public class SVC_ServiceLineInformation_2 : SVC, I_SVC<C003_CompositeMedicalProcedureIdentifier_6, C003_CompositeMedicalProcedureIdentifier_2>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_6 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C003_CompositeMedicalProcedureIdentifier_2 CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Service Line Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SVC", typeof(X12_ID_235_13))]
    public class SVC_ServiceLineInformation_3 : SVC, I_SVC<C003_CompositeMedicalProcedureIdentifier_13, C003_CompositeMedicalProcedureIdentifier_3>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_13 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Line Item Charge Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Revenue Code
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C003_CompositeMedicalProcedureIdentifier_3 CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Original Units of Service Count
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Service Payment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SVC", typeof(X12_ID_235_15))]
    public class SVC_ServicePaymentInformation : SVC, I_SVC<C003_CompositeMedicalProcedureIdentifier_16, C003_CompositeMedicalProcedureIdentifier_6>
    {
        
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C003_CompositeMedicalProcedureIdentifier_16 CompositeMedicalProcedureIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string LineItemChargeAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string RevenueCode_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string Quantity_05 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C003_CompositeMedicalProcedureIdentifier_6 CompositeMedicalProcedureIdentifier_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string UnitsofServiceCount_07 { get; set; }
    }
    
    /// <summary>
    /// Line Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation : SVD, I_SVD<C003_CompositeMedicalProcedureIdentifier_7>
    {
        
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string OtherPayerPrimaryIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ServiceLinePaidAmount_02 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C003_CompositeMedicalProcedureIdentifier_7 CompositeMedicalProcedureIdentifier_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProductServiceID_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PaidServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    /// <summary>
    /// Line Adjudication Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation_2 : SVD, I_SVD<C003_CompositeMedicalProcedureIdentifier_8>
    {
        
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string OtherPayerPrimaryIdentifier_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ServiceLinePaidAmount_02 { get; set; }
        /// <summary>
        /// Composite Medical Procedure Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C003_CompositeMedicalProcedureIdentifier_8 CompositeMedicalProcedureIdentifier_03 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ProductServiceID_04 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string PaidServiceUnitCount_05 { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    /// <summary>
    /// Tooth Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOO", typeof(X12_ID_1270_10))]
    public class TOO_ToothInformation : TOO, I_TOO<C005_ToothSurface>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ToothCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C005_ToothSurface ToothSurface_03 { get; set; }
    }
    
    /// <summary>
    /// Tooth Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOO", typeof(X12_ID_1270_34))]
    public class TOO_ToothInformation_2 : TOO, I_TOO<C005_ToothSurface_2>
    {
        
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string ToothCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C005_ToothSurface_2 ToothSurface_03 { get; set; }
    }
    
    /// <summary>
    /// Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN", typeof(X12_ID_481))]
    public class TRN_ClaimStatusTrackingNumber : TRN, I_TRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Claim Status Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN", typeof(X12_ID_481_2))]
    public class TRN_ClaimStatusTrackingNumber_2 : TRN, I_TRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Trace Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN", typeof(X12_ID_481))]
    public class TRN_DependentTraceNumber : TRN, I_TRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Dependent Trace Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN", typeof(X12_ID_481_3))]
    public class TRN_DependentTraceNumber_2 : TRN, I_TRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Patient Event Tracking Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN", typeof(X12_ID_1065_4))]
    public class TRN_PatientEventTrackingNumber : TRN, I_TRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Reassociation Trace Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN", typeof(X12_ID_481_4))]
    public class TRN_ReassociationTraceNumber : TRN, I_TRN
    {
        
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CurrentTransactionTraceNumber_02 { get; set; }
        /// <summary>
        /// Originating Company Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string OriginatingCompanyIdentifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string ReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    /// Provider Supplemental Summary Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TS2")]
    public class TS2_ProviderSupplementalSummaryInformation : TS2, I_TS2
    {
        
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string TotalDRGAmount_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string TotalFederalSpecificAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string TotalHospitalSpecificAmount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TotalDisproportionateShareAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TotalCapitalAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string TotalIndirectMedicalEducationAmount_06 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string TotalOutlierDayCount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string TotalDayOutlierAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string TotalCostOutlierAmount_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string AverageDRGLengthofStay_10 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string TotalDischargeCount_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string TotalCostReportDayCount_12 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string TotalCoveredDayCount_13 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string TotalNoncoveredDayCount_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string TotalMSPPassThroughAmount_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string AverageDRGweight_16 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string TotalPPSCapitalFSPDRGAmount_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string TotalPPSCapitalHSPDRGAmount_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string TotalPPSDSHDRGAmount_19 { get; set; }
    }
    
    /// <summary>
    /// Provider Summary Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TS3")]
    public class TS3_ProviderSummaryInformation : TS3, I_TS3
    {
        
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string ProviderIdentifier_01 { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string FacilityTypeCode_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string FiscalPeriodDate_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public override string TotalClaimCount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public override string TotalClaimChargeAmount_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string MonetaryAmount_06 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string MonetaryAmount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string MonetaryAmount_09 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string MonetaryAmount_10 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(11)]
        public override string MonetaryAmount_11 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(12)]
        public override string MonetaryAmount_12 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(13)]
        public override string TotalMSPPayerAmount_13 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(14)]
        public override string MonetaryAmount_14 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(15)]
        public override string TotalNonLabChargeAmount_15 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(16)]
        public override string MonetaryAmount_16 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(17)]
        public override string TotalHCPCSReportedChargeAmount_17 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(18)]
        public override string TotalHCPCSPayableAmount_18 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(19)]
        public override string MonetaryAmount_19 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(20)]
        public override string TotalProfessionalComponentAmount_20 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(21)]
        public override string TotalMSPPatientLiabilityMetAmount_21 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(22)]
        public override string TotalPatientReimbursementAmount_22 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(23)]
        public override string TotalPIPClaimCount_23 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Pos(24)]
        public override string TotalPIPAdjustmentAmount_24 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UM", typeof(X12_ID_1525_5), typeof(X12_ID_1322_7))]
    public class UM_HealthCareServicesReviewInformation : UM, I_UM<C023_HealthCareServiceLocationInformation_4, C024_RelatedCausesInformation>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C023_HealthCareServiceLocationInformation_4 ValuesEntered_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C024_RelatedCausesInformation RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DelayReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UM", typeof(X12_ID_1525_2), typeof(X12_ID_1322_3))]
    public class UM_HealthCareServicesReviewInformation_2 : UM, I_UM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation_2>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C023_HealthCareServiceLocationInformation ValuesEntered_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C024_RelatedCausesInformation_2 RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DelayReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UM", typeof(X12_ID_1525_6), typeof(X12_ID_1322_7))]
    public class UM_HealthCareServicesReviewInformation_3 : UM, I_UM<C023_HealthCareServiceLocationInformation_4, C024_RelatedCausesInformation_4>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C023_HealthCareServiceLocationInformation_4 ValuesEntered_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C024_RelatedCausesInformation_4 RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DelayReasonCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UM", typeof(X12_ID_1525_3), typeof(X12_ID_1322_3))]
    public class UM_HealthCareServicesReviewInformation_4 : UM, I_UM<C023_HealthCareServiceLocationInformation, C024_RelatedCausesInformation_2>
    {
        
        /// <summary>
        /// Request Category Code
        /// </summary>
        [DataMember]
        [Pos(1)]
        public override string RequestCategoryCode_01 { get; set; }
        /// <summary>
        /// Certification Type Code
        /// </summary>
        [DataMember]
        [Pos(2)]
        public override string CertificationTypeCode_02 { get; set; }
        /// <summary>
        /// Service Type Code
        /// </summary>
        [DataMember]
        [Pos(3)]
        public override string ServiceTypeCode_03 { get; set; }
        /// <summary>
        /// Health Care Service Location Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C023_HealthCareServiceLocationInformation ValuesEntered_04 { get; set; }
        /// <summary>
        /// Related Causes Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C024_RelatedCausesInformation_2 RelatedCausesInformation_05 { get; set; }
        /// <summary>
        /// Level of Service Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public override string LevelofServiceCode_06 { get; set; }
        /// <summary>
        /// Current Health Condition Code
        /// </summary>
        [DataMember]
        [Pos(7)]
        public override string CurrentHealthConditionCode_07 { get; set; }
        /// <summary>
        /// Prognosis Code
        /// </summary>
        [DataMember]
        [Pos(8)]
        public override string PrognosisCode_08 { get; set; }
        /// <summary>
        /// Release of Information Code
        /// </summary>
        [DataMember]
        [Pos(9)]
        public override string ReleaseofInformationCode_09 { get; set; }
        /// <summary>
        /// Delay Reason Code
        /// </summary>
        [DataMember]
        [Pos(10)]
        public override string DelayReasonCode_10 { get; set; }
    }
}
