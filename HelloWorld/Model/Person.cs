using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person        //classe: contiene i metodi costruttori e logici dell'oggetto Person
    {
        public string nome;     //variabili di classe
        public string cognome;
        public int eta;
        public string sesso;
        public int altezzacm;
        public double peso;
        public double bmi;
        public Person(string nome, string cognome)      //metodo costruttore (genera un oggetto)(richiede 2 variabili input)
        {
            this.nome = nome;       //la variabile di classe(this.) viene associata alla variabile di costruttore
            this.cognome = cognome;
            this.sesso = "sconosciuto";     //la variabile sesso non è richiesta in questo costruttore
        }
        //overloading costruttori con la stessa firma (Person)
        public Person(string nome)      //altro costruttore metodo diverso (richiede 1 sola variabile input)
        {
        }
        public Person()     //costruttore vuoto (non richiede input)
        {
        }
        public Person(string nome, string cognome, int altezzacm, double peso)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.altezzacm = altezzacm;
            this.peso = peso;
        }
        public string Anagrafica()      //metodo che rilascia una stringa nel main
        {
            double altezza = (double)altezzacm / 100;       //senza (double) la variabile verrebbe forzata a int
            string anagrafica;// = this.nome + " " + this.cognome + " " + bmi;
            if (BMI() < 0)
            {
                anagrafica = this.nome + " " + this.cognome + " " + "BMI non disponibile";
                return anagrafica;
            }
            else
            {
                anagrafica = this.nome + " " + this.cognome + " " + BMI();
                return anagrafica;
            }
        }
        public double BMI()
        {
            if (this.altezzacm != 0 && this.peso != 0)
            {
                double altezza = (double)altezzacm / 100;       //senza (double) la variabile verrebbe forzata a int
                double bmi = this.peso / Math.Pow(altezza, 2);
                return bmi;
            }
            else
                return -1;
        }
    }
}
