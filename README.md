# Resume API

This is an ASP.NET Core Web API-application that uses a Minimal API-approach to handle information about a persons education and work experiences. The application also includes integration with the GitHub API to get information about a specific users (public)repositories.

## ER-diagram

![Database ER diagram (crow's foot)](https://github.com/user-attachments/assets/18d54ca8-7787-45bc-bf8b-b7ffe59fdb6d)


## Functions

- **CRUD-operations** for persons, educations, and work experiences
- **GitHub API-integration** to get users repositories
- **Validation** of all data
- **Async database-operations** with Entity Framework Core
- **Async HTTP-calls** with HttpClient
- **Correct HTTP-statuscodes** for different outcomes

## Techstack

- ASP.NET Core 8.0 med Minimal API
- Entity Framework Core (Code-First approach)
- SQL Server
- GitHub API-integration

## Endpoints

### Person

- `GET /api/persons` - Get all persons
- `GET /api/persons/{id}` - Get a specific person by ID
- `POST /api/persons` - Create a new person
- `PUT /api/persons/{id}` - Update an existing person
- `DELETE /api/persons/{id}` - Delete a person

### Education

- `GET /api/educations` - Get all educations
- `GET /api/educations/{id}` - Get a specific education by ID
- `POST /api/educations` - Create a new education
- `PUT /api/educations/{id}` - Update an existing education
- `DELETE /api/educations/{id}` - Delete an education

### Work Experiences

- `GET /api/workexperiences` - Get all WorkExperiences
- `GET /api/workexperiences/{id}` - Get a specific WorkExperience by ID
- `POST /api/workexperiences` - Create a new WorkExperience
- `PUT /api/workexperiences/{id}` - Update an existing WorkExperience
- `DELETE /api/workexperiences/{id}` - Delete a WorkExperience

### GitHub API-integration

- `POST /api/github/repositories` - Get a list of public repositories from a specific user

## Examples:

### Create a person

```http
POST /api/persons
Content-Type: application/json

{
  "name": "Anna Andersson",
  "description": "Fullstack-developer with focus on .NET",
  "email": "anna.andersson@example.com",
  "phoneNumber": "070-1234567"
}
```

### Add a education

```http
POST /api/educations
Content-Type: application/json

{
  "school": "KTH",
  "degree": "Master of Science in Engineering",
  "startDate": "2015-08-15",
  "endDate": "2020-06-15",
  "personId": 1
}
```

### Get user-specific github repositories

```http
POST /api/github/repositories
Content-Type: application/json

{
  "username": "maoitz"
}
```
