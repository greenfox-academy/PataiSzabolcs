﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Greeting
    {
        public long Id { get; set; } = 1;
        public string Content { get; set; } = "Helllo!!";
        private static long Counter;
        public string[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};
        public Random random = new Random();

        public Greeting()
        {

        }

        public Greeting(long id, string content)
        {
            Id = id;
            Content = content;
        }

        public Greeting(string name)
        {
            Id = Counter + 1;
            Content = $"Hello {name}!";
            Counter++;
        }
    }
}
