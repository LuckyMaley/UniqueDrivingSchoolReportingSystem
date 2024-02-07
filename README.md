# Unique Driving School Report Management System 

This is a Crystal Report Management app for Business Intelligence based on the Unique Driving School Management System. It is built on the vb.net programming language.

# Guidelines

![Static Badge](https://img.shields.io/badge/Visual%20Studio-2010%20or%20later-green) ![Static Badge](https://img.shields.io/badge/.Net%20Framework-4-blue)

# Project Structure

- This project is separated into 3 sub-systems:
  - Unique Driving School Management System ([click here to visit](/../../../UniqueDrivingSchoolManagementSystem))
  - Unique Driving School Reporting System ([Current project](/))
  - Unique Driving School Website ([click here to visit](/../../../UniqueDrivingSchoolWebsite))
- A User Story System was built for the aforementioned subsystems to keep track of the progress of the user stories and test cases during development  ([click here to visit](/../../../UserStoryApp)).

# Config

- Clone the project
- To open the project solution just double click on [WindowsApplication1CrystalReports.sln](/WindowsApplication1CrystalReports.sln) 

- (re)build application
> (re)building the application will install the required ASP.NET packages from NuGet
![Screenshot (4085)](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/302508b0-9f80-43d2-9d7e-454cc445c11f)

- Crystal Reports setup
  > **NOTE:** You need to have crystal reports plugin installed in order to be able to use this project

  - You can go to the link below or go to the SAP crystal reports site.
  - https://www.tektutorialshub.com/crystal-reports/crystal-reports-download-for-visual-studio/
  - https://www.tektutorialshub.com/crystal-reports/install-crystal-reports-visual-studio/
  - https://www.youtube.com/watch?v=A1mTqRRHqw8

- Database Setup
> **NOTE:** If you want to change the connection string to a live or production-ready database just go to the [App.config](/App.config) file and change the existing one to your database. Example of connection string below:

 ```<add name="UniqueDrivingSchoolManagementSystem.My.MySettings.ist3bbConnectionString" connectionString="Data Source= DatabaseServerName; Integrated Security=true;Initial Catalog=UniqueDrivingSchoolDB; uid=YourUserName; Password=yourpassword; " providerName="System.Data.SqlClient" />``` 
 
 > **NOTE:** You need to also right-click the project name on the solution explorer > click properties > then go to settings, and when a pop-up message appears, click "yes" to confirm the changed connection string.

- A SQL query with the relevant database tables has already been created, you need to initialize it (**NOTE:** If you have already executed these SQL queries for the Unique Driving School Management System then you don't need to run them again as this system uses the same database). There are two SQL queries
  - The first one creates a database. [Click here](/UniqueDrivingSchoolManagementSystem/SQLQueryCreateUniqueDrivingSchoolDB.sql) to go to the file called SQLQueryCreateUniqueDrivingSchoolDB.sql.
  - The second uses the database you created in the previous point to initialize the database tables. [Click here](/UniqueDrivingSchoolManagementSystem/SQLQueryUniqueDrivingSchoolDB.sql) to go to the file called SQLQueryUniqueDrivingSchoolDB.sql.

> **NOTE:** You need to ensure that the initial catalog in your connection string is the same as the database where these db tables are created or located.

- You can now run and test the system.

# Noticable improvements for future work

- The system can be updated to use an API for database interactivity so users created on this system can also be accessible on the website.
- The PowerBI reports can be implemented better using an API that does not rely on a plugin.

# Screenshots

![1-Introduction](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/14bc72eb-233e-42b7-9ba8-4059cbd80812)

![2-Login](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/3244d030-d66a-44ad-86d7-2e369dcba039)

![3-Crystal Report](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/57e72fca-36b2-47c4-b626-9e6799e96f52)

![4-PowerBI](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/29648d74-899b-41ed-96df-210699646ab9)

![5-Customer Payments Report](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/eea072c7-0d62-41ce-ae5c-453368a0447e)

![6-Code 08-10 Payment Report](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/f8b56b36-b4b1-4c94-bd8a-7a472e996a98)

![7-Monthly Report](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/9a3e62a7-ff6d-45c1-b4ee-b88a031897ef)

![8-Booking Drill Down Report](https://github.com/LuckyMaley/UniqueDrivingSchoolReportingSystem/assets/58641501/e3212310-157f-4380-a3be-5608f5cb694e)

**([Click here](/../../../UniqueDrivingSchoolWebsite)) to visit a related project**
