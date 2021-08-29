# NS804 WebApi 2 Test

# Techonologies

The techonologies I used to build this WebApi were: 
- Visual Studio 2019
- .Net 4.7.2 WebApi 2 Framework
- Microsoft SQL Server
- JWT for token and user authentication
- Swagger

# Project architecture
- Onion architecture
	- NS804Test.Api
	- NS804Test.Service
	- NS804Test.Domains
	- NS804Test.DataAccess
	
- Unit Test
	- NS804.Test (This is the Unit Test project)

# Project Notes
This WebApi project is Restful and provides the following endpoints:
- User registration
- Login by Email and Password
- CRUD services for user. This support the following fields:
	- FirstName
	- LastName
	- Phone
	- Email
	- Address of street
	- City
	- State
	- ZipCode

- The verbs that are used are:	
	- HttpGet
	- HttpPost
	- HttpPut
	
- Fields validations are made with FluentValidator

- Authentication validation to use the most of the endpoints are validated with JWT Token. The configuration of JWT is set in the WebConfig of the project. If you wish to generate a different KEY than the one that is set in the WebConfig, you can go to: https://www.guidgenerator.com/

# Test WebApi
A postman collection and database script is added in the project in a folder called:
**PostmanCollectionAndDbScript**

- **David Valdez - Software Developer**
- **https://www.linkedin.com/in/davidisraelvaldezr/**
- **Happy testing**
