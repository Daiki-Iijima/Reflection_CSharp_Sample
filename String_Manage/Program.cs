using System;
using System.Diagnostics;
using System.Reflection;

namespace Reflection_Sample
{
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

    class MainClass
    {
        public static void Main(string[] args)
        {
            var player = new Player()
            {
                Attack = 100
            };
            var enemy = new Enemy()
            {
                Attack = 39
            };

            //  PlayerからEnemyに与えるダメージの計算
            int damage = CalcPlayerDamage(player, enemy);

            Console.WriteLine($"({player.Attack} - {enemy.Attack}) / 4 * 100 / 256 = {damage}");
        }

        /// <summary>
        /// ダメージの計算(リフレクションを使用した汎用的な仕様)
        /// </summary>
        /// <param name="attacker"></param>
        /// <param name="receiver"></param>
        /// <returns></returns>
        static int CalcPlayerDamage(Object attacker, Object receiver)
        {
            //  Attackerのクラス？を取得
            Type attackerType = attacker.GetType();

            //  取得したTypeからAttack(メタデータ)を取得
            FieldInfo attacker_fieldInfo = attackerType.GetField("Attack");

            //  取得したメタデータから数値を取得
            int attacker_Attack = (int)attacker_fieldInfo.GetValue(attacker);


            Type receiverType = receiver.GetType();

            FieldInfo receiver_FieldInfo = receiverType.GetField("Attack");

            int receiver_Attack = (int)receiver_FieldInfo.GetValue(receiver);

            return (attacker_Attack - receiver_Attack) / 4 * 100 / 256;
        }
    }

    
}
