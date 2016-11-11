﻿namespace EA4S.Balloons
{
    public class BalloonsIntroductionState : IGameState
    {
        BalloonsGame game;

        float timer = 1;
        public BalloonsIntroductionState(BalloonsGame game)
        {
            this.game = game;
        }

        public void EnterState()
        {
        }

        public void ExitState()
        {
        }

        public void Update(float delta)
        {
            timer -= delta;

            if (timer < 0)
            {
                game.SetCurrentState(game.QuestionState);
            }
        }

        public void UpdatePhysics(float delta)
        {
        }
    }
}