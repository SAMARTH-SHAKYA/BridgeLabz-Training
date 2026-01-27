using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.annotations
{
    // Attribute Definition
    [AttributeUsage(AttributeTargets.Field)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }

    // Applying the Attribute
    public class User
    {
        [MaxLength(10)]
        private string username;

        public User(string username)
        {
            if (username.Length > 10)
                throw new ArgumentException("Username exceeds max length");

            this.username = username;
        }
    }
}
