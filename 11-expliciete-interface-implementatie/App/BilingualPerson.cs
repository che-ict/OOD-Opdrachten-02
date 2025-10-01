namespace App;

public class BilingualPerson : IEnglishSpeaker, IFrenchSpeaker
{
    string IEnglishSpeaker.Greet() => "Hello!";
    string IFrenchSpeaker.Greet() => "Bonjour!";
}
