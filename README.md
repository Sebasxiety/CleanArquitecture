# CleanArquitecture Sample

This repository contains a minimal example demonstrating Clean Architecture concepts for an ASP.NET MVC application.


## Projects

- `Domain` – Core entities (`Device`, `ServiceEntry`) and enums.
- `Application` – Use cases and repository interfaces.
- `Infrastructure` – In-memory repository implementation.
- `Controllers` and `Views` – Web layer for listing and creating service entries.

## Running

The project targets `.NET 8`. Restore and run with `dotnet run` in the `CleanArquitecture` folder.

