using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Customer 
    {
        public int Id { get; set; }
        public DateTime InsertDateTime { get; set; }
        public int BranchId { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string PassportNo  { get; set; }  //todo : type?
        public string PayRefNo { get; set; } //todo: type?

        [DataType(DataType.Date)]
        public DateTime PassportExpDate { get; set; }
        public string VisaNo { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime VisaExpDate { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class ClassTitle : Attribute
    {
        public string Title { get; }

        public ClassTitle(string title)
        {
            this.Title = title;
        }
    }
}
