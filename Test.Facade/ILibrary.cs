using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity;
namespace Test.Facade
{
    public interface ILibrary
    {
        List<library> libraries();
        library getbyName(string name);
    }
}
