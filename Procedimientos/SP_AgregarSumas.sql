create proc SP_AgregarSumas
@mail as varchar(30),
@id_causa as int
as
begin try
declare @id_cuenta int = (select id_cuenta from cuentas where mail = @mail);
begin transaction
insert into sumas values(@id_cuenta,@id_causa)
commit transaction
end try
begin catch
rollback transaction
raiserror('Error al agregar',16,1)
end catch