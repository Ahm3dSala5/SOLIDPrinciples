namespace InterfaceSegregation.Before
{
    public static class Repository
    {
        public static List<Employee> GenerateEmployees()
        {

            return new List<Employee>()
            {
                new Staff()
                {
                    Id = 1,
                    Name = "Ahmed Salah",
                    Salary = 40000
                },
                new Staff()
                {
                    Id = 2,
                    Name = "John Doe",
                    Salary = 50000
                },
                new Staff()
                {
                    Id = 3,
                    Name = "Nada Tarek",
                    Salary = 5930
                },
                new Consultant()
                {
                    Id = 4,
                    Name = "Jane Smith",
                    Salary = 60000
                },
                new Consultant()
                {
                    Id = 5,
                    Name = "Ali Ahmed",
                    Salary = 45000
                },
                new DayLabourer()
                {
                    Id = 6,
                    Name = "Sara Ali",
                    Salary = 30000
                },
                new DayLabourer()
                {
                    Id = 7,
                    Name = "Omar Hassan",
                    Salary = 35000
                },
                new DayLabourer()
                {
                     Id = 8,
                    Name = "Marwa Hassan",
                    Salary = 250900
                }
            };
        }
    }
}
