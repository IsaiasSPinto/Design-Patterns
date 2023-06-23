using System.Reflection.Metadata;

namespace Design_Patterns;

public class DbClassic
{
  private static DbClassic _instance;
  private List<User> Users = new List<User>();
  private DbClassic() { }

  public static DbClassic GetInstance()
  {
    if (_instance == null)
      _instance = new DbClassic();

    return _instance;
  }

  public void Add(User user) => Users.Add(user);
  public void Remove(int id) => Users.RemoveAt(id);

  public void Show()
  {
    foreach (var user in Users)
      Console.WriteLine(user.ToString());
  }
}
