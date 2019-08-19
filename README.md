# CasoPropuesto1-Realizado Con la base de datos Neptuno
use neptuno;
DROP PROCEDURE IF EXISTS Usp_ListaClientes_Neptuno
Create Procedure Usp_ListaProductos_Neptuno
as
Select IdProducto,NombreProducto,IdProveedor,
PrecioUnidad,Suspendido
from Productos

Create Procedure Usp_ListaClientes_Neptuno
as
Select *
from Clientes

Create Procedure Usp_ListaClientes_Neptuno_2
@idCliente varchar(100)
as
Select idCliente,NombreContacto,Direccion,
Pais,Telefono
from Clientes where idcliente like '%'+@idCliente+'%'

Usp_ListaClientes_Neptuno_2 'B'

Create Procedure Usp_ListaClientes_Neptuno_3
@NombreContacto varchar(100)
as
Select *
from Clientes where NombreContacto like '%'+@NombreContacto+'%'

Usp_ListaClientes_Neptuno_3'Maria'
