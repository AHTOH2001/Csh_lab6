﻿using System;

namespace CshLab6
{
    interface ISpecificSport : IComparable<ISpecificSport>
    {
        public double GetResult();
        public SportName GetSportName();
        public void OutInfo();
        public bool IsSuit(Human human);

    }
}
