USE bd_peliculas;
GO

/*Desarrollar lo requerido en Index.aspx*/

/*
1.- Mostrar en una tabla todas las actrices (sólo mujeres) 
de todas las películas Blue-ray ordenados por nombre de las 
actrices de manera ascendente.

Debe mostrar :
	- id película.
	- nombre película.
	- id actor.
	- nombre actor.
	- nombre del país del actor.
*/
select pelicula.id, pelicula.nombre, actor.id, actor.nombre, pais.nombre
from pais, sexo, actor, director, pelicula, formato, pelicula_formato, pelicula_actor
where director.fk_sexo = sexo.id
and sexo.id = actor.fk_sexo
and pais.id = actor.fk_pais
and director.fk_sexo = sexo.id
and pelicula.fk_pais = pais.id
and pelicula.fk_director = director.id
and pelicula_formato.fk_pelicula = pelicula.id
and pelicula_formato.fk_formato = formato.id
and pelicula_actor.fk_pelicula = pelicula.id
and pelicula_actor.fk_actor = actor.id
and sexo.id=2 and formato.nombre like '%Blue-ray%' order by actor.nombre asc;




