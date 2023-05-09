namespace Object_Sample
{
    /// <summary>
    /// ファクトリークラス
    /// </summary>
    public static class Factories
    {
        /// <summary>
        /// 遊ぶ人区分
        /// </summary>
        public enum PlayKind
        {
            Otto,
            Grandfather,
            Tsumma
        }

        /// <summary>
        /// instance生成メソッド
        /// </summary>
        /// <param name="kind">遊ぶ人区分</param>
        /// <param name="hp">遊ぶ人の体力</param>
        /// <returns>IHeroRedを実装したクラス</returns>
        public static IHeroRed Create(PlayKind kind, int hp)
        {
            if (PlayKind.Otto == kind)
            {
                return new Otto(hp);
            }

            if (PlayKind.Grandfather == kind)
            {
                return new Grandfather(hp);
            }

            return new Tsumma(hp);
        }
    }
}
