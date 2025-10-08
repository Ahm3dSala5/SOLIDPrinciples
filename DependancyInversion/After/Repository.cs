namespace DependancyInversion.After
{
    public static class Repository
    {
        public static List<Client> GenerateClients =>
          new List<Client>()
          {
             new Client { Id = 1, Name = "Ahmed",    Email = "ahmed@gmail.com",    PhoneNO = "01012345678" },
             new Client { Id = 2, Name = "Sara",     Email = "sara@gmail.com",     PhoneNO = "01098765432" },
             new Client { Id = 3, Name = "Mohamed",  Email = "mohamed@gmail.com",  PhoneNO = "01123456789" },
             new Client { Id = 4, Name = "Laila",    Email = "laila@gmail.com",    PhoneNO = "01234567890" },
             new Client { Id = 5, Name = "Omar",     Email = "omar@gmail.com",     PhoneNO = "01087654321" },
             new Client { Id = 6, Name = "Nour",     Email = "nour@gmail.com",     PhoneNO = "01198765432" }
          };
    }
}
