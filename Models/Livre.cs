using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appPageRazor.Models
{
    public class Livre
    {
        [Key]
        public string ISBN { get; set; }
        public string title { get; set; }=string.Empty;
        public string autor { get; set; } = string.Empty;
        public Category Category { get; set; }
        public string description { get; set; } = string.Empty;

        public DateTime createdAt { get; set; }
        public String Img { get; set; }
       
       
    }
    public enum Category
    {
        Adventure ,
        Classics,
        Crime,
        Fairy,
        Fantasy,
        Horror,
        Humour ,
        mystery,
        Poetry,
        Romance,
        ScienceFiction,
        War,
    }
}
