using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;


namespace PortalAPI.Models.InformationTechnology

{
    public partial class InformationTechnologyContext : DbContext
    {
        public InformationTechnologyContext()
        {
        }
        public InformationTechnologyContext(DbContextOptions<InformationTechnologyContext> options) : base(options)
        {
        }
        public virtual DbSet<PH_Assets> PH_Assets { get; set; }

        public virtual DbSet<PH_Setting> PH_Setting { get; set; }
        public virtual DbSet<PH_Brands> PH_Brands { get; set; }
        public virtual DbSet<PH_Assets_Trans> PH_Assets_Trans { get; set; }
        public virtual DbSet<PH_Stores> PH_Stores { get; set; }
        public virtual DbSet<PH_Types> PH_Types { get; set; }
        public virtual DbSet<PH_Models> PH_Models { get; set; }
        public virtual DbSet<PH_Delivery_M> PH_Delivery_M { get; set; }
        public virtual DbSet<PH_Delivery_M_Attaches> PH_Delivery_M_Attaches { get; set; }
        public virtual DbSet<PH_Delivery_Det> PH_Delivery_Det { get; set; }
        public virtual DbSet<PH_DescGroup> PH_DescGroup { get; set; }
        public virtual DbSet<PH_DescGroup_Sub> PH_DescGroup_Sub { get; set; }
        public virtual DbSet<PH_DescGroup_Values> PH_DescGroup_Values { get; set; }
        public virtual DbSet<SP_PH_assetsDataAll> SP_PH_assetsDataAll { get; set; }
        public virtual DbSet<SP_ItmCat_Admin> SP_ItmCat_Admin { get; set; }
        public virtual DbSet<PH_Assets_Attaches> PH_Assets_Attaches { get; set; }     

      

        #region MDM 
        public virtual DbSet<ItmCat_Admin> ItmCat_Admin { get; set; }
        public virtual DbSet<ItmCat_Admin_Access> ItmCat_Admin_Access { get; set; }
        public virtual DbSet<ItmCat_Groups> ItmCat_Groups { get; set; }
        public virtual DbSet<ItmCat_UsersCompany> ItmCat_UsersCompany { get; set; }
        public virtual DbSet<ItmCat_CompanyGroups> ItmCat_CompanyGroups { get; set; }
        public virtual DbSet<ItmCat_Category> ItmCat_Category { get; set; }
        public virtual DbSet<SP_GetLastCategoryBeforeItem> SP_GetLastCategoryBeforeItem { get; set; }
        public virtual DbSet<ItmCat_Items> ItmCat_Items { get; set; }
        public virtual DbSet<ItmCat_Items_Deleted> ItmCat_Items_Deleted { get; set; }
        public virtual DbSet<ItmCat_Users_Cart> ItmCat_Users_Cart { get; set; }
        public virtual DbSet<ItmCat_Users_Favorites> ItmCat_Users_Favorites { get; set; }
        public virtual DbSet<ItmCat_Item_Attach> ItmCat_Item_Attach { get; set; }
        public virtual DbSet<ItmCat_Item_Request> ItmCat_Item_Request { get; set; }
        public virtual DbSet<ItmCat_Material_Group> ItmCat_Material_Group { get; set; }
        public virtual DbSet<ItmCat_Material_Type> ItmCat_Material_Type { get; set; }
        public virtual DbSet<ItmCat_Item_Request_Attach> ItmCat_Item_Request_Attach { get; set; }
        public virtual DbSet<ItmCat_UOM> ItmCat_UOM { get; set; }
        public virtual DbSet<ItmCat_Category_Attach> ItmCat_Category_Attach { get; set; }
        public virtual DbSet<ItmCat_Tags> ItmCat_Tags { get; set; }
        public virtual DbSet<SP_GetCategoryAccess> SP_GetCategoryAccess { get; set; }
        public virtual DbSet<ItmCat_Item_Request_Workflow> ItmCat_Item_Request_Workflow { get; set; }
        public virtual DbSet<SP_Requester> SP_Requester { get; set; }
        public virtual DbSet<SP_GetAdminsOFGroup> SP_GetAdminsOFGroup { get; set; }
        public virtual DbSet<SP_RequestHistory> SP_RequestHistory { get; set; }
        public virtual DbSet<SP_ItemRequest_WorkFlow> SP_ItemRequest_WorkFlow { get; set; }
        public virtual DbSet<SP_AllApprovals> SP_AllApprovals { get; set; }
        public virtual DbSet<SP_TrackWorkflowCycle> SP_TrackWorkflowCycle { get; set; }
        public virtual DbSet<SP_RequestReport> SP_RequestReport { get; set; }
        public virtual DbSet<ItmCat_Manufaturals> ItmCat_Manufaturals { get; set; }
        public virtual DbSet<ItmCat_Items_Manufactureres> ItmCat_Items_Manufactureres { get; set; }
        public virtual DbSet<ItmCat_Item_Request_Manufactureres> ItmCat_Item_Request_Manufactureres { get; set; }
        public virtual DbSet<ItmCat_Item_DiscussionAttach> ItmCat_Item_DiscussionAttach { get; set; }
        public virtual DbSet<ItmCat_Category_DiscussionAttach> ItmCat_Category_DiscussionAttach { get; set; }



        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //                optionsBuilder.UseSqlServer("Server=portal.hassanallam.com;Database=AIS;UID=sa;PWD=HappS@2020;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            
        }
    }
}
