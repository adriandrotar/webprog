// <copyright file="CustomerRepository.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace BookShop.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using BookShop.Data;

    /// <summary>
    /// The repo for customers.
    /// </summary>
    public class CustomerRepository : IRepository<CUSTOMER>
    {
        /// <summary>
        /// Gets contents from table Customer.
        /// </summary>
        public virtual string TableContents
        {
            get
            {
                string str = string.Empty;

                foreach (var item in DBMethods.CUSTOMER)
                {
                    str += "ID: " + item.CUSTOMERID + " | NAME: " + item.NAME + " | CITY: " + item.CITY + " | ADDRESS: " + item.ADDRESS + " | PHONE: " + item.PHONE + " | EMAIL: " + item.EMAIL + "\n";
                }

                return str;
            }
        }

        /// <summary>
        /// Gets every CUSTOMER.
        /// </summary>
        public virtual IQueryable<CUSTOMER> All
        {
            get
            {
                return DBMethods.CUSTOMER.AsQueryable();
            }
        }

        /// <summary>
        /// Adds a new customer to the db.
        /// </summary>
        /// <param name="customerid">id of customer.</param>
        /// <param name="name">name of customer.</param>
        /// <param name="city">city of customer.</param>
        /// <param name="address">address of customer.</param>
        /// <param name="phone">phone of customer.</param>
        /// <param name="email">email of customer.</param>
        /// <returns>True if added.</returns>
        public virtual bool Add(int customerid, string name, string city, string address, string phone, string email)
        {
            CUSTOMER newCUSTOMER = new CUSTOMER
            {
                CUSTOMERID = customerid,
                NAME = name,
                CITY = city,
                ADDRESS = address,
                PHONE = phone,
                EMAIL = email,
            };
            DBMethods.AddCustomer(newCUSTOMER);
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
            return DBMethods.CUSTOMER.Any(x => x.CUSTOMERID == id);
        }

        /// <summary>
        /// Removes a customer if there is one with the given id in the DB.
        /// </summary>
        /// <param name="id">The id of the customer.</param>
        /// <returns>Return true if it removed it.</returns>
        public virtual bool Remove(int id)
        {
            List<CUSTOMER> temporary = DBMethods.CUSTOMER.Where(a => a.CUSTOMERID == id).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                DBMethods.RemoveCustomer(temporary.First());
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customerid">id of customer.</param>
        /// <param name="name">name of customer.</param>
        /// <param name="city">city of customer.</param>
        /// <param name="address">address of customer.</param>
        /// <param name="phone">phone of customer.</param>
        /// <param name="email">email of customer.</param>
        /// <returns>True if updated.</returns>
        public virtual bool Update(int customerid, string name, string city, string address, string phone, string email)
        {
            List<CUSTOMER> temporary = DBMethods.CUSTOMER.Where(a => a.CUSTOMERID == customerid).Select(a => a).ToList();
            if (temporary.Count() > 0)
            {
                CUSTOMER updatedCUSTOMER = temporary.First();
                updatedCUSTOMER.CUSTOMERID = customerid;
                updatedCUSTOMER.NAME = name;
                updatedCUSTOMER.CITY = city;
                updatedCUSTOMER.ADDRESS = address;
                updatedCUSTOMER.PHONE = phone;
                updatedCUSTOMER.EMAIL = email;
                DBMethods.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gives back a customer from db.
        /// </summary>
        /// <param name="id">Customers id.</param>
        /// <returns>A Customer.</returns>
        public virtual string GetCustomerById(int id)
        {
            CUSTOMER item = DBMethods.GetCustomerById(id);
            return "ID: " + item.CUSTOMERID + " | NAME: " + item.NAME + " | CITY: " + item.CITY + " | ADDRESS: " + item.ADDRESS + " | PHONE: " + item.PHONE + " | EMAIL: " + item.EMAIL + "\n";
        }
    }
}
