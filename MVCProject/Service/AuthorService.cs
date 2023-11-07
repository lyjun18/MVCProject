using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Uow.Package.Data;

namespace MVCProject.Service
{
    public class AuthorService
    {
        private pubsEntities db = new pubsEntities();
        private UnitOfWork uok = new UnitOfWork();

        public List<authors> GetAuthorsIndex()
        {
            List<authors>  authors = db.authors.ToList();
            return authors;
        }
    }
}