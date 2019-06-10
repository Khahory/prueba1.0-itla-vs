using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prueba1._0.Models
{
    public class Planificacion
    {
        [DisplayName("ID")]
        [Required]
        public int id { get; set; }

        [DisplayName("Grado")]
        [Required]
        public string grado { get; set; }

        [DisplayName("Fecha(inicio)")]
        [Required]
        public DateTime año { get; set; }

        [DisplayName("Fecha(final)")]
        [Required]
        public DateTime mes { get; set; }


        [DisplayName("Tiempo estimado")]
        [Required]
        public string tiempo { get; set; }

        [DisplayName("Situacion aprendizaje")]
        [Required]
        public string Situacion_aprendizaje { get; set; }

        [DisplayName("Competencias fundamentales")]
        [Required]
        public string competencias_fundamentales { get; set; }

        [DisplayName("Areas curriculares")]
        [Required]
        public string areas_curriculares { get; set; }

        [DisplayName("Estrategia enseñanza aprendizaje")]
        [Required]
        public string estrategia_enzeñanza_aprendizaje { get; set; }

        [DisplayName("Compentecias especificas")]
        [Required]
        public string competencias_especificas { get; set; }

        [DisplayName("Comprension escrita")]
        [Required]
        public string comprension_escrita { get; set; }

        [DisplayName("Contenido conceptual")]
        [Required]
        public string contenido_conceptual { get; set; }

        [DisplayName("Contenido precedimental")]
        [Required]
        public string contenido_procedimental { get; set; }

        [DisplayName("Contenido actitudinal")]
        [Required]
        public string contenido_actitudinal { get; set; }

        [DisplayName("Actividades prediseñandas")]
        [Required]
        public string actividades { get; set; }

        [DisplayName("Indicadores logros")]
        [Required]
        public string indicadores_logro { get; set; }

        [DisplayName("Recursos")]
        [Required]
        public string recursos { get; set; }

        [DisplayName("Evaluacion")]
        [Required]
        public string evaluacion { get; set; }

    }
}