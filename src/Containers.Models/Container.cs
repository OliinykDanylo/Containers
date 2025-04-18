namespace Containers.Models;

public class Container
{
    public int ID { get; set; }
    public int ContainerTypeID { get; set; }
    public bool IsHazaerdous { get; set; }
    public string ContainerName { get; set; }
}