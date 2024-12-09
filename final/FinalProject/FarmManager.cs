public class FarmManager
{
    private List<FarmEntity> entities = new List<FarmEntity>();

    public void AddEntity(FarmEntity entity)
    {
        entities.Add(entity);
        Console.WriteLine($"{entity.Name} added to the farm.");
    }

    public void RemoveEntity(int id)
    {
        var entity = entities.Find(e => e.ID == id);
        if (entity != null)
        {
            entities.Remove(entity);
            Console.WriteLine($"{entity.Name} removed from the farm.");
        }
        else
        {
            Console.WriteLine($"Entity with ID {id} not found.");
        }
    }

    public void ViewAllEntities()
    {
        Console.WriteLine("Farm Entities:");
        foreach (var entity in entities)
        {
            entity.DisplayDetails();
            Console.WriteLine();
        }
    }
}