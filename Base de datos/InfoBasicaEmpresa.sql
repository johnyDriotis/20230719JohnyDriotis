CREATE OR ALTER PROCEDURE InfoBasicaEmpresa
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
				SET @ErrorMensaje = 'Debe escribir un valor v�lido'
				;THROW 51000, @ErrorMensaje, 1; 
			END

			SELECT 
				IDEmpresa,
				Nombre,
				RazonSocial,
				FechaRegistro
			FROM Empresa
			WHERE 
				IDEmpresa = @IdConsultar

		COMMIT

	END TRY

	BEGIN CATCH
		SET @NumeroError = 51000
		SET @ErrorMensaje = 'Ocurri� un error al consultar la informaci�n'
		;THROW 51000, @ErrorMensaje, 1; 
	END CATCH

END