namespace Realistate;

public class Ad
{
    private int _id { get; set; }
    private string _adress { get; set; }
    public District District { get; set; }
    private Agent _agent { get; set; }
    public double Price { get; set; }
    public bool Furnished { get; set; }


    public Ad(int id, string adress, District district, Agent agent, double price, bool furnished)
    {
        _id = id;
        _adress = adress;
        District = district;
        _agent = agent;
        Price = price;
        Furnished = furnished;

    }

    public override string ToString()
    {
        string furnishedText = Furnished ? "furnished" : "Not furnished";
        return $"{_id}: {_adress} in district {District} is {furnishedText}, being sold by {_agent.Name} for {Price}";
    }
}