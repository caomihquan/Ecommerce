# Ecommerce
dotnet new tool-manifest

# restore dotnet tool, run once only
dotnet tool restore

# check database
dotnet ef dbcontext info -s Ecommerce

# apply migrations
dotnet ef database update -s Ecommerce

# add new migration
dotnet ef migrations add Init -s Ecommerce -p Ecore

# generate a migration script
dotnet ef migrations script -s Ecommerce -p Ecore -o Ecore/Migrations/sql/1-init.sql
