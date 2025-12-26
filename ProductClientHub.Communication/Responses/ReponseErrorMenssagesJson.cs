namespace ProductClientHub.Communication.Responses
{
    public class ReponseErrorMenssagesJson
    {
        public List<string> Errors { get; private set; }
        public ReponseErrorMenssagesJson(string message)
        {
            Errors = [message];
        }

        public ReponseErrorMenssagesJson(List<string> messages)
        {
            Errors = messages;
        }
    }
}
