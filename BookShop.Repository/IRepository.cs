// <copyright file="IRepository.cs" company="BCXFMD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookShop.Repository
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Interface which requires the CRUD methods.
    /// </summary>
    /// <typeparam name="T">T type</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Gets the contents of the table.
        /// </summary>
        string TableContents { get; }

        /// <summary>
        /// Gets all of the Ts.
        /// </summary>
        IQueryable<T> All { get; }

        /// <summary>
        /// Gives back if the element exists or not.
        /// </summary>
        /// <param name="id">ID of the object.</param>
        /// <returns>If it exists, true.</returns>
        bool IsExists(int id);

        /// <summary>
        /// Removes an object from the db.
        /// </summary>
        /// <param name="id">ID of the object.</param>
        /// <returns>Gives back true, if it was succesful.</returns>
        bool Remove(int id);
   }
}
