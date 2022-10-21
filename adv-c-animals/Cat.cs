namespace adv_c_animals;

public class Cat : Pet, Talkable
{
    private int mouseskilled;
    
    public Cat(int mouseskilled, string name) : base(name)
    {
        this.mouseskilled = mouseskilled;
    }

    public int GetMousesKilled()
    {
        return mouseskilled;
    }

    public void AddMouse()
    {
        mouseskilled++;
    }

    public virtual string talk()
    {
        return "Meow";
    }

    public virtual string GetName()
    {
        return "Cat: " + "name=" + Name + " mousesKilled=" + mouseskilled;
    }
}