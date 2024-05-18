using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface;
using Pacagroup.Ecommerce.CrossSectional.Common;
using Pacagroup.Ecommerce.Domain.Interface;

namespace Pacagroup.Ecommerce.Application.Main
{
    public class CategoriesApplication : ICategoriesApplication
    {
        private readonly ICategoriesDomain _categoriesDomain;
        private readonly IMapper _mapper;
        public CategoriesApplication(ICategoriesDomain categoriesDomain, IMapper mapper)
        {
            _categoriesDomain = categoriesDomain;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<CategoriesDto>>> GetAll()
        {
            var response = new Response<IEnumerable<CategoriesDto>>();
            try
            {
                var categories = await _categoriesDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CategoriesDto>>(categories);
                if(response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "¡Consulta Exitosa!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
