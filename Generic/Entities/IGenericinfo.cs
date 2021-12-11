using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior<T>(T obj);

    }//IGenericBehavior Interface

}//NameSpace
