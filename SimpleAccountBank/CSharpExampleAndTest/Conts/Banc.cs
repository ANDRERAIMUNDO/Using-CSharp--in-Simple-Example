using SimpleAccountBank.Enum;
using System;

namespace SimpleAccountBank.Conts
{
    class Banc
    {
        public string Name { get; set; }
        public int Agency { get; set; }
        public int Account { get; set; }
        public int Digit { get; set; }
        public Enum_TypeAccount TypeAccount { get; set; }
        public Users Users = new Users();

        public Banc(Enum_TypeAccount typeAccount, string name, int agency, int account, int digit, DateTime dateTime, int id, int cpf, string nameAccount, DateTime birthDate)
        {
            Users.DateTime = dateTime;
            Users.Id = id;
            Users.Cpf = cpf;
            Users.Name = nameAccount;
            Users.BirthDate = birthDate;
            TypeAccount = typeAccount;
            Name = name;
            Agency = agency;
            Account = account;
        }
        public override string ToString()
        {
            return Users.DateTime
                + Name
                + Agency
                + Account
                + Digit
                + Users.Id
                + Users.Name
                + Users.Cpf
                + Users.BirthDate.ToString();
        }
    }
}
