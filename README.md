# DonatonApp

Crear la base de datos 
Crear La migración
dotnet ef migraions initial --context AppDbContext -p ../Infraestructure/ -s /Api -o Data/Migrations -v

Crear la base de datos apartir de la migracion
dotnet ef database update -c AppDbContext -p ../Infraestructure -s /Api -v 