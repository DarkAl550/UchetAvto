CREATE TABLE �������� (
	Id INT PRIMARY KEY,
    [� �������� �����] INTEGER REFERENCES [������� �����](Id),
    [� ����] INT,
	[����� ��������] TIME,
	[����� �������] INTEGER REFERENCES [����� �������](Id),
	���������� FLOAT
);