// <copyright file="UnitTests.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Logic.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using BookShop.Data;
    using BookShop.Repository;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// A class to test the logic.
    /// </summary>
    public static class UnitTests
    {
        private static BLLogic blLogic;

        private static List<AUTHOR> authorList;
        private static List<BOOK> bookList;
        private static List<CUSTOMER> customerList;
        private static List<GENRE> genreList;
        private static List<ORDERS> ordersList;
        private static List<PUBLISHER> publisherList;

        private static string authorTableContents;
        private static string bookTableContents;
        private static string customerTableContents;
        private static string genreTableContents;
        private static string orderTableContents;
        private static string publisherTableContents;

        private static Mock<AuthorRepository> authorRepoMock;
        private static Mock<BookRepository> bookRepoMock;
        private static Mock<CustomerRepository> customerRepoMock;
        private static Mock<GenreRepository> genreRepoMock;
        private static Mock<OrdersRepository> ordersRepoMock;
        private static Mock<PublisherRepository> publisherRepoMock;

        /// <summary>
        /// Sets the tests up.
        /// </summary>
        [OneTimeSetUp]
        public static void TestSetUp()
        {
            authorRepoMock = new Mock<AuthorRepository>();
            bookRepoMock = new Mock<BookRepository>();
            customerRepoMock = new Mock<CustomerRepository>();
            genreRepoMock = new Mock<GenreRepository>();
            ordersRepoMock = new Mock<OrdersRepository>();
            publisherRepoMock = new Mock<PublisherRepository>();

            authorList = new List<AUTHOR>
            {
                new AUTHOR() { AUTHORID = 1, NAME = "Anakin", COUNTRY = "Sandland" },
                new AUTHOR() { AUTHORID = 2, NAME = "Obiwan", COUNTRY = "Highground" },
            };

            bookList = new List<BOOK>
            {
                new BOOK() { BOOKID = 3, TITLE = "title1", AUTHORID = 1, PUBLISHERID = 1, GENREID = 1, DESCRIPTION = "desc1", RATING = 6, PRICE = 3800 },
                new BOOK() { BOOKID = 4, TITLE = "title2", AUTHORID = 2, PUBLISHERID = 2, GENREID = 2, DESCRIPTION = "desc2", RATING = 7, PRICE = 2000 },
            };

            customerList = new List<CUSTOMER>
            {
                new CUSTOMER() { CUSTOMERID = 1, NAME = "name1", CITY = "city1", ADDRESS = "address1", PHONE = "phone1", EMAIL = "email1" },
                new CUSTOMER() { CUSTOMERID = 2, NAME = "name2", CITY = "city2", ADDRESS = "address2", PHONE = "phone2", EMAIL = "email2" },
            };

            genreList = new List<GENRE>
            {
                new GENRE() { GENREID = 1, NAME = "Genre1", GENREDESCRIPTION = "genredesc1" },
                new GENRE() { GENREID = 2, NAME = "Genre2", GENREDESCRIPTION = "genredesc2" },
            };

            ordersList = new List<ORDERS>
            {
                new ORDERS() { ORDERSID = 1, CUSTOMERID = 1, SHOP = "shop1", BOOKID = 3, PURCHASEDATE = "2019.01.01", COMMENTS = "comments1" },
                new ORDERS() { ORDERSID = 2, CUSTOMERID = 2, SHOP = "shop2", BOOKID = 4, PURCHASEDATE = "2019.01.02", COMMENTS = "comments2" },
            };

            publisherList = new List<PUBLISHER>
            {
                new PUBLISHER() { PUBLISHERID = 1, NAME = "Publisher1", COUNTRY = "Country1" },
                new PUBLISHER() { PUBLISHERID = 2, NAME = "Publisher2", COUNTRY = "Country2" },
            };

            foreach (AUTHOR item in authorList)
            {
                authorTableContents += "ID: " + item.AUTHORID + " | NAME: " + item.NAME + " | COUNTRY: " + item.COUNTRY + "\n";
            }

            foreach (BOOK item in bookList)
            {
                bookTableContents += "ID: " + item.BOOKID + " | TITLE: " + item.TITLE + " | AUTHORID: " + item.AUTHORID + " | PUBLISHERID: " + item.PUBLISHERID + " | GENREID: " + item.GENREID + " | DESCRIPTION: " + item.DESCRIPTION + " | RATING: " + item.RATING + " | PRICE: " + item.PRICE + "\n";
            }

            foreach (CUSTOMER item in customerList)
            {
                customerTableContents += "ID: " + item.CUSTOMERID + " | NAME: " + item.NAME + " | CITY: " + item.CITY + " | ADDRESS: " + item.ADDRESS + " | PHONE: " + item.PHONE + " | EMAIL: " + item.EMAIL + "\n";
            }

            foreach (GENRE item in genreList)
            {
                genreTableContents += "ID: " + item.GENREID + " | NAME: " + item.NAME + " | GENREDESCRIPTION: " + item.GENREDESCRIPTION + "\n";
            }

            foreach (ORDERS item in ordersList)
            {
                orderTableContents += "ID: " + item.ORDERSID + " | CUSTOMERID: " + item.CUSTOMERID + " | SHOP: " + item.SHOP + " | BOOKID: " + item.BOOKID + " | PURCHASEDATE: " + item.PURCHASEDATE + " | COMMENTS: " + item.COMMENTS + "\n";
            }

            foreach (PUBLISHER item in publisherList)
            {
                publisherTableContents += "ID: " + item.PUBLISHERID + " | NAME: " + item.NAME + " | COUNTRY: " + item.COUNTRY + "\n";
            }

            authorRepoMock.Setup(x => x.All).Returns(authorList.AsQueryable());
            bookRepoMock.Setup(x => x.All).Returns(bookList.AsQueryable());
            ordersRepoMock.Setup(x => x.All).Returns(ordersList.AsQueryable());
            genreRepoMock.Setup(x => x.All).Returns(genreList.AsQueryable());
            ordersRepoMock.Setup(x => x.All).Returns(ordersList.AsQueryable());
            publisherRepoMock.Setup(x => x.All).Returns(publisherList.AsQueryable());

            authorRepoMock.Setup(x => x.TableContents).Returns(authorTableContents);
            bookRepoMock.Setup(x => x.TableContents).Returns(bookTableContents);
            customerRepoMock.Setup(x => x.TableContents).Returns(customerTableContents);
            genreRepoMock.Setup(x => x.TableContents).Returns(genreTableContents);
            ordersRepoMock.Setup(x => x.TableContents).Returns(orderTableContents);
            publisherRepoMock.Setup(x => x.TableContents).Returns(publisherTableContents);
            RepositoryCollection temporary = new RepositoryCollection(authorRepoMock.Object, bookRepoMock.Object, customerRepoMock.Object, genreRepoMock.Object, ordersRepoMock.Object, publisherRepoMock.Object);
            blLogic = new BLLogic(temporary);
        }

        /// <summary>
        /// Tests the readability of the AuthorRepository.
        /// </summary>
        /// <param name="input">Test data.</param>
        [TestCase("Anakin")]
        public static void AuthorRepository_CanRead(string input)
        {
            string contents = blLogic.AuthorContents;
            Assert.That(contents.Contains(input));
        }

        /// <summary>
        /// Tests the readability of the BookRepository.
        /// </summary>
        /// <param name="input">Test data.</param>
        [TestCase("title1")]
        public static void BookRepository_CanRead(string input)
        {
            string contents = blLogic.BookContents;
            Assert.That(contents.Contains(input));
        }

        /// <summary>
        /// Tests the readability of the CustomerRepository.
        /// </summary>
        /// <param name="input">Test data.</param>
        [TestCase("name1")]
        public static void CustomerRepository_CanRead(string input)
        {
            string contents = blLogic.CustomerContents;
            Assert.That(contents.Contains(input));
        }

        /// <summary>
        /// Tests the readability of the GenreRepository.
        /// </summary>
        /// <param name="input">Test data.</param>
        [TestCase("Genre1")]
        public static void GenreRepository_CanRead(string input)
        {
            string contents = blLogic.GenreContents;
            Assert.That(contents.Contains(input));
        }

        /// <summary>
        /// Tests the readability of the OrdersRepository.
        /// </summary>
        /// <param name="input">Test data.</param>
        [TestCase("shop1")]
        public static void OrdersRepository_CanRead(string input)
        {
            string contents = blLogic.OrdersContents;
            Assert.That(contents.Contains(input));
        }

        /// <summary>
        /// Tests the readability of the PublisherRepository.
        /// </summary>
        /// <param name="input">Test data.</param>
        [TestCase("Publisher2")]
        public static void PublisherRepository_CanRead(string input)
        {
            string contents = blLogic.PublisherContents;
            Assert.That(contents.Contains(input));
        }

        /// <summary>
        /// Tests the #1 NON-CRUD method.
        /// </summary>
        /// <param name="input">Test parameter.</param>
        [TestCase("shop1")]
        public static void TestBooksSoldInShop(string input)
        {
            Assert.That(blLogic.BooksSoldInShop(input).First() == "title1");
        }

        /// <summary>
        /// Tests the #2 NON-CRUD method.
        /// </summary>
        [TestCase]
        public static void TestAuthorsAndBooksExpensive()
        {
            Assert.That(blLogic.AuthorsAndBooksExpensive().First() == "Anakin : title1 : 3800");
        }

        /// <summary>
        /// Tests the #3 NON-CRUD method.
        /// </summary>
        [TestCase]
        public static void TestGenresAndBooksRatingMedium()
        {
            Assert.That(blLogic.GenresAndBooksRatingMedium().First() == "title2 : Genre2 : 7");
        }

        /// <summary>
        /// Tests the AddAuthor method.
        /// </summary>
        [Test]
        public static void AuthorCreateTest()
        {
            // SETUP
            authorRepoMock.Setup(r => r.Add(99, "teszt1", "tesztcountry")).Verifiable();

            // TEST
            blLogic.AddAuthor(99, "teszt1", "tesztcountry");

            // ASSERT
            authorRepoMock.Verify(r => r.Add(99, "teszt1", "tesztcountry"));
        }

        /// <summary>
        /// Tests the AddBook method.
        /// </summary>
        [Test]
        public static void BookCreateTest()
        {
            // SETUP
            bookRepoMock.Setup(r => r.Add(99, "teszt1", 2, 3, 4, "tesztdesc", 2, 5)).Verifiable();

            // TEST
            blLogic.AddBook(99, "teszt1", 2, 3, 4, "tesztdesc", 2, 5);

            // ASSERT
            bookRepoMock.Verify(r => r.Add(99, "teszt1", 2, 3, 4, "tesztdesc", 2, 5));
        }

        /// <summary>
        /// Tests the AddGenre method.
        /// </summary>
        [Test]
        public static void GenreCreateTest()
        {
            // SETUP
            genreRepoMock.Setup(r => r.Add(39, "teszt1", "tesztdescript")).Verifiable();

            // TEST
            blLogic.AddGenre(39, "teszt1", "tesztdescript");

            // ASSERT
            genreRepoMock.Verify(r => r.Add(39, "teszt1", "tesztdescript"));
        }

        /// <summary>
        /// Tests the AddCustomer method.
        /// </summary>
        [Test]
        public static void CustomerCreateTest()
        {
            // SETUP
            customerRepoMock.Setup(r => r.Add(29, "teszt1", "tesztcoiry", "addre", "ph", "mail")).Verifiable();

            // TEST
            blLogic.AddCustomer(29, "teszt1", "tesztcoiry", "addre", "ph", "mail");

            // ASSERT
            customerRepoMock.Verify(r => r.Add(29, "teszt1", "tesztcoiry", "addre", "ph", "mail"));
        }

        /// <summary>
        /// Tests the AddOrders method.
        /// </summary>
        [Test]
        public static void OrdersCreateTest()
        {
            // SETUP
            ordersRepoMock.Setup(r => r.Add(99, 34, "teszt1", 21, "tesztcountry", "comms")).Verifiable();

            // TEST
            blLogic.AddOrders(99, 34, "teszt1", 21, "tesztcountry", "comms");

            // ASSERT
            ordersRepoMock.Verify(r => r.Add(99, 34, "teszt1", 21, "tesztcountry", "comms"));
        }

        /// <summary>
        /// Tests the AddPublisher method.
        /// </summary>
        [Test]
        public static void PublisherCreateTest()
        {
            // SETUP
            publisherRepoMock.Setup(r => r.Add(29, "tt1", "tesztcountry")).Verifiable();

            // TEST
            blLogic.AddPublisher(29, "tt1", "tesztcountry");

            // ASSERT
            publisherRepoMock.Verify(r => r.Add(29, "tt1", "tesztcountry"));
        }

        /// <summary>
        /// Tests the UpdateAuthor method.
        /// </summary>
        [Test]
        public static void AuthorUpdateTest()
        {
            // SETUP
            authorRepoMock.Setup(r => r.Update(99, "teszt1", "tesztcountry")).Verifiable();

            // TEST
            blLogic.UpdateAuthor(99, "teszt1", "tesztcountry");

            // ASSERT
            authorRepoMock.Verify(r => r.Update(99, "teszt1", "tesztcountry"));
        }

        /// <summary>
        /// Tests the UpdateBook method.
        /// </summary>
        [Test]
        public static void BookUpdateTest()
        {
            // SETUP
            bookRepoMock.Setup(r => r.Update(99, "teszt1", 2, 3, 4, "tesztdesc", 2, 5)).Verifiable();

            // TEST
            blLogic.UpdateBook(99, "teszt1", 2, 3, 4, "tesztdesc", 2, 5);

            // ASSERT
            bookRepoMock.Verify(r => r.Update(99, "teszt1", 2, 3, 4, "tesztdesc", 2, 5));
        }

        /// <summary>
        /// Tests the UpdateGenre method.
        /// </summary>
        [Test]
        public static void GenreUpdateTest()
        {
            // SETUP
            genreRepoMock.Setup(r => r.Update(39, "teszt1", "tesztdescript")).Verifiable();

            // TEST
            blLogic.UpdateGenre(39, "teszt1", "tesztdescript");

            // ASSERT
            genreRepoMock.Verify(r => r.Update(39, "teszt1", "tesztdescript"));
        }

        /// <summary>
        /// Tests the UpdateCustomer method.
        /// </summary>
        [Test]
        public static void CustomerUpdateTest()
        {
            // SETUP
            customerRepoMock.Setup(r => r.Update(29, "teszt1", "tesztcoiry", "addre", "ph", "mail")).Verifiable();

            // TEST
            blLogic.UpdateCustomer(29, "teszt1", "tesztcoiry", "addre", "ph", "mail");

            // ASSERT
            customerRepoMock.Verify(r => r.Update(29, "teszt1", "tesztcoiry", "addre", "ph", "mail"));
        }

        /// <summary>
        /// Tests the UpdateOrders method.
        /// </summary>
        [Test]
        public static void OrdersUpdateTest()
        {
            // SETUP
            ordersRepoMock.Setup(r => r.Update(99, 34, "teszt1", 21, "tesztcountry", "comms")).Verifiable();

            // TEST
            blLogic.UpdateOrders(99, 34, "teszt1", 21, "tesztcountry", "comms");

            // ASSERT
            ordersRepoMock.Verify(r => r.Update(99, 34, "teszt1", 21, "tesztcountry", "comms"));
        }

        /// <summary>
        /// Tests the UpdatePublisher method.
        /// </summary>
        [Test]
        public static void PublisherUpdateTest()
        {
            // SETUP
            publisherRepoMock.Setup(r => r.Update(29, "tt1", "tesztcountry")).Verifiable();

            // TEST
            blLogic.UpdatePublisher(29, "tt1", "tesztcountry");

            // ASSERT
            publisherRepoMock.Verify(r => r.Update(29, "tt1", "tesztcountry"));
        }

        /// <summary>
        /// Tests the RemoveAuthor method.
        /// </summary>
        [Test]
        public static void AuthorDeleteTest()
        {
            // SETUP
            authorRepoMock.Setup(r => r.Remove(20)).Verifiable();

            // TEST
            blLogic.RemoveAuthor(20);

            // ASSERT
            authorRepoMock.Verify(r => r.Remove(20));
        }

        /// <summary>
        /// Tests the RemoveBook method.
        /// </summary>
        [Test]
        public static void BookDeleteTest()
        {
            // SETUP
            bookRepoMock.Setup(r => r.Remove(20)).Verifiable();

            // TEST
            blLogic.RemoveBook(20);

            // ASSERT
            bookRepoMock.Verify(r => r.Remove(20));
        }

        /// <summary>
        /// Tests the RemoveCustomer method.
        /// </summary>
        [Test]
        public static void CustomerDeleteTest()
        {
            // SETUP
            customerRepoMock.Setup(r => r.Remove(20)).Verifiable();

            // TEST
            blLogic.RemoveCustomer(20);

            // ASSERT
            customerRepoMock.Verify(r => r.Remove(20));
        }

        /// <summary>
        /// Tests the RemoveGenre method.
        /// </summary>
        [Test]
        public static void GenreDeleteTest()
        {
            // SETUP
            genreRepoMock.Setup(r => r.Remove(20)).Verifiable();

            // TEST
            blLogic.RemoveGenre(20);

            // ASSERT
            genreRepoMock.Verify(r => r.Remove(20));
        }

        /// <summary>
        /// Tests the RemoveOrders method.
        /// </summary>
        [Test]
        public static void OrdersDeleteTest()
        {
            // SETUP
            ordersRepoMock.Setup(r => r.Remove(20)).Verifiable();

            // TEST
            blLogic.RemoveOrders(20);

            // ASSERT
            ordersRepoMock.Verify(r => r.Remove(20));
        }

        /// <summary>
        /// Tests the RemovePublisher method.
        /// </summary>
        [Test]
        public static void PublisherDeleteTest()
        {
            // SETUP
            publisherRepoMock.Setup(r => r.Remove(20)).Verifiable();

            // TEST
            blLogic.RemovePublisher(20);

            // ASSERT
            publisherRepoMock.Verify(r => r.Remove(20));
        }

        /// <summary>
        /// Tests the GetAuthorById method.
        /// </summary>
        [Test]
        public static void AuthorGetByIdTest()
        {
            // SETUP
            authorRepoMock.Setup(r => r.GetAuthorById(10)).Verifiable();

            // TEST
            blLogic.GetAuthorById(10);

            // ASSERT
            authorRepoMock.Verify(r => r.GetAuthorById(10));
        }

        /// <summary>
        /// Tests the GetBookById method.
        /// </summary>
        [Test]
        public static void BookGetByIdTest()
        {
            // SETUP
            bookRepoMock.Setup(r => r.GetBookById(10)).Verifiable();

            // TEST
            blLogic.GetBookById(10);

            // ASSERT
            bookRepoMock.Verify(r => r.GetBookById(10));
        }

        /// <summary>
        /// Tests the GetCustomerById method.
        /// </summary>
        [Test]
        public static void CustomerGetByIdTest()
        {
            // SETUP
            customerRepoMock.Setup(r => r.GetCustomerById(10)).Verifiable();

            // TEST
            blLogic.GetCustomerById(10);

            // ASSERT
            customerRepoMock.Verify(r => r.GetCustomerById(10));
        }

        /// <summary>
        /// Tests the GetGenreById method.
        /// </summary>
        [Test]
        public static void GenreGetByIdTest()
        {
            // SETUP
            genreRepoMock.Setup(r => r.GetGenreById(10)).Verifiable();

            // TEST
            blLogic.GetGenreById(10);

            // ASSERT
            genreRepoMock.Verify(r => r.GetGenreById(10));
        }

        /// <summary>
        /// Tests the GetOrdersById method.
        /// </summary>
        [Test]
        public static void OrdersGetByIdTest()
        {
            // SETUP
            ordersRepoMock.Setup(r => r.GetOrdersById(10)).Verifiable();

            // TEST
            blLogic.GetOrdersById(10);

            // ASSERT
            ordersRepoMock.Verify(r => r.GetOrdersById(10));
        }

        /// <summary>
        /// Tests the GetPublisherById method.
        /// </summary>
        [Test]
        public static void PublisherGetByIdTest()
        {
            // SETUP
            publisherRepoMock.Setup(r => r.GetPublisherById(10)).Verifiable();

            // TEST
            blLogic.GetPublisherById(10);

            // ASSERT
            publisherRepoMock.Verify(r => r.GetPublisherById(10));
        }
    }
}
