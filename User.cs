using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMastersBank;

public abstract class User
{
    internal abstract class User
    {
        public string Username { get; private set; }
        private string _pincode;

        static int _userIdCounter = 100;
        private int _userId;
        public int UserId
        {
            get { return _userId; }
            private set;

        }
        protected User(string username, string pincode)
        {
            Username = username;
            _pincode = pincode;
            _userIdCounter++;
            _userId = _userIdCounter;
        }
    }
}
