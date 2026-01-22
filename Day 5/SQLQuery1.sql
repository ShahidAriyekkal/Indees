CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT,
    Course NVARCHAR(100)
);
select * from Students;
INSERT INTO Students(Name,Age,Course)
VALUES('AMIL',23,'MCA');
INSERT INTO Students VALUES('Shahid',23,'BCA');
INSERT INTO Students VALUES('jubi',24,'BCA');
select * from Students 
WHERE Age > 24; 
