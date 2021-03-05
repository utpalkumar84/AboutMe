using AboutMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.Domain.Abstract.Repositories
{
    public interface IMyInfoRepository
    {
        Task<MyInfo> GetMyInfoAsync();
    }
}
