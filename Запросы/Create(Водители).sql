CREATE TABLE Водители (
    Id INT NOT NULL PRIMARY KEY,
    Фамилия TEXT,
    Имя TEXT,
    Отчество TEXT,
	[Дата рождения] DATE,
	[Стаж работы] FLOAT,
	Оклад FLOAT,
	Категории TEXT
);