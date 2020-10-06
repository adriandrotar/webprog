// <copyright file="BLLogic.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Logic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using BookShop.Repository;

    /// <summary>
    /// A class which contains the BL methods(CRUD + NON CRUD).
    /// </summary>
    public class BLLogic : ILogic
    {
        private readonly RepositoryCollection repositoryCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BLLogic"/> class.
        /// </summary>
        public BLLogic()
        {
            this.repositoryCollection = new RepositoryCollection();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BLLogic"/> class. For testing.
        /// </summary>
        /// <param name="inj">injected repocollection.</param>
        public BLLogic(RepositoryCollection inj)
        {
            this.repositoryCollection = inj;
        }

        /// <inheritdoc/>
        public string AuthorContents
        {
            get { return this.repositoryCollection.AuthorRepository.TableContents; }
        }

        /// <inheritdoc/>
        public string BookContents
        {
            get { return this.repositoryCollection.BookRepository.TableContents; }
        }

        /// <inheritdoc/>
        public string CustomerContents
        {
            get { return this.repositoryCollection.CustomerRepository.TableContents; }
        }

        /// <inheritdoc/>
        public string GenreContents
        {
            get { return this.repositoryCollection.GenreRepository.TableContents; }
        }

        /// <inheritdoc/>
        public string OrdersContents
        {
            get { return this.repositoryCollection.OrdersRepository.TableContents; }
        }

        /// <inheritdoc/>
        public string PublisherContents
        {
            get { return this.repositoryCollection.PublisherRepository.TableContents; }
        }

        /// <inheritdoc/>
        public string GetAllContents
        {
            get { return this.repositoryCollection.GetAllContents(); }
        }

        /// <inheritdoc/>
        public bool AddAuthor(int authorid, string name, string country)
        {
            return this.repositoryCollection.AuthorRepository.Add(authorid, name, country);
        }

        /// <inheritdoc/>
        public bool AddBook(int bookid, string title, int authorid, int publisherid, int genreid, string description, int rating, int price)
        {
            return this.repositoryCollection.BookRepository.Add(bookid, title, authorid, publisherid, genreid, description, rating, price);
        }

        /// <inheritdoc/>
        public bool AddCustomer(int customerid, string name, string city, string address, string phone, string email)
        {
            return this.repositoryCollection.CustomerRepository.Add(customerid, name, city, address, phone, email);
        }

        /// <inheritdoc/>
        public bool AddGenre(int genreid, string name, string genredescription)
        {
            return this.repositoryCollection.GenreRepository.Add(genreid, name, genredescription);
        }

        /// <inheritdoc/>
        public bool AddOrders(int ordersid, int customerid, string shop, int bookid, string purchasedate, string comments)
        {
            return this.repositoryCollection.OrdersRepository.Add(ordersid, customerid, shop, bookid, purchasedate, comments);
        }

        /// <inheritdoc/>
        public bool AddPublisher(int publisherid, string name, string country)
        {
            return this.repositoryCollection.PublisherRepository.Add(publisherid, name, country);
        }

        /// <inheritdoc/>
        public void RemoveAuthor(int id)
        {
            this.repositoryCollection.AuthorRepository.Remove(id);
        }

        /// <inheritdoc/>
        public void RemoveBook(int id)
        {
            this.repositoryCollection.BookRepository.Remove(id);
        }

        /// <inheritdoc/>
        public void RemoveCustomer(int id)
        {
            this.repositoryCollection.CustomerRepository.Remove(id);
        }

        /// <inheritdoc/>
        public void RemoveGenre(int id)
        {
            this.repositoryCollection.GenreRepository.Remove(id);
        }

        /// <inheritdoc/>
        public void RemoveOrders(int id)
        {
            this.repositoryCollection.OrdersRepository.Remove(id);
        }

        /// <inheritdoc/>
        public void RemovePublisher(int id)
        {
            this.repositoryCollection.PublisherRepository.Remove(id);
        }

        /// <inheritdoc/>
        public bool UpdateAuthor(int authorid, string name, string country)
        {
            return this.repositoryCollection.AuthorRepository.Update(authorid, name, country);
        }

        /// <inheritdoc/>
        public bool UpdateBook(int bookid, string title, int authorid, int publisherid, int genreid, string description, int rating, int price)
        {
            return this.repositoryCollection.BookRepository.Update(bookid, title, authorid, publisherid, genreid, description, rating, price);
        }

        /// <inheritdoc/>
        public bool UpdateCustomer(int customerid, string name, string city, string address, string phone, string email)
        {
            return this.repositoryCollection.CustomerRepository.Update(customerid, name, city, address, phone, email);
        }

        /// <inheritdoc/>
        public bool UpdateGenre(int genreid, string name, string genredescription)
        {
            return this.repositoryCollection.GenreRepository.Update(genreid, name, genredescription);
        }

        /// <inheritdoc/>
        public bool UpdateOrders(int ordersid, int customerid, string shop, int bookid, string purchasedate, string comments)
        {
            return this.repositoryCollection.OrdersRepository.Update(ordersid, customerid, shop, bookid, purchasedate, comments);
        }

        /// <inheritdoc/>
        public bool UpdatePublisher(int publisherid, string name, string country)
        {
            return this.repositoryCollection.PublisherRepository.Update(publisherid, name, country);
        }

        /// <inheritdoc/>
        public string GetAuthorById(int id)
        {
            return this.repositoryCollection.AuthorRepository.GetAuthorById(id);
        }

        /// <inheritdoc/>
        public string GetBookById(int id)
        {
            return this.repositoryCollection.BookRepository.GetBookById(id);
        }

        /// <inheritdoc/>
        public string GetCustomerById(int id)
        {
            return this.repositoryCollection.CustomerRepository.GetCustomerById(id);
        }

        /// <inheritdoc/>
        public string GetGenreById(int id)
        {
            return this.repositoryCollection.GenreRepository.GetGenreById(id);
        }

        /// <inheritdoc/>
        public string GetOrdersById(int id)
        {
            return this.repositoryCollection.OrdersRepository.GetOrdersById(id);
        }

        /// <inheritdoc/>
        public string GetPublisherById(int id)
        {
            return this.repositoryCollection.PublisherRepository.GetPublisherById(id);
        }

        /// <inheritdoc/>
        public bool AuthorExists(int id)
        {
            return this.repositoryCollection.AuthorRepository.IsExists(id);
        }

        /// <inheritdoc/>
        public bool BookExists(int id)
        {
            return this.repositoryCollection.BookRepository.IsExists(id);
        }

        /// <inheritdoc/>
        public bool CustomerExists(int id)
        {
            return this.repositoryCollection.CustomerRepository.IsExists(id);
        }

        /// <inheritdoc/>
        public bool GenreExists(int id)
        {
            return this.repositoryCollection.GenreRepository.IsExists(id);
        }

        /// <inheritdoc/>
        public bool OrdersExists(int id)
        {
            return this.repositoryCollection.OrdersRepository.IsExists(id);
        }

        /// <inheritdoc/>
        public bool PublisherExists(int id)
        {
            return this.repositoryCollection.PublisherRepository.IsExists(id);
        }

        /// <inheritdoc/>
        public List<string> BooksSoldInShop(string shop)
        {
            List<string> bookslist = new List<string>();

            var answer = from x in this.repositoryCollection.OrdersRepository.All
                         join y in this.repositoryCollection.BookRepository.All on x.BOOKID equals y.BOOKID
                         where x.SHOP == shop
                         select new
                         {
                             BookName = y.TITLE,
                         };
            foreach (var book in answer)
            {
                if (!bookslist.Contains(book.BookName))
                {
                    bookslist.Add(book.BookName);
                }
            }

            return bookslist;
        }

        /// <inheritdoc/>
        public List<string> AuthorsAndBooksExpensive()
        {
            List<string> authorbookcollection = new List<string>();

            var answer = from x in this.repositoryCollection.AuthorRepository.All
                         join y in this.repositoryCollection.BookRepository.All on x.AUTHORID equals y.AUTHORID
                         where y.PRICE > 3000
                         orderby y.PRICE
                         select new
                         {
                             AuthorBookPrice = x.NAME + " : " + y.TITLE + " : " + y.PRICE,
                         };

            foreach (var info in answer)
            {
                if (!authorbookcollection.Contains(info.AuthorBookPrice))
                {
                    authorbookcollection.Add(info.AuthorBookPrice);
                }
            }

            return authorbookcollection;
        }

        /// <inheritdoc/>
        public List<string> GenresAndBooksRatingMedium()
        {
            List<string> genresbookrating = new List<string>();

            var answer = from x in this.repositoryCollection.GenreRepository.All
                         join y in this.repositoryCollection.BookRepository.All on x.GENREID equals y.GENREID
                         where y.RATING > 5
                         orderby y.RATING descending
                         select new
                         {
                             TitleGenreRating = y.TITLE + " : " + x.NAME + " : " + y.RATING,
                         };
            foreach (var info in answer)
            {
                if (!genresbookrating.Contains(info.TitleGenreRating))
                {
                    genresbookrating.Add(info.TitleGenreRating);
                }
            }

            return genresbookrating;
        }

        /// <inheritdoc/>
        public string GetIfBestSellerOrNot(string book)
        {
            string bestseller = string.Empty;
            string url = @"http://localhost:8080/BookShop/BookShopServlet?book=" + book;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                {
                    bestseller = reader.ReadToEnd();
                }
            }
            catch
            {
                bestseller = "Nem lehet kapcsolódni a szerverhez.";
            }

            return bestseller;
        }
    }
}