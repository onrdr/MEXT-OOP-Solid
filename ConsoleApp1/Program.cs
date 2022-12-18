using Business;
using DataAccess.Concrete; 
using Entities.Concrete;
 
// 4 Pillars of OOP => Abstraction, Encapsulation, Polymorphism, Interface

/*
 SOLID
 Single Responsibility : Every class should do just one thing
 Open - Closed Principle : Open to extension, close for modification 
 Liskov substitution : 
 Interface Segregation : 
 Depenceny Inversion : Bağımlılıkları ters çevirme
 */

// Seperation of Concerns
// Depend on abstractions, not on concretions

/*
--- C#
--- SQL 
--- SOLID
--- Dependency Injection, 
--- Entity Framework
--- MVC
--- Web API
--- Asp Net Core Identity API
 */

var ahmet = new Student("1", "Ahmet", "Yıldız", "Bursa");
var onur = new Worker("2", "Onur", "Derman", "Istanbul");
var samed = new Customer("3", "Samed", "Musabaşoğlu", "Ankara");
var şeyma = new Customer("4", "Şeyma", "Canbaz", "Ankara");

var dbService = new DatabaseCrudManager(new MySql());

dbService.AddToDb(samed);

dbService.UpdateInDb(onur);

dbService.DeleteFromDb(ahmet);

dbService.AddToDb(şeyma);


Console.ReadLine();
 


 



