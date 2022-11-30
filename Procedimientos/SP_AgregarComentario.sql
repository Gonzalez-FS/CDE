create proc SP_AgregarComentario
@mail as varchar(30),
@comentario as varchar(50)
as begin try
declare @id_cuenta int = (select id_cuenta from cuentas where mail = @mail);
begin transaction
insert into comentarios values (@id_cuenta, @comentario)
commit
end try
begin catch
rollback tran
raiserror('error',16,1)
end catch