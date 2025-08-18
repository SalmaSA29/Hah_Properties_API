using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SurvSurveyTransactions
    {
        public int SurveyTransNo { get; set; }
        public string UserHrCode { get; set; }
        public int SurveyId { get; set; }
        public DateTime? Date { get; set; }
        public bool? ItServicesProblemNetworkConnectivity { get; set; }
        public bool? ItServicesProblemInternetService { get; set; }
        public bool? ItServicesProblemPrintingPlottingScanningCopying { get; set; }
        public bool? ItServicesProblemAisService { get; set; }
        public bool? ItServicesProblemAutoAccount { get; set; }
        public bool? ItServicesProblemPortalServices { get; set; }
        public bool? ItServicesProblemAlphaServices { get; set; }
        public bool? ItServicesProblemVpnServices { get; set; }
        public bool? ItServicesProblemFileSharingService { get; set; }
        public bool? ItServicesProblemVideoConferenceSystems { get; set; }
        public bool? ItServicesProblemMicrosoftServices { get; set; }
        public bool? ItServicesProblemIfOtherPleaseSpecify { get; set; }
        public int? SupportHotlineResponseTime { get; set; }
        public int? SupportHotlineResponseEtiquette { get; set; }
        public int? SupportHotlineResolutionTime { get; set; }
        public int? EmailSupportHotlineResponseTime { get; set; }
        public int? EmailSupportHotlineResponseEtiquette { get; set; }
        public int? EmailSupportHotlineResolutionTime { get; set; }
        public int? RateItSupportResponseTime { get; set; }
        public int? RateItSupportResponseEtiquette { get; set; }
        public int? RateItSupportResolutionTime { get; set; }
        public int? RateItSupportStaffKnowledge { get; set; }
        public int? RateItSupportStaffAreSupportive { get; set; }
        public int? RateItSupportProblemSolving { get; set; }
        public int? RateItSupportStaffFeedbackAfterCaseResolution { get; set; }
        public string ProblemsOrConcerns { get; set; }
        public int? RateFollowingItSolutionsInternetAndNetworkConnectivity { get; set; }
        public int? RateFollowingItSolutionsVideoConferenceSystemsWebEx { get; set; }
        public int? RateFollowingItSolutionsCloudSolutions { get; set; }
        public int? RateFollowingItSolutionsHahPortal { get; set; }
        public int? RateFollowingItSolutionsAlphaFinancialModules { get; set; }
        public int? RateFollowingItSolutionsAisProcurementModule { get; set; }
        public int? RateFollowingItSolutionsAisCostControlModule { get; set; }
        public int? RateFollowingItSolutionsAisWorkshopModule { get; set; }
        public int? RateFollowingItSolutionsAutoAccountSolution { get; set; }
        public int? RateFollowingItSolutionsHitsHrSystem { get; set; }
        public int? RateFollowingItSolutionsMazayaHrSystem { get; set; }
        public int? ItSupportAskingForHelp { get; set; }
        public int? ItAnnouncementMailsUsefulUseful { get; set; }
        public string Suggestions { get; set; }
        public string Advice { get; set; }
    }
}
