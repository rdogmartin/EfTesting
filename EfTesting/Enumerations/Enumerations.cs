namespace EfTesting.Enumerations;

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
    ///<summary>Miscellaneous Report To FEC</summary>
    MiscReportToFec,
    ///<summary>Disavowal Response</summary>
    DisavowalResponse,
    ///<summary>Filing Frequency Change Notice</summary>
    FilingFreqChangeNotice
}

public enum EntityType : short
{
    Individual,
    Candidate,
    Committee,
    CampaignCommittee,
    PartyCommittee,
    Pac,
    Organization
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
}
