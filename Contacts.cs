using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Contactos
{
    

    class Contact
    {
        public Contact(int id,string name,string lastname,string phone,string email,string address){
            Id  = id;
            Name = name;
            Lastname = lastname;
            Phone = phone;
            Email = email;
            Address = address;

        }
        public Contact(string name,string lastname,string phone,string email,string address){
            Name = name;
            Lastname = lastname;
            Phone = phone;
            Email = email;
            Address = address;

        }
        // Properties
        public string Name {get; set; }
        public string Lastname{get; set;}
        public string Phone{get; set;}
        public string Email{get; set;}
        public string Address{get; set;}
        public int Id{get; set;}

       
    }



}