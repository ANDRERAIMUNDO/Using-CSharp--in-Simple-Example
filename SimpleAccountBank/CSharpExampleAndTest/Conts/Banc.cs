using System;

namespace SimpleAccountBank.Conts
{
    class Banc
    {
        public string Name { get; set; }
        public int Agency { get; set; }
        public int Account { get; set; }

        public Users Users = new Users();

        public Banc(string name, int agency, int account, DateTime dateTime, int id, int cpf, string nameAccount, DateTime birthDate)
        {
            Users.DateTime = dateTime;
            Users.Id = id;
            Users.Cpf = cpf;
            Users.Name = nameAccount;
            Users.BirthDate = birthDate;
            Name = name;
            Agency = agency;
            Account = account;
        }
        public override string ToString()
        {
            return Users.DateTime
                + " Agency: "
                + Agency
                + " Account: "
                + Account
                +" Id: "
                + Users.Id
                +" Client: "
                + Users.Name
                + " CPF: "
                + Users.Cpf
                + " Birth Datte"
                + Users.BirthDate.ToString();
        }
    }
}
