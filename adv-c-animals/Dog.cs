namespace adv_c_animals;

public class Dog : Pet, Talkable
{
    private bool friendly;
    
    public Dog(bool friendly, string name) : base(name)
    {
        this.friendly = friendly;
    }

    public bool IsFriendly()
    {
        return this.friendly;
    }

    public virtual string talk()
    {
        return "Bark";
    }

    public virtual string GetName()
    {
        return "Dog: " + "name=" + Name + " friendly=" + friendly;
    }
}