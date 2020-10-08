CREATE TABLE Заправка (
	Id INT PRIMARY KEY,
    [№ путевого листа] INTEGER REFERENCES [Путевые листы](Id),
    [№ чека] INT,
	[Время заправки] TIME,
	[Марка топлива] INTEGER REFERENCES [Марка топлива](Id),
	Количество FLOAT
);