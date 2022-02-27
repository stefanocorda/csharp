using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        //     string id;
        //     string titolo;
        //     string autore;
        //     Utente? utente;

        public string Id { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public Utente? Utente { get; set; }

        public Libro(string id, string titolo, string autore)
        {
            Id = id;
            Titolo = titolo;
            Autore = autore;
            Utente = null;
        }

        public string Descrizione()
        {
            return Titolo + " di " + Autore;
        }

        public void Prestito(Utente utente)
        {
            if (Utente != null)
            {
                Console.WriteLine($"---> Il libro {Descrizione()} è già assegnato all'utente {this.Utente.Denominazione}");
            }
            else
            {
                Console.WriteLine($"---> Il libro {Descrizione()} è preso in presito dall'utente {utente.Denominazione}");
                Utente = utente;
            }
        }

        public void Restituzione()
        {
            Console.WriteLine($"---> L'utente {Utente!.Denominazione} ha restituito il libro {Descrizione()}");
            Utente = null;
        }
    }
}