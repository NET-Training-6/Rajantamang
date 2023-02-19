
HRM
	Entities:

- Employee (Id, Name, Address, Gender, JoinDate, Department, Designation, Dob, Contact etc.)
- Departments (Id, Name, Desc)
- Designation (Id, Name, Desc, EstablishDate)
- Benifits (Salary, Bonus, PF, SSF, CIT, Insurance, Year, Tax)


Data Access / Database Programming

ADO (Active Data Object)
ADO.NET ()
ORM Tool(Object relational Mapper): *EF Core(Entity Framework core), Dapper, Nhibernate, RepoDb etc.
Database: 
	1. Relational: *Microsoft SQL Server, SQLite, Postgres, MYSql, Oracle etc.
	2. No Sql Database: MongoDb, AWS DynamoDB etc.


EF too:
Terminal: dotnet instal dotnet-ef -g
to check: dotnet-ef
dotnet ef migrations add initialCreate ( if show error, we need install other tool --> ef core design )
after install ef cor design tool try again run dotnet ef migrations add initialCreate on terminal

it is one time operation for EF tool and it create one folder names= Migrations


dotnet ef database update

