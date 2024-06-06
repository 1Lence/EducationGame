namespace MainScripts
{
    [System.Serializable]
    public class PlayerData
    {
        public int level;
        public int health;
        public float[] position;

        public PlayerData(Player player)
        {
            level = player.level;
            health = player.health;

            position = new float[3];
            var position1 = player.transform.position;
            position[0] = position1.x;
            position[1] = position1.y;
            position[2] = position1.z;
        }
    }
}
