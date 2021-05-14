using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Observer.Subject.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
