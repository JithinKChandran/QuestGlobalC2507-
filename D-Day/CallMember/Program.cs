using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallMember
{
    class User
    {
        private string _username;
        public string Name
        {
            get => _username;
            set
            {
                CheckIsEmpty(value);
                _username = value;
            }
        }
        private void CheckIsEmpty(string value , [CallerMemberName] string name = "")
        {
            Console.WriteLine(string.IsNullOrWhiteSpace(value)? $"{name} is invalid": $"{name} is valid");
        }
    }
    internal class Program
    {
        static void CallMe([CallerMemberName] string callerName = null)
        {
            Console.WriteLine($"called by: {callerName}");
        }
        static void Main(string[] args)
        {
            var user = new User();
            user.Name = "abhi";
            user.Name = "";
            CallMe();
        }
    }
}
