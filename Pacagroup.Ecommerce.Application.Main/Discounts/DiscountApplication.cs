﻿using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Application.Interface.UseCases;
using Pacagroup.Ecommerce.Application.Validator;
using Pacagroup.Ecommerce.CrossSectional.Common;
using Pacagroup.Ecommerce.Domain.Entities;

namespace Pacagroup.Ecommerce.Application.UseCases.Discounts
{
    public class DiscountApplication : IDiscountApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly DiscountDtoValidator _discountDtoValidator;

        public DiscountApplication(IUnitOfWork unitOfWork, IMapper mapper, DiscountDtoValidator discountDtoValidator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _discountDtoValidator = discountDtoValidator;
        }

        public async Task<Response<bool>> Create(DiscountDto discountDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                var validation = await _discountDtoValidator.ValidateAsync(discountDto, cancellationToken);
                if (!validation.IsValid)
                {
                    response.Message = "Errores de Validación";
                    response.Errors = validation.Errors;
                    return response;
                }
                var discount = _mapper.Map<Discount>(discountDto);
                await _unitOfWork.Discounts.InsertAsync(discount);
                response.Data = await _unitOfWork.Save(cancellationToken)>0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "¡Registro Exitoso!";
                }
            } catch(Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<bool>> Delete(int id, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                await _unitOfWork.Discounts.DeleteAsync(id.ToString());
                response.Data = await _unitOfWork.Save(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "¡Eliminación Exitosa!";
                }
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<DiscountDto>> Get(int id, CancellationToken cancellationToken = default)
        {
            var response = new Response<DiscountDto>();
            try
            {
                var discount = await _unitOfWork.Discounts.GetAsync(id, cancellationToken);
                if(discount == null)
                {
                    response.IsSuccess = true;
                    response.Message = "Descuento no existe...";
                }
                response.Data = _mapper.Map<DiscountDto>(discount);
                response.IsSuccess = true;
                response.Message = "¡Obtención Exitosa!";
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<List<DiscountDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            var response = new Response<List<DiscountDto>>();
            try
            {
                var discounts = await _unitOfWork.Discounts.GetAllAsync(cancellationToken);
                response.Data = _mapper.Map<List<DiscountDto>>(discounts);
                if (response.Data != null)
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

        public async Task<Response<bool>> Update(DiscountDto discountDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                var validation = await _discountDtoValidator.ValidateAsync(discountDto, cancellationToken);
                if (!validation.IsValid)
                {
                    response.Message = "Errores de Validación";
                    response.Errors = validation.Errors;
                    return response;
                }
                var discount = _mapper.Map<Discount>(discountDto);
                await _unitOfWork.Discounts.UpdateAsync(discount);
                response.Data = await _unitOfWork.Save(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "¡Actualización Exitosa!";
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
