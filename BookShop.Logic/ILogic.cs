// <copyright file="ILogic.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Logic
{
    using System.Collections.Generic;

    /// <summary>
    /// An interface which defines the BL methods(CRUD + NON CRUD).
    /// </summary>
    public interface ILogic
    {
        /// <summary>
        /// Gets all the contents from the Author table.
        /// </summary>
        string AuthorContents { get; }

        /// <summary>
        /// Gets all the contents from the Book table.
        /// </summary>
        string BookContents { get; }

        /// <summary>
        /// Gets all the contents from the Customer table.
        /// </summary>
        string CustomerContents { get; }

        /// <summary>
        /// Gets all the contents from the Genre table.
        /// </summary>
        string GenreContents { get; }

        /// <summary>
        /// Gets all the contents from the Orders table.
        /// </summary>
        string OrdersContents { get; }

        /// <summary>
        /// Gets all the contents from the Publisher table.
        /// </summary>
        string PublisherContents { get; }

        /// <summary>
        /// Gets all the contents from every table.
        /// </summary>
        string GetAllContents { get; }

        /// <summary>
        /// Adds a new Author to the DB.
        /// </summary>
        /// <param name="authorid">Id of author.</param>
        /// <param name="name">Name of author.</param>
        /// <param name="country">Country of author.</param>
        /// <returns>True if added.</returns>
        bool AddAuthor(int authorid, string name, string country);

        /// <summary>
        /// Adds a new Book to the DB.
        /// </summary>
        /// <param name="bookid">Id of the book.</param>
        /// <param name="title">Title of the book.</param>
        /// <param name="authorid">Author ID of the book.</param>
        /// <param name="publisherid">Publisher ID of the book.</param>
        /// <param name="genreid">Genre ID of the book.</param>
        /// <param name="description">Description of the book.</param>
        /// <param name="rating">Rating of the book.</param>
        /// <param name="price">Price of the book.</param>
        /// <returns>True if added.</returns>
        bool AddBook(int bookid, string title, int authorid, int publisherid, int genreid, string description, int rating, int price);

        /// <summary>
        /// Adds a new Customer to the DB.
        /// </summary>
        /// <param name="customerid">Id of the customer.</param>
        /// <param name="name">Name of the customer.</param>
        /// <param name="city">City of the customer.</param>
        /// <param name="address">Address of the customer.</param>
        /// <param name="phone">Phone of the customer.</param>
        /// <param name="email">Email of the customer.</param>
        /// <returns>True if added.</returns>
        bool AddCustomer(int customerid, string name, string city, string address, string phone, string email);

        /// <summary>
        /// Adds a new Genre to the DB.
        /// </summary>
        /// <param name="genreid">ID of the genre.</param>
        /// <param name="name">Name of the genre.</param>
        /// <param name="genredescription">Description of the genre.</param>
        /// <returns>True if added.</returns>
        bool AddGenre(int genreid, string name, string genredescription);

        /// <summary>
        /// Adds a new Order to the DB.
        /// </summary>
        /// <param name="ordersid">ID of the order.</param>
        /// <param name="customerid">Customer ID  of the order.</param>
        /// <param name="shop">Shop of the order.</param>
        /// <param name="bookid">Book ID of the order.</param>
        /// <param name="purchasedate">PurchaseDate of the order.</param>
        /// <param name="comments">Comments of the order.</param>
        /// <returns>True if added.</returns>
        bool AddOrders(int ordersid, int customerid, string shop, int bookid, string purchasedate, string comments);

        /// <summary>
        /// Adds a new Publisher to the DB.
        /// </summary>
        /// <param name="publisherid">ID of the publisher.</param>
        /// <param name="name">Name of the publisher.</param>
        /// <param name="country">Country of the publisher.</param>
        /// <returns>True if added.</returns>
        bool AddPublisher(int publisherid, string name, string country);

        /// <summary>
        /// Removes an author by id from the DB.
        /// </summary>
        /// <param name="id">ID of the author.</param>
        void RemoveAuthor(int id);

        /// <summary>
        /// Removes a book by id from the DB.
        /// </summary>
        /// <param name="id">ID of the book.</param>
        void RemoveBook(int id);

        /// <summary>
        /// Removes a customer by id from the DB.
        /// </summary>
        /// <param name="id">ID of the customer.</param>
        void RemoveCustomer(int id);

        /// <summary>
        /// Removes a Genre by id from the DB.
        /// </summary>
        /// <param name="id">ID of the genre.</param>
        void RemoveGenre(int id);

        /// <summary>
        /// Removes an order by id from the DB.
        /// </summary>
        /// <param name="id">ID of the order.</param>
        void RemoveOrders(int id);

        /// <summary>
        /// Removes a publisher by id from the DB.
        /// </summary>
        /// <param name="id">ID of the publisher.</param>
        void RemovePublisher(int id);

        /// <summary>
        /// Updates an Author from the DB.
        /// </summary>
        /// <param name="authorid">Id of author.</param>
        /// <param name="name">Name of author.</param>
        /// <param name="country">Country of author.</param>
        /// <returns>True if updated.</returns>
        bool UpdateAuthor(int authorid, string name, string country);

        /// <summary>
        /// Updates a Book from the DB.
        /// </summary>
        /// <param name="bookid">Id of the book.</param>
        /// <param name="title">Title of the book.</param>
        /// <param name="authorid">Author ID of the book.</param>
        /// <param name="publisherid">Publisher ID of the book.</param>
        /// <param name="genreid">Genre ID of the book.</param>
        /// <param name="description">Description of the book.</param>
        /// <param name="rating">Rating of the book.</param>
        /// <param name="price">Price of the book.</param>
        /// <returns>True if updated.</returns>
        bool UpdateBook(int bookid, string title, int authorid, int publisherid, int genreid, string description, int rating, int price);

        /// <summary>
        /// Updates a Customer from the DB.
        /// </summary>
        /// <param name="customerid">Id of the customer.</param>
        /// <param name="name">Name of the customer.</param>
        /// <param name="city">City of the customer.</param>
        /// <param name="address">Address of the customer.</param>
        /// <param name="phone">Phone of the customer.</param>
        /// <param name="email">Email of the customer.</param>
        /// <returns>True if updated.</returns>
        bool UpdateCustomer(int customerid, string name, string city, string address, string phone, string email);

        /// <summary>
        /// Updates a Genre from the DB.
        /// </summary>
        /// <param name="genreid">ID of the genre.</param>
        /// <param name="name">Name of the genre.</param>
        /// <param name="genredescription">Description of the genre.</param>
        /// <returns>True if updated.</returns>
        bool UpdateGenre(int genreid, string name, string genredescription);

        /// <summary>
        /// Updates an Order from the DB.
        /// </summary>
        /// <param name="ordersid">ID of the order.</param>
        /// <param name="customerid">Customer ID  of the order.</param>
        /// <param name="shop">Shop of the order.</param>
        /// <param name="bookid">Book ID of the order.</param>
        /// <param name="purchasedate">PurchaseDate of the order.</param>
        /// <param name="comments">Comments of the order.</param>
        /// <returns>True if updated.</returns>
        bool UpdateOrders(int ordersid, int customerid, string shop, int bookid, string purchasedate, string comments);

        /// <summary>
        /// Updates Publisher from the DB.
        /// </summary>
        /// <param name="publisherid">ID of the publisher.</param>
        /// <param name="name">Name of the publisher.</param>
        /// <param name="country">Country of the publisher.</param>
        /// <returns>True if updated.</returns>
        bool UpdatePublisher(int publisherid, string name, string country);

        /// <summary>
        /// Gives back an Author from the DB.
        /// </summary>
        /// <param name="id">ID of the author.</param>
        /// <returns>Returns an author.</returns>
        string GetAuthorById(int id);

        /// <summary>
        /// Gives back a Book from the DB.
        /// </summary>
        /// <param name="id">ID of the book.</param>
        /// <returns>Returns a book.</returns>
        string GetBookById(int id);

        /// <summary>
        /// Gives back a Customer from the DB.
        /// </summary>
        /// <param name="id">ID of the customer.</param>
        /// <returns>Returns a customer.</returns>
        string GetCustomerById(int id);

        /// <summary>
        /// Gives back a Genre from the DB.
        /// </summary>
        /// <param name="id">ID of the genre.</param>
        /// <returns>Returns a genre.</returns>
        string GetGenreById(int id);

        /// <summary>
        /// Gives back an Order from the DB.
        /// </summary>
        /// <param name="id">ID of the order.</param>
        /// <returns>Returns an order.</returns>
        string GetOrdersById(int id);

        /// <summary>
        /// Gives back a Publisher from the DB.
        /// </summary>
        /// <param name="id">ID of the publisher.</param>
        /// <returns>Returns a publisher.</returns>
        string GetPublisherById(int id);

        /// <summary>
        /// Gives back if the Author exists.
        /// </summary>
        /// <param name="id">ID of the author.</param>
        /// <returns>True if it exists.</returns>
        bool AuthorExists(int id);

        /// <summary>
        /// Gives back if the Book exists.
        /// </summary>
        /// <param name="id">ID of the book.</param>
        /// <returns>True if it exists.</returns>
        bool BookExists(int id);

        /// <summary>
        /// Gives back if the Customer exists.
        /// </summary>
        /// <param name="id">ID of the customer.</param>
        /// <returns>True if it exists.</returns>
        bool CustomerExists(int id);

        /// <summary>
        /// Gives back if the Genre exists.
        /// </summary>
        /// <param name="id">ID of the genre.</param>
        /// <returns>True if it exists.</returns>
        bool GenreExists(int id);

        /// <summary>
        /// Gives back if the Order exists.
        /// </summary>
        /// <param name="id">ID of the order.</param>
        /// <returns>True if it exists.</returns>
        bool OrdersExists(int id);

        /// <summary>
        /// Gives back if the Publisher exists.
        /// </summary>
        /// <param name="id">ID of the publisher.</param>
        /// <returns>True if it exists.</returns>
        bool PublisherExists(int id);

        /// <summary>
        /// Gives back the books that were sold in a given shop.
        /// </summary>
        /// <param name="shop">The name of the shop.</param>
        /// <returns>The title of the books.</returns>
        List<string> BooksSoldInShop(string shop);

        /// <summary>
        /// Gives back the books of the authors that are priced more than 3000 in order.
        /// </summary>
        /// <returns>The title of the books, with their authors name and the books price.</returns>
        List<string> AuthorsAndBooksExpensive();

        /// <summary>
        /// Gives back the books and their genres which are rated more than 5/10.
        /// </summary>
        /// <returns>The books and their genres, and their rating.</returns>
        List<string> GenresAndBooksRatingMedium();

        /// <summary>
        /// Gives back if the book is a bestseller or not.
        /// </summary>
        /// <param name="book">the book.</param>
        /// <returns>The bestseller books.</returns>
        string GetIfBestSellerOrNot(string book);
    }
}
