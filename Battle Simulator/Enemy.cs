namespace Battle_Simulator
{
    class Enemy
    {
        public string enemyName { get; set; }
        public int enemyHp { get; set; }

        public Enemy (string enemyName1, int enemyHp1)
        {
            enemyName = enemyName1;
            enemyHp = enemyHp1;
        }
    }
}
