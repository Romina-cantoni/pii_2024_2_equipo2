namespace Library;

public class Type
{
    public string Name { get; set; }

    public Type(string name)
    {
        this.Name = name;
    }

    public float AttackEffectivity(Attack attack, Type type)
    {
        if (attack.AType == Water)
        {
            if (type == Fire)
            {
                attack.Damage = attack.Damage * 2;
            }
            if (type == Grass)
            {
                attack.Damage = attack.Damage / 2;
            }
        }
        
        if (attack.AType == Fire)
        {
            if (type == Grass)
            {
                attack.Damage = attack.Damage * 2;
            }
            if (type == Water)
            {
                attack.Damage = attack.Damage / 2;
            }
        }
        
        if (attack.AType == Grass)
        {
            if (type == Water)
            {
                attack.Damage = attack.Damage * 2;
            }
            if (type == Fire)
            {
                attack.Damage = attack.Damage / 2;
            }
        }

        return attack.Damage;
    }
}