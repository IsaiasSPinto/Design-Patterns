namespace Design_Patterns;

public class User
{
  public string Name { get; set; }
  public int Age { get; set; }
  public override string ToString() => $"Name: {Name}, Age: {Age}";
}
