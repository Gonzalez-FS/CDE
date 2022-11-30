Create proc SP_SumarRespuestas
@id_causa as int
as
begin try
begin transaction
update respuestas set frecuencia = frecuencia + 1 where id_causa = @id_causa
commit transaction
end try
begin catch
rollback transaction
raiserror ('error', 16,1)
end catch
