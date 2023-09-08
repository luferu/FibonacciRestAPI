1) Dividí la solución en 3 proyectos:
	-API: en donde puse el controller y por medio de inyección de dependencias inyecto el servicio
		
	-Service:eh creado el servicio donde esta el metodo que realiza el calculo

	-Test:hice un test unitario para probar el método

2) Mejoras a aplicar:
 -Crear archivo de recursos para que sea multilenguaje
 -Manejo de errores TRY - CATCH
 -Se podría poner seguridad de usuario con TOKEN usando JWT por ejemplo
 -Se podria hacer control de permisos y roles
 -Se podría crear una tabla en una BD en donde se guarden los valores la fecha y el user que llamo al endpoint y donde se refleje el parametro
de entrada y el valor de salida
 -Se podria poner un log de errores para saber cuando este en produccion la API que errores arrojo, fecha/hora y user