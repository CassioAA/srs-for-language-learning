/*
    It could be static, but it wouldn't be 
    able to be part of an automated test
*/
public class ContentValidator
{
    private readonly int maxContentLength = 40;
    private readonly int minContentLength = 2;

    public bool IsValid(string content)
    {
        
        if (content.Length > maxContentLength) {
            
            Console.WriteLine($"Content cannot be larger than {maxContentLength}");
            return false;

        }

        if (content.Length < minContentLength) {
            
            Console.WriteLine($"Content cannot be shorter than {minContentLength}");
            return false;

        }

        return true;

    }
}