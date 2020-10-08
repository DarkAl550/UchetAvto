CREATE TABLE [Транспорт] (
	Id INT PRIMARY KEY,
    [Название транспорта] TEXT,
    Марка TEXT,
	[Тип транспорта] INTEGER REFERENCES [Тип транспорта](ID),
	Организация TEXT,
	Колонна TEXT,
	[Год выпуска] INT,
	[Гос номер] TEXT,
	[№ двигателя] TEXT,
	[№ кузова] TEXT,
	[Максимальная скорость] FLOAT,
	Грузоподъемноть FLOAT,
	[Марка топлива] INTEGER REFERENCES [Марка топлива](Id),
	[Средний расход топлива] FLOAT
);