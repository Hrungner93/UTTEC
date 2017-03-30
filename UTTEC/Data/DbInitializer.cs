using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTTEC.Models;

namespace UTTEC.Data
{
    public class DbInitializer
    {
        public static void Initialize(UTTECContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alumnos.Any())
            {
                return;
            }

            var alumnos = new Alumnos[]
            {
                new Alumnos{Matricula="2514160185",Nombre="Irving",AppPaterno="Mancera",AppMaterno="Robles"},
                new Alumnos{Matricula="2514160107",Nombre="Ana Belen",AppPaterno="Garcia",AppMaterno="Gonzalez"},
                new Alumnos{Matricula="2514160102",Nombre="Jesus Abraham",AppPaterno="Romero",AppMaterno="Cruz"},
                new Alumnos{Matricula="2514160103",Nombre="Juan",AppPaterno="Perez",AppMaterno="Jolote"},
                new Alumnos{Matricula="2514160174",Nombre="Omar Alejandro",AppPaterno="Hernandez",AppMaterno="Ramos"}
        };
            foreach(Alumnos a in alumnos)
            {
                context.Alumnos.Add(a);
            }
            context.SaveChanges();
        }
    }
}
