// See https://aka.ms/new-console-template for more information
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Services;
using Examen.Infrastructure;

Console.WriteLine("Hello, World!");
Categorie categorie1= new Categorie();
Categorie categorie2= new Categorie();
categorie1.Nom = "Cosmetique";
categorie2.Nom = "alimentaire";
//ExamContext am = new ExamContext();
//am.Categorie.Add(categorie1);
//am.Categorie.Add(categorie2);
//am.SaveChanges();