using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TalentAddTopic
    {
        public int TransId { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public string DepId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProTypId { get; set; }
        public int? EntryId { get; set; }
        public string ScopeId { get; set; }
        public int? ClientId { get; set; }
        public string Subject { get; set; }
        public string Topic { get; set; }
        public string TagId { get; set; }
        public string PhotoAttached { get; set; }
        public string VideoAttached { get; set; }
        public string FileAttached { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string UpdUser { get; set; }
        public DateTime? UpdDate { get; set; }
        public int? PostView { get; set; }
        public int? LessonLearnedCategoryId { get; set; }
        public int? CyclePhaseId { get; set; }
        public int? ResultCategoryId { get; set; }
        public string TopicBody { get; set; }
        public string WhatWentWell { get; set; }
        public string WhatDidntGoAsWell { get; set; }
        public string Results { get; set; }
        public string ImpactTime { get; set; }
        public string ImpactCost { get; set; }
        public string RecommendedActions { get; set; }
        public string RelatedBoqItem { get; set; }
        public string Manpower { get; set; }
        public string Equipment { get; set; }
        public string SpecialAssignedManpower { get; set; }
        public string KeyMaterial { get; set; }
        public string KeyPlant { get; set; }
        public string DetailedSequence { get; set; }
        public string CauseOfSpeciality { get; set; }
        public string Submittal { get; set; }
        public string SubmittalProcedures { get; set; }
        public string MaterialType { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialStorage { get; set; }
        public string AdvantagesofMaterialusage { get; set; }
        public string DisadvantagesofMaterialusage { get; set; }
        public string CauseofAchievements { get; set; }
        public string Achievements { get; set; }
        public string Majorincident { get; set; }
        public string Impacts { get; set; }
        public int? WorkflowStep { get; set; }
        public string Refperson { get; set; }
        public string Refemail { get; set; }
        public int? Reftitle { get; set; }
        public int? Status { get; set; }
        public bool? FinalEdit { get; set; }
    }
}
