namespace Realistate;

public class Agency
{
    private List<User> users { get; set; }
    private List<Ad> ads { get; set; }

    public Agency()
    {
        users = new List<User>();
        ads = new List<Ad>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    

    public void AddAd(Ad ad)
    {
        ads.Add(ad);
    }


    public List<User> GetUsers()
    {
        return users;
    }
}