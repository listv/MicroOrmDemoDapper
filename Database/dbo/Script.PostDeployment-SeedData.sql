﻿/******** SEED DATA FOR STATES TABLE ********/
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(1 , N'Alabama');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(2 , N'Alaska');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(3 , N'Arizona');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(4 , N'Arkansas');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(5 , N'California');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(6 , N'Colorado');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(7 , N'Connecticut');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(8 , N'Delaware');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(9 , N'Florida');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(10 , N'Georgia');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(11 , N'Hawaii');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(12 , N'Idaho');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(13 , N'Illinois');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(14 , N'Indiana');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(15 , N'Iowa');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(16 , N'Kansas');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(17 , N'Kentucky');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(18 , N'Louisiana');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(19 , N'Maine');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(20 , N'Maryland');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(21 , N'Massachusetts');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(22 , N'Michigan');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(23 , N'Minnesota');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(24 , N'Mississippi');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(25 , N'Missouri');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(26 , N'Montana');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(27 , N'Nebraska');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(28 , N'Nevada');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(29 , N'New Hampshire');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(30 , N'New Jersey');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(31 , N'New Mexico');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(32 , N'New York');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(33 , N'North Carolina');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(34 , N'North Dakota');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(35 , N'Ohio');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(36 , N'Oklahoma');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(37 , N'Oregon');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(38 , N'Pennsylvania');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(39 , N'Rhode Island');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(40 , N'South Carolina');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(41 , N'South Dakota');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(42 , N'Tennessee');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(43 , N'Texas');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(44 , N'Utah');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(45 , N'Vermont');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(46 , N'Virginia');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(47 , N'Washington');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(48 , N'West Virginia');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(49 , N'Wisconsin');
INSERT INTO [dbo].[States] ([Id], [StateName]) VALUES(50 , N'Wyoming');

/******** SEED DATA FOR CONTACTS TABLE ********/
INSERT INTO [dbo].[Contacts] VALUES('Michael', 'Jordan', 'mickael@bulls.com', 'Chicago Bulls', 'MVP');
INSERT INTO [dbo].[Contacts] VALUES('LaBron', 'James', 'labron@heat.com', 'Miami Hit', 'King James');
INSERT INTO [dbo].[Contacts] VALUES('Kobe', 'Bruant', 'kobe@lakers.com', 'Los Angeles Lakers', 'Guard');
INSERT INTO [dbo].[Contacts] VALUES('Kevin', 'Durant', 'kevin@thunder.com', 'OKC Thunder', 'Durantula');
INSERT INTO [dbo].[Contacts] VALUES('Kurie', 'Irving', 'kurie@cavs.com', 'Cleveliend Cavaliers', 'Uncle');
INSERT INTO [dbo].[Contacts] VALUES('Chris', 'Paul', 'chris@clippers.com', 'Los Angeles Clippers', 'CP3');

/******** SEED DATA FOR ADDRESSES TABLE ********/
INSERT INTO [dbo].[Addresses] VALUES (1, 'Home', '123 Main Street', 'Chicago', 17, '60290');
INSERT INTO [dbo].[Addresses] VALUES (1, 'Work', '1901 W Madison Street', 'Chicago', 17, '60612');
INSERT INTO [dbo].[Addresses] VALUES (2, 'Home', '123 Main Street', 'Miami', 12, '33101');
INSERT INTO [dbo].[Addresses] VALUES (3, 'Home', '123 Main Street', 'Los Angeles', 6, '90001');
INSERT INTO [dbo].[Addresses] VALUES (4, 'Home', '123 Main Street', 'Oklahoma City', 40, '73101');
INSERT INTO [dbo].[Addresses] VALUES (5, 'Home', '123 Main Street', 'Cleveland', 39, '44101');
INSERT INTO [dbo].[Addresses] VALUES (6, 'Home', '456 Main Street', 'Los Angeles', 6, '90003');

SELECT * FROM dbo.Addresses;
SELECT * FROM dbo.States;
SELECT * FROM dbo.Contacts;
DELETE FROM	 dbo.Contacts WHERE FirstName='Joe';
DELETE FROM	 dbo.Contacts WHERE FirstName='Bob';
SELECT * FROM dbo.Contacts;