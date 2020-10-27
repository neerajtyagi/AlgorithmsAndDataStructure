using System;
using Xunit;

namespace Problems.Tests
{
    public class RecentCache_Tests
    {
        private readonly Storage storage;

        public RecentCache_Tests()
        {
            storage = new Storage()
            {
                [1] = new UserData { UserID = 1, UserName = "Neeraj" },
                [2] = new UserData { UserID = 2, UserName = "Amit" },
                [3] = new UserData { UserID = 3, UserName = "Kapil" },
                [4] = new UserData { UserID = 4, UserName = "Robin" },
                [5] = new UserData { UserID = 5, UserName = "Vijay" }
            };
        }

        public void EmptyCache_Get_Test()
        {

        }

        public void Cache_Get_Test()
        {

        }

        public void Cache_Get_Cached_Tests()
        {

        }

        public void Cache_Full_Get_Test()
        {

        }

        public void Cache_Invalid_Get_Test()
        {

        }
    }
}