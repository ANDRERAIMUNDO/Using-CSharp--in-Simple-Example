using SimpleAccountBank.Conts;
using SimpleAccountBank.Enum;
using System;

namespace SimpleAccountBank
{
    class Users
    {
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Users()
        {

        }

        public Users (DateTime dateTime, int id, int cpf, string name, DateTime birthDate)
        {
            DateTime = dateTime;
            Id = id;
            Cpf = cpf;
            Name = name;
            DateTime = birthDate;

        }
    }
}
