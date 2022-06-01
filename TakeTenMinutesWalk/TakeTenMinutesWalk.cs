using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeTenMinutesWalk
{
    public class TakeTenMinutesWalkHelper
    {
        public bool IsValidWalk(string[] walk)
        {
            bool isValid = false;
            var currentStep = string.Empty;
            var previousStep = string.Empty;

            if (walk.Length == 10)
            {
                for (int x = 0; x < walk.Length; x++)
                {
                    if (x == 0)
                    {
                        currentStep = walk[x];
                        previousStep = string.Empty;
                    }
                    else
                    {
                        previousStep = currentStep;
                        currentStep = walk[x];
                        isValid = true;

                        if (currentStep == previousStep)
                        {
                            isValid = false;
                            break;
                        }

                    }
                }
            }

            return isValid;
        }
    }
}
