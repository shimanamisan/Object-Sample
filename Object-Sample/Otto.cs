namespace Object_Sample
{
    /// <summary>
    /// オットクラス
    /// </summary>
    public class Otto : IHeroRed
    {
        /// <summary>
        /// オットの体力
        /// </summary>
        private int _hp;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="hp">オットの体力</param>
        public Otto(int hp)
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
                Console.WriteLine("オットはもう遊べない");

                return false;
            }

            _hp -= 20;

            return true;
        }
    }
}
