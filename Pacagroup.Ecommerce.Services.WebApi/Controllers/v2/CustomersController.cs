using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface;
using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Services.WebApi.Controllers.v2
{
    [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class CustomersController : Controller
    {
        private readonly ICustomersApplication _customersApplication;
        public CustomersController(ICustomersApplication customersApplication)
        {
            _customersApplication = customersApplication;
        }

        #region Sync Methods

        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] CustomersDto customersDto)
        {
            if (customersDto == null)
            {
                return BadRequest();
            }
            var response = _customersApplication.Insert(customersDto);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("Update/{customerId}")]
        public IActionResult Update(string customerId, [FromBody] CustomersDto customersDto)
        {
            var customerDto = _customersApplication.Get(customerId);
            if (customerDto.Data == null) return NotFound(customerDto.Message);
            if (customersDto == null) return BadRequest();
            var response = _customersApplication.Update(customersDto);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("Delete/{customerId}")]
        public IActionResult Delete(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = _customersApplication.Delete(customerId);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("Get/{customerId}")]
        public IActionResult Get(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = _customersApplication.Get(customerId);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = _customersApplication.GetAll();
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        #endregion

        #region Async Methods

        [HttpPost("InsertAsync")]
        public async Task<IActionResult> InsertAsync(CustomersDto customersDto)
        {
            if (customersDto == null)
            {
                return BadRequest();
            }
            var response = await _customersApplication.InsertAsync(customersDto);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("UpdateAsync/{customerId}")]
        public async Task<IActionResult> UpdateAsync(string customerId, [FromBody]CustomersDto customersDto)
        {
            var customerDto = _customersApplication.Get(customerId);
            if (customerDto.Data == null) return NotFound(customerDto.Message);
            if (customersDto == null) return BadRequest();
            var response = await _customersApplication.UpdateAsync(customersDto);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("DeleteAsync/{customerId}")]
        public async Task<IActionResult> DeleteAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = await _customersApplication.DeleteAsync(customerId);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAsync/{customerId}")]
        public async Task<IActionResult> GetAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = await _customersApplication.GetAsync(customerId);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _customersApplication.GetAllAsync();
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        #endregion
    }
}