/*
 Pre-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.   
 Use SQLCMD syntax to include a file in the pre-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the pre-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/

use master;
go

if (DB_ID(N'MonsterDB') is not null)
 Begin
 drop database MonsterDB;
 end;
 go

  create database MonsterDB;
  go


  use MonsterDB;
go

--if(object_id('MonsterDb') = 1)
--begin
create schema Monster;
--end;
go

create table Monster.Monster
(
  MonsterId int not null identity(1,1) primary key
  ,Gender int null
  ,TitleId int null --foreign key references Monster.Title (TitleId)
  ,TypeId int not null
  ,Name nvarchar(250) not null
  ,PicturePath nvarchar(256) null
  ,Active bit not null
);
go

create table Monster.MonsterType
(
  MonsterTypeId int not null identity(1,1) primary key
  ,TypeName nvarchar(250) not null
  ,Active bit not null
);
go

create table Monster.Gender
(
  GenderId int not null identity(1,1) primary key
  ,GenderName nvarchar(250) not null
  ,Active bit not null
);
go

create table Monster.Title
(
  TitleId int not null identity(1,1) primary key
  ,TitleName nvarchar(250) not null
  ,Active bit not null
);
go


