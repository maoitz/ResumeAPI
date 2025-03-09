# Resume API

Detta är en ASP.NET Core Web API-applikation som använder Minimal API-approach för att hantera information om personers utbildning och arbetslivserfarenhet. Applikationen inkluderar även integration med GitHub API för att hämta information om användares repositories.

## ER-diagram

![Database ER diagram (crow's foot)](https://github.com/user-attachments/assets/18d54ca8-7787-45bc-bf8b-b7ffe59fdb6d)


## Funktioner

- **CRUD-operationer** för personer, utbildningar och arbetslivserfarenheter
- **GitHub API-integration** för att hämta användarens publika repositories
- **Validering** av all indata
- **Asynkrona databasoperationer** med Entity Framework Core
- **Asynkrona HTTP-anrop** med HttpClient
- **Korrekta HTTP-statuskoder** för olika scenarion

## Tekniker

- ASP.NET Core 7.0 med Minimal API
- Entity Framework Core (Code-First approach)
- SQL Server
- GitHub API-integration

## Endpoints

### Person

- `GET /api/persons` - Hämta alla personer
- `GET /api/persons/{id}` - Hämta en specifik person
- `POST /api/persons` - Skapa en ny person
- `PUT /api/persons/{id}` - Uppdatera en befintlig person
- `DELETE /api/persons/{id}` - Ta bort en person

### Utbildning

- `GET /api/educations` - Hämta alla utbildningar
- `GET /api/educations/{id}` - Hämta en specifik utbildning
- `POST /api/educations` - Skapa en ny utbildning
- `PUT /api/educations/{id}` - Uppdatera en befintlig utbildning
- `DELETE /api/educations/{id}` - Ta bort en utbildning

### Arbetslivserfarenhet

- `GET /api/workexperiences` - Hämta alla arbetslivserfarenheter
- `GET /api/workexperiences/{id}` - Hämta en specifik arbetslivserfarenhet
- `POST /api/workexperiences` - Skapa en ny arbetslivserfarenhet
- `PUT /api/workexperiences/{id}` - Uppdatera en befintlig arbetslivserfarenhet
- `DELETE /api/workexperiences/{id}` - Ta bort en arbetslivserfarenhet

### GitHub API-integration

- `POST /api/github/repositories` - Hämta en lista över publika repositories för ett GitHub-användarnamn

## Kom igång

1. Klona detta repository
2. Uppdatera ConnectionStrings i appsettings.json (om nödvändigt)
3. Kör följande kommandon i terminalen:
   ```
   dotnet ef database update
   dotnet run
   ```
4. Öppna API:et på https://localhost:5001/swagger

## Exempel på anrop

### Skapa en person

```http
POST /api/persons
Content-Type: application/json

{
  "name": "Anna Andersson",
  "description": "Fullstack-utvecklare med fokus på .NET",
  "email": "anna.andersson@example.com",
  "phoneNumber": "070-1234567"
}
```

### Lägga till en utbildning

```http
POST /api/educations
Content-Type: application/json

{
  "school": "KTH",
  "degree": "Civilingenjör i datateknik",
  "startDate": "2015-08-15",
  "endDate": "2020-06-15",
  "personId": 1
}
```

### Hämta GitHub-repositories

```http
POST /api/github/repositories
Content-Type: application/json

{
  "username": "octocat"
}
```
