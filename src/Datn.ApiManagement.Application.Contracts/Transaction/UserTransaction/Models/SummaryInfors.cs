using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public  class SummaryInfors
    {
        public double QualityReview { get; set; }

        public double QualityReviewDifference { get; set; }

        public double AverageIncome { get; set; }

        public double AverageIncomeDifference { get; set; }

        public int TransactionCancel { get; set; }

        public double TransactionCancelDifference { get; set; }

        public List<UserTransactionResponse> SuccessTransactions { get; set; }

        public List<UserTransactionResponse> CanceledTransactions { get; set; }
    }
}
