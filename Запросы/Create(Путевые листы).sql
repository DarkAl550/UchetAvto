CREATE TABLE [������� �����] (
	Id INT PRIMARY KEY,
    [���������] INTEGER REFERENCES ���������(Id),
    �������� INTEGER REFERENCES ��������(Id),
	[���� ������] DATE,
	[���� ��������] DATE,
	[���������� ������� ��� ��������] FLOAT,
	[���������� ������� �� �����������] FLOAT,
	������� INTEGER REFERENCES ��������([� ��������]) ,
	[����� �����] FLOAT
);