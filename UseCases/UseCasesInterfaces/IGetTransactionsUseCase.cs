using CoreBussiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IGetTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}