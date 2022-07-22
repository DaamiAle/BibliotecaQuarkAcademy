﻿using DataObjects.src;
using Repositories.src;
using Util.src.CustomExceptions.LibroExceptions;
using Models.src.DatabaseContext;
using Models.src.Entities;

namespace Services.src
{
    public class LibroService
    {
        private LibroRepository libroReposytory;

        public LibroService(ProjectContext context)
        {
            libroReposytory = new LibroRepository(context);
        }
        /*
        internal LibroModel GetModelByISBN(string codigoISBN)
        {
            LibroModel libroModel = libroReposytory.GetByISBN(codigoISBN);
            if (libroModel.GetType() != typeof(LibroModel))
            {
                throw new LibroNotFoundException();
            }
            else
            {
                return libroModel;
            }
        }

        public LibroDTO GetByISBN(string codigoISBN)
        {
            LibroModel libroModel = GetModelByISBN(codigoISBN);
            LibroDTO libroDTO = new();
            libroDTO.CodigoISBN(libroModel.CodigoISBN);
            libroDTO.Nombre(libroModel.Nombre);
            libroDTO.Autor(libroModel.Autor);
            return libroDTO;
        }*/

        public void AgregarLibro(string codigoISBN, string nombre, string autor)
        {
            if (!ExiteLibro(codigoISBN))
            {
                if (codigoISBN == null || codigoISBN.Length == 0)
                {
                    throw new LibroInvalidCreationException("codigoISBN");
                }
                if (nombre == null || nombre.Length == 0)
                {
                    throw new LibroInvalidCreationException("nombre");
                }
                if (autor == null || autor.Length == 0)
                {
                    throw new LibroInvalidCreationException("autor");
                }
                LibroModel libro = new()
                {
                    Nombre = nombre,
                    Autor = autor,
                    CodigoISBN = codigoISBN
                };
                libroReposytory.AddLibro(libro);
            }
            
        }
        public bool ExiteLibro(string codigoISBN)
        {
            return libroReposytory.ExisteLibro(codigoISBN);
        }

    }
}
