﻿namespace Biblioteca.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}