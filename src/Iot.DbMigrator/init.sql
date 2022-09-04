
CREATE TABLE [dbo].[__EFMigrationsHistory](
    [MigrationId] [nvarchar](150) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED
(
[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AbpAuditLogActions]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AbpAuditLogActions](
    [Id] [uniqueidentifier] NOT NULL,
    [TenantId] [uniqueidentifier] NULL,
    [AuditLogId] [uniqueidentifier] NOT NULL,
    [ServiceName] [nvarchar](256) NULL,
    [MethodName] [nvarchar](128) NULL,
    [Parameters] [nvarchar](2000) NULL,
    [ExecutionTime] [datetime2](7) NOT NULL,
    [ExecutionDuration] [int] NOT NULL,
    [ExtraProperties] [nvarchar](max) NULL,
    CONSTRAINT [PK_AbpAuditLogActions] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AbpAuditLogs]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AbpAuditLogs](
    [Id] [uniqueidentifier] NOT NULL,
    [ApplicationName] [nvarchar](96) NULL,
    [UserId] [uniqueidentifier] NULL,
    [UserName] [nvarchar](256) NULL,
    [TenantId] [uniqueidentifier] NULL,
    [TenantName] [nvarchar](64) NULL,
    [ImpersonatorUserId] [uniqueidentifier] NULL,
    [ImpersonatorUserName] [nvarchar](256) NULL,
    [ImpersonatorTenantId] [uniqueidentifier] NULL,
    [ImpersonatorTenantName] [nvarchar](64) NULL,
    [ExecutionTime] [datetime2](7) NOT NULL,
    [ExecutionDuration] [int] NOT NULL,
    [ClientIpAddress] [nvarchar](64) NULL,
    [ClientName] [nvarchar](128) NULL,
    [ClientId] [nvarchar](64) NULL,
    [CorrelationId] [nvarchar](64) NULL,
    [BrowserInfo] [nvarchar](512) NULL,
    [HttpMethod] [nvarchar](16) NULL,
    [Url] [nvarchar](256) NULL,
    [Exceptions] [nvarchar](max) NULL,
    [Comments] [nvarchar](256) NULL,
    [HttpStatusCode] [int] NULL,
    [ExtraProperties] [nvarchar](max) NULL,
    [ConcurrencyStamp] [nvarchar](40) NULL,
    CONSTRAINT [PK_AbpAuditLogs] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AbpEntityChanges]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AbpEntityChanges](
    [Id] [uniqueidentifier] NOT NULL,
    [AuditLogId] [uniqueidentifier] NOT NULL,
    [TenantId] [uniqueidentifier] NULL,
    [ChangeTime] [datetime2](7) NOT NULL,
    [ChangeType] [tinyint] NOT NULL,
    [EntityTenantId] [uniqueidentifier] NULL,
    [EntityId] [nvarchar](128) NOT NULL,
    [EntityTypeFullName] [nvarchar](128) NOT NULL,
    [ExtraProperties] [nvarchar](max) NULL,
    CONSTRAINT [PK_AbpEntityChanges] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AbpEntityPropertyChanges]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AbpEntityPropertyChanges](
    [Id] [uniqueidentifier] NOT NULL,
    [TenantId] [uniqueidentifier] NULL,
    [EntityChangeId] [uniqueidentifier] NOT NULL,
    [NewValue] [nvarchar](512) NULL,
    [OriginalValue] [nvarchar](512) NULL,
    [PropertyName] [nvarchar](128) NOT NULL,
    [PropertyTypeFullName] [nvarchar](64) NOT NULL,
    CONSTRAINT [PK_AbpEntityPropertyChanges] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AbpFeatureValues]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AbpFeatureValues](
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](128) NOT NULL,
    [Value] [nvarchar](128) NOT NULL,
    [ProviderName] [nvarchar](64) NULL,
    [ProviderKey] [nvarchar](64) NULL,
    CONSTRAINT [PK_AbpFeatureValues] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AbpSettings]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AbpSettings](
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](128) NOT NULL,
    [Value] [nvarchar](2048) NOT NULL,
    [ProviderName] [nvarchar](64) NULL,
    [ProviderKey] [nvarchar](64) NULL,
    CONSTRAINT [PK_AbpSettings] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[DeviceRunLogs]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[DeviceRunLogs](
    [Id] [uniqueidentifier] NOT NULL,
    [DeviceId] [uniqueidentifier] NOT NULL,
    [Logs] [nvarchar](max) NULL,
    [CreationTime] [datetime2](7) NOT NULL,
    CONSTRAINT [PK_DeviceRunLogs] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[DeviceTemplates]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[DeviceTemplates](
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](max) NULL,
    [Icon] [nvarchar](max) NULL,
    [Type] [int] NOT NULL,
    [Remark] [nvarchar](max) NULL,
    [UserId] [uniqueidentifier] NULL,
    [IsDeleted] [bit] NOT NULL,
    [DeletionTime] [datetime2](7) NULL,
    [CreationTime] [datetime2](7) NOT NULL,
    [CreatorId] [uniqueidentifier] NULL,
    CONSTRAINT [PK_DeviceTemplates] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[IotDevices]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[IotDevices](
    [Id] [uniqueidentifier] NOT NULL,
    [Remark] [nvarchar](max) NULL,
    [Stats] [int] NOT NULL,
    [Name] [nvarchar](max) NULL,
    [LastTime] [datetime2](7) NULL,
    [UserInfoId] [uniqueidentifier] NULL,
    [DeviceTemplateId] [uniqueidentifier] NULL,
    [IsDeleted] [bit] NOT NULL,
    [DeletionTime] [datetime2](7) NULL,
    [CreationTime] [datetime2](7) NOT NULL,
    [CreatorId] [uniqueidentifier] NULL,
    CONSTRAINT [PK_IotDevices] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[IotUserInfo]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[IotUserInfo](
    [Id] [uniqueidentifier] NOT NULL,
    [AccountNumber] [nvarchar](450) NULL,
    [PhoneNumber] [nvarchar](max) NULL,
    [WeChatOpenId] [nvarchar](450) NULL,
    [Password] [nvarchar](450) NULL,
    [Avatar] [nvarchar](max) NULL,
    [Introduce] [nvarchar](max) NULL,
    [State] [int] NOT NULL,
    [Name] [nvarchar](max) NULL,
    [IsDeleted] [bit] NOT NULL,
    [DeletionTime] [datetime2](7) NULL,
    [CreationTime] [datetime2](7) NOT NULL,
    [CreatorId] [uniqueidentifier] NULL,
    CONSTRAINT [PK_IotUserInfo] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[menuRoleFunctions]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[menuRoleFunctions](
    [MenuId] [uniqueidentifier] NOT NULL,
    [RoleId] [uniqueidentifier] NOT NULL,
     CONSTRAINT [PK_menuRoleFunctions] PRIMARY KEY CLUSTERED
    (
    [MenuId] ASC,
[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Menus]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Menus](
    [Id] [uniqueidentifier] NOT NULL,
    [Index] [int] NOT NULL,
    [Component] [nvarchar](max) NULL,
    [Title] [nvarchar](max) NULL,
    [Name] [nvarchar](max) NULL,
    [Icon] [nvarchar](max) NULL,
    [Path] [nvarchar](max) NULL,
    [ParentId] [uniqueidentifier] NULL,
    [IsDeleted] [bit] NOT NULL,
    [ConcurrencyStamp] [nvarchar](40) NULL,
    [CreationTime] [datetime2](7) NOT NULL,
    [ExtraProperties] [nvarchar](max) NULL,
    CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Roles]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Roles](
    [Id] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](max) NULL,
    [Code] [nvarchar](max) NULL,
    [Remark] [nvarchar](max) NULL,
    [Index] [int] NOT NULL,
    [ParentId] [uniqueidentifier] NULL,
    [IsDeleted] [bit] NOT NULL,
    [CreationTime] [datetime2](7) NOT NULL,
    [ConcurrencyStamp] [nvarchar](40) NULL,
    [ExtraProperties] [nvarchar](max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[UserRoleFunctions]    Script Date: 2022/9/4 22:51:06 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[UserRoleFunctions](
    [UserInfoId] [uniqueidentifier] NOT NULL,
    [RoleId] [uniqueidentifier] NOT NULL,
     CONSTRAINT [PK_UserRoleFunctions] PRIMARY KEY CLUSTERED
    (
    [UserInfoId] ASC,
[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
    INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904142248_init', N'6.0.8')
    GO
    INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220904144646_createRoleData', N'6.0.8')
    GO
    INSERT [dbo].[DeviceTemplates] ([Id], [Name], [Icon], [Type], [Remark], [UserId], [IsDeleted], [DeletionTime], [CreationTime], [CreatorId]) VALUES (N'45784583-83f4-40ea-a95e-19ddb411fe3b', N'温度计', N'https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png', 0, N'', N'8749ca90-555c-4b4a-b974-c520b5b4766a', 0, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
    GO
    INSERT [dbo].[IotDevices] ([Id], [Remark], [Stats], [Name], [LastTime], [UserInfoId], [DeviceTemplateId], [IsDeleted], [DeletionTime], [CreationTime], [CreatorId]) VALUES (N'3ec20660-d276-40f1-bcca-f446207356ca', N'', 1, NULL, NULL, N'8749ca90-555c-4b4a-b974-c520b5b4766a', N'45784583-83f4-40ea-a95e-19ddb411fe3b', 0, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
    GO
    INSERT [dbo].[IotUserInfo] ([Id], [AccountNumber], [PhoneNumber], [WeChatOpenId], [Password], [Avatar], [Introduce], [State], [Name], [IsDeleted], [DeletionTime], [CreationTime], [CreatorId]) VALUES (N'8749ca90-555c-4b4a-b974-c520b5b4766a', N'admin', N'13049809673', NULL, N'dd666666', N'https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg', N'超级管理员', 0, N'管理员', 0, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'67a38722-ad2b-4693-b767-1a8bbd026a7f', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'417e578a-48fe-41b6-a60d-21cffbd99328', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'bb72fac0-1d4f-408b-b7e6-248594514f38', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'02256adc-9797-4a82-836e-50119661662b', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'98c36e51-4b78-4690-b170-68e14304f0ae', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'efca255d-bbc2-46d4-a28f-6b9f8b35a617', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'72745051-a07d-4d9e-8fcb-8b3188040b5a', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[menuRoleFunctions] ([MenuId], [RoleId]) VALUES (N'af0a92e5-86ed-4d57-905f-c9765e5e0f9e', N'e1d3806f-a432-4e38-91e0-6823148e0ed2')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'67a38722-ad2b-4693-b767-1a8bbd026a7f', 0, N'@/pages/devices/template/index', N'设备模板', N'设备模板', NULL, N'/devices/template', N'417e578a-48fe-41b6-a60d-21cffbd99328', 0, N'66c4de51e2f1470588f80d8bfe6966fb', CAST(N'2022-09-04T22:46:46.3741203' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'417e578a-48fe-41b6-a60d-21cffbd99328', 2, NULL, N'设备', N'设备', N'DashboardOutlined', N'/devices', NULL, 0, N'11d03668a9dc4cacb00dc19f3787b27d', CAST(N'2022-09-04T22:46:46.3741197' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'bb72fac0-1d4f-408b-b7e6-248594514f38', 1, N'', N'权限管理', N'权限管理', N'SettingOutlined', N'/authority', NULL, 0, N'003f71409f6f43c8bff3eacfb4f09d13', CAST(N'2022-09-04T22:46:46.3741175' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'02256adc-9797-4a82-836e-50119661662b', 1, N'@/pages/authority/users/index', N'用户管理', N'用户管理', NULL, N'/authority/user', N'bb72fac0-1d4f-408b-b7e6-248594514f38', 0, N'a9f4f7939ad04ca08c169840abb08576', CAST(N'2022-09-04T22:46:46.3741189' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'98c36e51-4b78-4690-b170-68e14304f0ae', 1, N'@/pages/devices/admin/index', N'设备管理', N'设备管理', NULL, N'/devices/admin', N'417e578a-48fe-41b6-a60d-21cffbd99328', 0, N'd9f7a17c1c734c549b8726aa24bdf270', CAST(N'2022-09-04T22:46:46.3741207' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'efca255d-bbc2-46d4-a28f-6b9f8b35a617', 2, N'@/pages/authority/menus/index', N'菜单管理', N'菜单管理', NULL, N'/authority/menu', N'bb72fac0-1d4f-408b-b7e6-248594514f38', 0, N'f8766a897e344567a34fa293606be746', CAST(N'2022-09-04T22:46:46.3741193' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'72745051-a07d-4d9e-8fcb-8b3188040b5a', 0, N'@/pages/home/index', N'首页', N'首页', N'HomeOutlined', N'/', NULL, 0, N'38fa5f7cfed34da9a7c8540f1d9f4d4f', CAST(N'2022-09-04T22:46:46.3741170' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Menus] ([Id], [Index], [Component], [Title], [Name], [Icon], [Path], [ParentId], [IsDeleted], [ConcurrencyStamp], [CreationTime], [ExtraProperties]) VALUES (N'af0a92e5-86ed-4d57-905f-c9765e5e0f9e', 0, N'@/pages/authority/roles/index', N'角色管理', N'角色管理', NULL, N'/authority/role', N'bb72fac0-1d4f-408b-b7e6-248594514f38', 0, N'1604c7258daf48929c138377aa5855d7', CAST(N'2022-09-04T22:46:46.3741185' AS DateTime2), N'{}')
    GO
    INSERT [dbo].[Roles] ([Id], [Name], [Code], [Remark], [Index], [ParentId], [IsDeleted], [CreationTime], [ConcurrencyStamp], [ExtraProperties]) VALUES (N'e1d3806f-a432-4e38-91e0-6823148e0ed2', N'管理员', N'admin', N'系统管理员', 0, NULL, 0, CAST(N'2022-09-04T22:46:46.3741094' AS DateTime2), N'cf04189a00a64a50b50fd6293b09169d', N'{}')
    GO
ALTER TABLE [dbo].[DeviceTemplates] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
    GO
ALTER TABLE [dbo].[IotDevices] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
    GO
ALTER TABLE [dbo].[IotUserInfo] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
    GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
    GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreationTime]
    GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
    GO
ALTER TABLE [dbo].[AbpAuditLogActions]  WITH CHECK ADD  CONSTRAINT [FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId] FOREIGN KEY([AuditLogId])
    REFERENCES [dbo].[AbpAuditLogs] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AbpAuditLogActions] CHECK CONSTRAINT [FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId]
    GO
ALTER TABLE [dbo].[AbpEntityChanges]  WITH CHECK ADD  CONSTRAINT [FK_AbpEntityChanges_AbpAuditLogs_AuditLogId] FOREIGN KEY([AuditLogId])
    REFERENCES [dbo].[AbpAuditLogs] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AbpEntityChanges] CHECK CONSTRAINT [FK_AbpEntityChanges_AbpAuditLogs_AuditLogId]
    GO
ALTER TABLE [dbo].[AbpEntityPropertyChanges]  WITH CHECK ADD  CONSTRAINT [FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId] FOREIGN KEY([EntityChangeId])
    REFERENCES [dbo].[AbpEntityChanges] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AbpEntityPropertyChanges] CHECK CONSTRAINT [FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId]
    GO
ALTER TABLE [dbo].[DeviceTemplates]  WITH CHECK ADD  CONSTRAINT [FK_DeviceTemplates_IotUserInfo_UserId] FOREIGN KEY([UserId])
    REFERENCES [dbo].[IotUserInfo] ([Id])
    GO
ALTER TABLE [dbo].[DeviceTemplates] CHECK CONSTRAINT [FK_DeviceTemplates_IotUserInfo_UserId]
    GO
ALTER TABLE [dbo].[IotDevices]  WITH CHECK ADD  CONSTRAINT [FK_IotDevices_DeviceTemplates_DeviceTemplateId] FOREIGN KEY([DeviceTemplateId])
    REFERENCES [dbo].[DeviceTemplates] ([Id])
    GO
ALTER TABLE [dbo].[IotDevices] CHECK CONSTRAINT [FK_IotDevices_DeviceTemplates_DeviceTemplateId]
    GO
ALTER TABLE [dbo].[IotDevices]  WITH CHECK ADD  CONSTRAINT [FK_IotDevices_IotUserInfo_UserInfoId] FOREIGN KEY([UserInfoId])
    REFERENCES [dbo].[IotUserInfo] ([Id])
    GO
ALTER TABLE [dbo].[IotDevices] CHECK CONSTRAINT [FK_IotDevices_IotUserInfo_UserInfoId]
    GO
ALTER TABLE [dbo].[menuRoleFunctions]  WITH CHECK ADD  CONSTRAINT [FK_menuRoleFunctions_Menus_MenuId] FOREIGN KEY([MenuId])
    REFERENCES [dbo].[Menus] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[menuRoleFunctions] CHECK CONSTRAINT [FK_menuRoleFunctions_Menus_MenuId]
    GO
ALTER TABLE [dbo].[menuRoleFunctions]  WITH CHECK ADD  CONSTRAINT [FK_menuRoleFunctions_Roles_RoleId] FOREIGN KEY([RoleId])
    REFERENCES [dbo].[Roles] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[menuRoleFunctions] CHECK CONSTRAINT [FK_menuRoleFunctions_Roles_RoleId]
    GO
ALTER TABLE [dbo].[UserRoleFunctions]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleFunctions_IotUserInfo_UserInfoId] FOREIGN KEY([UserInfoId])
    REFERENCES [dbo].[IotUserInfo] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoleFunctions] CHECK CONSTRAINT [FK_UserRoleFunctions_IotUserInfo_UserInfoId]
    GO
ALTER TABLE [dbo].[UserRoleFunctions]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleFunctions_Roles_RoleId] FOREIGN KEY([RoleId])
    REFERENCES [dbo].[Roles] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoleFunctions] CHECK CONSTRAINT [FK_UserRoleFunctions_Roles_RoleId]
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'设备运行信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceRunLogs'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'模板名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceTemplates', @level2type=N'COLUMN',@level2name=N'Name'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceTemplates', @level2type=N'COLUMN',@level2name=N'Icon'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceTemplates', @level2type=N'COLUMN',@level2name=N'Type'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceTemplates', @level2type=N'COLUMN',@level2name=N'Remark'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceTemplates', @level2type=N'COLUMN',@level2name=N'UserId'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'设备模板' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DeviceTemplates'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'设备信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotDevices'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo', @level2type=N'COLUMN',@level2name=N'AccountNumber'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo', @level2type=N'COLUMN',@level2name=N'PhoneNumber'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo', @level2type=N'COLUMN',@level2name=N'Password'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo', @level2type=N'COLUMN',@level2name=N'Avatar'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账号状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo', @level2type=N'COLUMN',@level2name=N'State'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'昵称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo', @level2type=N'COLUMN',@level2name=N'Name'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'IotUserInfo'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单角色配置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menuRoleFunctions'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus', @level2type=N'COLUMN',@level2name=N'Title'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单权限控制' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menus'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Code'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Remark'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Index'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上一级id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'ParentId'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles'
    GO
    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色配置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRoleFunctions'
    GO
