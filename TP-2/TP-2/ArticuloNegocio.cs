﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    public class ArticuloNegocio
    {
        private AccesoDatos Datos;

        public ArticuloNegocio()
        {
            Datos = new AccesoDatos();
        }

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> Lista = new List<Articulo>();
            try
            {
                Datos.SetearConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, c.Descripcion as 'Categoria', m.Descripcion as 'Marca', i.ImagenUrl FROM ARTICULOS a INNER JOIN CATEGORIAS c on a.IdCategoria = c.Id INNER JOIN Marcas m on a.IdMarca = m.Id INNER JOIN IMAGENES i on a.Id = i.IdArticulo");
                Datos.EjectucarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDArticulo = Datos.Lector.GetInt32(0);
                    aux.CodigoArticulo = (string)Datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)Datos.Lector["Nombre"];
                    aux.MarcaArticulo = new Marca();
                    aux.MarcaArticulo.NombreMarca= (string)Datos.Lector["Marca"];
                    aux.CategoriaArticulo = new Categoria();
                    aux.CategoriaArticulo.NombreCategoria = (string)Datos.Lector["Categoria"];
                    aux.Imagenes = new List<Imagen>();
                    aux.Imagenes.Add(new Imagen() { URLImagen = (string)Datos.Lector["ImagenUrl"] });

                    Lista.Add(aux);
                }   

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AgregarArticulo(Articulo Nuevo)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModificarArticulo(Articulo Modificado)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarArticulo(int ID)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
