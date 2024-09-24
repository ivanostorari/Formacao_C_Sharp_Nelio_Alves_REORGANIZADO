﻿using System;
using System.Collections.Generic;
using System.Text;


namespace CursoNelioAula1510.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client client)) 
            {
                return false;
            }

            Client other = obj as Client;
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
