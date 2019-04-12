# MySQLNetCore22Template

 ____________________________________________________
T ================================================= |T
| ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|[L
| __________________________________________________[|
|I __==___________  ___________     .  ,. _ .   __  T|
||[_j  L_I_I_I_I_j  L_I_I_I_I_j    /|/V||(g/|   ==  l|
lI _______________________________  _____  _________I]
 |[__I_I_I_I_I_I_I_I_I_I_I_I_I_I_] [__I__] [_I_I_I_]|
 |[___I_I_I_I_I_I_I_I_I_I_I_I_L  I   ___   [_I_I_I_]|
 |[__I_I_I_I_I_I_I_I_I_I_I_I_I_L_I __I_]_  [_I_I_T ||
 |[___I_I_I_I_I_I_I_I_I_I_I_I____] [_I_I_] [___I_I_j|
 | [__I__I_________________I__L_]                   |
 |                                                  |  
 l__________________________________________________j
 
Mysql NetCore2.2 Template with Identity and CodeFirst with migration - Clean Code without mysql net core bug

  this is a ready-to-use solution you don't have to waste hours on the internet to remove problems.
I wanted to create a ready-to-use solution so that you can quickly create your software with netcore 2.1.x (you can easily upgrade), there's not much to say ... the models have already been adapted to mysql ....
I hate empty commits on github! before committing I checked the datacontext for reading and writing through Asp.Net Identity.

I also used GhostDoc to comment on all the methods, in order to have a complete code with an online help code.

I thank everyone, any doubts, contact me.

this solution fix this bug MySql on boolean model type:
No coercion operator is defined between types 'System.Int16' and 'System.Boolean' EF Core 2.1.4

use this query to init database migration table

CREATE TABLE `databasename`.`__EFMigrationsHistory` (
  `MigrationId` text NOT NULL,
  `ProductVersion` text NOT NULL,
  PRIMARY KEY (`MigrationId`(255)));
  
