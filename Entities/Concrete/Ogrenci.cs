using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;

namespace Entities.Concrete
{ 
    public class Ogrenci : IEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int OgrId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DgTarih { get; set; }

        public string Cinsiyet { get; set; }

        public string Sinif { get; set; }

        public int Puan { get; set; }

    }
}
