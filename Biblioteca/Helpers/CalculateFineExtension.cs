using Biblioteca.Models;

namespace Biblioteca.Helpers
{
    public static class CalculateFineExtension
    {
        private static decimal _fineAmountPerDay = 1;
        public static void CalculateFine(this Borrowing borrowing)
        {
            decimal fine;
            TimeSpan diff = borrowing.DateBorrowed - borrowing.DateReturned.Value;
            int days = (int)Math.Abs(Math.Truncate(diff.TotalDays));
            if (days > borrowing.AmountOfDays)
            {
                fine = (days - borrowing.AmountOfDays) * _fineAmountPerDay;
            }
            else 
                fine = 0;
            borrowing.FinePay = fine;
        }
    }
}
