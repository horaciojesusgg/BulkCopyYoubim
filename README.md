# BulkCopyYoubim
These are the instructions for the project setup.


# Database scripts

Run the following scripts to create the database:

	

    CREATE DATABASE BulkCopyTest
    CREATE TABLE Department
    (
     Id int primary key,
     Name nvarchar(50),
     Location nvarchar(50)
    )
    GO

## XML

Place the test xml file located in TestYoubimLibrary/TestData in your local server.

## Test the application

Run the console application for testing.
