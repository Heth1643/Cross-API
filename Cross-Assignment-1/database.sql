Select *from crossdemo;

ALTER TABLE Crossdemo
ADD PRIMARY KEY (id);

ALTER TABLE Crossdemo
ADD CONSTRAINT PK_Person PRIMARY KEY (Id);


drop TABLE crossdemo;

Create table Crossdemo(id int PRIMARY key,Name varchar(20),sub varchar(20));


insert into Crossdemo VALUES(1,'Hetul','Asp.net');

DELETE from Crossdemo where id BETWEEN 6 AND 400;
