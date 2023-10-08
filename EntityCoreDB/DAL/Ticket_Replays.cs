using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoreDB.DAL
{
    public class Ticket_Replays
    {
        [Key]
        public int Id { get; set; }
        public string Replay { get; set; }
        [Required]
        public int ticket_id { get; set; }
        [StringLength(50)]
        public string ReplayBy { get; set; }

    }
}
