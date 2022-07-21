using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App.Repositories
{
    public class GenericRepository<T>
    {
        private List<T> mainList;

        //Method Constructor
        public GenericRepository()
        {
            mainList = new List<T>();
        }

        //Methods and Functions

        public void AddData(T obj)
        {
            mainList.Add(obj);
        }
    }
}
