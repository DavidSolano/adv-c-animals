namespace adv_c_animals;

public abstract class Pet
{
    public string Name { get; internal set; }

    public Pet(string name)
    {
        this.Name = name;
    }
    
}