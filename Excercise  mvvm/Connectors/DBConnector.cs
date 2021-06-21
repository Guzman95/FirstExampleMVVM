using Excercise__mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise__mvvm.Connectors
{
    public class DBConnector
    {
        public PersonaCollection listarPersonas()
        {
            PersonaCollection lista = new PersonaCollection();
            lista.Add(new Persona(1, "Yoshi"));
            lista.Add(new Persona(2, "Rayito"));
            lista.Add(new Persona(3, "Adriana"));
            lista.Add(new Persona(4, "Lizzie"));
            return lista;
        }

        internal Persona infoPersona()
        {
            throw new NotImplementedException();
        }
    }
}
