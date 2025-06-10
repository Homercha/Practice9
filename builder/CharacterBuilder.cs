public class CharacterBuilder
{
    private Character character = new Character();

    public CharacterBuilder SetStrength(int strength)
    {
        character.Strength = strength;
        return this;
    }
    public CharacterBuilder SetAgility(int agility)
    {
        character.Agility = agility;
        return this;
    }
    public CharacterBuilder SetIntelligence(int intelligence)
    {
        character.Intelligence = intelligence;
        return this;
    }
    public Character Build() => character;
}
