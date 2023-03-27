using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drinks;

namespace Automata
{
    internal class Automat
    {
        public float m_moneyInput;
        Drink[] m_drinkChoices = new Drink[] { new Drink(500, 0),
                                               new Drink(1000, 0),
                                               new Drink(250, 40),
                                               new Drink(330, 100),
                                               new Drink(500, 15),
                                              };

        float[] m_drinkPrice = new float[] { 1.0f, 1.5f, 1.5f, 2.0f, 3.0f };

        string[] m_drinkNames = new string[] { "Wasser", "Wasser", "Cola", "Süßer Tee", "Süßer Tee" };

        public void ShowDrinkList()
        {
            for (int i = 0; i < m_drinkChoices.Length; i++)
            {
                Console.WriteLine("{0}. {1}: {2} ml, {3} Euro", i+1, m_drinkNames[i], m_drinkChoices[i].m_liquidVolume, m_drinkPrice[i]);
            }
        }

        public void InputMoney(float _money)
        {
            m_moneyInput += _money;
        }





    }
}
