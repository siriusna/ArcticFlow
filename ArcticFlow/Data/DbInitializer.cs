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



            var news = new New[]
            {
                new New{Autor="Renan Agues",Data=DateTime.Now.AddDays(-150),Titulo="A arte urbana ocupa, nos dias 15 e 16 de outubro, os jardins do Museu de Arte Moderna do Rio de Janeiro.",
                Descricao="O espaço também contará com uma mostra fotográfica de Marco Frossard e exposições de outros artistas da Homegrown",
                URLImage="https://scontent.fsdu6-1.fna.fbcdn.net/v/t1.0-9/60490526_2511569322209941_3846703625195749376_o.jpg?_nc_cat=104&_nc_eui2=AeFirxag3IGwU7vRCQQkYJ0tIfwznXW5OsiIjtHB0kLr1lVkPlx2zAKQfr6q3rs6aG7pM4jKHaAxN1Ys3GDbldu6cNMysVM3PI1lB50K9v_RTA&_nc_oc=AQnlN7V0H1UriK1w5qUMZO1MnbBaWN4v2Ze2tykRs2lndQux1Bk-1RDIgwCD5tX4Jmw&_nc_ht=scontent.fsdu6-1.fna&oh=14c5829150d5cae3f94a2bd4c2983f03&oe=5D95013BR",
                RedeSocial = new RedeSocial{ Site="http://visit.rio/evento/arte-core/", Facebook ="https://web.facebook.com/festivalartecore/", Instagram="@festivalartecore" , Youtube=null},
               // Categoria = new Categoria { Nome = 1},
                Corpo ="A quarta edição do Arte Core traz de arte urbana reunindo arte de rua, skate e música alternativa em dois dias com atividades que incluem shows, oficinas, debates, visitas guiadas e diferentes manifestações artísticas. O evento foi idealizado pela Homegrown, em parceria com a Agência Macro, também realizadores do projeto junto ao MAM Rio, Só Pedrada Musical, Coletivo XV e Rio Ramp Design. A programação é gratuita e a classificação é livre. No som, DJs de hip hop, música brasileira, afrobeat, jazz e shows. MC Marechal, DJ Saddam,Jesuton & ZedoRoque, DJ Negralha e DJ Marcelinho da Lua são alguns dos nomes que animam o festival.O espaço também contará com uma mostra fotográfica de Marco Frossard e exposições de outros artistas da Homegrown – Bruno Big, João Lelo, Marcio Swk, Marcelo Ment, Ronaldo Land e Izolag. Onio e Gabriel Mello Franco irão desenvolver uma ação interativa no Espaço Converse e Rafo Castro aplicará lambe lambes nos containers dos DJs."
                },
             };
            foreach (New model in news)
            {
                context.News.Add(model);
            }
            context.SaveChanges();




        }
    }
}
