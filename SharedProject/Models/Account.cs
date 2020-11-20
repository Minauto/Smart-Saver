using SmartSaver;
using System.ComponentModel;


public class Account
{
    public string Nickname { get; set; }

    public string Name { get; set; }
    public int UserId { get; set; }

    public int Limit { get; set; }

    public Gender gender { get; set; }

    public Themes themes { get; set; }

    public Account(string newNickname, string newName, int newUserId, Gender newGender, int newLimit)
    {
        Nickname = newNickname;
        Name = newName;
        UserId = newUserId;
        gender = newGender;
        Limit = newLimit;
    }
    public Account()
    {
    }
}
