﻿namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString1to60 : LimitedString
    {
        public LimitedString1to60(string value)
            : base(value, 1, 60)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, minLength: 1, maxLength: 60);
        }
    }
}
