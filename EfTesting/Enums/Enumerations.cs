namespace EfTesting.Enums;

public enum OrganizationType
{
    ///<summary>"C - Corporation"</summary>
    C,
    ///<summary>"L - Labor Organization"</summary>
    L,
    ///<summary>"M - Membership Organization"</summary>
    M,
    ///<summary>"T - Trade Association"</summary>
    T,
    ///<summary>"V - Cooperative"</summary>
    V,
    ///<summary>"W - Corporation W/O Capital Stock"</summary>
    W,
}

public enum CommitteeType
{
    ///<summary>"A - Principal Campaign Committee"</summary>
    A,
    ///<summary>"B - Authorized Committee"</summary>
    B,
    ///<summary>"C - Support/Oppose One Candidate (Not Authoized Committee)"</summary>
    C,
    ///<summary>"D - National; State; Or Subordinate Party Committee"</summary>
    D,
    ///<summary>"E - Separate Segregated Fund"</summary>
    E,
    ///<summary>"F - Support/Oppose More Than One Federal Cand & Not Segregated Fund/Party"</summary>
    F,
    ///<summary>"G - Joint Fundraising Representative (At least One Is Authorized)"</summary>
    G,
    ///<summary>"H - Joint Fundraising Representative (None Are Authorized)"</summary>
    H,
}

/// <summary>
/// This enum represents all the different forms that can be submitted to the FEC
/// </summary>
public enum FecFormType : short
{
    /// <summary>Statement of Organization</summary>
    Form1,
    /// <summary>Notification of Multicandidate Status</summary>
    Form1M,
    /// <summary>Statement of Candidacy</summary>
    Form2,
    /// <summary>Independent expenditure reports and notices</summary>
    Form24,
    /// <summary>Receipts and Disbursements</summary>
    Form3,
    /// <summary>Receipts and Disbursements</summary>
    Form3P,
    /// <summary>Contributions Bundled by Lobbyists/Registrants and Lobbyist/Registrant PACs</summary>
    Form3L,
    /// <summary>Receipts and Disbursements</summary>
    Form3X,
    /// <summary>Receipts and Disbursements</summary>
    Form4,
    /// <summary>Independent Expenditures Made and Contributions Received</summary>
    Form5,
    /// <summary>48-Hour Notice of Contributions/Loans Received</summary>
    Form6,
    /// <summary>Communication Costs by Corporations and Membership Organizations</summary>
    Form7,
    /// <summary>Debt Settlement Plan</summary>
    Form8,
    /// <summary>24-Hour Notice of Disbursements/Obligations for Electioneering Communications</summary>
    Form9,
    /// <summary>Expenditure of personal funds notices</summary>
    Form10,
    /// <summary>Opposition personal funds notices</summary>
    Form11,
    /// <summary>Suspension of increased limits notices</summary>
    Form12,
    /// <summary>Donations Accepted for Inaugural Committee</summary>
    Form13,
    /// <summary>Miscellaneous Report to the FEC</summary>
    Form99,
    /// <summary>Request For Additional Information</summary>
    RFAI,
}

/// <summary>
/// This subtype enum can be used for Form's 3, 3L, 3P, and 3X
/// </summary>
public enum FecFormSubtype : short
{
    ///<summary>Form 24 - 24 Hour Report</summary>
    Form24_24Hour,
    ///<summary>Form 24 - 48 Hour Report</summary>
    Form24_48Hour,

    ///<summary>Form 3 - April 15 Quarterly Report</summary>
    Form3_Q1,
    ///<summary>Form 3 - July 15 Quarterly and/or Semi-annual Report</summary>
    Form3_Q2,
    ///<summary>Form 3 - October 15 Quarterly Report</summary>
    Form3_Q3,
    ///<summary>Form 3 - Jan 31 Year-End Report</summary>
    Form3_QYE,
    ///<summary>Form 3 - July 31 Mid-Year Report</summary>
    Form3_MY,
    ///<summary>Form 3 - Monthly Feb 20 Report</summary>
    Form3_M2,
    ///<summary>Form 3 - Monthly Mar 20 Report</summary>
    Form3_M3,
    ///<summary>Form 3 - Monthly Apr 20 Report</summary>
    Form3_M4,
    ///<summary>Form 3 - Monthly May 20 Report</summary>
    Form3_M5,
    ///<summary>Form 3 - Monthly Jun 20 Report</summary>
    Form3_M6,
    ///<summary>Form 3 - Monthly Jul 20 and/or Semi-annual Report</summary>
    Form3_M7,
    ///<summary>Form 3 - Monthly Aug 20 Report</summary>
    Form3_M8,
    ///<summary>Form 3 - Monthly Sep 20 Report</summary>
    Form3_M9,
    ///<summary>Form 3 - Monthly Oct 20 Report</summary>
    Form3_M10,
    ///<summary>Form 3 - Monthly Nov 20 Report</summary>
    Form3_M11,
    ///<summary>Form 3 - Monthly Dec 20 Report</summary>
    Form3_M12,
    ///<summary>Form 3 - Monthly Jan 31 and/or Semi-annual Report</summary>
    Form3_MYE,
    ///<summary>Form 3 - 12-Day Pre-election Primary Report</summary>
    Form3_P12,
    ///<summary>Form 3 - 12-Day Pre-election General Report</summary>
    Form3_G12,
    ///<summary>Form 3 - 12-Day Pre-election Runoff Report</summary>
    Form3_R12,
    ///<summary>Form 3 - 12-Day Pre-election Special Report</summary>
    Form3_S12,
    ///<summary>Form 3 - 12-Day Pre-election Convention Report</summary>
    Form3_C12,
    ///<summary>Form 3 - 30-Day Post-election General Report</summary>
    Form3_G30,
    ///<summary>Form 3 - 30-Day Post-election Runoff Report</summary>
    Form3_R30,
    ///<summary>Form 3 - 30-Day Post-election Special Report</summary>
    Form3_S30,

    ///<summary>Termination Report</summary>
    Termination,
}

public enum FecFormFilingStatus : short
{
    GeneratingForm,
    Draft,
    Validating,
    ValidatedHasErrors,
    ValidatedHasWarnings,
    ValidationFailed,
    Validated,
    FilingInProgress,
    FilingFailed,
    Filed
}

public enum Form99DocType : short
{
    Unknown = 0,
    ///<summary>Miscellaneous Report To FEC</summary>
    MiscReportToFec,
    ///<summary>Disavowal Response</summary>
    DisavowalResponse,
    ///<summary>Filing Frequency Change Notice</summary>
    FilingFreqChangeNotice
}

public enum EntityType : short
{
    IND, // Individual,
    CAN, // Candidate,
    COM, // Committee,
    CCM, // CampaignCommittee,
    PTY, // PartyCommittee,
    PAC,
    ORG, // Organization
}

public enum AffiliatedRelationship : short
{
    ///<summary>ORG - Connected Organization</summary>
    Organization,
    ///<summary>AFF - Affiliated Committee</summary>
    AffiliatedCommittee,
    ///<summary>JFR - Joint Fundraising Participant</summary>
    JointFundraisingParticipant,
    ///<summary>LPS - Leadership PAC Sponsor</summary>
    LeadershipPac
}   /// <summary>
    /// The record type FEC submission. These relate to a Line Number in FEC file documents.
    /// Usually associated with a Receipt, Disbursement, or Loan.
    /// </summary>
public enum FecRecordType
{
    None = 0,

    #region Scheduled A - Receipts

    /// <summary>
    /// Line number: 11a i
    /// FEC file schedule line number: SA11AI
    /// </summary>
    IndividualContributionItemized,

    /// <summary>
    /// Line number: 11a ii
    /// FEC file schedule line number: SA11AII
    /// </summary>
    IndividualContributionUnitemized,

    /// <summary>
    /// Line number: 11b
    /// FEC file schedule line number: SA11B
    /// </summary>
    PoliticalPartyContribution,

    /// <summary>
    /// Line number: 11c
    /// FEC file schedule line number: SA11C
    /// </summary>
    OtherPartyContribution,

    /// <summary>
    /// Line number: 11d
    /// FEC file schedule line number: SA11D
    /// </summary>
    CandidateContribution,

    /// <summary>
    /// Line number: 12
    /// FEC file schedule line number: SA12
    /// </summary>
    PartyTransfer,

    /// <summary>
    /// Line number: 13
    /// FEC file schedule line number: SA13
    /// </summary>
    Loan,

    /// <summary>
    /// Line number: 15
    /// FEC file schedule line number: SA15
    /// </summary>
    OperatingOffset,

    /// <summary>
    /// Line number: 16
    /// FEC file schedule line number: SA16
    /// </summary>
    RefundFedCandidateOrParty,

    /// <summary>
    /// Line number: 17
    /// FEC file schedule line number: SA17
    /// </summary>
    OtherFecReceipt,

    /// <summary>
    /// Line number: 18a
    /// FEC file schedule line number: SA18A -- double check this one (feels like it should be SA18AI)
    /// </summary>
    TransferNonFed,

    /// <summary>
    /// Line number: 18b
    /// FEC file schedule line number: SA18B
    /// </summary>
    TransferLevin,

    /// <summary>
    /// Line number: 21a i (Federal)
    /// FEC file schedule line number: SA21AI
    /// </summary>
    AllocatedFedShare,

    /// <summary>
    /// Line number: 21a ii (Non Federal)
    /// FEC file schedule line number: SA21AII
    /// </summary>
    AllocatedNonFedShare,

    #endregion

    #region Scheduld B - Disbursements

    /// <summary>
    /// Line number: 21b
    /// FEC file schedule line number: SB21B
    /// </summary>
    OperatingExpense = 1000,

    /// <summary>
    /// Line number: 22
    /// FEC file schedule line number: SB22
    /// </summary>
    TransferToParty,

    /// <summary>
    /// Line number: 23
    /// FEC file schedule line number: SB23
    /// </summary>
    TransferToCandidateOrCommittee,

    /// <summary>
    /// Line number: 24
    /// FEC file schedule line number: SB24
    /// </summary>
    IndependentExpenditure,

    /// <summary>
    /// Line number: 25
    /// FEC file schedule line number: SB25
    /// </summary>
    CoordinatedExpenditure,

    /// <summary>
    /// Line number: 26
    /// FEC file schedule line number: SB26
    /// </summary>
    LoanPaymentsMade,

    /// <summary>
    /// Line number: 27
    /// FEC file schedule line number: SB27
    /// </summary>
    LoansMade,

    /// <summary>
    /// Line number: 28a
    /// FEC file schedule line number: SB28A
    /// </summary>
    RefundIndividual,

    /// <summary>
    /// Line number: 28b
    /// FEC file schedule line number: SB28B
    /// </summary>
    RefundParty,

    /// <summary>
    /// Line number: 28c
    /// FEC file schedule line number: SB28C
    /// </summary>
    RefundCommittee,

    /// <summary>
    /// Line number: 29
    /// FEC file schedule line number: SB29
    /// </summary>
    OtherDisbursement,

    /// <summary>
    /// Line number: 30a i
    /// FEC file schedule line number: SB30AI
    /// </summary>
    FederalSharedElectionActivity,

    /// <summary>
    /// Line number: 30a ii
    /// FEC file schedule line number: SB30AII
    /// </summary>
    LevinSharedElectionActivity,

    /// <summary>
    /// Line number: 30b
    /// FEC file schedule line number: SB30B
    /// </summary>
    FecElectionActivity,

    #endregion

    // Schedule C - Loan
    /// <summary>
    /// FEC line number in Form Sch C attached to: 9    
    /// Loan is owed TO the Committee: SC/9
    /// </summary>
    SchC_Sc9_LoanOwedTOComm,

    /// <summary>
    /// FEC line number in Form Sch C attached to: 10    
    /// Loan is owed BY the Committee: SC/10
    /// </summary>
    SchC_Sc10_LoanOwedBYComm,

    // Schedule D - Debt
    /// <summary>
    /// FEC line number in Form Sch D attached to: 9    
    /// Debt is owed TO the Committee: SD9
    /// </summary>
    SchD_Sd9_DebtOwedTOComm,

    /// <summary>
    /// FEC line number in Form Sch D attached to: 10    
    /// Debt is owed BY the Committee: SD10
    /// </summary>
    SchD_Sd10_DebtOwedBYComm,

    /// <summary>
    /// Schedule E - itemized independent expenditures
    /// </summary>
    SchE,

    /// <summary>
    /// Schedule F - itemized coordinated expenditures
    /// </summary>
    SchF,

    #region Scheduled Misc

    /// <summary>
    /// FEC file schedule line number: H1
    /// </summary>
    MethodOfAllocation = 2000,

    /// <summary>
    /// FEC file schedule line number: H2
    /// </summary>
    AllocationRatioJoint,

    /// <summary>
    /// FEC file schedule line number: SL
    /// </summary>
    LevinFunds,

    /// <summary>
    /// Used in, at least, Form 3X to give information about the report and
    /// the records within.
    /// FEC file schedule line number: TEXT
    /// </summary>
    Text,

    /// <summary>
    /// The record that goes at the top of a .FEC file which will
    /// contain info about this software.
    /// HDR
    /// </summary>
    HeaderRecord,

    // Missing Schedule line numbers for Form 3X (might not be needed):
    //SC1/10
    //SC2/10
    //SE24
    //SF25
    //H3
    //H4
    //H5
    //H6
    //SI

    #endregion
}
