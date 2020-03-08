using System;

namespace AppleStore.Entities
{
    public class AjaxResult
    {
        public object Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public AjaxResult()
        {
            Success = true;
        }
    }
}
