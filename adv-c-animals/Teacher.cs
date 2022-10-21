namespace adv_c_animals;

public class Teacher : Person, Talkable
{
    private int age;

    public Teacher(int age, string name) : base(name)
    {
        base.Equals(name);
        this.age = age;
    }

    public int GetAge()
    {
        return this.age;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
    
    public virtual string talk()
    {
        return "Don't forget to do the assigned reading!";
    }

    public virtual string GetName()
    {
        return "don't forget to do the assigned readings";
    }
}