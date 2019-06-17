using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArcticFlow.Models.Entities
{
    public class Arctic
    {
        public Arctic()
        {
            Categorias = new Collection<Categoria>();
        }

        public int ArcticID { get; set; }

        [Display(Description = "Nome do usuário")]
        public string Nome { get; set; }

        [Display(Description = "Email")]
        public string Email { get; set; }

        [Display(Description = "Telefone")]
        public int Telefone { get; set; }

        [Display(Description = "Endereço")]
        public int Endereco { get; set; }

        [Display(Description = "Empresa")]
        public string Empresa { get; set; }

        [Display(Description = "Foto Perfil")]
        public string FotoPerfil { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da matéria")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Display(Description = "Descrição")]
        public string Descricao { get; set; }


        public ICollection<Categoria> Categorias { get; set; }


        [Display(Description = "Rede Social")]
        public RedeSocial RedeSocial { get; set; }      

    }
}
