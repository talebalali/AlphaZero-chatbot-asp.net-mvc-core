using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Models
{
    [Table("BotChat")]
    public class Chat
    {
        [Column("Id")]
        [Display(Name = "ChatId")]
        public int Id { get; set; }

        [Column("Reply")]
        [Display(Name = "Reply")]
        public string Reply { get; set; }

        [Column("Message")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
