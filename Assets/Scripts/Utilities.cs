using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    static public float Compare(EAffinities player, EAffinities enemy)
    {
        float affinityMultiplier = 1.0f;

        switch (player)
        {
            case EAffinities.fire:
                {
                    switch (enemy)
                    {
                        case EAffinities.fire:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                        case EAffinities.water:
                            {
                                affinityMultiplier = 2.0f;
                                return affinityMultiplier;
                            }
                        case EAffinities.earth:
                            {
                                affinityMultiplier = 0.0f;
                                return affinityMultiplier;
                            }
                    }
                    break;
                }
            case EAffinities.wind:
                {
                    switch (enemy)
                    {
                        case EAffinities.wind:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                        case EAffinities.water:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                        case EAffinities.earth:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                    }
                    break;
                }
            case EAffinities.water:
                {
                    switch (enemy)
                    {
                        case EAffinities.fire:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                        case EAffinities.wind:
                            {
                                affinityMultiplier = 2.0f;
                                return affinityMultiplier;
                            }
                        case EAffinities.water:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                    }
                    break;
                }
            case EAffinities.earth:
                {
                    switch (enemy)
                    {
                        case EAffinities.wind:
                            {
                                affinityMultiplier = 2.0f;
                                return affinityMultiplier;
                            }
                        case EAffinities.earth:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                    }
                    break;
                }
            case EAffinities.dark:
                {
                    switch (enemy)
                    {
                        case EAffinities.dark:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                        case EAffinities.light:
                            {
                                affinityMultiplier = 2.0f;
                                return affinityMultiplier;
                            }
                    }
                    break;
                }
            case EAffinities.light:
                {
                    switch (enemy)
                    { 
                        case EAffinities.dark:
                            {
                                affinityMultiplier = 2.0f;
                                return affinityMultiplier;
                            }
                        case EAffinities.light:
                            {
                                affinityMultiplier = 0.5f;
                                return affinityMultiplier;
                            }
                    }
                    break;
                }
        }
        return affinityMultiplier;
    }
}
