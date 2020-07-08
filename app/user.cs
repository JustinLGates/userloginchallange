namespace userchallange.app
{
  public class user
  {
    public string Name { get; set; }
    public string Password { get; set; }

    public user(string name, string password)
    {
      Name = name;
      Password = password;
    }
  }
}