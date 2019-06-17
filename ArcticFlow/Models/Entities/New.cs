using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArcticFlow.Models.Entities
{
    public class New
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Titulo é obrigaório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Descricao é obrigaório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Corpo é obrigaório")]
        public string Corpo { get; set; }

        public string URLImage { get; set; }

        [Required(ErrorMessage = "Autor é obrigaório")]
        public string Autor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da matéria")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        public RedeSocial RedeSocial { get; set; }
        public Categoria Categoria { get; set; }
    }
}
