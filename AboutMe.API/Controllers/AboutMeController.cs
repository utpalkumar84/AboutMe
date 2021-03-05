using AboutMe.Domain.Abstract.Repositories;
using AboutMe.Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMeController : ControllerBase
    {
        private IMyInfoRepository myInfoRepositoryObj;

        public AboutMeController(IMyInfoRepository myInfoRepository)
        {
            myInfoRepositoryObj = myInfoRepository;
        }

        [EnableCors("PolicyGetMyInfo")]
        [HttpGet]
        public async Task<IActionResult> GetMyInfo()
        {
            MyInfo myInfo = await myInfoRepositoryObj.GetMyInfoAsync();
            return Ok(myInfo);
        }
    }
}
