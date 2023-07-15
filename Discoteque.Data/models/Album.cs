namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>
{
    public  string Name { get; set; } = "";
    public int Year { get; set; }
    public Genres Genre { get; set; } = Genres.Unknown;

}

public enum Genres { //descriptor para un grupo de valores que son constantes
    Rock,
    Metal,
    Salsa,
    Merengue,
    Urban,
    Folk,
    Indie,
    Techno,
    Vallenato,
    Unknown
}

