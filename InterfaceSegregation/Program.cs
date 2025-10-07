namespace InterfaceSegregation.Before
{
    public class EntryPoint
    {
        // definition 
        // Clients should not be forced to depend on interfaces they do not use.
        // This principle is about creating specific and focused interfaces rather than large, general-purpose ones.
        // splits large intefaces to specific interface based on class needs 

        // there are relationsip between ISP and LSP
        // ISP Focuse on seperate intefaces in smaller interface 
        // LSP Focuse Inheritance 

        public static void Main()
        {
            BeforeApplyInterfaceSegregation();
            //            ??              //
            AfterApplyInterfaceSegregation();
        }

        static void BeforeApplyInterfaceSegregation()
        {
            var employees = InterfaceSegregation.Before.Repository.GenerateEmployees();
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.PrintSalarySlip());
                Console.WriteLine(new string('-', 50));
            }
        }

        // in this modul i seperate intitlment inteface in smaller interfaces 
        // each interface do specific tasks
        static void AfterApplyInterfaceSegregation()
        {
            var employees = InterfaceSegregation.After.Repository.GenerateEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.PrintSalarySlip());
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}