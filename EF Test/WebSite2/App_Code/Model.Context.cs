﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class Entities : DbContext
{
    public Entities()
        : base("name=Entities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<K_Act> K_Act { get; set; }
    public virtual DbSet<K_Category> K_Category { get; set; }
    public virtual DbSet<K_F_FeedBack> K_F_FeedBack { get; set; }
    public virtual DbSet<K_FlowStep> K_FlowStep { get; set; }
    public virtual DbSet<K_HRApplyJob> K_HRApplyJob { get; set; }
    public virtual DbSet<K_HRJob> K_HRJob { get; set; }
    public virtual DbSet<K_HRJobCate> K_HRJobCate { get; set; }
    public virtual DbSet<K_HRResume> K_HRResume { get; set; }
    public virtual DbSet<K_Member> K_Member { get; set; }
    public virtual DbSet<K_MemberGroup> K_MemberGroup { get; set; }
    public virtual DbSet<K_ModelCommonField> K_ModelCommonField { get; set; }
    public virtual DbSet<K_ModelCommonFieldGroup> K_ModelCommonFieldGroup { get; set; }
    public virtual DbSet<K_ModelField> K_ModelField { get; set; }
    public virtual DbSet<K_ModelFieldGroup> K_ModelFieldGroup { get; set; }
    public virtual DbSet<K_ModelManage> K_ModelManage { get; set; }
    public virtual DbSet<K_ReviewFlow> K_ReviewFlow { get; set; }
    public virtual DbSet<K_ReviewFlowState> K_ReviewFlowState { get; set; }
    public virtual DbSet<K_Special> K_Special { get; set; }
    public virtual DbSet<K_SpecialInfo> K_SpecialInfo { get; set; }
    public virtual DbSet<K_SpecialMenu> K_SpecialMenu { get; set; }
    public virtual DbSet<K_SysAccount> K_SysAccount { get; set; }
    public virtual DbSet<K_SysAccountPermit> K_SysAccountPermit { get; set; }
    public virtual DbSet<K_SysAccountSite> K_SysAccountSite { get; set; }
    public virtual DbSet<K_SysActionPermit> K_SysActionPermit { get; set; }
    public virtual DbSet<K_SysModule> K_SysModule { get; set; }
    public virtual DbSet<K_SysModuleNode> K_SysModuleNode { get; set; }
    public virtual DbSet<K_SysPublicOper> K_SysPublicOper { get; set; }
    public virtual DbSet<K_SysRole> K_SysRole { get; set; }
    public virtual DbSet<K_SysRolePermit> K_SysRolePermit { get; set; }
    public virtual DbSet<K_SysUserGroup> K_SysUserGroup { get; set; }
    public virtual DbSet<K_SysUserGroupPermit> K_SysUserGroupPermit { get; set; }
    public virtual DbSet<K_SysUserGroupRole> K_SysUserGroupRole { get; set; }
    public virtual DbSet<K_SysUserRole> K_SysUserRole { get; set; }
    public virtual DbSet<K_SysWebSite> K_SysWebSite { get; set; }
    public virtual DbSet<K_TemplateProject> K_TemplateProject { get; set; }
    public virtual DbSet<K_U_Common> K_U_Common { get; set; }
    public virtual DbSet<K_U_Contact> K_U_Contact { get; set; }
    public virtual DbSet<K_U_DownLoad> K_U_DownLoad { get; set; }
    public virtual DbSet<K_U_friendlink> K_U_friendlink { get; set; }
    public virtual DbSet<K_U_Jobs> K_U_Jobs { get; set; }
    public virtual DbSet<K_U_Member> K_U_Member { get; set; }
    public virtual DbSet<K_U_News> K_U_News { get; set; }
    public virtual DbSet<K_U_PersonIntro> K_U_PersonIntro { get; set; }
    public virtual DbSet<K_U_product> K_U_product { get; set; }
    public virtual DbSet<K_U_ProductType> K_U_ProductType { get; set; }
    public virtual DbSet<K_U_Show> K_U_Show { get; set; }
    public virtual DbSet<K_U_Thanks> K_U_Thanks { get; set; }
    public virtual DbSet<K_WebSiteTemplate> K_WebSiteTemplate { get; set; }
    public virtual DbSet<K_WebSiteTemplateNode> K_WebSiteTemplateNode { get; set; }
    public virtual DbSet<K_WebSiteTemplatePermit> K_WebSiteTemplatePermit { get; set; }
    public virtual DbSet<K_RecyclingAssociated> K_RecyclingAssociated { get; set; }
    public virtual DbSet<K_RecyclingManage> K_RecyclingManage { get; set; }
    public virtual DbSet<K_ReviewFlowLog> K_ReviewFlowLog { get; set; }
    public virtual DbSet<K_SysLog> K_SysLog { get; set; }
    public virtual DbSet<K_Types> K_Types { get; set; }
}
