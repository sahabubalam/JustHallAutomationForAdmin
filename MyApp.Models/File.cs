//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class File
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public string FileTitle { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
    }
}
