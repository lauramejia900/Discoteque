namespace Discoteque.Data.Models;

public class Artist: BaseEntity<int> //Herencia del atributo de la clase BaseEntity
{
    public string Name { get; set; } = ""; //Desactiva el warning del null
    public string Label { get; set; } = "";
    public bool IsOnTour { get; set; }

}