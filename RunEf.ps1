param(
    [string]$MigrationName = "InitialCreate",
    [ValidateSet("add","update","remove")]
    [string]$Action = "add"
)

# Ruta base de la solución
$solutionPath = 'D:\C#\JOANAPI'

# Proyectos
$apiProject = "$solutionPath\JOANAPI.Api\JOANAPI.Api.csproj"
$infraProject = "$solutionPath\JOANAPI.Infrastructure\JOANAPI.Infrastructure.csproj"

Write-Host '📌 Acción: $Action'
Write-Host '➡️ Migración: $MigrationName'
Write-Host '➡️ Api Project: $apiProject'
Write-Host '➡️ Infrastructure Project: $infraProject'
Write-Host '➡️ Carpeta de migraciones: JOANAPI.Infrastructure\\Persistence\\Migrations'

switch ($Action) {
    'add' {
        dotnet ef migrations add $MigrationName -p $infraProject -s $apiProject -o Persistence\Migrations
    }
    'update' {
        dotnet ef database update -p $infraProject -s $apiProject
    }
    'remove' {
        dotnet ef migrations remove -p $infraProject -s $apiProject
    }
}
# .\RunEf.ps1 -MigrationName AddUsersTable -Action add
#.\RunEf.ps1 -Action update
#.\RunEf.ps1 -Action remove 
