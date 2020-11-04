CREATE TABLE [Car] (
	Id INT PRIMARY KEY,
    [Name Car] TEXT,
    [Marks] TEXT,
	[Car Type] INTEGER REFERENCES [Car Type](ID),
	Org TEXT,
	Colonna TEXT,
	[Date release] INT,
	[Car Number] TEXT,
	[Motor Number] TEXT,
	[Kuzov Number] TEXT,
	[Tech Status] FLOAT,
	[Max Speed] FLOAT,
	[Oil Marks] INTEGER REFERENCES [Oil Marks](Id),
	[Oils Lost] FLOAT
);