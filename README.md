# Ejemplo de CleanArquitecture

**Clean Architecture** aplicada a una **aplicación ASP.NET MVC**.

---

## Proyectos

- **`Domain`**  
  Núcleo de la aplicación: entidades principales (`Device`, `ServiceEntry`) y enumeraciones.

- **`Application`**  
  Lógica de negocio: casos de uso e interfaces de repositorio.

- **`Infrastructure`**  
  Detalles de implementación: repositorio en memoria para pruebas y prototipos.

- **`Controllers`** & **`Views`**  
  Capa de presentación: listados y formularios para gestionar registros de servicio.

---

## Ejecución

El proyecto está dirigido a **`.NET 8`**.  
Para compilar y ejecutar:

```bash
cd CleanArquitecture
dotnet restore
dotnet run
