string? sentence = "";

do {

    Console.WriteLine("What does the front of the card say?");

    sentence = Console.ReadLine();

} while(!IsValid(sentence));

Console.WriteLine(sentence);

bool IsValid(string? sentence) {

    if (string.IsNullOrWhiteSpace(sentence)) {

        Console.WriteLine("The front of the card can't be empty.");
        Console.WriteLine();
        
        return false;

    }

    return true;
    
}