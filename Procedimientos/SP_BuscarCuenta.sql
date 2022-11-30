create proc SP_BuscarCuenta
@nombre as varchar(30),
@contrase�a as varchar(30),
@mail as varchar(30),
@tipo as varchar(20)
as
begin try
if ((select count(nombre) from cuentas where nombre = @nombre and contrase�a = @contrase�a and mail = @mail and tipo = @tipo) = 1)
print('Cuenta encontrada')
else 
raiserror ('Cuenta no encontrada', 16,1)
end try
begin catch
raiserror ('Cuenta no encontrada', 16,1)
end catch
