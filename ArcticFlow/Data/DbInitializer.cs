using ArcticFlow.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcticFlow.Data
{
    public class DbInitializer
    {
        public static void Initialize(ArcticDataContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //if (context.Categorias.Any())
            //{
            //    return;  //O banco foi inicializado
            //}
            var arctics = new Arctic[]
            {
             new Arctic{Nome="Angelo",Telefone=21-96658-5201,DataNascimento=DateTime.Now,Email="angelo@gmail.com",Empresa="Banzai",DataCriacao=DateTime.Now,
                 Descricao ="Tatuador que curte dar rolê de Skate entre outros hobbies",FotoPerfil=""},
            };
            foreach (Arctic model in arctics)
            {
                context.Arctics.Add(model);
            }
            context.SaveChanges();


            var categoria = new Categoria[]
            {
             new Categoria{Nome="Tattoo", 
                 Descrição ="A tatuagem é uma das formas de modificação do corpo mais conhecidas e cultuadas do mundo. Trata-se de uma arte permanente feita na pele humana que, tecnicamente, consiste em uma aplicação subcutânea obtida através da introdução de pigmentos por agulhas."},
            new Categoria{Nome="Grafite", 
                 Descrição ="Um grafito ou grafite ou grafíti é uma inscrição feita em paredes, existentes desde o Império Romano. Considera-se grafite uma inscrição caligrafada ou um desenho pintado ou gravado sobre um suporte que não é normalmente previsto para esta finalidade."},
            new Categoria{Nome="Pintura",
                 Descrição ="A pintura refere-se genericamente à técnica de aplicar pigmento em forma pastosa, líquida ou em pó a uma superfície, a fim de colori-la, atribuindo-lhe matizes, tons e texturas. Em um sentido mais específico, é a arte de pintar uma superfície, tais como papel, tela, ou uma parede."},
            new Categoria{Nome="Skate", 
                 Descrição ="Skate, também denominado no Brasil por esqueitismo, ou esqueite é um esporte que consiste em deslizar sobre o solo e obstáculos equilibrando-se numa prancha, chamada também de esqueite ou skate, dotada de quatro pequenas rodas e dois eixos chamados de trucks."},
             };
            foreach (Categoria model in categoria)
            {
                context.Categorias.Add(model);
            }
            context.SaveChanges();



            var redesocial = new RedeSocial[]
            {
                new RedeSocial{Facebook="facebook.com",Site="https://kovokcrew.tumblr.com/",Telegram="21-9222-5988",Instagram="@angkvk",Twitter=null,Whatsapp="21-9222-5988",Youtube=null},
             };
            foreach (RedeSocial model in redesocial)
            {
                context.RedesSociais.Add(model);
            }
            context.SaveChanges();




         


        }
    }
}
