using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZidanBookStore.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public int TotalPages { get; set; }
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public int AutherId { get; set; }
        [Required]
        public int GenreId { get; set; }
    
    }
}
