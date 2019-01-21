using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SigmaBookAPI.Models
{
    /// <summary>
    /// Book library. Contains a list of all books in the library
    /// </summary>
    [XmlRoot("catalog")]
    public class BookLibrary
    {
        #region properties
        [XmlElement(ElementName = "book")]
        public List<Book> Books { get; set; }
        #endregion

    }
}
