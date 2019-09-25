using System;
using System.Collections.Generic;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Services
{
    public class MockCarService
    {
        private static MockCarService _instance;

        public static MockCarService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MockCarService();
                return _instance;
            }
        }

        public List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Id= Guid.NewGuid().ToString(), ImageUrl="bmwvisionmnextconcep1.jpg" , Title="BMW Vision M NEXT", SubTitle="", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquid ex ea commodi consequat. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. "  },
                new Item { Id= Guid.NewGuid().ToString(), ImageUrl="bmwvisionmnextconcep2.jpg" , Title="BMW Vision M NEXT", SubTitle="", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquid ex ea commodi consequat. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. "  },
                new Item { Id= Guid.NewGuid().ToString(), ImageUrl="bmwvisionmnextconcep3.jpg" , Title="BMW Vision M NEXT", SubTitle="", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquid ex ea commodi consequat. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. "  }
            };
        }
    }
}
