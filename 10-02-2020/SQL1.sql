CREATE DATABASE SNEHA;

DROP DATABASE SNEHA;

CREATE SCHEMA Student;
Go

Create table job
(
  Job_id int primary key identity,
  Customer_id int not null,
  description varchar(200),
  created_at datetime2 not null
 
);



CREATE TABLE Office
(
  Office_id int Primary key identity, 
  Office_Name nvarchar(20) not null,
  Office_Address nvarchar(20) not null,
  Phone int ,
 );


  insert into Office values(1,'Bizruntime','Sarjapura',9634379443);
  insert into Office values(2,'Cognizant','Gandhinagar',9658476364);
  insert into Office values(3,'Accenture','Jayanagar',9634792274);
  insert into Office values(4,'Intel','Majestic',96337944383);

 CREATE SCHEMA logistics;
 GO

CREATE TABLE logistics.deliveries
(
  Order_id int primary key,
  delivery_date date not null,
  delivery_status int not null
);

drop table logistics.deliveries;

drop schema logistics;

drop schema if exists logistics;

CREATE SCHEMA sales;
go


CREATE TABLE sales.stores
(
store_id INT IDENTITY (1, 1) PRIMARY KEY,
store_name VARCHAR(255) NOT NULL,
phone VARCHAR(25),
email VARCHAR(255),
streetn VARCHAR(255),
city VARCHAR(255),
state VARCHAR(10),
zip_code VARCHAR(5)
);


USE [BikeStores]
GO

INSERT INTO [sales].[stores]
           ([store_name]
           ,[phone]
           ,[email]
           ,[streetn]
           ,[city]
           ,[state]
           ,[zip_code])
     VALUES
           ('boutir.store',9538292762,'boutir@gmail.com','jayanagar','Bangalore','Karnataka',536291),
		   ('mantan.store',953864321,'mantan@gmail.com','indiranagar','Mangalore','Karnataka',573831),
		   ('lukas.store',9539267282,'lukas@gmail.com','kushalnagar','Tumkur','Karnataka',563691),
		   ('khalid.store',953622882,'khalid@gmail.com','keertinagar','Kushtagi','Karnataka',423191),
		   ('hosanna.store',953803643,'hosanna@gmail.com','kamalanagar','Ilkal','Karnataka',536721),
		   ('nundle.store',9535728268,'nundle@gmail.com','vijayanagar','Gangavathi','Karnataka',581321),
		   ('twirl.store',959243562,'twirl@gmail.com','gandhinagar','Hasan','Karnataka',5392642),
		   ('virtue.store',958243673,'virtue@gmail.com','lokanagar','Belgavi','Karnataka',537252),
		   ('moxie.store',9503534228,'moxie@gmail.com','kasturinagar','Koppal','Karnataka',592624),
		   ('zing.store',9594632622,'zing@gmail.com','mayanagar','Gulbarga','Karnataka',527272);


GO


/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [store_id]
      ,[store_name]
      ,[phone]
      ,[email]
      ,[streetn]
      ,[city]
      ,[state]
      ,[zip_code]
  FROM [BikeStores].[sales].[stores]