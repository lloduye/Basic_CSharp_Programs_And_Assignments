using System;

public class Player
{
	public string Name { get; set; }
    public List<Card> Hand { get; set;}
    public bool IsActive { get; set; }
    public int Balance { get; set; }
}
