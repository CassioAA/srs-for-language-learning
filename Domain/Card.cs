using System.Collections.Generic;

public class Card
{

    public string FrontContent { get; private set; } = "";
    public string BackContent { get; private set; } = "";
    public DateOnly CreatedDate { get; }
    private readonly ContentValidator _contentValidator = new ContentValidator();
    
    public Card(string frontContent, string backContent) {

        this.SetFrontContent(frontContent);
        this.SetBackContent(backContent);
        CreatedDate = DateOnly.FromDateTime(DateTime.Now);

    }

    public void SetFrontContent(string content) {

        if(_contentValidator.IsValid(content)) {
            FrontContent = content;
        } 

    }

    public void SetBackContent(string content) {

        if(_contentValidator.IsValid(content)) {
            BackContent = content;
        } 

    }

}