public class PromptGenerator
{   
    List<string> _prompts = new List<string>();
    Random randomGenerator = new Random();

    public PromptGenerator()
    {
        _prompts.Add("¿Cuál fue la mejor parte de mi día?");
        _prompts.Add("¿Cuál fue la parte más desafiante de mi día?");
        _prompts.Add("¿Por qué estoy agradecido hoy?");
        _prompts.Add("¿Qué aprendí hoy?");
        _prompts.Add("¿Cómo tuve un impacto positivo hoy?");
        _prompts.Add("¿Qué podría haber hecho mejor hoy?");
        _prompts.Add("¿Qué me hizo sonreír hoy?");
        _prompts.Add("¿Cuál es una meta que tengo para mañana?");
        _prompts.Add("¿Qué cosa nueva intenté hoy?");
        _prompts.Add("¿Qué quiero recordar sobre hoy?");
    }

    public string getPrompt()
    {
        int indexPrompt = randomGenerator.Next(0, _prompts.Count);
        string prompt = (_prompts[indexPrompt]);
        return prompt;
    }
}