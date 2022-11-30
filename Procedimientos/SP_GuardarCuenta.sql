create proc SP_GuardarCuenta
@nombre as varchar(20),
@mail as varchar(20),
@contraseña as varchar(20),
@tipo as varchar(20)
as
begin try
begin transaction
if ((select count(mail) from cuentas where mail = @mail) = 0) 
insert into cuentas values (@nombre,@contraseña,@mail,@tipo)
else
raiserror('No se ha podido registrar',16,1);
commit transaction
end try
begin catch
rollback transaction
raiserror('No se ha podido registrar',16,1);
end catch