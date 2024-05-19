using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Application.Interface.UseCases;
using Pacagroup.Ecommerce.Application.Validator;
using Pacagroup.Ecommerce.CrossSectional.Common;

namespace Pacagroup.Ecommerce.Application.UseCases.Users
{
    public class UsersApplication : IUsersApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UsersDtoValidator _usersDtoValidator;
        public UsersApplication(IUnitOfWork unitOfWork, IMapper mapper, UsersDtoValidator usersDtoValidator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _usersDtoValidator = usersDtoValidator;
        }

        public Response<UserDto> Authenticate(string userName, string password)
        {
            var response = new Response<UserDto>();
            var validation = _usersDtoValidator.Validate(new UserDto
            {
                UserName = userName,
                Password = password
            });
            if (!validation.IsValid)
            {
                response.Message = "Parametros no pueden ser vacios.";
                response.Errors = validation.Errors;
                return response;
            }
            try
            {
                var user = _unitOfWork.Users.Authenticate(userName, password);
                response.Data = _mapper.Map<UserDto>(user);
                response.IsSuccess = true;
                response.Message = "¡Autentificacion Exitosa!";
            }
            catch (InvalidOperationException)
            {
                response.IsSuccess = true;
                response.Message = "Usuario no existe.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
