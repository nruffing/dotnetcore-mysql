# dotnetcore-mysql
.NET Core data access library for MySQL

This repository provides a data access base class for interacting with a MySQL database and includes examples on how to use to implement your own asynchronous data access libraries.

The MySQL.Data .NET Core package is used to interact with the MySQL database.
https://dev.mysql.com/downloads/connector/net/
https://www.nuget.org/packages/MySql.Data/

DataAccessBase can be used to implement a data access class for any MySQL schema structure that uses stored procedure for all its operations.

UserDataAccess shows an example of how to implement an asynchronous data access class using DataAccessBase.