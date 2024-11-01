﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

using Contactos;


Console.WriteLine("Mi Agenda Perrón");

Console.WriteLine("Bienvenido a tu lista de contactes");
List<Contact> contacts = new List<Contact>();


bool running = true;
while (running)
{

    Console.Write("1. Agregar Contacto      ");
    Console.Write("2. Ver Contactos     ");
    Console.Write("3. Buscar Contactos      ");
    Console.Write("4. Modificar Contacto        ");
    Console.Write("5. Eliminar Contacto     ");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddContact(contacts);
            break;
        case 2:
            ViewContacts(contacts);
            break;
        case 3: //esto es intencional, no importa el orden en que pongan los cases, pero, traten de ser siempre lo mas ordenados posible
                // Comentario de Angel (De todas maneras dejare el comentario y lo organizare para mejor legibilidad)
            SearchContact(contacts);
            break;
        case 4:
            EditContact(contacts);
            break;
        case 5:
            DeleteContact(contacts);
            break;
        case 6:
            running = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
}

static void AddContact(List<Contact> contacts)
{
    int id = contacts.Count + 1;
    
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
     Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el correo electronico de la persona");
    string email = Console.ReadLine();
   
    
    try{
            
        contacts.Add(new Contact(id,name,lastname,phone,email,address));
        
            
    }catch(NullReferenceException ex){
        Console.WriteLine(ex.Message);
        Console.WriteLine("Porfavor intentelo de nuevo");
    }catch(Exception ex){
        Console.WriteLine(ex.Message);
    }
    finally{
    Console.WriteLine("Perfecto!!, si desea ver los cambios dirijase a la parte de Ver (opcion 2) o buscar directamente el contacto modificado (opcion 3)");
    }

}

static void ViewContacts(List<Contact> contacts)
{
    Console.WriteLine("Id           Nombre          Apellido           Telefono            Email           Dirección");
    Console.WriteLine("______________________________________________________________________________________");

    foreach (var item in contacts)  
    {
         
        Console.WriteLine($"{item.Id}           {item.Name}           {item.Lastname}           {item.Phone}           {item.Email}           {item.Address}");
        
    }
}

static void EditContact(List<Contact> contacts){
    
    try{
    Console.WriteLine("Digite un  Id de Contacto Para Editar");
    int id = Convert.ToInt32(Console.ReadLine());


        if ((id == 0) && contacts.Contains(contacts[id])){
            contacts.RemoveAt(id);

            Console.WriteLine("Digite el nombre de la persona");
            string name = Console.ReadLine();
            Console.WriteLine("Digite el apellido de la persona");
            string lastname = Console.ReadLine();
            Console.WriteLine("Digite el telefono de la persona");
            string phone = Console.ReadLine();
            Console.WriteLine("Digite la dirección");
            string address = Console.ReadLine();
            Console.WriteLine("Digite el correo electronico de la persona");
            string email = Console.ReadLine();

            contacts.Add(new Contact(id,name,lastname,phone,email,address));


        }else if (id >= 1 && contacts.Contains(contacts[id - 1])){
            
            contacts.RemoveAt(id - 1);
            
            Console.WriteLine("Digite el nombre de la persona");
            string name = Console.ReadLine();
            Console.WriteLine("Digite el apellido de la persona");
            string lastname = Console.ReadLine();
            Console.WriteLine("Digite el telefono de la persona");
            string phone = Console.ReadLine();
            Console.WriteLine("Digite la dirección");
            string address = Console.ReadLine();
            Console.WriteLine("Digite el correo electronico de la persona");
            string email = Console.ReadLine();

            contacts.Add(new Contact(id,name,lastname,phone,email,address));
            
        }else{

            Console.WriteLine($"Disculpa pero este contacto no existe o no tiene ese ID {id}");
            
        }
    }catch(NullReferenceException ex){
            Console.WriteLine(ex.Message);
            Console.WriteLine("Porfavor intentelo de nuevo");
    }catch(Exception ex){
            Console.WriteLine(ex.Message);
            Console.WriteLine("Porfavor intentelo de nuevo");
    }
    finally{
    Console.WriteLine(@"Perfecto!!, si desea ver los cambios dirijase a la parte de Ver (opcion 2) o buscar directamente el contacto modificado (opcion 3)
    
    ");
    }
}

    

static void DeleteContact(List<Contact> contacts)
{
    Console.WriteLine("Digite un Id de Contacto del cual desea eliminar");
    int id = Convert.ToInt32(Console.ReadLine());
    if (id == 0){
    contacts.RemoveAt(id);
    }else{
    contacts.RemoveAt(id - 1);

    }
    Console.WriteLine("Este contacto ha sido eliminado correctamente");
}

static void SearchContact(List<Contact> contacts)
{

    Console.WriteLine("Digite un Id de Contacto Para Mostrar");
    int id = Convert.ToInt32(Console.ReadLine());
    
    
        Console.WriteLine("Id           Nombre          Apellido           Telefono            Email           Dirección");
        Console.WriteLine("______________________________________________________________________________________");
        Console.WriteLine($"{contacts[id - 1].Id}    {contacts[id - 1].Name}    {contacts[id - 1].Lastname}       {contacts[id - 1].Phone}      {contacts[id - 1].Email}     {contacts[id - 1].Address}");

}