﻿namespace MyProject.Application.Commands.Withdraw
{
    using System;

    public class WithdrawCommand
    {
        public Guid AccountId { get; private set; }
        public Double Amount { get; private set; }

        public WithdrawCommand(Guid accountId, double amount)
        {
            AccountId = accountId;
            Amount = amount;
        }
    }
}
