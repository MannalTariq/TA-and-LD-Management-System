DROP TABLE IF EXISTS Admins;
DROP TABLE IF EXISTS Departments;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS CourseDepartments;
DROP TABLE IF EXISTS Lab_Sections;
DROP TABLE IF EXISTS Course_Sections;
DROP TABLE IF EXISTS Teacher;
DROP TABLE IF EXISTS Lab_Instructor;
DROP TABLE IF EXISTS Lab_Instructor_Labs;
DROP TABLE IF EXISTS Lab_Demonstrator;
DROP TABLE IF EXISTS Lab_Instructor_Demonstrators;
DROP TABLE IF EXISTS Lab_Demonstrator_Sections;
DROP TABLE IF EXISTS Lab_Instructor_Sections;
DROP TABLE IF EXISTS Course_Instructor;
DROP TABLE IF EXISTS Course_Instructor_Sections;
DROP TABLE IF EXISTS Teacher_Assistant;
DROP TABLE IF EXISTS Course_Instructor_Assistants;
DROP TABLE IF EXISTS Teacher_Assistant_Sections;
DROP TABLE IF EXISTS Lab_Tasks;
DROP TABLE IF EXISTS Course_Tasks;
DROP TABLE IF EXISTS Attendance;
DROP TABLE IF EXISTS AuditTrail;

-----------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------
-------------------------------------------------------CREATION-------------------------------------------
-----------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------


CREATE TABLE Admins (
ID INT PRIMARY KEY IDENTITY(1,1),
FName VARCHAR(255),
LName VARCHAR(255),
Email VARCHAR(255),
Phone VARCHAR(255),
Username VARCHAR(255),
Pasword VARCHAR(255)
);

CREATE TABLE Departments (
ID INT PRIMARY KEY IDENTITY(1,1),
DName VARCHAR(255)
);

CREATE TABLE Courses (
ID INT PRIMARY KEY IDENTITY(1,1),
Co_Name VARCHAR(255),
Co_Description VARCHAR(255),
Semester VARCHAR(255),
Credit_hr VARCHAR(255)
);

CREATE TABLE CourseDepartments (
    C_ID INT,
    D_ID INT,
    FOREIGN KEY (C_ID) REFERENCES Courses(ID),
    FOREIGN KEY (D_ID) REFERENCES Departments(ID),
    PRIMARY KEY (C_ID, D_ID)
);

CREATE TABLE Lab_Sections (
LSec_ID INT PRIMARY KEY IDENTITY(1,1),
Co_ID INT,
LSec_Name VARCHAR(255),
FOREIGN KEY (Co_ID) REFERENCES Courses(ID)
);

CREATE TABLE Course_Sections (
CSec_ID INT PRIMARY KEY IDENTITY(1,1),
Co_ID INT,
CSec_Name VARCHAR(255),
FOREIGN KEY (Co_ID) REFERENCES Courses(ID)
);

CREATE TABLE Teacher (
ID INT PRIMARY KEY IDENTITY(1,1),
FName VARCHAR(255),
LName VARCHAR(255),
Email VARCHAR(255),
Phone VARCHAR(255),
Salary DECIMAL(10, 2),
Typ VARCHAR(255),
Username VARCHAR(255),
Pasword VARCHAR(255)
);

CREATE TABLE Lab_Instructor (
L_ID INT PRIMARY KEY,
A_ID INT DEFAULT 1,
FOREIGN KEY (A_ID) REFERENCES Admins(ID),
FOREIGN KEY (L_ID) REFERENCES Teacher(ID)
);

CREATE TABLE Lab_Instructor_Labs (
L_ID INT,
LSec_ID INT,
FOREIGN KEY (L_ID) REFERENCES Lab_Instructor(L_ID),
FOREIGN KEY (LSec_ID) REFERENCES Lab_Sections(LSec_ID),
PRIMARY KEY (L_ID, LSec_ID)
);

CREATE TABLE Course_Instructor (
c_ID INT PRIMARY KEY,
A_ID INT DEFAULT 1,
FOREIGN KEY (A_ID) REFERENCES Admins(ID),
FOREIGN KEY (C_ID) REFERENCES Teacher(ID)
);

CREATE TABLE Course_Instructor_Sections (
C_ID INT,
CSec_ID INT,
FOREIGN KEY (C_ID) REFERENCES Course_Instructor(C_ID),
FOREIGN KEY (CSec_ID) REFERENCES Course_Sections(CSec_ID),
PRIMARY KEY (C_ID, CSec_ID)
);

CREATE TABLE Lab_Demonstrator (
LD_ID INT PRIMARY KEY IDENTITY(1,1),
FName VARCHAR(255),
LName VARCHAR(255),
Email VARCHAR(255),
phone VARCHAR(255),
DOB VARCHAR(255),
Username VARCHAR(255),
Pasword VARCHAR(255),
A_ID INT DEFAULT 1,
FOREIGN KEY (A_ID) REFERENCES Admins(ID),
);

CREATE TABLE Lab_Instructor_Demonstrators (
L_ID INT,
LD_ID INT,
FOREIGN KEY (L_ID) REFERENCES Lab_Instructor(L_ID),
FOREIGN KEY (LD_ID) REFERENCES Lab_Demonstrator(LD_ID),
PRIMARY KEY (L_ID, LD_ID)
);

CREATE TABLE Lab_Demonstrator_Sections (
LD_ID INT,
LSec_ID INT,
FOREIGN KEY (LD_ID) REFERENCES Lab_Demonstrator(LD_ID),
FOREIGN KEY (LSec_ID) REFERENCES Lab_Sections(LSec_ID),
PRIMARY KEY (LD_ID, LSec_ID)
);

CREATE TABLE Teacher_Assistant (
TA_ID INT PRIMARY KEY IDENTITY(1,1),
FName VARCHAR(255),
LName VARCHAR(255),
Email VARCHAR(255),
phone VARCHAR(255),
DOB VARCHAR(255),
Username VARCHAR(255),
Pasword VARCHAR(255),
A_ID INT DEFAULT 1,
FOREIGN KEY (A_ID) REFERENCES Admins(ID),
);


CREATE TABLE Course_Instructor_Assistants (
C_ID INT,
TA_ID INT,
FOREIGN KEY (C_ID) REFERENCES Course_Instructor(C_ID),
FOREIGN KEY (TA_ID) REFERENCES Teacher_Assistant(TA_ID),
PRIMARY KEY (C_ID, TA_ID)
);

CREATE TABLE Teacher_Assistant_Sections (
TA_ID INT,
CSec_ID INT,
FOREIGN KEY (TA_ID) REFERENCES Teacher_Assistant(TA_ID),
FOREIGN KEY (CSec_ID) REFERENCES Course_Sections(CSec_ID),
PRIMARY KEY (TA_ID, CSec_ID)
);

CREATE TABLE Lab_Tasks (
ID INT PRIMARY KEY IDENTITY(1,1),
TName VARCHAR (255),
TDescription VARCHAR(255),
Deadline VARCHAR(255),
Status_ VARCHAR(255),
LD_ID INT,
INT_ID INT,
LSec_ID INT,
FOREIGN KEY (LSec_ID) REFERENCES Lab_Sections(LSec_ID),
FOREIGN KEY (INT_ID) REFERENCES Lab_Instructor(L_ID),
FOREIGN KEY (LD_ID) REFERENCES Lab_Demonstrator(LD_ID),
);

CREATE TABLE Course_Tasks (
ID INT PRIMARY KEY IDENTITY(1,1),
TName VARCHAR (255),
TDescription VARCHAR(255),
Deadline VARCHAR(255),
Status_ VARCHAR(255) DEFAULT 'Incomplete',
TA_ID INT,
INT_ID INT,
CSec_ID INT,
FOREIGN KEY (CSec_ID) REFERENCES Course_Sections(CSec_ID),
FOREIGN KEY (INT_ID) REFERENCES Course_Instructor(C_ID),
FOREIGN KEY (TA_ID) REFERENCES Teacher_Assistant(TA_ID),
);



CREATE TABLE Attendance (
AttendanceID INT PRIMARY KEY IDENTITY(1,1),
LD_ID INT,
LSec_ID INT,
ADate VARCHAR(255),
Attendance VARCHAR(1) DEFAULT '-',   -- 'A' absent // 'L' late // 'P' present
L_ID INT,
FOREIGN KEY (LD_ID) REFERENCES Lab_Demonstrator(LD_ID),
FOREIGN KEY (LSec_ID) REFERENCES Lab_Sections(LSec_ID),
FOREIGN KEY (L_ID) REFERENCES Lab_Instructor(L_ID)
);


CREATE TABLE AuditTrail (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TableName VARCHAR(255),
    OperationType VARCHAR(10), 
    RecordID INT,
    UserID INT,
    Timestamp DATETIME DEFAULT GETDATE()
);





-----------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------
-------------------------------------------------------INSERTION-------------------------------------------
-----------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------


-- Inserting Admins
INSERT INTO Admins (FName, LName, Email, Phone, Username, Pasword) VALUES
('Bilal','Khalid Dar', 'bilalkhaliddar@nu.edu.pk','0309-007-8601','bilalkhalid','bilal');
--('Mannal', 'Tariq', 'mannaltariq@.com', '0300-456-7890', 'mannaltariq', 'mannal'),


-- Inserting Departments
INSERT INTO Departments (DName) VALUES 
('Computer Science'),
('Electrical Engineering'),
('Business Management');

-- Inserting Courses
INSERT INTO Courses (Co_Name, Co_Description, Semester, Credit_hr) VALUES
('Introduction to Programming Fundamentals', 'Basic programming concepts', 'Fall 2023', '3'), --1
('Database Management', 'Fundamentals of database systems', 'Spring 2024', '4'), --2
('Digital Logic Designs', 'Introduction to digital circuit design', 'Fall 2023', '3'), --3
('Quantum Mechanics', 'Principles of quantum physics', 'Fall 2023', '3'), --4
('Calculus I', 'Introduction to differential and integral calculus', 'Spring 2024', '4'), --5
('Calculus II', 'Introduction to differential equations', 'Spring 2024', '4'), --6
('English Composition', 'Developing writing and communication skills', 'Spring 2024', '3'), --7
('Introduction to Psychology', 'Overview of psychology principles', 'Spring 2024', '3'), --8
('Probability and Statistics', 'Overview of probability and Statistical analysis', 'Fall 2024', '3'); --9


-- Linking Courses to Departments
INSERT INTO CourseDepartments (C_ID, D_ID) VALUES
(1, 1),
(2, 1),
(3, 1),
(3, 2), 
(4, 2),
(5, 1), 
(6, 1), 
(5, 2), 
(6, 2),
(7, 1),
(8, 1), 
(7, 2), 
(8, 2),
(7, 3), 
(8, 3), 
(9, 1), 
(9, 2),
(9, 3); 


-- Inserting Lab Sections
INSERT INTO Lab_Sections (Co_ID,LSec_Name) VALUES
(1,'PF-A'), --1 
(2,'DB-A'), --2
(3,'DLD-A'),  --3
(4,'QM-A'), --4
(7,'ENG-A'), --5
(2,'DB-B'), --6
(3,'DLD-C'), --7
(1,'PF-B'), --8
(2,'DB-C'), --9
(7,'ENG-B'), --10
(3,'DLD-B'), --11
(7,'ENG-C'), --12
(3,'DLD-D'); --13




-- Inserting Teachers
 INSERT INTO Teacher (FName, LName, Email, Phone, Salary,Typ, Username, Pasword) VALUES
('Ali', 'Khan', 'ali.khan@nu.edu.pk', '0300-134-5679', 50000.00,'Lab Instructor', 'alikhan', 'ali'), --1
('Ayesha', 'Ahmed', 'ayesha.ahmed@nu.edu.pk', '0333-987-5321', 60000.00,'Course Instructor', 'ayeshaahmed', 'ayesha'), --2
('Usman', 'Riaz', 'usman.riaz@nu.edu.pk', '0318-555-6777', 55000.00,'Lab Instructor', 'usmanriaz', 'usman'), --3
('Saima', 'Hussain', 'saima.hussain@nu.edu.pk', '0327-444-3372', 52000.00,'Course Instructor', 'saimahussain', 'saima'), --4
('Irfan', 'Ullah' , 'irfan.ullah@nu.edu.pk' , '0317-345-8776', 70000.00,'Course Instructor', 'irfanullah', 'irfan'), --5
('Urooj', 'Ghani', 'urooj.ghani@nu.edu.pk' , '0326-564-6657', 75000.00,'Lab Instructor', 'uroojghani', 'urooj'), --6
('Usman', 'Ashraf', 'usman.ashraf@nu.edu.pk', '0321- 563-8694', 50000.00,'Course Instructor', 'usmanashraf', 'usman'), --7
('Madiha', 'Nauman' , 'madiha.nauman@nu.edu.pk', '0300-134-5674', 45000.00,'Lab Instructor', 'madihanauman', 'madiha'), --8
('Sara', 'Aziz' , 'sara.aziz@nu.edu.pk', '0301-456-675', 70000.00,'Lab Instructor','saraaziz', 'sara'), --9
('Rohail', 'Gulbaz', 'rohail.gulbaz@nu.edu.pk' , '0316-564-9888', 55000.00,'Course Instructor', 'rohailgulbaz', 'rohail'); --10

-- Inserting Lab Instrutcors
INSERT INTO Lab_Instructor (L_ID)
VALUES 
(1),
(3),
(6),
(8),
(9);

INSERT INTO Lab_Instructor_Labs  (L_ID, LSec_ID)
VALUES
(1,1),
(1,8),
(3,3),
(3,7),
(3,11),
(3,13),
(6,2),
(6,9),
(6,6),
(8,4),
(9,5),
(9,10),
(9,12);

INSERT INTO Course_Instructor (C_ID)
VALUES
(2),
(4),
(5),
(7),
(10);

-- Inserting Course Sections
INSERT INTO Course_Sections (Co_ID,CSec_Name) VALUES
(1,'PF-A'), --1
(9,'P&S-A'), --2
(2,'DB-A'), --3
(8,'PSY-A'), --4
(3,'DLD-A'), --5
(7,'ENG-A'), --6
(4,'QM-A'), --7
(6,'DE-B'), --8
(5,'CAL-A'), --9
(5,'CAL-B'), --10
(6,'DE-A'), --11
(4,'QM-B'), --12
(7,'ENG-B'), --13
(3,'DLD-B'), --14
(8,'PSY-B'), --15
(2,'DB-B'), --16
(9,'P&S-B'), --17
(1,'PF-B'); --18


INSERT INTO Course_Instructor_Sections  (C_ID, CSec_ID)
VALUES
(2,1),
(2,18),
(4,2),
(4,17),
(5,3),
(5,16),
(7,4),
(7,15),
(10,5),
(10,14),
(2,6),
(2,13),
(4,7),
(4,12),
(5,8),
(5,11),
(7,9),
(7,10);

INSERT INTO Lab_Demonstrator(FName, LName, Email, phone, DOB,Username,Pasword)
VALUES
('Eman', 'Hassan', 'emanhassan@nu.edu.pk', '0321-654-3210','2001-05-14', 'emanhassan', 'eman'),
('Mariam', 'Tahir', 'mariamtahir@nu.edu.pk', '0333-123-4567','2003-09-15', 'mariamtahir', 'mariam');


-- Inserting Lab Instructor Demonstrators
INSERT INTO Lab_Instructor_Demonstrators (L_ID, LD_ID) VALUES
(1, 1),  
(1, 2),  
(3, 2),  
(6, 1),  
(8, 1),  
(8, 2), 
(9, 1);  


INSERT INTO Lab_Demonstrator_Sections (LD_ID,LSec_ID)
VALUES
(1,8),
(1,2),
(1,10),
(2,7),
(2,4);



INSERT INTO Teacher_Assistant   (FName, LName, Email, phone, DOB,Username,Pasword)
VALUES
('Leena', 'Rizwan', 'leenarizwan@nu.edu.pk', '0327-222-3333','2002-09-12', 'leenarizwan', 'leena'),
('Kynat', 'Mansha', 'kynatmansha@nu.edu.pk', '0332-555-6666', '2001-10-07','kynatmansha', 'kynat');



INSERT INTO Course_Instructor_Assistants (C_ID,TA_ID) VALUES
(5,1),
(7,1),
(2,2),
(2,1),
(4,2),
(10,2);


INSERT INTO Teacher_Assistant_Sections (TA_ID,CSec_ID) VALUES
(1,8),
(1,4),
(1,10),
(2,1),
(2,17),
(2,5);

-- Inserting Lab Tasks
INSERT INTO Lab_Tasks (TName, TDescription, Deadline, LD_ID, INT_ID, Status_,LSec_ID) VALUES
('Quiz 3', 'On Lab Manual # 7', '2023-12-01', 1, 1, 'Incomplete',8), 
('Lab Task 2', 'Superwise and mark students Lab Task 2', '2023-12-15', 1, 3,'Incomplete',7), 
('Lab Task 3', 'Only help Students in Lab Task 3', '2023-12-10', 2, 6, 'Incomplete',9), 
('Lab Task 4', 'Description for Lab Task 4', '2023-12-05', 1, 8, 'Incomplete',4), 
('Quiz 5', 'On Lab Manual # 12', '2023-11-30', 2, 9, 'Incomplete',5); 




INSERT INTO Course_Tasks (TName, TDescription, Deadline, TA_ID, INT_ID, CSec_ID) VALUES
('Assignment 1', 'Come up with a Draft for Assignment 1', '2023-12-05', 1, 5, 1), 
('Quiz # 7', 'Mark and Submit Mark Sheet of Quiz', '2023-12-20', 2, 4, 18),  
('Quiz # 3', 'Prepare a Quiz from Lecture # 7-9', '2023-12-15', 2, 10, 2),
('Assignment Demo', 'Conduct Assignment # 3 Demo', '2023-12-10', 2, 2, 17), 
('Final Project', 'Prepare Draft for Final Project', '2023-12-30', 1, 7, 3); 



-- Inserting Attendance Records
INSERT INTO Attendance (LD_ID, LSec_ID, ADate, Attendance, L_ID) VALUES
(1, 8, '2023-12-01', 'P', 1), 
(1, 2, '2023-12-05', 'A', 6), 
(1, 10, '2023-12-02', 'P', 9),  
(2,7 , '2023-12-10', 'L', 3),  
(2, 4, '2023-12-03', 'A', 8), 
(2, 7, '2023-12-08', 'P', 3); 



----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------INSERTION PROCEDURE AND TRIGGERS-------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------



CREATE OR ALTER PROCEDURE InsertTeacherAssistant
    @FName VARCHAR(255),
    @LName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(255),
    @DOB VARCHAR(255),
    @Username VARCHAR(255),
    @Pasword VARCHAR(255)
AS
BEGIN
    INSERT INTO Teacher_Assistant (FName, LName, Email, phone, DOB, Username, Pasword)
    VALUES (@FName, @LName, @Email, @Phone, @DOB, @Username, @Pasword);
	
END;
GO


CREATE OR ALTER TRIGGER tr_Teacher_Assistant_Insert 
ON Teacher_Assistant
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditTrail (TableName, OperationType, RecordID, UserID)
    SELECT 'Teacher_Assistant', 'INSERT', TA_ID, 1 
    FROM inserted;
    PRINT ('Insertion in Teacher Assistant Successful');
END;
GO

CREATE OR ALTER PROCEDURE InsertLabDemonstrator
    @FName VARCHAR(255),
    @LName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(255),
    @DOB VARCHAR(255),
    @Username VARCHAR(255),
    @Pasword VARCHAR(255)
AS
BEGIN
    INSERT INTO Lab_Demonstrator (FName, LName, Email, phone, DOB, Username, Pasword)
    VALUES (@FName, @LName, @Email, @Phone, @DOB, @Username, @Pasword);
	
END;
GO


CREATE OR ALTER TRIGGER tr_Lab_Demonstrator_Insert 
ON Lab_Demonstrator
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditTrail (TableName, OperationType, RecordID, UserID)
    SELECT 'Lab_Demonstrator', 'INSERT', LD_ID, 1 
    FROM inserted;
    PRINT ('Insertion in Lab Demonstrator Successful');
END;
GO


CREATE OR ALTER PROCEDURE InsertInstructor
    @FName VARCHAR(255),
    @LName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(255),
    @Salary VARCHAR(255),
    @Typ VARCHAR(255),
    @Username VARCHAR(255),
    @Pasword VARCHAR(255)
AS
BEGIN
    INSERT INTO Teacher  (FName, LName, Email, Phone, Salary,Typ, Username, Pasword)
    VALUES (@FName, @LName, @Email, @Phone, @Salary, @Typ ,@Username, @Pasword);
	
END;
GO


CREATE OR ALTER TRIGGER tr_Instructor_Insert 
ON Teacher
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditTrail (TableName, OperationType, RecordID, UserID)
    SELECT 'Instructor', 'INSERT', ID, 1 
    FROM inserted;
    PRINT ('Insertion in Instructor Successful');
END;
GO



CREATE OR ALTER PROCEDURE InsertCourseTask
    @TaskName VARCHAR(255),
    @Description VARCHAR(255),
    @DueDate VARCHAR(255),
    @TA_ID INT,
    @INT_ID INT,
    @CSec_ID INT
AS
BEGIN
    INSERT INTO Course_Tasks (TName, TDescription, Deadline, TA_ID, INT_ID, CSec_ID) 
	VALUES(@TaskName, @Description, @DueDate, @TA_ID, @INT_ID, @CSec_ID)
	
END;
GO


CREATE OR ALTER TRIGGER tr_CourseTask_Insert 
ON Course_Tasks
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditTrail (TableName, OperationType, RecordID, UserID)
    SELECT 'Course Task', 'INSERT', ID, 1 
    FROM inserted;
    PRINT ('Insertion in Course Task Successful');
END;
GO




CREATE OR ALTER PROCEDURE InsertLabTask
    @TaskName VARCHAR(255),
    @Description VARCHAR(255),
    @DueDate VARCHAR(255),
    @LD_ID INT,
    @INT_ID INT,
    @LSec_ID INT
AS
BEGIN
    INSERT INTO Lab_Tasks (TName, TDescription, Deadline, LD_ID, INT_ID, LSec_ID) 
	VALUES(@TaskName, @Description, @DueDate, @LD_ID, @INT_ID, @LSec_ID)
	
END;
GO


CREATE OR ALTER TRIGGER tr_LabTask_Insert 
ON Lab_Tasks
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditTrail (TableName, OperationType, RecordID, UserID)
    SELECT 'Lab Task', 'INSERT', ID, 1 
    FROM inserted;
    PRINT ('Insertion in Lab Task Successful');
END;
GO


CREATE OR ALTER PROCEDURE InsertAttendance
    @LD_ID INT,
    @LSec_ID INT,
    @ADate DATE,
    @Attendance VARCHAR(1),
    @L_ID INT
AS
BEGIN
    INSERT INTO Attendance (LD_ID, LSec_ID, ADate, Attendance, L_ID)
    VALUES (@LD_ID, @LSec_ID, @ADate, @Attendance, @L_ID);
   
END;
GO

CREATE OR ALTER TRIGGER tr_Attendance_Insert 
ON Attendance
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditTrail (TableName, OperationType, RecordID, UserID)
    SELECT 'Attendance', 'INSERT', AttendanceID, 1 
    FROM inserted;
    PRINT ('Insertion in Attendance Successful');
END;
GO





SELECT * FROM AuditTrail





----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


SELECT * FROM Admins WHERE username = 'bilalkhalid'

SELECT * FROM Teacher


SELECT id from teacher where FName='urooj' and LName = 'ghani' and username = 'uroojghani'


---------- Course Instructor Sections Tab -----------------

CREATE OR ALTER PROCEDURE CTSections @cid int
as
begin
SELECT Co_Name as Courses,Cs.CSec_Name as Sections FROM Courses c
INNER JOIN Course_Sections cs 
ON c.ID=cs.Co_ID
INNER JOIN Course_Instructor_Sections cis
ON cis.CSec_ID = cs.CSec_ID
INNER JOIN Course_Instructor ci
ON cis.C_ID = ci.c_ID
WHERE ci.c_ID = @cid
end

exec CTSections 5


---------- Lab Instructor Labs Tab -----------------

CREATE OR ALTER PROCEDURE LTSections @lid int
as
begin
SELECT Co_Name as Courses,ls.LSec_Name as Sections 
FROM Courses c
INNER JOIN Lab_Sections ls 
ON c.ID=ls.Co_ID
INNER JOIN Lab_Instructor_Labs lis
ON lis.LSec_ID = ls.LSec_ID
INNER JOIN Lab_Instructor li
ON lis.L_ID = li.L_ID
WHERE li.L_ID = @lid
end

exec LTSections 1

---------- Course Instructor - Assistant Sections Tab -----------------

CREATE OR ALTER PROCEDURE CTAssistant @cid int
as
begin
SELECT c.Co_Name AS Courses,cs.CSec_Name AS Sections,ta.TA_ID AS 'Assistant ID ',ta.FName + ' ' + ta.LName AS AssistantName,ta.Email as Email, ta.phone as 'Contact Number'
FROM Courses c
INNER JOIN Course_Sections cs 
ON c.ID = cs.Co_ID
INNER JOIN Course_Instructor_Sections cis 
ON cis.CSec_ID = cs.CSec_ID
INNER JOIN Course_Instructor ci 
ON cis.C_ID = ci.C_ID
LEFT JOIN Teacher_Assistant_Sections tas 
ON cs.CSec_ID = tas.CSec_ID
LEFT JOIN Teacher_Assistant ta 
ON tas.TA_ID = ta.TA_ID
WHERE ci.C_ID = @cid;
end

exec CTAssistant 2


---------- Lab Instructor - Assistant Sections Tab -----------------

CREATE OR ALTER PROCEDURE LLDemonstrator @lid int
as
begin
SELECT c.Co_Name AS Courses,ls.LSec_ID,ls.LSec_Name,ld.LD_ID ,ld.FName + ' ' + ld.LName AS AssistantName,ld.Email as Email, ld.phone as 'Contact Number'
FROM Courses c
INNER JOIN Lab_Sections ls 
ON c.ID = ls.Co_ID
INNER JOIN Lab_Instructor_Labs lis
ON lis.LSec_ID = ls.LSec_ID
INNER JOIN Lab_Instructor li 
ON lis.L_ID = li.L_ID
LEFT JOIN Lab_Demonstrator_Sections lds 
ON ls.LSec_ID = lds.LSec_ID
LEFT JOIN Lab_Demonstrator ld 
ON lds.LD_ID = ld.LD_ID
WHERE li.L_ID = @lid;
end


exec LLDemonstrator 8

---------- Course Instructor - Assistant Tasks Tab -----------------

CREATE OR ALTER PROCEDURE CTAtasks @cid int
as
begin
SELECT ct.ID AS 'Task ID' , ct.TName AS 'Task Name' ,ta.FName + ' ' + ta.LName AS 'Assistant Name',ta.TA_ID 'Assistant ID', cs.CSec_Name AS 'Section' , TDescription AS 'Description',Deadline,Status_ AS 'Status' FROM Course_Tasks ct
INNER JOIN Teacher_Assistant ta ON ct.TA_ID = ta.TA_ID
INNER JOIN Course_Instructor_Assistants cia ON ta.TA_ID = cia.TA_ID
INNER JOIN Course_Instructor ci ON cia.C_ID = ci.c_ID
INNER JOIN Teacher_Assistant_Sections tas ON tas.TA_ID=ta.TA_ID
INNER JOIN Course_Instructor_Sections cis ON cis.C_ID = ci.c_ID AND tas.CSec_ID=cis.CSec_ID
INNER JOIN Course_Sections cs ON cs.CSec_ID = tas.CSec_ID AND cs.CSec_ID=cis.CSec_ID
INNER JOIN Courses c ON c.ID = cs.Co_ID
INNER JOIN Teacher t ON t.ID = ci.c_ID
WHERE cis.C_ID = @cid AND t.Typ = 'Course Instructor' ;
end



exec ctatasks 2




---------- Lab Instructor - Assistant Tasks Tab -----------------

CREATE OR ALTER PROCEDURE LLDtasks @lid int
as
begin
SELECT lt.ID AS 'Task ID' , lt.TName AS 'Task Name' ,ld.FName + ' ' + ld.LName AS 'Assistant Name',
ld.LD_ID 'Assistant ID', ls.LSec_Name AS 'Section' , TDescription AS 'Description',Deadline,Status_ AS 'Status'
FROM Lab_Tasks lt
INNER JOIN Lab_Demonstrator ld ON lt.LD_ID = ld.LD_ID
INNER JOIN Lab_Instructor_Demonstrators lid ON ld.LD_ID = lid.LD_ID
INNER JOIN Lab_Instructor li ON lid.L_ID = li.L_ID
INNER JOIN Lab_Demonstrator_Sections lds ON lds.LD_ID=ld.LD_ID
INNER JOIN Lab_Instructor_Labs lis ON lis.L_ID = li.L_ID AND lds.LSec_ID=lis.LSec_ID
INNER JOIN Lab_Sections ls ON ls.LSec_ID = lds.LSec_ID AND ls.LSec_ID=lis.LSec_ID
INNER JOIN Courses c ON c.ID = ls.Co_ID
INNER JOIN Teacher t ON t.ID = li.L_ID
WHERE lis.L_ID = @lid AND t.Typ = 'Lab Instructor' ;
end

exec LLDtasks 3


--------------- Course Instructor TA TASK Update --------------

CREATE OR ALTER PROCEDURE UpdateTask @tid INT, @tname VARCHAR(255), @tdesc VARCHAR(255), @td VARCHAR(255)
AS
BEGIN
    UPDATE Course_Tasks
    SET
        TName = @tname,
        TDescription = @tdesc,
        Deadline = @td
    WHERE ID = @tid;
END;


---------------  Course Instructor TA TASK Add Grid --------------

CREATE OR ALTER PROCEDURE TAGrid @int int
as
begin
SELECT ta.FName + ' ' + ta.LName AS 'Assistant Name',ta.TA_ID 'Assistant ID', cs.CSec_Name AS 'Section',cs.CSec_ID AS 'Section ID' 
FROM Teacher_Assistant ta 
INNER JOIN Course_Instructor_Assistants cia ON ta.TA_ID = cia.TA_ID
INNER JOIN Course_Instructor ci ON cia.C_ID = ci.c_ID
INNER JOIN Teacher_Assistant_Sections tas ON tas.TA_ID=ta.TA_ID
INNER JOIN Course_Instructor_Sections cis ON cis.C_ID = ci.c_ID AND tas.CSec_ID=cis.CSec_ID
INNER JOIN Course_Sections cs ON cs.CSec_ID = tas.CSec_ID AND cs.CSec_ID=cis.CSec_ID
WHERE cis.C_ID = @int AND tas.CSec_ID IS NOT NULL;
end

exec TAGrid 2

--------------- Lab Instructor LD TASK Add Grid --------------

CREATE OR ALTER PROCEDURE LDGrid @in int
as
begin
SELECT ld.FName + ' ' + ld.LName AS 'Demonstrator Name', ld.LD_ID AS 'Demonstrator ID', ls.LSec_Name AS 'Section', ls.LSec_ID AS 'Section ID'
FROM Lab_Demonstrator ld
INNER JOIN Lab_Instructor_Demonstrators lid 
ON ld.LD_ID = lid.LD_ID
INNER JOIN Lab_Instructor li 
ON lid.L_ID = li.L_ID
INNER JOIN Lab_Demonstrator_Sections lds 
ON lds.LD_ID = ld.LD_ID
INNER JOIN Lab_Instructor_Labs lis
ON lis.L_ID = li.L_ID AND lds.LSec_ID = lis.LSec_ID
INNER JOIN Lab_Sections ls 
ON ls.LSec_ID = lds.LSec_ID
WHERE li.L_ID = @in;
end

exec LDGrid 3

----------------------------------------------------------------------------------------------------------------------------------------------


select T.FName, T.LName, CT.TName, CT.TDescription, CT.Deadline, CT.Status_
from Course_Tasks CT
inner join Course_Instructor CI
on CT.ID = CI.c_ID
inner join Teacher T
on T.ID = CI.c_ID
where CT.TA_ID = 1;


SELECT CONCAT(T.FName, ' ', T.LName) AS Teacher , CT.TName AS Task , CT.TDescription As Description, CT.Deadline, CT.Status_ AS Status
FROM Course_Tasks CT
INNER JOIN Course_Instructor CI ON CT.ID = CI.c_ID
INNER JOIN Teacher T ON T.ID = CI.c_ID
WHERE CT.TA_ID = 3;


Select *
from Lab_Demonstrator
where LD_ID = 1;


SELECT CONCAT(T.FName, ' ', T.LName) AS Teacher , LT.TName AS Task , LT.TDescription As Description, LT.Deadline, LT.Status_ AS Status
FROM Lab_Tasks LT
INNER JOIN Lab_Instructor LI ON LT.ID = LI.L_ID
INNER JOIN Teacher T ON T.ID = LI.L_ID
WHERE LT.LD_ID = 1;

-- course sec and their course instryctors ----
CREATE OR ALTER PROCEDURE coursesectionview  @userid int
as
begin
Select distinct cs.CSec_Name, concat (T.Fname, ' ', T.Lname)
from Teacher_Assistant_Sections tas
inner join Course_Instructor_Sections cis
on tas.CSec_ID = cis.CSec_ID
inner join Course_Sections cs
on cis.C_ID = cs.Co_ID
inner join Course_Instructor Ins
on cis.C_ID = Ins.c_ID
inner join Teacher T
on T.ID = Ins.c_ID
where tas.TA_ID = @userid;
end


exec coursesectionview 1




-- lab sec and their lab instructors ----
CREATE OR ALTER PROCEDURE labsectionview  @userid int
as
begin
SELECT distinct ls.LSec_Name, concat (T.Fname, ' ', T.Lname)
FROM Lab_Demonstrator_Sections lds
INNER JOIN Lab_Instructor_Labs lis
ON lds.LSec_ID = lis.LSec_ID
INNER JOIN Lab_Sections ls
ON lis.L_ID = ls.Co_ID
INNER JOIN Lab_Instructor lint
ON lis.L_ID = lint.L_ID
INNER JOIN Teacher T
ON T.ID = lint.L_ID
WHERE lds.LD_ID = @userid;
end


CREATE OR ALTER PROCEDURE LDattendanceView @userid int
as
begin
SELECT a.ADate, a.Attendance
FROM Attendance a
INNER JOIN Lab_Demonstrator l ON a.LD_ID = l.LD_ID
INNER JOIN Lab_Demonstrator_Sections lds ON a.LSec_ID = lds.LSec_ID ANd l.LD_ID = lds.LD_ID
WHERE l.LD_ID = @userid
ORDER BY a.ADate ASC;
end;

------------ number of tasks done by TA------------
CREATE OR ALTER PROCEDURE TAsal @userid int
as
begin
--SELECT 
--    (SELECT COUNT(*) 
--     FROM Course_Tasks ct 
--     WHERE status_ = 'completed' AND ct.TA_ID = @userid) 
--AS 'Number of Tasks Completed', '700' as 'Amount';

SELECT 
    s.TA_ID, s.CompletedTaskCount AS 'Number of Tasks Completed', '700' as 'Amount'
FROM 
    ( SELECT ta.TA_ID, COUNT(ct.ID) AS CompletedTaskCount
     FROM Teacher_Assistant ta
     INNER JOIN Course_Tasks ct 
	 ON ta.TA_ID = ct.TA_ID
     WHERE ct.status_ = 'completed' AND ta.TA_ID = @userid
     GROUP BY ta.TA_ID
     HAVING COUNT(ct.ID) > 0
) AS s;

end

exec LDattendanceView 1



exec TAsal 2

------------ number of tasks done by LD------------

--CREATE OR ALTER PROCEDURE LDsal @userid int
--as
--begin
--SELECT count(*) as 'Number of Tasks Completed', '1000' as 'Amount' FROM Lab_Tasks lt
--INNER JOIN Lab_Demonstrator ld
--ON lt.LD_ID=ld.LD_ID
--WHERE status_ = 'completed' AND lt.LD_ID = @userid;
--end

CREATE OR ALTER PROCEDURE LDsal @userid int
as
begin
SELECT 
    s.LD_ID,
    s.CompletedTaskCount AS 'Number of Tasks Completed',
    '1000' as 'Amount'
FROM 
    ( SELECT lt.LD_ID, COUNT(lt.ID) AS CompletedTaskCount
      FROM Lab_Tasks lt
      WHERE lt.status_ = 'completed' AND lt.LD_ID = @userid
      GROUP BY lt.LD_ID
      HAVING COUNT(lt.ID) > 0
) AS s;

end

exec LDsal 2



------------ Attendance update------------

CREATE OR ALTER PROCEDURE UpdateAttendance @Att varchar(1), @currDate varchar(255), @LD_ID int,@LSec_ID int
as
begin
UPDATE Attendance SET Attendance = @Att WHERE LD_ID = @LD_ID AND LSec_ID = @LSec_ID AND ADate = @currDate;    
end;


CREATE OR ALTER PROCEDURE DeleteAttendance @currDate VARCHAR(255), @LD_ID INT, @LSec_ID INT
AS
BEGIN
DELETE FROM Attendance WHERE LD_ID = @LD_ID AND LSec_ID = @LSec_ID AND ADate = @currDate;       
END;

-------------------------------------------------------------------------------------------------------------------------------------------

--------------- LD TASK VIEW --------------

CREATE OR ALTER PROCEDURE LDTaskView @LD_ID int
as 
begin
SELECT CONCAT(T.FName, ' ', T.LName) AS 'Instructor Name',
ls.LSec_Name,
lt.TName AS 'Task Name',
lt.ID AS 'Task ID',
lt.TDescription AS 'Task Description',
lt.Deadline,
lt.Status_ AS 'Status'
FROM Lab_Tasks lt
INNER JOIN Lab_Sections ls ON lt.LSec_ID=ls.LSec_ID
INNER JOIN Lab_Instructor li ON lt.INT_ID = li.L_ID
INNER JOIN Teacher t ON t.ID = li.L_ID
INNER JOIN Lab_Demonstrator ld ON lt.LD_ID = ld.LD_ID
WHERE lt.LD_ID = @LD_ID; 
end

exec LDTaskView 1






--------------- TA TASK VIEW --------------

CREATE OR ALTER PROCEDURE TATaskView @TA_ID int
as 
begin
SELECT CONCAT(T.FName, ' ', T.LName) AS 'Instructor Name',
       cs.CSec_Name,
       CT.TName AS 'Task Name',
       CT.ID AS 'Task ID',
       CT.TDescription AS 'Task Description',
       CT.Deadline,
       CT.Status_ AS 'Status'
	   
FROM Course_Tasks CT
INNER JOIN Course_Instructor CI ON CT.INT_ID = CI.c_ID
INNER JOIN Course_Sections cs ON cs.CSec_ID = ct.CSec_ID
INNER JOIN Teacher T ON T.ID = CI.c_ID
INNER JOIN Teacher_Assistant ta ON ct.TA_ID=ta.TA_ID
WHERE CT.TA_ID = @TA_ID; 
end

exec TATaskView 2






-------------------------------- LD Attendance ---------------------------------------


CREATE OR ALTER PROCEDURE ldattendance @id int, @secid int
AS
begin
SELECT a.ADate AS 'Date',a.Attendance
FROM Lab_Demonstrator ld
INNER JOIN Attendance a 
ON ld.LD_ID=a.LD_ID
INNER JOIN Lab_Demonstrator_Sections lds
ON lds.LSec_ID=a.LSec_ID
Where ld.LD_ID= @id and lds.LSec_ID = @secid
end


exec ldattendance 1,2

CREATE OR ALTER PROCEDURE markattendance
    @LD_ID INT,
    @LSec_ID INT,
    @adate VARCHAR(255),
    @Attendance CHAR(1),
    @L_ID INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Attendance WHERE LD_ID = @LD_ID AND LSec_ID = @LSec_ID AND ADate = @adate)
    BEGIN
        RETURN -1; 
    END
    ELSE
    BEGIN
        INSERT INTO Attendance (LD_ID, LSec_ID, ADate, Attendance, L_ID)
        VALUES (@LD_ID, @LSec_ID, @adate, @Attendance, @L_ID);
        RETURN 1;
    END
END

exec markattendance 1,2,'2023-12-06','P',6

------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------ROUGH----------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------



SELECT * FROM AuditTrail
select * from admins;
select * from Attendance;
select * from Course_Instructor;
select * from Course_Instructor_Assistants;
select * from Course_Instructor_Sections;
select * from Course_Sections;
select * from Course_Tasks;
select * from CourseDepartments;
select * from Courses;
select * from Departments;
select * from Lab_Demonstrator;
select * from Lab_Demonstrator_Sections;
select * from Lab_Instructor;
select * from Lab_Instructor_Demonstrators;
select * from Lab_Instructor_Labs;
select * from lab_Sections;
select * from Lab_Tasks;
select * from Teacher;
select * from Teacher_Assistant;
select * from Teacher_Assistant_Sections;
