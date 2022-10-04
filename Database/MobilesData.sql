CREATE DATABASE MOBILESHOP
use MOBILESHOP
go


                          --Tables--
create table Login(
username varchar(50) primary key,
password varchar(14)not null);


select * from Login

--Mobiles table for MobilesInformation

create table Mobiles(
MobileID bigint identity(1,1) primary key,
MobileName varchar(50) not null,
Model varchar(40) not null,
MobileCompany varchar(50) not null,
Ram varchar(10),
InternalStorage varchar(10),
BatteryCapacity varchar(10),
FrontCamera varchar(20),
RearCamera varchar(20),
Display varchar(20),
);
select*from Mobiles
insert into Mobiles values('Vivo Y20','Y20','Vivo','8GB','128GB','4400mAH','14MP','34MP','6.76 1320x1440 PX',26000)
insert into Mobiles values('Infinix Hot8','Hot8','Infinix','8GB','32GB','6000mAH','8MP','16MP','6.76 1200x1940 PX',20000)
insert into Mobiles values('Oppo F11 Pro','F11Pro','Oppo','8GB','128GB','5000mAH','23MP','48MP','5.76 1200x1940 PX',55000)
insert into Mobiles values('RealMe C3','RMX 2020','RealMe','3GB','32GB','5000mAH','8MP','13MP','6.76 1300x1900 PX',20000)

select * from Mobiles



--Inventry table for storing Stock
create table Inventry(
InvID int identity(1,1) primary key,
MobileID bigint foreign key
references Mobiles(MobileID),
Quantity int );

insert into Inventry values(1,11)
insert into Inventry values(2,8)
insert into Inventry values(3,5)
insert into Inventry values(4,9)
insert into Inventry values(5,9)
select * from Inventry
update Inventry set Quantity=44 where MobileID=5
select * from Sales



--priceinfotable  Table
create table PriceInfo(
Price# int identity(1,1) primary key,
MobileID bigint foreign key references mobiles(MobileID),
PurchasePrice int,
SalePrice int,
);

insert into PriceInfo values(1,25000,30000),
							(2,21000,25000),
							(3,48000,55000),
							(4,17000,20000),
							(5,23000,29000);
select * from PriceInfo


--Customer Table
create table Customer(
CustomerID int identity(100,1) primary key,
C_Name varchar(50) not null,
C_Address varchar(50),
C_Contact varchar(50)not null,
C_Email varchar(50));
select * from Customer





      --Sales Table
create table Sales(
SaleID int identity(1000,1) primary key,
MobileID bigint foreign key
references Mobiles(MobileID),
Quantity int,
CustomerID int foreign key
references Customer(CustomerID),
SoldDate date);

select * from Sales

--table for Backup
create table auditable(
ID int identity(1,1) ,
auditdata varchar(5000),

)
select * from auditable


          --SUm queries for fetching total mObiles and total Quantity--


         --Sum Query for Displaying Total Quantity of Mobile--
select sum(Inventry.Quantity) as totalMobiles from Inventry

               --Total Mobiles Sold--
select sum(Sales.Quantity) as TotalMobiles_SOld from Sales



               --Joints--

--Inner Join for checking Inventry for Each Mobile and Also Display Their Selling Price
SELECT MobileName,SalePrice as Price,Quantity from Mobiles 
inner join PriceInfo on Mobiles.MobileID=PriceInfo.MobileID
inner join Inventry on PriceInfo.MobileID=Inventry.MobileID


--Inner Join for returning Sold Mobiles
SELECT Mobiles.MobileName,Sales.Quantity as Sold
from Sales
inner join Mobiles on Mobiles.MobileID=Sales.MobileID


---Inner Join With Five Tables to getting all information with one sell
select MobileName,SoldDate,Customer.C_Name,(PriceInfo.PurchasePrice*Sales.Quantity)
 as PurchasedPrice,

(Sales.Quantity*PriceInfo.SalePrice)as SalesPrice,

(Sales.Quantity*PriceInfo.SalePrice-PriceInfo.PurchasePrice*Sales.Quantity)as Profit,

Sales.Quantity as Total_Mobiles_Bought

from Mobiles 
inner join Inventry on
Mobiles.MobileID =Inventry.MobileID
inner join Sales
on
Mobiles.MobileID=Sales.MobileID
inner join PriceInfo
on
Sales.MobileID=PriceInfo.MobileID
inner join Customer
on
Customer.CustomerID=Sales.CustomerID







               --Store Procedures--

---Store Procedure for Updating Inventry and inserting in SalesTable
create proc sp_SalesEntree
@MobId bigint,
@Quantity int,
@CustomerId int,
@SoldDate date 
as begin

set @SoldDate=GETDATE()
insert into Sales values(@MobId,@Quantity,@CustomerId,@SoldDate)
update Inventry 
set Inventry.Quantity=Inventry.Quantity-@Quantity
where @MobId=Inventry.MobileID
end

execute sp_SalesEntree 1,1,100,''
execute sp_SalesEntree 2,2,101,''
execute sp_SalesEntree 4,2,102,''





--Store Procedure for checking Mobiles Sold On Specific Day and Also Calculate Profit
create proc sp_OneDayProfit
 @Date date
as begin
select sum(Sales.Quantity) as TotalMobiles_Sold_on_OneDay from Sales where Sales.SoldDate=@Date 
select sum(Sales.Quantity*PriceInfo.SalePrice-PriceInfo.PurchasePrice*Sales.Quantity)as TotalProfitOn_One_Day 
from PriceInfo 
inner join Sales on
PriceInfo.MobileID =Sales.MobileID
and
 Sales.SoldDate=@Date
End

exec sp_OneDayProfit '2021-12-31'






--profit Store Procedure for Calculating Whole Profit 
create proc sp_Profit
as begin
select  sum(Sales.Quantity*PriceInfo.SalePrice-PriceInfo.PurchasePrice*Sales.Quantity)as TotalProfit
from PriceInfo 
inner join Sales on
PriceInfo.MobileID =Sales.MobileID
end

execute sp_Profit






---Store Procedure for Calculating the Profit between two Dates
alter proc sp_ProfitForTwoDats
 @Date date,
 @Date2 date
as begin
select sum(Sales.Quantity) as TotalMobiles_Sold from Sales where Sales.SoldDate between @Date  and @Date2
select sum(Sales.Quantity*PriceInfo.SalePrice-PriceInfo.PurchasePrice*Sales.Quantity)as TotalProfit
from PriceInfo 
inner join Sales on
PriceInfo.MobileID =Sales.MobileID
and
 Sales.SoldDate Between  @Date and @Date2
End
exec sp_ProfitForTwoDats '2021-9-9','2021-12-31'








--Triggers in SQL


create trigger tr_SaleInsert
on Sales
for insert
as begin
declare @id int
select @id=SaleID   from inserted
insert into auditable values('This Mobile is Sold with Saleid : '+cast(  @id as nvarchar(20))+
 'Sold On '+cast( GETDATE() as nvarchar(50)))
end


