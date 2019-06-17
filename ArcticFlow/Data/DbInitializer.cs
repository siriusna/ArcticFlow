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
            context.Database.EnsureCreated();
            // procura por qualquer Exame
            //if (context.Arctics.Any())
            //{
            //    return;  //O banco foi inicializado
            //}
            //var arctics = new Arctic[]
            //{
            // new Exame{Nome="Glicemia",Descricao="Fica dez dias sem beber água", Especialidade="Laboratorial",Valor=20},
            // new Exame{Nome="Hemograma",Especialidade="Laboratorial",Valor=100},
            // new Exame{Nome="Ureia e creatinina",Especialidade="Laboratorial",Valor=450},
            // new Exame{Nome="Ácido úrico",Especialidade="Laboratorial",Valor=410},
            // new Exame{Nome="Triglicerídeos",Especialidade="Laboratorial",Valor=96},
            // new Exame{Nome="TSH e T4 livre",Especialidade="Laboratorial",Valor=33}
            //};
            //foreach (Arctic s in arctics)
            //{
            //    context.Arctic.Add(s);
            //}
            //context.SaveChanges();


            //var paciente = new Paciente[]
            //{
            // new Paciente{Nome="Sirius Roberto",Telefone="21-98286-8571",Email="sirius@sirius.com"},
            // new Paciente{Nome="Jorge Eduardo",Telefone="21-99850-4054",Email="jorge@jorge.com"},
            // new Paciente{Nome="Ruben Moraes",Telefone="21-98116-0070",Email="ruben@ruben.com"},
            // new Paciente{Nome="Victor Hugo",Telefone="21-98200-7577",Email="victor@victor.com"}
            //};
            //foreach (Paciente s in paciente)
            //{
            //    context.Paciente.Add(s);
            //}
            //context.SaveChanges();


            //var laboratorio = new Laboratorio[]
            //{
            // new Laboratorio{Nome="Diagnóstica Leopoldinense", Endereco="R. Uranos, 1189" },
            // new Laboratorio{Nome="Laboratório de Patologia Clínica Pasteur", Endereco="R. Monsenhor Alves Rocha, 140 "}
            //};
            //foreach (Laboratorio s in laboratorio)
            //{
            //    context.Laboratorio.Add(s);
            //}
            //context.SaveChanges();
        }
    }
}
