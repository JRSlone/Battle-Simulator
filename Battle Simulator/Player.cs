namespace Battle_Simulator
{
    class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
        
    }
}
