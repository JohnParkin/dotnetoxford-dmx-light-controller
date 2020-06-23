using System;
using System.Collections.Generic;

namespace DNOLights.API.Users
{
    public interface IUserQueue
    {
        void PushUserToQueue(Guid userId, string username);
        User PopUserFromQueue();
        List<User> GetAllUsersFromQueue();
    }
}