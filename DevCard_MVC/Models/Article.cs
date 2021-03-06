namespace DevCard_MVC.Models
{
    public class Article
    {
        #region constructor

        public Article(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }

        #endregion

        #region properties

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        #endregion
    }
}