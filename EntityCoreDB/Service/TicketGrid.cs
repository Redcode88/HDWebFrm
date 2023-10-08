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


        //Get all closed ticket
        public IEnumerable<Ticket> GetAllTicket(string UserName)
        {
            return _ctx.Tickets.Where(c => c.FrmUserName == UserName && c.State == "Close").ToList();
        }

        public IEnumerable<Ticket> GetAllTicketByState(string State)
        {
            return _ctx.Tickets.Where(c => c.State == State).ToList();
        }

        //Get ticket by username and avilabilty
        public IEnumerable<Ticket> GetAllUserTicket(string UserName)
        {
           return _ctx.Tickets.Where(
           c => c.FrmUserName == UserName &&
           c.IsActive == true &&
           c.State == "Open")
           .ToList();
        }


        //Logical Delete for Ticket
        public void DeleteTicket(int id)
        {
            var entity = _ctx.Tickets.Where(i => i.Id == id).FirstOrDefault();
            _ctx.Entry(entity).Property(d => d.IsActive).IsModified = false;
            _ctx.SaveChanges();
        }

        //Edit Ticket recored 
        public void EditTicket(int id, string newDescription, string newState, bool newIsActive)
        {
            var entity = _ctx.Tickets.FirstOrDefault(i => i.Id == id);

            if (entity != null)
            {
                entity.Discreption = newDescription;
                entity.State = newState;
                entity.IsActive = newIsActive;
                _ctx.SaveChanges();
            }
        }

        //Get All Tickets
        public IEnumerable<Ticket> GetAllTicket()
        {
            return _ctx.Tickets.ToList();
        }

        //Delete Phiscal Recored From DataBase
        public void RemoveTicket(int id)
        {
            var DeletedRecored = _ctx.Tickets.FirstOrDefault(i => i.Id == id);
            _ctx.Tickets.Remove(DeletedRecored);
            _ctx.SaveChanges();
        }


        #region Dashboread Static's


        public int ClosedTicketCount()
        {
            var count = _ctx.Tickets.Where(t => t.State == "Close").Count();
            return count;
        }


        public int OpendTicketCount()
        {
            var count = _ctx.Tickets.Where(t => t.State == "Open").Count();
            return count;
        }


        public int UrgetntTicketCount()
        {
            var count = _ctx.Tickets.Where(t => t.Per == "Urgent").Count();
            return count;
        }


        #endregion




    }
}
