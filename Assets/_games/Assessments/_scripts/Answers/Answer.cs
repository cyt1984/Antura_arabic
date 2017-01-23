using EA4S.LivingLetters;
using UnityEngine;

namespace EA4S.Assessment
{
    /// <summary>
    /// This class is an answer to a question. It provide a simplified interface
    /// compared to LLs and few additionals utilities for checking correctness
    /// and equality with other answers.
    /// </summary>
    public class Answer: MonoBehaviour
    {
        private LetterObjectView view;
        private bool isCorrect;

        public Answer Init( bool correct)
        {
            view = GetComponent< LetterObjectView>();
            isCorrect = correct;
            return this;
        }

        /// <summary>
        /// Is this a correct answer?
        /// </summary>
        public bool IsCorrect()
        {
            return isCorrect;
        }

        /// <summary>
        /// Compare content of the answer
        /// </summary>
        /// <param name="other"> other answer content</param>
        public bool Equals( Answer other)
        {
            if (Data().Equals(other.Data()))
                return true;

            return false;
        }

        /// <summary>
        /// Regular override of Equals/GetHashCode
        /// </summary>
        public override bool Equals( object obj)
        {
            if (obj is Answer)
                return this.Equals( obj as Answer);

            return false;
        }

        /// <summary>
        /// Regular override of Equals/GetHashCode
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// The data of the living letter
        /// </summary>
        public ILivingLetterData Data()
        {
            return view.Data;
        }

        /// <summary>
        /// Play letter sound if global options require that.
        /// </summary>
        void OnMouseDown()
        {
            if ( AssessmentOptions.Instance.PronunceAnswerWhenClicked)
                AssessmentConfiguration.Instance.Context.GetAudioManager()
                    .PlayLetterData( Data());
        }
    }
}