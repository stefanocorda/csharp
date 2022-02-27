using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Utente
    {
        // string id;
        // string nome;
        // string cognome;
        // int annoIscrizione;

        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public int AnnoIscrizione { get; set; }

        // public Utente(string id, string nome, string cognome, int annoIscrizione)
        // {
        //     Id = id;
        //     Nome = nome;
        //     Cognome = cognome;
        //     AnnoIscrizione = annoIscrizione;
        // }

        // public string Denominazione(){
        //     return nome + " " + cognome;
        // }

        public string Denominazione
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }
    }
}