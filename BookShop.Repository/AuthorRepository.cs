// <copyright file="AuthorRepository.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using BookShop.Data;

    /// <summary>
    /// The repo for authors.
    /// </summary>
    public class AuthorRepository : IRepository<AUTHOR>
    {
        /// <summary>
        /// Gets contents from table Author.
        /// </summary>
        public virtual string TableContents
        {
            get
            {
                string str = string.Empty;

                foreach (var item in DBMethods.AUTHOR)
                {
                    str += "ID: " + item.AUTHORID + " | NAME: " + item.NAME + " | COUNTRY: " + item.COUNTRY + "\n";
                }

                return str;
            }
        }

        /// <summary>
        /// Gets every AUTHOR.
        /// </summary>
        public virtual IQueryable<AUTHOR> All
        {
            get
            {
                return DBMethods.AUTHOR.AsQueryable();
            }
        }

        /// <summary>
        /// Adds new Author to DB.
        /// </summary>
        /// <param name="authorid">ID of author.</param>
        /// <param name="name">Name of author.</param>
        /// <param name="country">Country of author.</param>
        /// <returns>If succesful returns true.</returns>
        public virtual bool Add(int authorid, string name, string country)
        {
            AUTHOR newAUTHOR = new AUTHOR
            {
                AUTHORID = authorid,
                NAME = name,
                COUNTRY = country,
            };
            DBMethods.AddAuthor(newAUTHOR);
            DBMethods.SaveChanges();
            return true;
        }

        /// <summary>
        /// Returns true if the entity exists.
        /// </summary>
        /// <param name="id">Entity ID.</param>
        /// <returns>True if exists.</returns>
        public bool IsExists(int id)
        {
            return DBMethods.AUTHOR.Any(x => x.AUTHORID == id);
        }

        /// <summary>
        /// Removes an author if there is one with the given id in the DB.
        /// </summary>
        /// <param name="id">The id of the author.</param>
        /// <returns>Return true if it removed it.</returns>
        public virtual bool Remove(int id)
        {
            List<AUTHOR> temporary = DBMethods.AUTHOR.Where(a => a.AUTHORID == id).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                DBMethods.RemoveAuthor(temporary.First());
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates the author in the db.
        /// </summary>
        /// <param name="authorid">The id we look for the author with.</param>
        /// <param name="name">The name of the author.</param>
        /// <param name="country">The country of the author.</param>
        /// <returns>True if updated.</returns>
        public virtual bool Update(int authorid, string name, string country)
        {
            List<AUTHOR> temporary = DBMethods.AUTHOR.Where(a => a.AUTHORID == authorid).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                AUTHOR updatedAUTHOR = temporary.First();
                updatedAUTHOR.AUTHORID = authorid;
                updatedAUTHOR.NAME = name;
                updatedAUTHOR.COUNTRY = country;
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gives back an author from db.
        /// </summary>
        /// <param name="id">Authors id.</param>
        /// <returns>An author.</returns>
        public virtual string GetAuthorById(int id)
        {
            AUTHOR item = DBMethods.GetAuthorById(id);
            return "ID: " + item.AUTHORID + " | NAME: " + item.NAME + " | COUNTRY: " + item.COUNTRY + "\n";
        }
    }
}
