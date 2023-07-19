CREATE OR ALTER PROCEDURE DepartamentosEmpresa
AS
BEGIN

	DECLARE 
		@NumeroError INT = 51000,
		@ErrorMensaje VARCHAR(255)

	BEGIN TRY

		BEGIN TRAN

			SELECT 
				d.IDDepartamento,
				d.Nombres,
				d.NumeroEmpleados,
				d.NivelOrganizacion,
				e.IDEmpresa,
				e.Nombre
			FROM Empresa e
			INNER JOIN Departamento d
			ON d.IDEmpresa = e.IDEmpresa
				
		COMMIT

	END TRY

	BEGIN CATCH
		SET @NumeroError = 51000
		SET @ErrorMensaje = 'Ocurrió un error al consultar la información'
		;THROW 51000, @ErrorMensaje, 1; 
	END CATCH

END