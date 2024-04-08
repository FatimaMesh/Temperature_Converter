class ConvertTemperature{

    public static void Main(string[] args)
    {
        Console.WriteLine("==============================");
        Console.WriteLine("** Convert Temperature **");
        Console.WriteLine("==============================");
        do{
        Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:"); 
        string input = Console.ReadLine() ?? "";
        if(input.ToLower() == "quit"){
            Console.WriteLine("Program terminated");
            break;
        }
        try{
            CheckResult(input);
        }catch(Exception){
            Console.WriteLine("Invalid input. Please enter a numeric temperature");
        }
        Console.WriteLine("================================");
        }while(true);
    }
    public static void CheckResult(string input){
        string[] inputPairs = input.Split(" ");
        double amount =double.Parse(inputPairs[0]);
        string unit =inputPairs[1].ToUpper();
        if(TempConvert(amount, unit) != "wrong input"){
            Console.WriteLine($"Converted: {amount} {unit} = "+TempConvert(amount, unit));
        }else{
            Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit");
        }
    }    
    public static string TempConvert(double amount,string unit){
        switch(unit){
            case "C":      
            return $"{CheckInteger(amount * 9 / 5 + 32)} °F";;
            case "F":
            return $"{CheckInteger((amount - 32) * 5 / 9)} °C ";    
            default:
            return "wrong input";
        }
    }

    //Function to avoid .00 if it is integer 
    public static string CheckInteger(double result){
        if (result % 1 == 0){
        result = (int)result;
        }
        else
        {
        result = Math.Round(result, 2);
        }
    return ""+result;
    }
}
