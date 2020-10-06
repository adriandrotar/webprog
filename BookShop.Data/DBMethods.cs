// <copyright file="DBMethods.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace BookShop.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// Data class which implements db methods.
    /// </summary>
    public static class DBMethods
    {
        private static BookShopDBEntities bsdbe = new BookShopDBEntities();

        /// <summary>
        /// Gets or Sets the database source.
        /// </summary>
        public static BookShopDBEntities Bsdbe { get => bsdbe; set => bsdbe = value; }

        /// <summary>
        /// Gets the contents of the table AUTHOR.
        /// </summary>
        public static List<AUTHOR> AUTHOR
        {
            get
            {
                return Bsdbe.AUTHOR.Select(x => x).ToList();
            }
        }

        /// <summary>
        /// Gets the contents of the table GENRE.
        /// </summary>
        public static List<GENRE> GENRE
        {
            get
            {
                return Bsdbe.GENRE.Select(x => x).ToList();
            }
        }

        /// <summary>
        /// Gets the contents of the table PUBLISHER.
        /// </summary>
        public static List<PUBLISHER> PUBLISHER
        {
            get
            {
                return Bsdbe.PUBLISHER.Select(x => x).ToList();
            }
        }

        /// <summary>
        /// Gets the contents of the table BOOK.
        /// </summary>
        public static List<BOOK> BOOK
        {
            get
            {
                return Bsdbe.BOOK.Select(x => x).ToList();
            }
        }

        /// <summary>
        /// Gets the contents of the table ORDERS.
        /// </summary>
        public static List<ORDERS> ORDERS
        {
            get
            {
                return Bsdbe.ORDERS.Select(x => x).ToList();
            }
        }

        /// <summary>
        /// Gets the contents of the table CUSTOMER.
        /// </summary>
        public static List<CUSTOMER> CUSTOMER
        {
            get
            {
                return Bsdbe.CUSTOMER.Select(x => x).ToList();
            }
        }

        /// <summary>
        /// Adds a new AUTHOR to DB.
        /// </summary>
        /// <param name="author">an author entity.</param>
        public static void AddAuthor(AUTHOR author)
        {
            Bsdbe.AUTHOR.Add(author);
        }

        /// <summary>
        /// Adds a new GENRE to DB.
        /// </summary>
        /// <param name="genre">a genre entity.</param>
        public static void AddGenre(GENRE genre)
        {
            Bsdbe.GENRE.Add(genre);
        }

        /// <summary>
        /// Adds a new PUBLISHER  to DB.
        /// </summary>
        /// <param name="publisher">a PUBLISHER entity.</param>
        public static void AddPublisher(PUBLISHER publisher)
        {
            Bsdbe.PUBLISHER.Add(publisher);
        }

        /// <summary>
        /// Adds a new BOOK to DB.
        /// </summary>
        /// <param name="book">a BOOK entity.</param>
        public static void AddBook(BOOK book)
        {
            Bsdbe.BOOK.Add(book);
        }

        /// <summary>
        /// Adds a new ORDER to DB.
        /// </summary>
        /// <param name="orders">an ORDER entity.</param>
        public static void AddOrders(ORDERS orders)
        {
            Bsdbe.ORDERS.Add(orders);
        }

        /// <summary>
        /// Adds a new CUSTOMER to DB.
        /// </summary>
        /// <param name="customer">a CUSTOMER entity.</param>
        public static void AddCustomer(CUSTOMER customer)
        {
            Bsdbe.CUSTOMER.Add(customer);
        }

        /// <summary>
        /// Removes an AUTHOR from DB.
        /// </summary>
        /// <param name="author">AUTHOR ID.</param>
        public static void RemoveAuthor(AUTHOR author)
        {
            Bsdbe.AUTHOR.Remove(author);
        }

        /// <summary>
        /// Removes a PUBLISHER from DB.
        /// </summary>
        /// <param name="publisher">PUBLISHER ID.</param>
        public static void RemovePublisher(PUBLISHER publisher)
        {
            Bsdbe.PUBLISHER.Remove(publisher);
        }

        /// <summary>
        /// Removes a GENRE from DB.
        /// </summary>
        /// <param name="genre">GENRE ID.</param>
        public static void RemoveGenre(GENRE genre)
        {
            Bsdbe.GENRE.Remove(genre);
        }

        /// <summary>
        /// Removes a BOOK from DB.
        /// </summary>
        /// <param name="book">BOOK ID.</param>
        public static void RemoveBook(BOOK book)
        {
            Bsdbe.BOOK.Remove(book);
        }

        /// <summary>
        /// Removes an ORDER from DB.
        /// </summary>
        /// <param name="order">ORDER ID.</param>
        public static void RemoveOrders(ORDERS order)
        {
            Bsdbe.ORDERS.Remove(order);
        }

        /// <summary>
        /// Removes a CUSTOMER from DB.
        /// </summary>
        /// <param name="customer">CUSTOMER ID.</param>
        public static void RemoveCustomer(CUSTOMER customer)
        {
            Bsdbe.CUSTOMER.Remove(customer);
        }

        /// <summary>
        /// Returns an AUTHOR from the DB.
        /// </summary>
        /// <param name="id">AUTHOR ID.</param>
        /// <returns>AUTHOR entity.</returns>
        public static AUTHOR GetAuthorById(int id)
        {
            return AUTHOR.Where(a => a.AUTHORID == id).Select(a => a).First();
        }

        /// <summary>
        /// Returns an PUBLISHER from DB.
        /// </summary>
        /// <param name="id">PUBLISHER ID.</param>
        /// <returns>PUBLISHER entity.</returns>
        public static PUBLISHER GetPublisherById(int id)
        {
            return PUBLISHER.Where(p => p.PUBLISHERID == id).Select(a => a).First();
        }

        /// <summary>
        /// Returns a GENRE from DB.
        /// </summary>
        /// <param name="id">GENRE ID.</param>
        /// <returns>GENRE entity.</returns>
        public static GENRE GetGenreById(int id)
        {
            return GENRE.Where(g => g.GENREID == id).Select(g => g).First();
        }

        /// <summary>
        /// Returns an ORDER from DB.
        /// </summary>
        /// <param name="id">ORDERS ID.</param>
        /// <returns>ORDERS entity.</returns>
        public static ORDERS GetOrdersById(int id)
        {
            return ORDERS.Where(o => o.ORDERSID == id).Select(o => o).First();
        }

        /// <summary>
        /// Returns a CUSTOMER from DB.
        /// </summary>
        /// <param name="id">CUSTOMER ID.</param>
        /// <returns>CUSTOMER entity.</returns>
        public static CUSTOMER GetCustomerById(int id)
        {
            return CUSTOMER.Where(c => c.CUSTOMERID == id).Select(c => c).First();
        }

        /// <summary>
        /// Returns a BOOK from DB.
        /// </summary>
        /// <param name="id">BOOK ID.</param>
        /// <returns>BOOK entity.</returns>
        public static BOOK GetBookById(int id)
        {
            return BOOK.Where(b => b.BOOKID == id).Select(b => b).First();
        }

        /// <summary>
        /// Save method.
        /// </summary>
        public static void SaveChanges()
        {
            Bsdbe.SaveChanges();
        }
    }
}