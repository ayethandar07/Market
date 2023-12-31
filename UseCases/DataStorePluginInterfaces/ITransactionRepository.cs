﻿using CoreBussiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> Get(string cashierName);
        IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);
        void Save(string cashierName, int productId, string productName, double price, int beforeQty, int SoldQty);
        IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);
    }
}