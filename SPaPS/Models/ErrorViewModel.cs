using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models
{
    public class ErrorViewModel
    {
        
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}