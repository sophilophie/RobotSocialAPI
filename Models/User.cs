using System.Text.Json.Serialization;

namespace RobotSocialAPI.Models
{
  public class User 
  {
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    
    [JsonIgnore]
    public string? Password { get; set; }
  }
}
