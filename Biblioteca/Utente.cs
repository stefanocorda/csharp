using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Utente
    {
        string id;
        string nome;
        string cognome;
        int annoIscrizione;

        public Utente(string id, string nome, string cognome, int annoIscrizione){
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.annoIscrizione = annoIscrizione;
        }

        public string Denominazione(){
            return nome + " " + cognome;
        }
    }
}