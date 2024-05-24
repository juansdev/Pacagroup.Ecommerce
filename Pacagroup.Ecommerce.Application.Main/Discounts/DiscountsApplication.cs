using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface.Infrastructure;
using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Application.Interface.UseCases;
using Pacagroup.Ecommerce.CrossSectional.Common;
using Pacagroup.Ecommerce.Domain.Entities;
using Pacagroup.Ecommerce.Domain.Events;

namespace Pacagroup.Ecommerce.Application.UseCases.Discounts
{
    public class DiscountsApplication : IDiscountsApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IEventBus _eventBus;

        public DiscountsApplication(IUnitOfWork unitOfWork, IMapper mapper, IEventBus eventBus)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _eventBus = eventBus;
        }

        public async Task<Response<bool>> Create(DiscountDto discountDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            var discount = _mapper.Map<Discount>(discountDto);
            await _unitOfWork.Discounts.InsertAsync(discount);
            response.Data = await _unitOfWork.Save(cancellationToken) > 0;
            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "¡Registro Exitoso!";

                /* Publicamos el evento */
                var discountCreatedEvent = _mapper.Map<DiscountCreatedEvent>(discount);
                _eventBus.Publish(discountCreatedEvent);
            }
            return response;
        }

        public async Task<Response<bool>> Delete(int id, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            await _unitOfWork.Discounts.DeleteAsync(id.ToString());
            response.Data = await _unitOfWork.Save(cancellationToken) > 0;
            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "¡Eliminación Exitosa!";
            }
            return response;
        }

        public async Task<Response<DiscountDto>> Get(int id, CancellationToken cancellationToken = default)
        {
            var response = new Response<DiscountDto>();
            var discount = await _unitOfWork.Discounts.GetAsync(id, cancellationToken);
            if (discount == null)
            {
                response.IsSuccess = true;
                response.Message = "Descuento no existe...";
            }
            response.Data = _mapper.Map<DiscountDto>(discount);
            response.IsSuccess = true;
            response.Message = "¡Obtención Exitosa!";
            return response;
        }

        public async Task<Response<List<DiscountDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            var response = new Response<List<DiscountDto>>();
            var discounts = await _unitOfWork.Discounts.GetAllAsync(cancellationToken);
            response.Data = _mapper.Map<List<DiscountDto>>(discounts);
            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "¡Consulta Exitosa!";
            }
            return response;
        }

        public async Task<ResponsePagination<IEnumerable<DiscountDto>>> GetAllWithPagination(int pageNumber, int pageSize)
        {
            var response = new ResponsePagination<IEnumerable<DiscountDto>>();
            var count = await _unitOfWork.Discounts.CountAsync();
            var discounts = await _unitOfWork.Discounts.GetAllWithPaginationAsync(pageNumber, pageSize);
            response.Data = _mapper.Map<IEnumerable<DiscountDto>>(discounts);
            if (response.Data != null)
            {
                response.PageNumber = pageNumber;
                response.TotalPages = (int)Math.Ceiling(count / (double)pageSize);
                response.TotalCount = count;
                response.IsSuccess = true;
                response.Message = "¡Obtención Paginada Exitosa!";
            }
            return response;
        }

        public async Task<Response<bool>> Update(DiscountDto discountDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            var discount = _mapper.Map<Discount>(discountDto);
            await _unitOfWork.Discounts.UpdateAsync(discount);
            response.Data = await _unitOfWork.Save(cancellationToken) > 0;
            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "¡Actualización Exitosa!";
            }
            return response;
        }
    }
}
