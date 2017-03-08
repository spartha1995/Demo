using Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface ICatagory
    {

        IEnumerable<Catagory> GetAll();
        void CatagoryAdd(Catagory catagoryName);
        Catagory CatagoryFind(long key);
        void CatagoryUpdate(Catagory catagoryName);
        /// <summary>
        /// Find that catagory name is sanme or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns>boolean value</returns>
        // bool CatagoryNameExists(int id);
    }
}
