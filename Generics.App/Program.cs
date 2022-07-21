// See https://aka.ms/new-console-template for more information
using Generics.App.Repositories;
using Generics.App.Models;

Console.WriteLine("Hello, World!");

GenericRepository<Cat> CatgenericRepository = new GenericRepository<Cat>();
GenericRepository<Dog> DoggenericRepository = new GenericRepository<Dog>();

GenericRepository<string> TextgenericRepository = new GenericRepository<string>();

