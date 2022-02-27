using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        string id;
        string titolo;
        string autore;
        Utente? utente;

        public Libro(string id, string titolo, string autore){
            this.id = id;
            this.titolo = titolo;
            this.autore = autore;
            this.utente = null;
        }

        public string Descrizione(){
            return titolo + " di " + autore;
        }

        public void Prestito(Utente utente){
            if (this.utente != null) {
                Console.WriteLine($"---> Il libro {Descrizione()} è già assegnato all'utente {this.utente.Denominazione()}");
            } else {
                Console.WriteLine($"---> Il libro {Descrizione()} è preso in presito dall'utente {utente.Denominazione()}");
                this.utente = utente;
            }
        }

        public void Restituzione(){
            Console.WriteLine($"---> L'utente {utente.Denominazione()} ha restituito il libro {Descrizione()}");
            utente = null;
        }
    }
}