namespace adv_c_animals;

public abstract class Person
{
    public string Name { get; internal set; }

    public Person(string name)
    {
        this.Name = name;
    }
}