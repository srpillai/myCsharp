﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public EventType Type { get; set; }

        public int Id { get; set; }

        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        public Event()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
