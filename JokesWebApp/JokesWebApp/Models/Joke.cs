namespace JokesWebApp.Models
{
    public class Joke
    {
        //so now we finna make a property forr this object
        //first one will be the ID forr the joke
        public int Id { get; set; }
        public string JokeQuestions { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {
            
        }
    }
}
