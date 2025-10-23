# Sistema Inventario Simple en C#

Aplicación de consola para gestionar un inventario básico en C#. Permite agregar productos (nombre, cantidad, precio), listar el inventario y buscar productos por nombre. Proyecto pensado para prácticas y aprendizaje de colecciones y LINQ.

---

## Contenido del proyecto

1. **Agregar producto**: Entrada validada para nombre, cantidad y precio.  
2. **Listar productos**: Muestra tabla con nombre, cantidad y precio.  
3. **Buscar producto**: Búsqueda parcial por nombre usando LINQ.  
4. **Interfaz de consola**: Menú simple y navegación por teclado.

---

## Archivos incluidos

- `SistemaInventarioSimple.csproj`: Archivo de proyecto (.NET).  
- `Program.cs`: Código fuente principal del sistema de inventario.  
- `README.md`: Archivo con explicaciones e instrucciones.

---

## Compilación y ejecución

Recomendado tener instalado el SDK de .NET. Para compilar y ejecutar:

1. Desde la carpeta del proyecto compila:

   ```bash
   dotnet build
   ```

2. Ejecuta la aplicación:

   ```bash
   dotnet run --project SistemaInventarioSimple.csproj
   ```
O si prefieres crear el ejecutable:

   ```bash
   dotnet publish -c Release -r win-x64 --self-contained false -o ./publish
   ```

y luego ejecuta el binario en ./publish.

---

## Ejemplo de uso

Al ejecutar la aplicación verás un menú con las opciones:

1. Agregar producto: Ingresa nombre, cantidad y precio.
2. Listar productos: Muestra la tabla de inventario.
3. Buscar producto: Busca por texto dentro del nombre.
4. Salir: Termina la aplicación.

Los precios se muestran con formato numérico y el símbolo de moneda.

---

## Autor

Alan Aquino.

---

## Licencia

Proyecto con licencia MIT. Consulta el archivo LICENSE para más detalles.
