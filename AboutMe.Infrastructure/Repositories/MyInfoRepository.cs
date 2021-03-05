using AboutMe.Domain.Abstract.Repositories;
using AboutMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.Infrastructure.Repositories
{
    public class MyInfoRepository : IMyInfoRepository
    {
        private MyInfo myInfoObj;

        public MyInfoRepository()
        {
            myInfoObj = new MyInfo();
            myInfoObj.Name = "Utpal Kumar";
            myInfoObj.Profile = "I hold a degree of MS in CS from UCSD and am passionate about programming. I have been in the IT industry for more than a decade now. As a hobby, during my free time, I write articles on a variety of topics with most of them dealing with psychology and philosophy. I also like going for treks.";
        }
        public async Task<MyInfo> GetMyInfoAsync()
        {
            return await Task.Factory.StartNew(() => myInfoObj );
        }
    }
}
