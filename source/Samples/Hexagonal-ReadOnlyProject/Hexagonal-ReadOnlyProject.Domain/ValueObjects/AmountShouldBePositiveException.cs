﻿namespace Hexagonal_ReadOnlyProject.Domain.ValueObjects
{
    public class AmountShouldBePositiveException : DomainException
    {
        internal AmountShouldBePositiveException(string message)
            : base(message)
        { }
    }
}