using System;
using System.Collections.Generic;
using System.Linq;

namespace DNOLights.API.Users
{
    public class UserQueue : IUserQueue
    {
        private readonly Queue<User> _users = new Queue<User>();

        public void PushUserToQueue(Guid userId, string username) =>
            _users.Enqueue(new User {UserId = userId, UserName = username});

        public User PopUserFromQueue() =>
            _users.Count == 0 ? null : _users.Dequeue();

        public List<User> GetAllUsersFromQueue() =>
            _users.ToList();
    }
}