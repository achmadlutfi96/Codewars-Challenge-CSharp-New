class Hero{
    public string Name{ get; set; } = "Hero";
    public string Position { get; set; } = "00";
    public float Health { get; set; } = 100;
    public float Damage { get; set; } = 5;
    public int Experience { get; set; } = 0;
    public Hero(string name = "Hero"){
      Name = name;
    }
}