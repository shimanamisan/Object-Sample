namespace Object_Sample
{
    /// <summary>
    /// ムスコクラス
    /// </summary>
    public class Musuko
    {
        /// <summary>
        /// ムスコの満足度
        /// </summary>
        private int _satisfaction;

        /// <summary>
        /// IHeroRedインターフェースが実装されたクラス
        /// </summary>
        public IHeroRed HeroRed { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="heroRed">IHeroRedインターフェースが実装されたクラス</param>
        public Musuko(IHeroRed heroRed)
        {
            HeroRed = heroRed;
        }

        /// <summary>
        /// 幸福値
        /// </summary>
        public string Happiness()
        {
            _satisfaction += 20;

            return $"ムスコの幸福値: {_satisfaction}";            
        }
    }
}
