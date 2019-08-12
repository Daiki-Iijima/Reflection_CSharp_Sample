using System;

namespace Reflection_Sample
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        }

        //  ============== ほぼ同じメソッドができてしまった ==================

        /// <summary>
        /// Playerの与えるダメージの計算
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        /// <returns></returns>
        int CalcPlayerDamage(Player player, Enemy enemy)
        {
            return (player.Attack - enemy.Attack / 4) * 100 / 256;
        }

        /// <summary>
        /// Enemyの与えるダメージの計算
        /// </summary>
        /// <param name="enemy"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        int CalcEnemyDamage(Enemy enemy, Player player)
        {
            return (enemy.Attack - player.Attack / 4) * 100 / 256;
        }
        //  =============================================================
    }

    class Player
    {
        public int HP;
        public int Attack;
        public int EXP;
    }

    class Enemy
    {
        public int HP;
        public int Attack;
        public int EXP;
        public int DropItem;
    }
}
