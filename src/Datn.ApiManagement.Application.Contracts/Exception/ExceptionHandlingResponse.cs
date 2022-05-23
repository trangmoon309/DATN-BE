using System.Collections.Generic;

namespace Datn.ApiManagement.Models
{
    public class ExceptionHandlingResponse
    {
        /// <summary>
        /// Get or set error
        /// </summary>
        public List<ValidationErrorsResponse> ValidationErrors { get; private set; }

        public ExceptionHandlingResponse()
        {
            ValidationErrors = new List<ValidationErrorsResponse>();
        }
    }

    public class ValidationErrorsResponse
    {
        /// <summary>
        /// Get or set error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Get or set error field
        /// </summary>
        public string Member { get; set; }
    }
}
