using System;

Libro libro1 = new Libro();
libro1.Nombre = "Los Juegos del Hambre";
libro1.Autor = "Suzanne Collins";
libro1.Copias = 20;
libro1.Prestadas = 7;

Libro libro2 = new Libro();
libro2.Nombre = "Harry Potter y el prisionero de Azkaban";
libro2.Autor = "J.K.Rowling";
libro2.Copias = 42;
libro2.Prestadas = 10;

Libro libro3 = new Libro();
libro3.Nombre = "Locke & Key: Bienvenidos a Lovecraft";
libro3.Autor = "Joe Hill";
libro3.Copias = 17;
libro3.Prestadas = 4;

    libro1.prestar(6);
    Console.WriteLine(libro1.mostrar());

    libro1.devolver(9);
    Console.WriteLine(libro1.mostrar());

