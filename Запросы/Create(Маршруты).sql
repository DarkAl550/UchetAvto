CREATE TABLE Маршруты (
    [№ Маршрута] INT NOT NULL PRIMARY KEY,
    [Пункт отправки] TEXT,
    [Пункт прибытия] TEXT,
    [Дата отправки] DATE,
	[Дата прибытия] DATE,
	Расстояние FLOAT,
	[Примерный расход] FLOAT,
	[Время отдыха] TIME,
);