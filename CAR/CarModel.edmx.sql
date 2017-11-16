
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/20/2017 22:12:05
-- Generated from EDMX file: C:\Users\amarv\Downloads\CAR\CAR\CarModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CAR];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_APOPCOBADGE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [FK_APOPCOBADGE];
GO
IF OBJECT_ID(N'[dbo].[FK_BARCODE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [FK_BARCODE];
GO
IF OBJECT_ID(N'[dbo].[FK_centers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[APO_PCO] DROP CONSTRAINT [FK_centers];
GO
IF OBJECT_ID(N'[dbo].[FK_PCOBADGE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ASSETS] DROP CONSTRAINT [FK_PCOBADGE];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[APO_PCO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[APO_PCO];
GO
IF OBJECT_ID(N'[dbo].[ASSETS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ASSETS];
GO
IF OBJECT_ID(N'[dbo].[CENTERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CENTERS];
GO
IF OBJECT_ID(N'[dbo].[USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'APO_PCO'
CREATE TABLE [dbo].[APO_PCO] (
    [APO_PCO_PIV_BADGE_NUM] int  NOT NULL,
    [USER_ID] varchar(12)  NULL,
    [CENTER] varchar(5)  NULL,
    [CAR_ADMIN] bit  NULL,
    [CAN_SEND_REMINDER] bit  NULL,
    [MUST_CHANGE_PWD] bit  NULL,
    [ENABLED] bit  NULL,
    [LAST_NAME] varchar(45)  NULL,
    [MIDDLE_INITIAL] varchar(1)  NULL,
    [FIRST_NAME] varchar(45)  NULL,
    [PHONE_NUM] varchar(15)  NULL,
    [EMAIL] varchar(100)  NULL,
    [PASSWORD_REMINDER] varchar(150)  NULL,
    [CREATED] datetime  NULL,
    [LAST_UPDATED] datetime  NULL,
    [PASSWORD] varchar(12)  NULL
);
GO

-- Creating table 'ASSETS'
CREATE TABLE [dbo].[ASSETS] (
    [BARCODE] int  NOT NULL,
    [MANUFACTURER] varchar(45)  NULL,
    [MODEL] varchar(45)  NULL,
    [SERIAL_NUM] varchar(45)  NULL,
    [COMPUTER_NAME] varchar(45)  NULL,
    [DATETIME_ASSIGNED] datetime  NULL,
    [DATETIME_RECEIVED] datetime  NULL,
    [STATE] varchar(45)  NULL,
    [APO_PCO_PIV_BADGE_NUM] int  NULL,
    [CREATED] datetime  NULL,
    [LAST_UPDATED] datetime  NULL
);
GO

-- Creating table 'CENTERS'
CREATE TABLE [dbo].[CENTERS] (
    [CENTER1] varchar(5)  NOT NULL,
    [LOCATION_CODE] varchar(10)  NULL,
    [CREATED] datetime  NULL,
    [LAST_UPDATED] datetime  NULL
);
GO

-- Creating table 'USERS'
CREATE TABLE [dbo].[USERS] (
    [USER_PIV_BADGE_NUM] int  NOT NULL,
    [FIRST_NAME] varchar(45)  NULL,
    [LAST_NAME] varchar(45)  NULL,
    [MIDDILE_INITIAL] varchar(1)  NULL,
    [EMAIL] varchar(100)  NULL,
    [DATETIME_ACCEPTED] datetime  NULL,
    [BARCODE] int  NULL,
    [APO_PCO_PIV_BADGE_NUM] int  NULL,
    [PREVIOUS_BARCODE] int  NULL,
    [OUTSTANDING_ASSET] bit  NULL,
    [LAST_REMINDER] datetime  NULL,
    [CREATED] datetime  NULL,
    [LAST_UPDATED] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [APO_PCO_PIV_BADGE_NUM] in table 'APO_PCO'
ALTER TABLE [dbo].[APO_PCO]
ADD CONSTRAINT [PK_APO_PCO]
    PRIMARY KEY CLUSTERED ([APO_PCO_PIV_BADGE_NUM] ASC);
GO

-- Creating primary key on [BARCODE] in table 'ASSETS'
ALTER TABLE [dbo].[ASSETS]
ADD CONSTRAINT [PK_ASSETS]
    PRIMARY KEY CLUSTERED ([BARCODE] ASC);
GO

-- Creating primary key on [CENTER1] in table 'CENTERS'
ALTER TABLE [dbo].[CENTERS]
ADD CONSTRAINT [PK_CENTERS]
    PRIMARY KEY CLUSTERED ([CENTER1] ASC);
GO

-- Creating primary key on [USER_PIV_BADGE_NUM] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [PK_USERS]
    PRIMARY KEY CLUSTERED ([USER_PIV_BADGE_NUM] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [APO_PCO_PIV_BADGE_NUM] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [FK_APOPCOBADGE]
    FOREIGN KEY ([APO_PCO_PIV_BADGE_NUM])
    REFERENCES [dbo].[APO_PCO]
        ([APO_PCO_PIV_BADGE_NUM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_APOPCOBADGE'
CREATE INDEX [IX_FK_APOPCOBADGE]
ON [dbo].[USERS]
    ([APO_PCO_PIV_BADGE_NUM]);
GO

-- Creating foreign key on [CENTER] in table 'APO_PCO'
ALTER TABLE [dbo].[APO_PCO]
ADD CONSTRAINT [FK_centers]
    FOREIGN KEY ([CENTER])
    REFERENCES [dbo].[CENTERS]
        ([CENTER1])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_centers'
CREATE INDEX [IX_FK_centers]
ON [dbo].[APO_PCO]
    ([CENTER]);
GO

-- Creating foreign key on [APO_PCO_PIV_BADGE_NUM] in table 'ASSETS'
ALTER TABLE [dbo].[ASSETS]
ADD CONSTRAINT [FK_PCOBADGE]
    FOREIGN KEY ([APO_PCO_PIV_BADGE_NUM])
    REFERENCES [dbo].[APO_PCO]
        ([APO_PCO_PIV_BADGE_NUM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PCOBADGE'
CREATE INDEX [IX_FK_PCOBADGE]
ON [dbo].[ASSETS]
    ([APO_PCO_PIV_BADGE_NUM]);
GO

-- Creating foreign key on [BARCODE] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [FK_BARCODE]
    FOREIGN KEY ([BARCODE])
    REFERENCES [dbo].[ASSETS]
        ([BARCODE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BARCODE'
CREATE INDEX [IX_FK_BARCODE]
ON [dbo].[USERS]
    ([BARCODE]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------