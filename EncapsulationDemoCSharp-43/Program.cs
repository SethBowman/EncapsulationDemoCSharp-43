using EncapsulationDemoCSharp_43;

var seth = new Person();

seth.Name = "Seth";
seth.Age = 29;

seth.AddMoney(20.00);

var currentMoney = seth.CheckWallet();

Console.WriteLine(currentMoney);

seth.AddMoney(500.00);

currentMoney = seth.CheckWallet();

Console.WriteLine(currentMoney);

