# CASO LABORATORIO 1 

|LOGRO DE LA EVALUACIÓN: |
| ------------------------| 
|Tenga presente que el logro de esta evaluación es que usted aplique los conceptos aprendidos en el curso para construir una aplicación web en **ASP.NET MVC** y **C#** donde permita realizar operaciones de consultas y filtros desde un origen de datos en **SQL Server** | 

---
## PREGUNTA 1
Implementa una consulta donde permita filtra los registros de la tabla Producto según su descripción.
![Data Base](/public/database.png)

**En la aplicación SQL Server:**
Cree en la base de datos **POOCL1** un procedimiento almacenado llamado `usp_productos_por_descripcion`, donde liste los registros de Producto de acuerdo a una descripción, el cual se ingresa como parámetro **@descripcion varchar(20)**. El procedimiento almacenado debe retornar la lista de productos con los campos **id**, **descripcion**, **tipo**, **precio**.

**En la aplicación ASP.NET MVC**:
* En la carpeta **Models**, crea la clase **Producto** definido por los campos de la tabla `Producto`.

* En la carpeta **Controllers**, crear el **controlador** `ProductoController`.

* En el controlador crea el **ActionResult** `ProductosPorDescripcion` donde permita ejecutar el procedimiento almacenado `usp_productos_por_descripcion`, y retorne una vistacon los resultados.

* En la vista de consulta, defina un control **TextBox** donde al ingresar una descripción y pulsar en un botón Consultar, visualice la vista con la lista de resultados.

---
## PREGUNTA 2
Implementa una consulta donde permita listar los registros de la tabla Producto entre un rango de precios

**Para este proceso cree en la base de datos POOCL1 del SQL Server:**
* Un procedure llamado **usp_productos_por_precio**, donde liste los registros de Producto entre dos precios, defina los parámetros **@precioMin**, **@precioMax**. En el procedimiento almacenado, liste los campos **id**, **descripcion**, **tipo**, **precio**.

**En la aplicación ASP.NET MVC:**
* En la carpeta **Models**, utilice la clase `Producto`.

* En la carpeta **Controllers**, utilice el controlador `ProductoController`.

* En el controlador crea el **ActionResult** `ProductosPorPrecio` donde permita ejecutar el procedimiento almacenado `usp_productos_por_precio`, y retorne una vista con los resultados.

* En la vista de consulta, defina los **TextBox** para ingresar el precio mínimo y máximo. Ingrese los valores y al presionar el botón Consultar, visualice la vista con la lista de resultados.

---
## PREGUNTA 3
Implementa una consulta donde permita listar los registros de la tabla **Productos** según un tipo y precio menor a uno indicado.

**Para este proceso cree en la base de datos POOCL1 del SQL Server:**
* Un procedure llamado **usp_productos_por_tipo_y_precio**, donde liste los registros de Producto por un tipo y precio, defina los parámetros **@tipo**, **@precio**. En el procedimiento almacenado, liste los campos **id**, **descripcion**, **tipo**, **precio**.

**En una aplicación ASP.NET MVC:**
* En la carpeta **Models**, utilice la clase `Producto`.

* En la carpeta **Controllers**, utilice el controlador `ProductoController`.

* En el controlador crea el **ActionResult** `ProductosPorTipoYPrecio` donde permita ejecutar el procedimiento almacenado `usp_productos_por_tipo_y_precio` y retorne la vista con los resultados.

* En la vista de consulta, **defina un TextBox**, para ingresar el tipo de producto **y otro TextBox** para ingresar el precio, y al presionar el botón Consultar, visualice la vista con la lista de resultados. Al final de la lista visualice la cantidad de productos que se muestran.
