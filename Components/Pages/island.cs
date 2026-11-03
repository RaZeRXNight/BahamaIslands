namespace islandClass
{
public class Island
{
    public String Name ; 
    public String Image  ;
    public String Description  ;
    
    public Island(String Name, String Description) {
        this.Name = Name;
        this.Image = $"/images/{Name.ToLower().Replace(" ", "_")}.jpg";
        this.Description = Description;
    }

}

}