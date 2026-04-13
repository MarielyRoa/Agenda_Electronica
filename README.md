# 📒 Agenda Electrónica

Aplicación de escritorio desarrollada en **C# con Windows Forms (.NET Framework 4.8)** para la gestión de contactos personales, implementada con arquitectura de **4 capas** + Repository Pattern.

---

## 🧩 Descripción

La aplicación permite administrar contactos con operaciones CRUD completas:

- Crear contactos
- Listar contactos activos en un `DataGridView`
- Buscar contactos (por **ID**)
- Editar contactos desde un formulario secundario
- Eliminar contactos con confirmación (eliminación lógica)

---

## 🖼️ Interfaz

La solución cuenta con:

- **Formulario principal (`Form1`)**
  - Listado de contactos en `DataGridView`
  - Botones: Insertar, Actualizar, Buscar, Eliminar, Salir
- **Formulario de detalle (`DatosContacto`)**
  - Alta y edición de contactos
  - Validaciones de campos obligatorios
  - ComboBox para Género y Estado Civil (Enums)

---

## 🏗️ Arquitectura (4 capas)

```text
AE.Domain            → Entidades, Enums e interfaces (IContactRepository)
AE.DataAccessLayer   → Acceso a datos SQL Server (ContactRepository, ConnectionBD)
AE.Application       → Lógica de negocio (LogicService)
AE.PresentationUI    → Interfaz WinForms (Form1, DatosContacto)
```

---

## ✅ Funcionalidades implementadas

- ➕ **Insertar contacto**
- 📋 **Listar contactos activos**
- 🔍 **Buscar contacto por ID**
- ✏️ **Actualizar contacto** (cargando datos en formulario secundario)
- 🗑️ **Eliminar contacto con confirmación**
  - Eliminación **lógica**: se marca `IsActive = 0`
- 🚪 **Salir de la aplicación** con confirmación

---

## 🗃️ Base de datos

**Motor:** SQL Server  
**Base de datos:** `AgendaElectronicaDB`  
**Tabla:** `Contacts`

### Estructura principal

- `Id` `INT IDENTITY(1,1)` (autoincremental)
- `Name`, `LastName`
- `Birthday`, `Address`
- `Mobile`, `PhoneNumber`
- `Gender` (INT)
- `CivilStatus` (INT)
- `Email`
- `IsActive` (BIT) → para eliminación lógica
- `CreatedAt`, `UpdatedAt`

---

## 🧠 Stored Procedures

- `sp_Contact_Insert`
- `sp_Contact_Update`
- `sp_Contact_Delete` (lógica con `IsActive = 0`)
- `sp_Contact_GetAll` (solo activos)
- `sp_Contact_Search`
- `sp_Contact_GetById`

---

## ⚙️ Requisitos

- Windows 10/11
- Visual Studio 2019 o superior
- .NET Framework 4.8
- SQL Server / SQL Server Express
- SQL Server Management Studio (opcional)

---

## 🚀 Ejecución

1. Clonar/abrir la solución en Visual Studio.
2. Crear la base de datos `AgendaElectronicaDB`.
3. Ejecutar script de tabla + stored procedures.
4. Configurar la cadena de conexión en `App.config`.
5. Compilar y ejecutar `AE.PresentationUI`.

---

## 👩‍💻 Autor

**Mariely Roa**
