using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using epms.Entities;
using epms.Entities.Models;

namespace epms.WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<AccountGroup>> IndexAsync()
        {
            return await _unitOfWork.AccountGroupRepository.GetAllAsync();
        }
    }
}
