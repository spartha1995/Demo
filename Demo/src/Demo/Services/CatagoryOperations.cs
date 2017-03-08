using Demo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class CatagoryOperations : ICatagory
    {
        private readonly ApplicationDbContext _context;


        public CatagoryOperations(ApplicationDbContext Context)
        {
            _context = Context;
            // CatagoryAdd(new Catagory { CatagoryName= "C.S.E"});//adding value manually
        }



        #region Get all
        public IEnumerable<Catagory> GetAll()

        {
            return _context.Catagorys.ToList();
        }
        #endregion



        #region Catagory Name Add
        /// <summary>
        /// Adding a Catagory Into Database
        /// </summary>
        /// <param name="catagoryname"></param>
        public void CatagoryAdd(Catagory catagoryname)
        {
            _context.Catagorys.Add(catagoryname);
            _context.SaveChanges();
        }
        #endregion


        #region Finding a Key Catagory Table
        /// <summary>
        /// Findind a Respective key from Catagory Table
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public Catagory CatagoryFind(long Key)
        {
            return _context.Catagorys.FirstOrDefault(t => t.CatagoryId == Key);
        }
        #endregion



        #region Update A Catagory Name
        // <summary>
        // Updating a Catagory Name
        // </summary>
        // <param name="catagoryname"></param>
        public void CatagoryUpdate(Catagory catagoryname)
        {
            _context.Catagorys.Update(catagoryname);
            _context.SaveChanges();
        }

        #endregion



        //#region Checks for catagory name is same or not
        ///// <summary>
        ///// checks wheteher catagory name is same or not
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public bool CatagoryNameExists(int id)
        //{
        //    return _context.Catagorys.Any(e => e.CatagoryId == id);
        //}
        //#endregion
    }
}
