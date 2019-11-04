using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string nome;    //variabili di casse
        public string cognome;
        public int eta;
        public string sesso;
        public int altezzacm;
        public double peso;
        public Person(string nome, string cognome) //firma del metodo (costruttore)
        {
            this.nome = nome;   //la variabile di classe viene associata alla variabile di costruttore
            this.cognome = cognome;
            this.sesso = "sconosciuto";
        }
        public Person(string nome) //altro costruttore
        {
        }
        public Person() //costruttore vuoto
        {
        }

        public string Anagrafica()
        {
            string anagrafica = this.nome + " " + this.cognome;
            return anagrafica;
        }
    }
}
