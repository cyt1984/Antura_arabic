﻿using UnityEngine;

namespace EA4S.Assessment
{
    /// <summary>
    /// This is the code specific to each Assessment (basically only initialization differs)
    /// </summary>
    public static class AssessmentFactory
    {
        public static IAssessment CreateLetterInWordAssessment( IAssessmentConfiguration configuration)
        {
            Init(); // common initialization stuff

            //            return new DefaultAssessment();
            return null;
        }

        //private LivingLetterFactory livingLetterFactory;

        private static void Init()
        {
            TimeEngine.Instance.Clear();
        }
    }
}