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
            [Description("Waiting for paying")]
            WAITING = 0,

            [Description("Payed")]
            DONE = 1,

            [Description("Cancel paying")]
            CANCEL = 2,
        }

        public enum RentalStatus
        {
            [Description("Waiting for rentaling")]
            WAITING = 0,

            [Description("Using")]
            USING = 1,

            [Description("Returned")]
            RETURNED = 2,
        }
    }
}
