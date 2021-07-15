using System;
using SalesWebMvc.v2.Models;

namespace SalesWebMvc.v2.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}