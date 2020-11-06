CREATE TABLE [Lists] (
	Id INT PRIMARY KEY,
    [Car] INTEGER REFERENCES [Car](Id),
    Driver INTEGER REFERENCES Drivers(Id),
	[Date Start] DATE,
	[Date End] DATE,
	[Start Oils] FLOAT,
	[End Oils] FLOAT,
	Marshrut INTEGER REFERENCES Marshruts([Id]) ,
	[Mass] FLOAT
);