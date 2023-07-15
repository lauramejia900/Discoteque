namespace Discoteque.Data.Models;

public class BaseEntity<TId> where TId: struct //una clase de .net basic nombre, tipo inferenciado generico, struct componente para data, referencia data
{
    public TId id {get; set;}

}