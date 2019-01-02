namespace MAP_PI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EtatResource = c.String(),
                        Role = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        AdministratorId = c.Int(),
                        RessourceId = c.Int(),
                        First_name = c.String(),
                        Last_name = c.String(),
                        Seniority = c.String(),
                        Work_profil = c.String(),
                        Note = c.Single(),
                        picture = c.String(),
                        Business_sector = c.String(),
                        Salary = c.Single(),
                        etat = c.Boolean(),
                        lang = c.String(),
                        lat = c.String(),
                        JobType = c.String(),
                        contract_Type = c.Int(),
                        availibity_type = c.Int(),
                        state_Type = c.Int(),
                        SkiFk = c.Int(),
                        DaysoffFK = c.Int(),
                        HolidayFk = c.Int(),
                        Organizational_ChartFk = c.Int(),
                        ClientId = c.Int(),
                        client_Type = c.Int(),
                        nameClient = c.String(),
                        logo = c.String(),
                        CandidatId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Organizational_Chart_ChartId = c.Int(),
                        MyAdminstrator_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizational_Chart", t => t.Organizational_Chart_ChartId)
                .ForeignKey("dbo.AspNetUsers", t => t.MyAdminstrator_Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.Organizational_Chart_ChartId)
                .Index(t => t.MyAdminstrator_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Inboxes",
                c => new
                    {
                        InboxId = c.Int(nullable: false, identity: true),
                        sender = c.String(),
                        MyPerson_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.InboxId)
                .ForeignKey("dbo.AspNetUsers", t => t.MyPerson_Id)
                .Index(t => t.MyPerson_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Message_object = c.String(),
                        Message_content = c.String(),
                        DateDebutMessage = c.DateTime(nullable: false),
                        DateFinMessage = c.DateTime(nullable: false),
                        Cost = c.Single(nullable: false),
                        EtatMessage = c.Boolean(nullable: false),
                        Date_message = c.DateTime(nullable: false),
                        RessourceMsgFK_Id = c.String(maxLength: 128),
                        Administrator_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.AspNetUsers", t => t.RessourceMsgFK_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Administrator_Id)
                .Index(t => t.RessourceMsgFK_Id)
                .Index(t => t.Administrator_Id);
            
            CreateTable(
                "dbo.DayOffs",
                c => new
                    {
                        DayoffId = c.Int(nullable: false, identity: true),
                        start_Date = c.DateTime(nullable: false),
                        end_Date = c.DateTime(nullable: false),
                        raison = c.String(),
                        Ressource_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DayoffId)
                .ForeignKey("dbo.AspNetUsers", t => t.Ressource_Id)
                .Index(t => t.Ressource_Id);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        HolidayId = c.Int(nullable: false, identity: true),
                        stard_Date = c.DateTime(nullable: false),
                        end_Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Ressource_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HolidayId)
                .ForeignKey("dbo.AspNetUsers", t => t.Ressource_Id)
                .Index(t => t.Ressource_Id);
            
            CreateTable(
                "dbo.Mandates",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        Id = c.String(nullable: false, maxLength: 128),
                        start_Date = c.DateTime(nullable: false),
                        end_Date = c.DateTime(nullable: false),
                        Fees = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.Id, t.start_Date, t.end_Date })
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Id, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        project_name = c.String(),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        total_number_ressources = c.Int(nullable: false),
                        levio_number_ressources = c.Int(nullable: false),
                        picture = c.String(),
                        category_type = c.String(),
                        project_type = c.Int(nullable: false),
                        addresse_AddressId = c.Int(),
                        MyClient_Id = c.String(maxLength: 128),
                        MyOrgChart_ChartId = c.Int(),
                        SkillFk_SkillId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Addresses", t => t.addresse_AddressId)
                .ForeignKey("dbo.AspNetUsers", t => t.MyClient_Id)
                .ForeignKey("dbo.Organizational_Chart", t => t.MyOrgChart_ChartId)
                .ForeignKey("dbo.Skills", t => t.SkillFk_SkillId)
                .Index(t => t.addresse_AddressId)
                .Index(t => t.MyClient_Id)
                .Index(t => t.MyOrgChart_ChartId)
                .Index(t => t.SkillFk_SkillId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        city = c.String(),
                        postal_Code = c.String(),
                        country = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        requested_profil = c.String(),
                        experience_year = c.DateTime(nullable: false),
                        education_scolarity = c.String(),
                        Manager = c.String(),
                        deposit_hour = c.DateTime(nullable: false),
                        deposit_Date = c.DateTime(nullable: false),
                        start_date_mandate = c.DateTime(nullable: false),
                        end_date_mandate = c.DateTime(nullable: false),
                        MyAdmin_Id = c.String(maxLength: 128),
                        MyClient_Id = c.String(maxLength: 128),
                        MyResourcee_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.AspNetUsers", t => t.MyAdmin_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.MyClient_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.MyResourcee_Id)
                .Index(t => t.MyAdmin_Id)
                .Index(t => t.MyClient_Id)
                .Index(t => t.MyResourcee_Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Organizational_Chart",
                c => new
                    {
                        ChartId = c.Int(nullable: false, identity: true),
                        directionnal_level = c.String(),
                        program_Name = c.String(),
                        project_responsable = c.String(),
                        client_Name = c.String(),
                        manager_account = c.String(),
                        name_assignment_manager_client = c.String(),
                    })
                .PrimaryKey(t => t.ChartId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        name_Skill = c.String(),
                        description_Skill = c.String(),
                        rate_Skill = c.Single(nullable: false),
                        MyResource_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SkillId)
                .ForeignKey("dbo.AspNetUsers", t => t.MyResource_Id)
                .Index(t => t.MyResource_Id);
            
            CreateTable(
                "dbo.Job_Request",
                c => new
                    {
                        Job_RequestId = c.Int(nullable: false, identity: true),
                        State_Type = c.Int(nullable: false),
                        Date_Request = c.DateTime(nullable: false),
                        Speciality = c.String(),
                        MyCandidat_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Job_RequestId)
                .ForeignKey("dbo.AspNetUsers", t => t.MyCandidat_Id)
                .Index(t => t.MyCandidat_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.MessageInboxes",
                c => new
                    {
                        Message_MessageId = c.Int(nullable: false),
                        Inbox_InboxId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Message_MessageId, t.Inbox_InboxId })
                .ForeignKey("dbo.Messages", t => t.Message_MessageId, cascadeDelete: true)
                .ForeignKey("dbo.Inboxes", t => t.Inbox_InboxId, cascadeDelete: true)
                .Index(t => t.Message_MessageId)
                .Index(t => t.Inbox_InboxId);
            
            CreateTable(
                "dbo.Organizational_ChartRessource",
                c => new
                    {
                        Organizational_Chart_ChartId = c.Int(nullable: false),
                        Ressource_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Organizational_Chart_ChartId, t.Ressource_Id })
                .ForeignKey("dbo.Organizational_Chart", t => t.Organizational_Chart_ChartId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Ressource_Id, cascadeDelete: true)
                .Index(t => t.Organizational_Chart_ChartId)
                .Index(t => t.Ressource_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Job_Request", "MyCandidat_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Messages", "Administrator_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Messages", "RessourceMsgFK_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "MyAdminstrator_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Mandates", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Inboxes", "MyPerson_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Projects", "SkillFk_SkillId", "dbo.Skills");
            DropForeignKey("dbo.Skills", "MyResource_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Organizational_ChartRessource", "Ressource_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Organizational_ChartRessource", "Organizational_Chart_ChartId", "dbo.Organizational_Chart");
            DropForeignKey("dbo.Projects", "MyOrgChart_ChartId", "dbo.Organizational_Chart");
            DropForeignKey("dbo.AspNetUsers", "Organizational_Chart_ChartId", "dbo.Organizational_Chart");
            DropForeignKey("dbo.Projects", "MyClient_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requests", "MyResourcee_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requests", "MyClient_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requests", "MyAdmin_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Mandates", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "addresse_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Holidays", "Ressource_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.DayOffs", "Ressource_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.MessageInboxes", "Inbox_InboxId", "dbo.Inboxes");
            DropForeignKey("dbo.MessageInboxes", "Message_MessageId", "dbo.Messages");
            DropIndex("dbo.Organizational_ChartRessource", new[] { "Ressource_Id" });
            DropIndex("dbo.Organizational_ChartRessource", new[] { "Organizational_Chart_ChartId" });
            DropIndex("dbo.MessageInboxes", new[] { "Inbox_InboxId" });
            DropIndex("dbo.MessageInboxes", new[] { "Message_MessageId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Job_Request", new[] { "MyCandidat_Id" });
            DropIndex("dbo.Skills", new[] { "MyResource_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.Requests", new[] { "MyResourcee_Id" });
            DropIndex("dbo.Requests", new[] { "MyClient_Id" });
            DropIndex("dbo.Requests", new[] { "MyAdmin_Id" });
            DropIndex("dbo.Projects", new[] { "SkillFk_SkillId" });
            DropIndex("dbo.Projects", new[] { "MyOrgChart_ChartId" });
            DropIndex("dbo.Projects", new[] { "MyClient_Id" });
            DropIndex("dbo.Projects", new[] { "addresse_AddressId" });
            DropIndex("dbo.Mandates", new[] { "Id" });
            DropIndex("dbo.Mandates", new[] { "ProjectId" });
            DropIndex("dbo.Holidays", new[] { "Ressource_Id" });
            DropIndex("dbo.DayOffs", new[] { "Ressource_Id" });
            DropIndex("dbo.Messages", new[] { "Administrator_Id" });
            DropIndex("dbo.Messages", new[] { "RessourceMsgFK_Id" });
            DropIndex("dbo.Inboxes", new[] { "MyPerson_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "MyAdminstrator_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "Organizational_Chart_ChartId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropTable("dbo.Organizational_ChartRessource");
            DropTable("dbo.MessageInboxes");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Job_Request");
            DropTable("dbo.Skills");
            DropTable("dbo.Organizational_Chart");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Requests");
            DropTable("dbo.Addresses");
            DropTable("dbo.Projects");
            DropTable("dbo.Mandates");
            DropTable("dbo.Holidays");
            DropTable("dbo.DayOffs");
            DropTable("dbo.Messages");
            DropTable("dbo.Inboxes");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
        }
    }
}
