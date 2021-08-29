using AutoMapper;
using NS804Test.Api.JwtGenerator;
using NS804Test.DataAccess;
using NS804Test.DataAccess.Repositories.Implementation;
using NS804Test.Service.Dtos;
using NS804Test.Services.Service.Implementation;
using System.Net;
using System.Web.Http;

namespace NS804Test.Api.Controllers
{
    /// <summary>
    /// Account API methods
    /// </summary>
    [AllowAnonymous]
    public class AccountController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly AccountServices _accountServices;

        /// <summary>
        /// Account API Constructor
        /// </summary>
        public AccountController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
            _accountServices = new AccountServices(new AccountRepository(ApplicationDbContext.Create()), _mapper);
        }

        /// <summary>
        /// Account API Constructor
        /// </summary>
        public AccountController(IMapper mapper)
        {
            if (WebApiApplication.MapperConfiguration is null)
                _mapper = mapper;
            else
                _mapper = WebApiApplication.MapperConfiguration.CreateMapper();

            _accountServices = new AccountServices(new AccountRepository(ApplicationDbContext.Create()), _mapper);
        }

        /// <summary>
        /// Login and gets TOKEN
        /// </summary>
        /// <param name="logIn"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Login(LogInDto logIn)
        {
            var user = _accountServices.LogIn(logIn.Email, logIn.Password);
            var token = TokenGenerator.GenerateTokenJwt(user.FullName, logIn.Email);

            return Ok(new { username = user.FullName, email = user.Email, token });
        }

        /// <summary>
        /// Create an user entity
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Post(UserDto user)
        {
            var users = _accountServices.Create(user);
            return Content(HttpStatusCode.Created, users);
        }
    }
}
