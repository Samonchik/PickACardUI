using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        /// <summary>
        /// Создает экземпляр класса Random
        /// </summary>
        static Random random = new Random();
        /// <summary>
        /// Выбирает случайные карты и возвращает ихю
        /// </summary>
        /// <param name="numberOfCards"> количество выбранных карт</param>
        /// <returns></returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuite();
            }
            return pickedCards;
        }

        private static string RandomSuite()
        {
            int value = random.Next(1, 4);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
