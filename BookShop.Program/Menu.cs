// <copyright file="Menu.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace BookShop.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookShop.Logic;

    /// <summary>
    /// This is where BLLogic is used.
    /// </summary>
    public class Menu
    {
        private readonly BLLogic blLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// </summary>
        public Menu()
        {
            this.blLogic = new BLLogic();
        }

        /// <summary>
        /// Runs the program.
        /// </summary>
        public void RunMenu()
        {
            string choose = string.Empty;
            do
            {
                try
                {
                    choose = this.MainMenu();
                }
                catch
                {
                    Console.WriteLine("HIBA : Rossz bemeneti paraméterek");
                    Console.ReadKey();
                }
            }
            while (choose != "x");
        }

        /// <summary>
        /// Basic mainmenu.
        /// </summary>
        /// <returns>The option the user choosen.</returns>
        private string MainMenu()
        {
            Console.WriteLine("\t0 : Minden elem listázása\n" +
                "\t1 : Összes AUTHOR listázása\n" +
                "\t2 : Összes BOOK listázása\n" +
                "\t3 : Összes CUSTOMER listázása\n" +
                "\t4 : Összes GENRE listázása\n" +
                "\t5 : Összes ORDER listázása\n" +
                "\t6 : Összes PUBLISHER listázása\n" +
                "\t7 : Új AUTHOR hozzáadása\n" +
                "\t8 : AUTHOR módositása\n" +
                "\t9 : AUTHOR törlése\n" +
                "\t10 : Új BOOK hozzáadása\n" +
                "\t11 : BOOK módositása\n" +
                "\t12 : BOOK törlése\n" +
                "\t13 : Új CUSTOMER hozzádása\n" +
                "\t14 : CUSTOMER módositása\n" +
                "\t15 : CUSTOMER törlése\n" +
                "\t16 : Új GENRE hozzádása\n" +
                "\t17 : GENRE módositása\n" +
                "\t18 : GENRE törlése\n" +
                "\t19 : Új ORDER hozzádása\n" +
                "\t20 : ORDER módositása\n" +
                "\t21 : ORDER törlése\n" +
                "\t22 : Új PUBLISHER hozzádása\n" +
                "\t23 : PUBLISHER módositása\n" +
                "\t24 : PUBLISHER törlése\n" +
                "\t25 : Milyen könyveket adtak el az adott shopban\n" +
                "\t26 : Az 5-nél nagyobb értékelésű könyvek és műfajok listázása\n" +
                "\t27 : A 3000-nél drágább könyvek irójuk, cimük, és áruk listázása\n" +
                "\t28 : Java BestSeller\n" +
                "\t X : Kilépés");

            string choose = Console.ReadLine();
            Console.Clear();
            switch (choose)
            {
                case "0":

                    Console.WriteLine(this.blLogic.GetAllContents);
                    break;

                case "1":

                    Console.WriteLine(this.blLogic.AuthorContents);
                    break;

                case "2":

                    Console.WriteLine(this.blLogic.BookContents);
                    break;

                case "3":

                    Console.WriteLine(this.blLogic.CustomerContents);
                    break;

                case "4":

                    Console.WriteLine(this.blLogic.GenreContents);
                    break;

                case "5":

                    Console.WriteLine(this.blLogic.OrdersContents);
                    break;

                case "6":

                    Console.WriteLine(this.blLogic.PublisherContents);
                    break;

                case "7":

                    Console.WriteLine("Adjon meg egy AUTHORID-t");
                    int authorid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon megy egy AUTHORNAME-t");
                    string authorname = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy AUTHORCOUNTRY-t");
                    string authorcountry = Console.ReadLine();
                    this.blLogic.AddAuthor(authorid, authorname, authorcountry);
                    break;

                case "8":

                    Console.WriteLine("Adjon meg egy AUTHORID-t");
                    authorid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon megy egy AUTHORNAME-t");
                    authorname = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy AUTHORCOUNTRY-t");
                    authorcountry = Console.ReadLine();
                    this.blLogic.UpdateAuthor(authorid, authorname, authorcountry);
                    break;

                case "9":

                    Console.WriteLine("Adjon meg egy AUTHORID-t");
                    authorid = int.Parse(Console.ReadLine());
                    this.blLogic.RemoveAuthor(authorid);
                    break;

                case "10":

                    Console.WriteLine("Adjon megy egy BOOKID-t");
                    int bookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy BOOKTITLE-t");
                    string booktitle = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy AUTHORID-t");
                    int bookauthorid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PUBLISHERID-t");
                    int bookpublisherid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy GENRERID-t");
                    int bookgenreid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy DESCRIPTION-t");
                    string bookdescription = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy RATING-et");
                    int bookrating = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PRICE-t");
                    int bookprice = int.Parse(Console.ReadLine());
                    this.blLogic.AddBook(bookid, booktitle, bookauthorid, bookpublisherid, bookgenreid, bookdescription, bookrating, bookprice);
                    break;

                case "11":

                    Console.WriteLine("Adjon megy egy BOOKID-t");
                    bookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy BOOKTITLE-t");
                    booktitle = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy AUTHORID-t");
                    bookauthorid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PUBLISHERID-t");
                    bookpublisherid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy GENRERID-t");
                    bookgenreid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy DESCRIPTION-t");
                    bookdescription = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy RATING-et");
                    bookrating = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PRICE-t");
                    bookprice = int.Parse(Console.ReadLine());
                    this.blLogic.UpdateBook(bookid, booktitle, bookauthorid, bookpublisherid, bookgenreid, bookdescription, bookrating, bookprice);
                    break;

                case "12":

                    Console.WriteLine("Adjon megy egy BOOKID-t");
                    bookid = int.Parse(Console.ReadLine());
                    this.blLogic.RemoveBook(bookid);
                    break;

                case "13":

                    Console.WriteLine("Adjon meg egy CUSTOMERID-t");
                    int customerid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy CUSTOMERNAME-t");
                    string customername = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMERCITY-t");
                    string customercity = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMERADDRESS-t");
                    string customeraddress = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMERPHONE-t");
                    string customerphone = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMEREMAIL-t");
                    string customeremail = Console.ReadLine();
                    this.blLogic.AddCustomer(customerid, customername, customercity, customeraddress, customerphone, customeremail);
                    break;

                case "14":

                    Console.WriteLine("Adjon meg egy CUSTOMERID-t");
                    customerid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy CUSTOMERNAME-t");
                    customername = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMERCITY-t");
                    customercity = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMERADDRESS-t");
                    customeraddress = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMERPHONE-t");
                    customerphone = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy CUSTOMEREMAIL-t");
                    customeremail = Console.ReadLine();
                    this.blLogic.UpdateCustomer(customerid, customername, customercity, customeraddress, customerphone, customeremail);
                    break;

                case "15":

                    Console.WriteLine("Adjon meg egy CUSTOMERID-t");
                    customerid = int.Parse(Console.ReadLine());
                    this.blLogic.RemoveCustomer(customerid);
                    break;

                case "16":

                    Console.WriteLine("Adjon meg egy GENREID-t");
                    int genreid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon megy egy GENRENAME-t");
                    string genrename = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy GENREDESCRIPTION-t");
                    string genredescription = Console.ReadLine();
                    this.blLogic.AddGenre(genreid, genrename, genredescription);
                    break;

                case "17":

                    Console.WriteLine("Adjon meg egy GENREID-t");
                    genreid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon megy egy GENRENAME-t");
                    genrename = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy GENREDESCRIPTION-t");
                    genredescription = Console.ReadLine();
                    this.blLogic.UpdateGenre(genreid, genrename, genredescription);
                    break;

                case "18":

                    Console.WriteLine("Adjon meg egy GENREID-t");
                    genreid = int.Parse(Console.ReadLine());
                    this.blLogic.RemoveGenre(genreid);
                    break;

                case "19":

                    Console.WriteLine("Adjon meg egy ORDERID-t");
                    int orderid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy CUSTOMERID-t");
                    int ordercustomerid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy SHOP-t");
                    string ordershop = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy BOOKID-t");
                    int orderbookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PURCHASEDATE-t");
                    string orderpurchasedate = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy COMMENT-et");
                    string ordercomment = Console.ReadLine();
                    this.blLogic.AddOrders(orderid, ordercustomerid, ordershop, orderbookid, orderpurchasedate, ordercomment);
                    break;

                case "20":

                    Console.WriteLine("Adjon meg egy ORDERID-t");
                    orderid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy CUSTOMERID-t");
                    ordercustomerid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy SHOP-t");
                    ordershop = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy BOOKID-t");
                    orderbookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PURCHASEDATE-t");
                    orderpurchasedate = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy COMMENT-et");
                    ordercomment = Console.ReadLine();
                    this.blLogic.UpdateOrders(orderid, ordercustomerid, ordershop, orderbookid, orderpurchasedate, ordercomment);
                    break;

                case "21":

                    Console.WriteLine("Adjon meg egy ORDERID-t");
                    orderid = int.Parse(Console.ReadLine());
                    this.blLogic.RemoveOrders(orderid);
                    break;

                case "22":

                    Console.WriteLine("Adjon meg egy PUBLISHERID-t");
                    int publisherid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PUBLISHERNAME-t");
                    string publishername = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy PUBLISHERCOUNTRY-t");
                    string publishercountry = Console.ReadLine();
                    this.blLogic.AddPublisher(publisherid, publishername, publishercountry);
                    break;

                case "23":

                    Console.WriteLine("Adjon meg egy PUBLISHERID-t");
                    publisherid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adjon meg egy PUBLISHERNAME-t");
                    publishername = Console.ReadLine();
                    Console.WriteLine("Adjon meg egy PUBLISHERCOUNTRY-t");
                    publishercountry = Console.ReadLine();
                    this.blLogic.UpdatePublisher(publisherid, publishername, publishercountry);
                    break;

                case "24":

                    Console.WriteLine("Adjon meg egy PUBLISHERID-t");
                    publisherid = int.Parse(Console.ReadLine());
                    this.blLogic.RemovePublisher(publisherid);
                    break;

                case "25":

                    Console.WriteLine("Adjon meg egy Shopnevet");
                    string shopnev = Console.ReadLine();
                    foreach (var item in this.blLogic.BooksSoldInShop(shopnev))
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case "26":

                    foreach (var item in this.blLogic.GenresAndBooksRatingMedium())
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case "27":

                    foreach (var item in this.blLogic.AuthorsAndBooksExpensive())
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case "28":

                    Console.WriteLine("Adja meg melyik book-ra kiváncsi, hogy bestseller-e");
                    Console.WriteLine(this.blLogic.GetIfBestSellerOrNot(Console.ReadLine()));
                    break;

                case "x":

                    Console.WriteLine("Viszlát");
                    break;

                default:
                    Console.WriteLine("HIBA: érvénytelen opció");
                    break;
            }

            return choose;
        }
    }
}
