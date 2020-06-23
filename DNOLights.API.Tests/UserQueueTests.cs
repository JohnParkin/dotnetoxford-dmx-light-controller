using System;
using DNOLights.API.Users;
using FluentAssertions;
using Xunit;

namespace DNOLights.API.Tests
{
    public class UserQueueTests
    {
        [Fact]
        public void GivenAnEmptyQueue_WhenPushingNewUserToQueue_ThenPoppingUserShouldReturnThatUser()
        {
            var queue = new UserQueue();
            queue.PushUserToQueue(Guid.NewGuid(), "Dan");
            queue.PopUserFromQueue().Should().BeEquivalentTo("Dan");
        }

        [Fact]
        public void GivenAnEmptyQueue_WhenPushingTwoUsersToQueue_ThenPoppingUserShouldReturnFirstUser()
        {
            var queue = new UserQueue();
            queue.PushUserToQueue(Guid.NewGuid(),"Dan");
            queue.PushUserToQueue(Guid.NewGuid(), "Bob");
            queue.PopUserFromQueue().Should().BeEquivalentTo("Dan");
        }

        [Fact]
        public void GivenAQueueWithThreeUsers_EnsureExpectedOrderWhenPopping()
        {
            var queue = new UserQueue();
            queue.PushUserToQueue(Guid.NewGuid(), "Dan");
            queue.PushUserToQueue(Guid.NewGuid(), "Bob");
            queue.PushUserToQueue(Guid.NewGuid(), "Fred");
            queue.PopUserFromQueue().Should().BeEquivalentTo("Dan");
            queue.PopUserFromQueue().Should().BeEquivalentTo("Bob");
            queue.PopUserFromQueue().Should().BeEquivalentTo("Fred");
            queue.PopUserFromQueue().Should().BeNull();
        }

        [Fact]
        public void GivenAnEmptyQueue_WhenPoppingUser_ShouldReturnNull() =>
            new UserQueue().PopUserFromQueue().Should().BeNull();
    }
}