create database CommomSimulation1
use CommomSimulation1
create table Pizza
(OrderId int primary key identity,
PhoneNo varchar(10),
Toppings varchar(max),
SpecialInfo varchar(max),
OrderDate date,
Size varchar(10),
Deliver varchar(5))

create table Customer
(CustomerId int primary key identity,
FirstName varchar(30),
LastName varchar(30),
Address varchar(max))