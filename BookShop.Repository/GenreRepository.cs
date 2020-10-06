// <copyright file="GenreRepository.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using BookShop.Data;

    /// <summary>
    /// The repo for genre.
    /// </summary>
    public class GenreRepository : IRepository<GENRE>
    {
        /// <summary>
        /// Gets contents from table Genre.
        /// </summary>
        public virtual string TableContents
        {
            get
            {
                string str = string.Empty;

                foreach (var item in DBMethods.GENRE)
                {
                    str += "ID: " + item.GENREID + " | NAME: " + item.NAME + " | GENREDESCRIPTION: " + item.GENREDESCRIPTION + "\n";
                }

                return str;
            }
        }

        /// <summary>
        /// Gets every Genre.
        /// </summary>
        public virtual IQueryable<GENRE> All
        {
            get
            {
                return DBMethods.GENRE.AsQueryable();
            }
        }

        /// <summary>
        /// Adds new genre to DB.
        /// </summary>
        /// <param name="genreid">ID of genre.</param>
        /// <param name="name">Name of genre.</param>
        /// <param name="genredescription">description of genre.</param>
        /// <returns>If succesful returns true.</returns>
        public virtual bool Add(int genreid, string name, string genredescription)
        {
            GENRE newGENRE = new GENRE
            {
                GENREID = genreid,
                NAME = name,
                GENREDESCRIPTION = genredescription,
            };
            DBMethods.AddGenre(newGENRE);
            DBMethods.SaveChanges();
            return true;
        }

        /// <summary>
        /// Returns true if the entity exists.
        /// </summary>
        /// <param name="id">Entity ID.</param>
        /// <returns>True if exists.</returns>
        public virtual bool IsExists(int id)
        {
            return DBMethods.GENRE.Any(x => x.GENREID == id);
        }

        /// <summary>
        /// Removes a genre if there is one with the given id in the DB.
        /// </summary>
        /// <param name="id">The id of the genre.</param>
        /// <returns>Return true if it removed it.</returns>
        public virtual bool Remove(int id)
        {
            List<GENRE> temporary = DBMethods.GENRE.Where(a => a.GENREID == id).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                DBMethods.RemoveGenre(temporary.First());
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates a genre in the db.
        /// </summary>
        /// <param name="genreid">The id we look for the genre with.</param>
        /// <param name="name">The name of the genre.</param>
        /// <param name="genredescription">The description of the genre.</param>
        /// <returns>True if updated.</returns>
        public virtual bool Update(int genreid, string name, string genredescription)
        {
            List<GENRE> temporary = DBMethods.GENRE.Where(a => a.GENREID == genreid).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                GENRE updatedGENRE = temporary.First();
                updatedGENRE.GENREID = genreid;
                updatedGENRE.NAME = name;
                updatedGENRE.GENREDESCRIPTION = genredescription;
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gives back a genre from db.
        /// </summary>
        /// <param name="id">Genres id.</param>
        /// <returns>A genre.</returns>
        public virtual string GetGenreById(int id)
        {
            GENRE item = DBMethods.GetGenreById(id);
            return "ID: " + item.GENREID + " | NAME: " + item.NAME + " | GENREDESCRIPTION: " + item.GENREDESCRIPTION + "\n";
        }
    }
}
