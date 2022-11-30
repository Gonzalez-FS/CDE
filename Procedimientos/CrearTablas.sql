create table cuentas
(Id_cuenta INT not null IDENTITY PRIMARY KEY,
Nombre varchar(30) not null,
Contraseña varchar(30) not null,
Mail varchar(30) not null,
tipo varchar(20) not null
)
create table historial(
ID_Historial int not null identity primary key,
Id_cuenta INT CONSTRAINT FK_cuenta FOREIGN KEY (Id_cuenta) REFERENCES cuentas(Id_cuenta) on delete cascade not null,
fecha varchar(30) not null, tipo varchar(30) not null, promedio varchar(30) not null, nivel_educativo varchar(30) not null, 
trabajo varchar(30) not null, RelFam varchar(30) not null, RelComp varchar(30) not null, CondEco varchar(30) not null, 
EnfMen varchar(60), ComuDoc varchar(30) not null, 
CondInsti varchar(30) not null, ActivExt varchar(30) not null, EnfGrave varchar(30) not null
)
create table comentarios(
ID_comentario int not null identity primary key,
Id_cuenta INT CONSTRAINT FK_cuentaC FOREIGN KEY (Id_cuenta) REFERENCES cuentas(Id_cuenta) on delete cascade not null,
comentario varchar(50)
)

create table respuestas( ID_Causa int not null identity primary key,
Causa Varchar(50), Frecuencia int)
insert into respuestas values('Aumento de nivel educativo',0)
insert into respuestas values('Aumento de carga de trabajo',0)
insert into respuestas values('Problemas familiares',0)
insert into respuestas values('Problemas con compañeros',0)
insert into respuestas values('Deterioro económico',0)
insert into respuestas values('Deterioro de salud mental',0)
insert into respuestas values('Peor comunicación con docentes',0)
insert into respuestas values('Traslado a una peor institución',0)
insert into respuestas values('Inicio de actividades extracurriculares',0)
insert into respuestas values('Aparición de una enfermedad grave',0)

create table sumas(ID_suma int not null identity primary key,
Id_cuenta INT CONSTRAINT FK_cuenta2 FOREIGN KEY (Id_cuenta) REFERENCES cuentas(Id_cuenta) on delete cascade not null,
Id_causa INT CONSTRAINT FK_causa FOREIGN KEY (Id_causa) REFERENCES respuestas(Id_causa) not null
)
