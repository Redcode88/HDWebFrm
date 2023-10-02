using EntityCoreDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoreDB.Service
{
   public  class TicketGrid
   {
        private readonly dbcon _ctx;
        public TicketGrid(dbcon ctx)
        {
            _ctx = ctx;
        }


        public IEnumerable<Ticket> GetAllUserTicket(string UserName)
        {
           return _ctx.Tickets.Where(c => c.FrmUserName == UserName).ToList();
        }

        public IEnumerable<Ticket> GetAllTicket()
        {
            return _ctx.Tickets.ToList();
        }

    }
}
