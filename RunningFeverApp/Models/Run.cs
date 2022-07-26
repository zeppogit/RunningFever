using System.ComponentModel.DataAnnotations;

public class Run
{
    [Key]
    public int Id { get; set; } 
    public DateTime StartTime {get; set;}
    public float Miles  {get; set;}
    public string? Route {get; set;}
    public string? Note {get; set;}

}