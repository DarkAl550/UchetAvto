CREATE TABLE [Путевые листы] (
	Id INT PRIMARY KEY,
    [Транспорт] INTEGER REFERENCES Транспорт(Id),
    Водитель INTEGER REFERENCES Водители(Id),
	[Дата выезда] DATE,
	[Дата возврата] DATE,
	[Количество топлива при отправке] FLOAT,
	[Количество топлива по возвращении] FLOAT,
	Маршрут INTEGER REFERENCES Маршруты([№ Маршрута]) ,
	[Масса груза] FLOAT
);