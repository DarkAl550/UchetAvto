CREATE TABLE Oils (
	Id INT PRIMARY KEY,
    [List] INTEGER REFERENCES [Lists](Id),
    [Check Number] INT,
	[Time] TIME,
	[OilMarks] INTEGER REFERENCES [Oil Marks](Id),
	[Value] FLOAT
);