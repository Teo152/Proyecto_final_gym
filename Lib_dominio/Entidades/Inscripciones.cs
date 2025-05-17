using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json; //me toco agregar este using para poder poner jsonIgnore en la clave foranea

namespace Lib_dominio.Entidades
{
    public class Inscripciones
    {
        public int id { get; set; }
        public int ? personas { get; set; }
        public int? estados_inscripciones {  get; set; }
        public int? planes_sedes { get; set; }

        public string? codigo { get; set; }

        public DateTime?  fecha_inscripcion { get; set; }

        public DateTime? fecha_vencimiento { get; set; }

        [ForeignKey("personas")][JsonIgnore] public Personas? _personas { get; set; } 
        [ForeignKey("planes_sedes")][JsonIgnore] public Planes_Sedes? _planes_sedes { get; set; }//agregro JsonIgnore para que al momento de ejecutar en el postman no me salga
                                                                                                 //un atributo "_Planes_sedes":null ya con eso lo arreglo y no me sale  hago lo mismo en todas las foraneas

        [ForeignKey("estados_inscripciones")][JsonIgnore] public Estados_Inscripciones? _estados_inscripciones { get; set; }



    }
}
