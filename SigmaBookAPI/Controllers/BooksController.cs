using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using SigmaBookAPI.Models;

namespace SigmaBookAPI.Controllers
{
    /// <summary>
    /// Books controller. Handles API requests.
    /// </summary>
    [Route("bookapi/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        #region properties
        public BookLibrary BookLibrary { get; set; }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SigmaBookAPI.Controllers.BooksController"/> class.
        /// Maps books.xml to POCO
        /// </summary>
        public BooksController()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(BookLibrary));

            using (TextReader textReader = new StreamReader(@"./books.xml"))
            {
                BookLibrary = (BookLibrary)deserializer.Deserialize(textReader);
            }

        }

        /// <summary>
        /// Method for the API request GET bookapi/books.
        /// This is called when the user presses search in the GUI without any search input.
        /// </summary>
        /// <returns>A list of all books in the book library</returns>
        [HttpGet]
        public List<Book> GetAllBooks() => BookLibrary.Books;

        /// <summary>
        /// Method for the API request GET bookapi/books/{title}.
        /// </summary>
        /// <returns>All books which title is matching the <paramref name="title"/></returns>
        /// <param name="title">The search input from the user calling the request</param>
        [HttpGet("{title}")]
        public List<Book> GetBooks(String title) => BookLibrary.Books.Where(b => b.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase)).ToList();

    }
}
