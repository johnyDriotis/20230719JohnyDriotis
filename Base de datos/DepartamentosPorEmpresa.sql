CREATE OR ALTER PROCEDURE DepartamentosPorEmpresa
	@IdConsultar VARCHAR(10)
AS
BEGIN

	DECLARE 
		@NumeroError INT = 51000,
		@ErrorMensaje VARCHAR(255)

	BEGIN TRY

		BEGIN TRAN

			IF ISNULL(@IdConsultar,'') = ''
			BEGIN
				SET @NumeroError = 51001
				SET @ErrorMensaje = 'Debe escribir un valor válido'
				;THROW 51000, @ErrorMensaje, 1; 
			END

			SELECT 
				d.IDDepartamento,
				d.Nombres,
				d.NumeroEmpleados,
				d.NivelOrganizacion,
				e.IDEmpresa,
				e.Nombre
			FROM Departamento d, Empresa e
			WHERE 
				d.IDEmpresa = e.IDEmpresa
				AND e.IDEmpresa = @IdConsultar
				

		COMMIT

	END TRY

	BEGIN CATCH
		SET @NumeroError = 51000
		SET @ErrorMensaje = 'Ocurrió un error al consultar la información'
		;THROW 51000, @ErrorMensaje, 1; 
	END CATCH

END