using System;

namespace Lab3
{
    // Ֆիլմի ժանրերը (1-ից 5)
    public enum Genre
    {
        Action = 1,
        Comedy = 2,
        Drama = 3,
        Horror = 4,
        SciFi = 5
    }

    public class Movie
    {
        public int Id;
        public string Name = "";
        public int Year;
        public Genre Genre;
        public long Views;
        public long Likes;

        // Մուտքային տողը տարանջատում (split) ենք և լրացնում դաշտերը
        // Ձևաչափ: Id, Name, Year, Genre(1-5), Views, Likes
        public void Parse(string line)
        {
            string[] parts = line.Split(',');
            Id = int.Parse(parts[0].Trim());
            Name = parts[1].Trim();
            Year = int.Parse(parts[2].Trim());
            Genre = (Genre)int.Parse(parts[3].Trim());
            Views = long.Parse(parts[4].Trim());
            Likes = long.Parse(parts[5].Trim());
        }

        // Ռեյտինգ = SQRT(Likes^2 / Views)
        public double GetRating()
        {
            if (Views == 0) return 0;
            return Math.Sqrt(Math.Pow(Likes, 2) / Views);
        }

        // Ժանրի տեքստային անվանումը՝ switch-ով
        public string GetGenreName()
        {
            switch (Genre)
            {
                case Genre.Action: return "Action";
                case Genre.Comedy: return "Comedy";
                case Genre.Drama:  return "Drama";
                case Genre.Horror: return "Horror";
                case Genre.SciFi:  return "Sci-Fi";
                default:           return "Unknown";
            }
        }

        public override string ToString()
        {
            string year = $"({Year})";
            // Id: 4 աջ | Name: 15 ձախ | Year: 8 ձախ | Genre: 12 ձախ | Rating: 8, 3 նիշ ստորակետից հետո
            return $"{Id,4} {Name,-15} {year,-8} {GetGenreName(),-12} {GetRating(),8:F3}";
        }
    }
}
