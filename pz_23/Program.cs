﻿using System;

namespace PZ_23_Petashvili_2pk2
{
    class RadioactiveAtom : Atom
    {
        private int countFreeElectrons;
        private bool radioactivity;

        public RadioactiveAtom(int countElectrons) : base(countElectrons)
        {
            countFreeElectrons = countElectrons;

            if (countFreeElectrons >= 0) radioactivity = false;
            else if (countFreeElectrons < 0) radioactivity = true;
        }

        public bool PeriodSemiDecay
        {
            get { return radioactivity; }
            set { radioactivity = value; }
        }

        public override void PrintInfo()
        {
            Console.Write($"Количество электронов: {countFreeElectrons}\n" +
                          $"Является ли элемент радиоактивным: {PeriodSemiDecay}");
        }
    }
}