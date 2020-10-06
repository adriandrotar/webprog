// <copyright file="BookRepository.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace BookShop.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using BookShop.Data;

    /// <summary>
    /// The repo for books.
    /// </summary>
    public class BookRepository : IRepository<BOOK>
    {
        /// <summary>
        /// Gets contents from table Book.
        /// </summary>
        public virtual string TableContents
        {
            get
            {
                string str = string.Empty;

                foreach (var item in DBMethods.BOOK)
                {
                    str += "ID: " + item.BOOKID + " | TITLE: " + item.TITLE + " | AUTHORID: " + item.AUTHORID + " | PUBLISHERID: " + item.PUBLISHERID + " | GENREID: " + item.GENREID + " | DESCRIPTION: " + item.DESCRIPTION + " | RATING: " + item.RATING + " | PRICE: " + item.PRICE + "\n";
                }

                return str;
            }
        }

        /// <summary>
        /// Gets every BOOK.
        /// </summary>
        public virtual IQueryable<BOOK> All
        {
            get
            {
                return DBMethods.BOOK.AsQueryable();
            }
        }

        /// <summary>
        /// Adds new book in DB.
        /// </summary>
        /// <param name="bookid">id of book.</param>
        /// <param name="title">title of book.</param>
        /// <param name="authorid">authorid of book.</param>
        /// <param name="publisherid">publisherid of book.</param>
        /// <param name="genreid">genreid of book.</param>
        /// <param name="description">description of book.</param>
        /// <param name="rating">rating of book.</param>
        /// <param name="price">price of book.</param>
        /// <returns>True if book is added.</returns>
        public virtual bool Add(int bookid, string title, int authorid, int publisherid, int genreid, string description, int rating, int price)
        {
            BOOK newBOOK = new BOOK
            {
                BOOKID = bookid,
                TITLE = title,
                AUTHORID = authorid,
                PUBLISHERID = publisherid,
                GENREID = genreid,
                DESCRIPTION = description,
                RATING = rating,
                PRICE = price,
            };
            DBMethods.AddBook(newBOOK);
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
            return DBMethods.BOOK.Any(x => x.BOOKID == id);
        }

        /// <summary>
        /// Removes a book if there is one with the given id in the DB.
        /// </summary>
        /// <param name="id">The id of the book.</param>
        /// <returns>Return true if it removed it.</returns>
        public virtual bool Remove(int id)
        {
            List<BOOK> temporary = DBMethods.BOOK.Where(a => a.BOOKID == id).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                DBMethods.RemoveBook(temporary.First());
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates a book in the db.
        /// </summary>
        /// <param name="bookid">id of book.</param>
        /// <param name="title">title of book.</param>
        /// <param name="authorid">authorid of book.</param>
        /// <param name="publisherid">publisherid of book.</param>
        /// <param name="genreid">genreid of book.</param>
        /// <param name="description">description of book.</param>
        /// <param name="rating">rating of book.</param>
        /// <param name="price">price of book.</param>
        /// <returns>True if it updated it.</returns>
        public virtual bool Update(int bookid, string title, int authorid, int publisherid, int genreid, string description, int rating, int price)
        {
            List<BOOK> temporary = DBMethods.BOOK.Where(a => a.BOOKID == bookid).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                BOOK updatedBOOK = temporary.First();
                updatedBOOK.BOOKID = bookid;
                updatedBOOK.TITLE = title;
                updatedBOOK.AUTHORID = authorid;
                updatedBOOK.PUBLISHERID = publisherid;
                updatedBOOK.GENREID = genreid;
                updatedBOOK.DESCRIPTION = description;
                updatedBOOK.RATING = rating;
                updatedBOOK.PRICE = price;
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gives back a book from db.
        /// </summary>
        /// <param name="id">Books id.</param>
        /// <returns>A book.</returns>
        public virtual string GetBookById(int id)
        {
            BOOK item = DBMethods.GetBookById(id);
            return "ID: " + item.BOOKID + " | TITLE: " + item.TITLE + " | AUTHORID: " + item.AUTHORID + " | PUBLISHERID: " + item.PUBLISHERID + " | GENREID: " + item.GENREID + " | DESCRIPTION: " + item.DESCRIPTION + " | RATING: " + item.RATING + " | PRICE: " + item.PRICE + "\n";
        }
    }
}
