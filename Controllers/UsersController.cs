using AutoMapper;
using NS804Test.DataAccess;
using NS804Test.DataAccess.Repositories.Implementation;
using NS804Test.Service.Dtos;
using NS804Test.Services.Service.Implementation;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace NS804Test.Api.Controllers
{

    /// <summary>
    /// User API controller with all CRUD methods
    /// </summary>
    [Authorize]
    public class UsersController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly UserServices _userServices;

        /// <summary>
        /// User API Controller Constructor
        /// </summary>
        public UsersController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
            _userServices = new UserServices(new UserRepository(ApplicationDbContext.Create()), _mapper);
        }

        /// <summary>
        /// User API Controller Constructor
        /// </summary>
        public UsersController(IMapper mapper)
        {
            if (WebApiApplication.MapperConfiguration is null)
                _mapper = mapper;
            else
                _mapper = WebApiApplication.MapperConfiguration.CreateMapper();

            _userServices = new UserServices(new UserRepository(ApplicationDbContext.Create()), _mapper);
        }

        /// <summary>
        /// Returns the list of all user registered in the DataBase
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<UserDto> GetAll()
        {
            var users = _userServices.GetAll();
            return users;
        }

        /// <summary>
        /// Returns the user information by specifying the user id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var users = _userServices.GetById(id);
            return Ok(users);
        }

        /// <summary>
        /// Update an user entity
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IHttpActionResult Put(UserDto user)
        {
            var users = _userServices.Update(user);
            return Content(HttpStatusCode.OK, users);
        }
    }
}