using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Datn.ApiManagement.Enums
{
    public class Enums
    {
        public enum CostStatus
        {
            [Description("Deposited")]
            DEPOSITED = 0,

            [Description("Waiting for paying")]
            WAITINGFORPAYING = 1,

            [Description("Payed")]
            PAYED = 2,
        }

        public enum RentalStatus
        {
            [Description("Waiting for rentaling")]
            WAITING = 0,

            [Description("Using")]
            USING = 1,

            [Description("Returned")]
            RETURNED = 2,

            [Description("Cancel paying")]
            CANCEL = 3,
        }
    }
}
