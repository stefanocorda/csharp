using Biblioteca;

// Utente utente1 = new Utente("Cod_1", "Mario", "Rossi", 2010);
Utente utente1 = new Utente() {Id = "Cod_1", Nome = "Mario", Cognome = "Rossi", AnnoIscrizione = 2010};

Console.WriteLine(utente1.Denominazione);

// Utente utente2 = new Utente("Cod_2", "Sara", "Bianchi", 2015);
Utente utente2 = new Utente() {Id = "Cod_2", Nome = "Sara", Cognome = "Bianchi", AnnoIscrizione = 2015};
Console.WriteLine(utente2.Denominazione);

Libro libro1 = new Libro("Lib_001", "Il tramonto", "Smith");
Console.WriteLine(libro1.Descrizione());

libro1.Prestito(utente1);
libro1.Prestito(utente2);
libro1.Restituzione();
libro1.Prestito(utente2);

