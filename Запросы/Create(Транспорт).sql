CREATE TABLE [���������] (
	Id INT PRIMARY KEY,
    [�������� ����������] TEXT,
    ����� TEXT,
	[��� ����������] INTEGER REFERENCES [��� ����������](ID),
	����������� TEXT,
	������� TEXT,
	[��� �������] INT,
	[��� �����] TEXT,
	[� ���������] TEXT,
	[� ������] TEXT,
	[������������ ��������] FLOAT,
	��������������� FLOAT,
	[����� �������] INTEGER REFERENCES [����� �������](Id),
	[������� ������ �������] FLOAT
);