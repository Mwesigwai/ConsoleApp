
System.Console.WriteLine("--------------------Isaac's work calender for every week-------------");
string[]day = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday",
 "Friday", "Saturday", "Sunday"};
 for (var i = 0; i < day.Length; i++) 
 {
    System.Console.Write(day[i]);
   switch (day[i])
   {
    case "Monday":
    System.Console.WriteLine("........Work");
    break;

    case "Tuesday":
    System.Console.WriteLine(".......Work");
    break;

    case "Wednesday":
    System.Console.WriteLine(".....Work");
    break;

    case "Thursday":
    System.Console.WriteLine("......Work");
    break;

    case "Friday":
    System.Console.WriteLine("........Work");
    break;

    case "Saturday":
    System.Console.WriteLine("......Out");
    break;

    case "Sunday":
    System.Console.WriteLine("........Church");
    break;
   }
   System.Console.WriteLine();
 }