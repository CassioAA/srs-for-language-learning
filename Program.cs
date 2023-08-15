string frontContent = "";
string backContent = "";

Console.WriteLine("What does the front of the card say?");
    // null coalescing operator (x == null) ? y : x
frontContent = Console.ReadLine() ?? string.Empty;

Console.WriteLine("What does the back of the card say?");
backContent = Console.ReadLine() ?? string.Empty;

var card = new Card(frontContent, backContent);