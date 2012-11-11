namespace Backlog.Stories
{
    public class Story
    {
        public int Id { get; set; }

        public int Rank { get; set; }

        public int Points { get; set; }

        public StoryState State { get; set; }

        public string Text { get; set; }
    }
}