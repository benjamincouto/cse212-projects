using System.ComponentModel;

public class FeatureCollection
{
    public List<Feature> Features { get; set; }
    
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public string place { get; set; }
    public decimal mag { get; set; }
}