namespace MazeApi.Models
{
    public class MazeDataItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
    }
}
