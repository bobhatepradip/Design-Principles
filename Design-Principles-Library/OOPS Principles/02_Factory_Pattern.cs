namespace Design_Principles_Library.OOPS_Principles
{
    internal class _02_Factory_Pattern
    {
        internal class CardGameExamlple
        {
            private enum GameType
            {
                PockerGame,
                BlackJackGame
            }

            // If any module is using a Base class then the reference to that Base class can be replaced with a Derived class without affecting the functionality of the module.
            // Or
            // While implementing derived classes, one needs to ensure that, derived classes just extend the functionality of base classes without replacing the functionality of base classes.
            private class CardGame
            {
            }

            // While implementing derived class if one replaces the functionality of base class then,
            // it might results into undesired side effects when such derived classes are used in existing program modules.
            private class PokerGame : CardGame
            {
            }

            private class BlackJackGame : CardGame
            {
            }

            private class CardGameFactory
            {
                private static CardGame CreateInstance(GameType gameType)
                {
                    if (gameType == GameType.PockerGame)
                    {
                        return new PokerGame();
                    }
                    else if (gameType == GameType.BlackJackGame)
                    {
                        return new BlackJackGame();
                    }

                    return null;
                }
            }
        }
    }
}