using System;

namespace Test.Entity
{
    public class library
    {
        private int id;
        private string Artista;
        private string Cancion;
        private string Album;
        private string Descripcion;
        private DateTime Fecha_Creacion;
        private DateTime? FechaModifica;
        private string Path_photo;

        public int Id { get => id; set => id = value; }
        public string Cancion1 { get => Cancion; set => Cancion = value; }
        public string Artista1{ get => Artista; set => Artista = value; }
        public string Album1 { get => Album; set => Album = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public DateTime Fecha_Creacion1 { get => Fecha_Creacion; set => Fecha_Creacion = value; }
        public DateTime? FechaModifica1 { get => FechaModifica; set => FechaModifica = value; }
        public string Path_photo1 { get => Path_photo; set => Path_photo = value; }
    }
}
