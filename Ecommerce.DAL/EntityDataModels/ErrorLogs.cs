//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce.DAL.EntityDataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorLogs
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public System.DateTime LogDate { get; set; }
    }
}
