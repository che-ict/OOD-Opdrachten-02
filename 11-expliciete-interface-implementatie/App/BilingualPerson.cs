namespace App;

public class BilingualPerson : IEnglishSpeaker, IFrenchSpeaker
{
    string IEnglishSpeaker.Greet()
    {
        // TODO: Implement the English Greet method
        throw new NotImplementedException();
    }

    string IFrenchSpeaker.Greet()
    {
        // TODO: Implement the French Greet method
        throw new NotImplementedException();
    }
}
