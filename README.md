# StockF cil - Sistema de Control de Inventario

## ?? Prop¢sito del Sistema
Apoyar el control eficiente de los productos disponibles en el almac‚n de la empresa comercial TecnoMarket, solucionando la duplicaci¢n de informaci¢n y la falta de trazabilidad.

## ?? M¢dulos Principales
- **Registro de productos**: Registro indicando c¢digo, nombre, precio y stock (RF-01).
- **Validaci¢n de productos**: Verificaci¢n de nombre no vac¡o y precio mayor a cero (RF-02).
- **Actualizaci¢n de stock**: Modificaci¢n de cantidades disponibles en almac‚n (RF-03).
- **Consulta de disponibilidad**: Determinaci¢n de existencias en tiempo real (RF-04).

## ??? Estructura del Proyecto (Arquitectura de Capas)
- **Controllers/**: Coordina las solicitudes relacionadas con productos (ProductoController.cs).
- **Models/**: Representa las entidades del sistema (Producto.cs).
- **Services/**: Contiene las reglas, validaciones y l¢gica del negocio (ProductoService.cs).
- **Data/**: Gestor de acceso y persistencia de datos (ProductoRepository.cs).
- **Views/**: Interfaz de interacci¢n y comunicaci¢n con el usuario (ProductoView.cs).

## ??? Control de Versiones
El proyecto utiliza **Git** para el registro del historial de cambios y la trazabilidad del c¢digo.
