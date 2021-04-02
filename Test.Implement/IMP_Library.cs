using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity;
using Test.Facade;
namespace Test.Implement
{
    public class IMP_Library : ILibrary
    {
        List<library> librerias = new List<library>
        {
            new library{ Id=1,Artista1="Los Fabulosos Cadilacs",Album1="Los Fabuloso",Cancion1="Matador",Descripcion1="",Path_photo1="~/Img/cadi.jpg"},
            new library{ Id=2,Artista1="Los Fabulosos Cadilacs",Album1="Los Fabuloso",Cancion1="Mal Bicho",Descripcion1="",Path_photo1="~/Img/cadi.jpg"},
            new library{ Id=3,Artista1="Mana",Album1="Revolucion de Amor",Cancion1="Angel de Amor",Descripcion1="",Path_photo1="~/Img/mana.jpg"},
            new library{ Id=4,Artista1="Mana",Album1="Revolucion de Amor",Cancion1="Fe",Descripcion1="",Path_photo1="~/Img/mana.jpg"}
        };
        public library getbyName(string name)
        {

            throw new NotImplementedException();
        }

        public List<library> libraries()
        {
            return librerias;
        }
    }
}
