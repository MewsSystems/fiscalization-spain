﻿namespace Mews.Sii.Dto.Identifiers
{
    public class RegistryIdentifier : StringIdentifier
    {
        public RegistryIdentifier(string value)
            : base(value, Patterns.RegistryIdentifier)
        {
        }
    }
}
