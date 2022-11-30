create proc SP_ContarRespuestas
as
begin
if ((select sum(frecuencia) from respuestas) = 0)
raiserror('Aun no hay respuestas!', 16,1)
else
print('ok')
end
