/*
Post-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.      
 Use SQLCMD syntax to include a file in the post-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the post-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/

alter table Monster.Monster
  add constraint pk_monster_monsterid primary key clustered (MonsterId);
go


alter table Monster.Monster
  add constraint fk_monster_genderid foreign key (GenderId) references Monster.Gender (GenderId);
go

alter table Monster.Monster
  add constraint fk_monster_titleid foreign key (TypeId) references Monster.MonsterType (MonsterTypeId);
go
