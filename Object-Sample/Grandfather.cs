namespace Object_Sample
{
    /// <summary>
    /// ジィジクラス
    /// </summary>
    public class Grandfather : IHeroRed
    {
        /// <summary>
        /// ジィジの体力
        /// </summary>
        private int _hp;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="hp">ジィジの体力</param>
        public Grandfather(int hp)
        {
            _hp = hp;
        }

        /// <summary>
        /// 遊ぶ
        /// </summary>
        /// <returns>遊べるか否か</returns>
        public bool Play()
        {
            if (_hp < 0)
            {
                Console.WriteLine("ジィジはもう遊べない");

                return false;
            }

            _hp -= 20;

            return true;
        }
    }
}
