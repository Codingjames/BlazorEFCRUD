using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.server2.Data
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
}