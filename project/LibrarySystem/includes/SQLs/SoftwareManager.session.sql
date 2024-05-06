CREATE TABLE User(
    UserID INT PRIMARY KEY,
    Username VARCHAR(100),
    email VARCHAR(100)
);

CREATE TABLE Subscribers(
    UserID INT PRIMARY KEY,
    password VARCHAR(50),
    subscription_date DATE,
    FOREIGN KEY (UserID) REFERENCES User(UserID)
);

CREATE TABLE GuestUser(
    UserID INT PRIMARY KEY,
    FOREIGN KEY (UserID) REFERENCES User(UserID)
);

CREATE TABLE Developer(
    UserID INT PRIMARY KEY,
    DeveloperID INT,
    dateCreated DATE, 
    FOREIGN KEY (UserID) REFERENCES Subscribers(UserID)
);

CREATE TABLE Category(
    categoryID INT PRIMARY KEY,
    Category_name VARCHAR(50) 
); 

CREATE TABLE Project(
    projectID INT PRIMARY KEY,
    project_status VARCHAR(50),
    dependancy_projectID INT,
    DeveloperID INT,
    categoryID INT,
    Project_description TEXT,
    FOREIGN KEY (dependancy_projectID) REFERENCES Project(projectID),
    FOREIGN KEY (DeveloperID) REFERENCES Developer(UserID),
    FOREIGN KEY (categoryID) REFERENCES Category(categoryID)   
);

CREATE TABLE BugReport(
    bugID INT PRIMARY KEY,
    projectID INT,
    subscriberID INT,
    filing_date DATE,
    Bug_description TEXT,
    FOREIGN KEY (projectID) REFERENCES Project(projectID),
    FOREIGN KEY (subscriberID) REFERENCES Subscribers(UserID)
);



CREATE TABLE Transactions(
    transactionID INT PRIMARY KEY,
    projectID INT,
    transactionType VARCHAR(50),
    FOREIGN KEY (projectID) REFERENCES Project(projectID)
);

CREATE TABLE Software_Update(
    updateID INT PRIMARY KEY,
    projectID INT,
    Update_name VARCHAR(100),
    Updatestatus VARCHAR(50),
    Update_description TEXT,
    Update_type  INT,
    FOREIGN KEY (projectID) REFERENCES Project(projectID)
 );



CREATE TABLE Downloads(
    projectID INT,
    UserID INT,
    download_count INT,
    PRIMARY KEY (projectID, UserID),
    FOREIGN KEY (projectID) REFERENCES Project(projectID),
    FOREIGN KEY (UserID) REFERENCES User(UserID)
);

User
INSERT INTO User (UserID, Username, email) VALUES
(1, 'John Doe', 'john@example.com'),
(2, 'Jane Smith', 'jane@example.com'),
(3, 'Michael Johnson', 'michael@example.com'),
(4, 'Emily Brown', 'emily@example.com'),
(5, 'David Wilson', 'david@example.com'),
(6, 'Sarah Martinez', 'sarah@example.com'),
(7, 'Robert Taylor', 'robert@example.com'),
(8, 'Linda Anderson', 'linda@example.com'),
(9, 'William Thomas', 'william@example.com'),
(10, 'Patricia Garcia', 'patricia@example.com'),
(11, 'James Hernandez', 'james@example.com'),
(12, 'Mary Young', 'mary@example.com'),
(13, 'Christopher King', 'christopher@example.com'),
(14, 'Jennifer Lee', 'jennifer@example.com'),
(15, 'Richard Perez', 'richard@example.com'),
(16, 'Elizabeth Moore', 'elizabeth@example.com'),
(17, 'Charles Thompson', 'charles@example.com'),
(18, 'Margaret Hall', 'margaret@example.com'),
(19, 'Joseph Hernandez', 'joseph@example.com'),
(20, 'Karen Clark', 'karen@example.com');

Subscribers
INSERT INTO Subscribers (UserID, password, subscription_date) VALUES
(1, 'password123', '2023-01-15'),
(2, 'subscriberpass', '2023-02-20'),
(3, 'subpass123', '2023-03-25'),
(4, '123subscriber', '2023-04-30'),
(5, 'sub123pass', '2023-05-05'),
(6, 'subscriber123', '2023-06-10'),
(7, 'passsubscriber', '2023-07-15'),
(8, 'subpass', '2023-08-20'),
(9, 'subscriber', '2023-09-25'),
(10, '123pass', '2023-10-30'),
(11, 'sub123', '2023-11-05'),
(12, 'pass123', '2023-12-10'),
(13, 'subpass456', '2024-01-15'),
(14, 'passwordsubscriber', '2024-02-20'),
(15, 'subscriberpassword', '2024-03-25'),
(16, 'pass123subscriber', '2024-04-30'),
(17, 'subscriberpass123', '2024-05-05'),
(18, '123passwordsub', '2024-06-10'),
(19, 'sub123password', '2024-07-15'),
(20, 'password123sub', '2024-08-20');

GuestUser
INSERT INTO GuestUser (UserID) VALUES
(15), (16), (17), (18), (19), (20)
;

-- Developer
INSERT INTO Developer(UserID, DeveloperID, dateCreated) VALUES
(1, 101, '2023-01-15'),
(2, 102, '2023-02-20'),
(3, 103, '2023-03-25'),
(4, 104, '2023-04-30'),
(5, 105, '2023-05-05'),
(6, 106, '2023-06-10'),
(7, 107, '2023-07-15'),
(8, 108, '2023-08-20'),
(9, 109, '2023-09-25'),
(10, 110, '2023-10-30'),
(11, 111, '2023-11-05'),
(12, 112, '2023-12-10'),
(13, 113, '2024-01-15'),
(14, 114, '2024-02-20'),
(15, 115, '2024-03-25'),
(16, 116, '2024-04-30'),
(17, 117, '2024-05-05'),
(18, 118, '2024-06-10'),
(19, 119, '2024-07-15'),
(20, 120, '2024-08-20');

-- Category
INSERT INTO Category (categoryID, Category_name) VALUES
(1, 'A'),
(2, 'B'),
(3, 'C'),
(4, 'D'),
(5, 'E'),
(6, 'F'),
(7, 'G'),
(8, 'H'),
(9, 'I'),
(10, 'J');

-- Project
INSERT INTO Project (projectID, project_status, dependancy_projectID, DeveloperID, categoryID, Project_description) VALUES
(1, 'Active', NULL, 1, 1, 'Project A description'),
(2, 'Inactive', NULL, 2, 2, 'Project B description'),
(3, 'Active', 1, 3, 3, 'Project C description'),
(4, 'Inactive', NULL, 4, 4, 'Project D description'),
(5, 'Active', 2, 5, 5, 'Project E description'),
(6, 'Active', 3, 6, 6, 'Project F description'),
(7, 'Inactive', NULL, 7, 7, 'Project G description'),
(8, 'Active', 4, 8, 8, 'Project H description'),
(9, 'Inactive', NULL, 9, 9, 'Project I description'),
(10, 'Active', 5, 10, 10, 'Project J description'),
(11, 'Active', 6, 11, 1, 'Project K description'),
(12, 'Inactive', NULL, 12, 2, 'Project L description'),
(13, 'Active', 7, 13, 3, 'Project M description'),
(14, 'Inactive', NULL, 14, 4, 'Project N description'),
(15, 'Active', 8, 15, 5, 'Project O description'),
(16, 'Active', 9, 16, 6, 'Project P description'),
(17, 'Inactive', NULL, 17, 7, 'Project Q description'),
(18, 'Active', 10, 18, 8, 'Project R description'),
(19, 'Inactive', NULL, 19, 9, 'Project S description'),
(20, 'Active', 11, 20, 10, 'Project T description');

-- Transactions
INSERT INTO Transactions (transactionID, projectID, transactionType) VALUES
(1, 1, 'Upload'),
(2, 2, 'Upload'),
(3, 3, 'Upload'),
(4, 4, 'Upload'),
(5, 5, 'Upload'),
(6, 6, 'Upload'),
(7, 7, 'Upload'),
(8, 8, 'Upload'),
(9, 9, 'Upload'),
(10, 10, 'Upload'),
(11, 11, 'Upload'),
(12, 12, 'Upload'),
(13, 13, 'Upload'),
(14, 14, 'Upload'),
(15, 15, 'Upload'),
(16, 16, 'Upload'),
(17, 17, 'Upload'),
(18, 18, 'Upload'),
(19, 19, 'Upload'),
(20, 20, 'Upload');

ALTER TABLE Project
ADD COLUMN project_name VARCHAR(100); -- Adjust the size as needed


-- Software_Update
INSERT INTO Software_Update(updateID, projectID, Update_name, Updatestatus, Update_description, Update_type) VALUES
(1, 1, 'Update 1', 'Active', 'Update 1 description', 1),
(2, 1, 'Update 2', 'Active', 'Update 2 description', 2),
(3, 2, 'Update 3', 'Active', 'Update 3 description', 1),
(4, 2, 'Update 4', 'Active', 'Update 4 description', 2),
(5, 3, 'Update 5', 'Active', 'Update 5 description', 1),
(6, 3, 'Update 6', 'Active', 'Update 6 description', 2),
(7, 4, 'Update 7', 'Active', 'Update 7 description', 1),
(8, 4, 'Update 8', 'Active', 'Update 8 description', 2),
(9, 5, 'Update 9', 'Active', 'Update 9 description', 1),
(10, 5, 'Update 10', 'Active', 'Update 10 description', 2),
(11, 6, 'Update 11', 'Active', 'Update 11 description', 1),
(12, 6, 'Update 12', 'Active', 'Update 12 description', 2),
(13, 7, 'Update 13', 'Active', 'Update 13 description', 1),
(14, 7, 'Update 14', 'Active', 'Update 14 description', 2),
(15, 8, 'Update 15', 'Active', 'Update 15 description', 1),
(16, 8, 'Update 16', 'Active', 'Update 16 description', 2),
(17, 9, 'Update 17', 'Active', 'Update 17 description', 1),
(18, 9, 'Update 18', 'Active', 'Update 18 description', 2),
(19, 10, 'Update 19', 'Active', 'Update 19 description', 1),
(20, 10, 'Update 20', 'Active', 'Update 20 description', 2);

-- BugReport
INSERT INTO BugReport (bugID, projectID, subscriberID, filing_date, Bug_description) VALUES
(1, 1, 1, '2023-02-01', 'Bug report description 1'),
(2, 2, 1, '2023-03-10', 'Bug report description 2'),
(3, 3, 2, '2023-04-15', 'Bug report description 3'),
(4, 4, 3, '2023-05-20', 'Bug report description 4'),
(5, 5, 4, '2023-06-25', 'Bug report description 5'),
(6, 6, 5, '2023-07-30', 'Bug report description 6'),
(7, 7, 6, '2023-08-05', 'Bug report description 7'),
(8, 8, 7, '2023-09-10', 'Bug report description 8'),
(9, 9, 8, '2023-10-15', 'Bug report description 9'),
(10, 10, 9, '2023-11-20', 'Bug report description 10'),
(11, 11, 10, '2023-12-25', 'Bug report description 11'),
(12, 12, 11, '2024-01-01', 'Bug report description 12'),
(13, 13, 12, '2024-02-05', 'Bug report description 13'),
(14, 14, 13, '2024-03-10', 'Bug report description 14'),
(15, 15, 14, '2024-04-15', 'Bug report description 15'),
(16, 16, 15, '2024-05-20', 'Bug report description 16'),
(17, 17, 16, '2024-06-25', 'Bug report description 17'),
(18, 18, 17, '2024-07-30', 'Bug report description 18'),
(19, 19, 18, '2024-08-05', 'Bug report description 19'),
(20, 20, 19, '2024-09-10', 'Bug report description 20');

-- Downloads
INSERT INTO Downloads(projectID, UserID, download_count) VALUES
(1, 1, 10),
(2, 2, 5),
(3, 3, 15),
(4, 4, 20),
(5, 5, 25),
(6, 6, 30),
(7, 7, 35),
(8, 8, 40)

(9, 9, 45),
(10, 10, 50),
(11, 11, 55),
(12, 12, 60),
(13, 13, 65),
(14, 14, 70),
(15, 15, 75),
(16, 16, 80),
(17, 17, 85),
(18, 18, 90),
(19, 19, 95),
(20, 20, 100);
