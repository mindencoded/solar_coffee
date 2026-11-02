## EF v.10 Migrations

#### Add migration

```shell
dotnet ef migrations add InitialMigration -p ./SolarCoffee.Data/SolarCoffee.Data.csproj -s ./SolarCoffee.Web/SolarCoffee.Web.csproj
```

#### Update database

```shell
dotnet ef database update InitialMigration -p ./SolarCoffee.Data/SolarCoffee.Data.csproj -s ./SolarCoffee.Web/SolarCoffee.Web.csproj
```

#### Rollback migration

```shell
dotnet ef database update <NameOfPreviousMigration>
```

#### Remove migrations

```shell
dotnet ef migrations remove
```


