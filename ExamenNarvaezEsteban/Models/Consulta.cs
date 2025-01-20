using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ExamenNarvaezEsteban.Models
{

    [Table("Consulta")]
    public class Consulta
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Nombre { get; set; }
        public string Region { get; set; }
        public string link { get; set; }

    }
}
