using System;
using System.Xml.Serialization;

namespace SigmaBookAPI.Models
{
    /// <summary>
    /// Book. Represents a book in the book library.
    /// Each book have the properties id, author, title, genre, price, description and publish date
    /// </summary>
    public class Book
    {
        #region properties
        [XmlAttribute(AttributeName = "id")]
        public String Id { get; set; }

        [XmlElement(ElementName = "author")]
        public String Author { get; set; }

        [XmlElement(ElementName = "title")]
        public String Title { get; set; }

        [XmlElement(ElementName = "genre")]
        public String Genre { get; set; }

        [XmlElement(ElementName = "price")]
        public String Price { get; set; }

        [XmlElement(ElementName = "publish_date")]
        public String PublishDate { get; set; }

        [XmlElement(ElementName = "description")]
        public String Description { get; set; }
        #endregion
    }
}
