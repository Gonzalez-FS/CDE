create proc SP_GuardarHistorial
@mail as varchar(30),
@fecha as varchar(30), @tipo as varchar(30), @promedio as varchar(30), @nivel_educativo as varchar(30), 
@trabajo as varchar(30), @RelFam as varchar(30), @RelComp as varchar(30), @CondEco as varchar(30), 
@EnfMen as varchar(30), @ComuDoc as varchar(30), @CondInsti as varchar(30), @ActivExt as varchar(30), @EnfGrave as varchar(30)
as
begin try
declare @id_cuenta int = (select id_cuenta from cuentas where mail = @mail);
begin transaction
insert into historial values(@id_cuenta, @fecha, @tipo, @promedio, @nivel_educativo, @trabajo, @RelFam, @RelComp, @CondEco, 
@EnfMen, @ComuDoc, @CondInsti, @ActivExt, @EnfGrave)
commit
end try
begin catch
rollback transaction
raiserror ('Error al guardar', 16,1)
end catch