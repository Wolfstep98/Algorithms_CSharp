using System;

namespace Algortihms.Shuffle
{
    public static class Shuffle<T>
    {
        /// <summary>
        /// Implementation of the Fisher-Yates modern shuffle Algorithm.
        /// </summary>
        /// <param name="sequence">The sequence to shuffle.</param>
        /// <returns>Return the sequence shuffled in a new array.</returns>
        public static T[] FisherYatesShuffle(T[] sequence)
        {
            Random random = new Random();
            T[] result = new T[sequence.Length];
            for(int i = sequence.Length - 1; i >= 0; i--)
            {
                int index = random.Next(0, i + 1);
                result[i] = sequence[index];
                sequence[index] = sequence[i];
            }
            return result;
        }
    }
}
