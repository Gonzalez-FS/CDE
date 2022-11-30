create proc SP_BorrarCuenta
@id_cuenta as int
as
begin try
declare @id_causa as int = 1
begin transaction
if ((select tipo from cuentas where id_cuenta = @id_cuenta) = 'usuario')
begin
while @id_causa <= (select count(*) from respuestas) begin
update respuestas set frecuencia = frecuencia - (select count(*) from sumas where id_cuenta = @id_cuenta and Id_causa = @id_causa )where id_causa=@id_causa
set @id_causa = @id_causa + 1
end
delete from cuentas where Id_cuenta = @id_cuenta
end
else
raiserror('No se puede eliminar esta cuenta',16,1);
commit transaction
end try
begin catch
rollback transaction
raiserror('No se ha podido borrar',16,1);
end catch
