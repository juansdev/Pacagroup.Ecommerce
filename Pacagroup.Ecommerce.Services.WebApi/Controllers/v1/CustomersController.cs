using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface;

namespace Pacagroup.Ecommerce.Services.WebApi.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    public class CustomersController : Controller
    {
        private readonly ICustomersApplication _customersApplication;
        public CustomersController(ICustomersApplication customersApplication)
        {
            _customersApplication = customersApplication;
        }

        #region Sync Methods

        [HttpPost("Insert")]
        public IActionResult Insert(CustomersDto customersDto)
        {
            if (customersDto == null)
            {
                return BadRequest();
            }
            var response = _customersApplication.Insert(customersDto);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("Update")]
        public IActionResult Update(CustomersDto customersDto)
        {
            if (customersDto == null)
            {
                return BadRequest();
            }
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

        #region

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

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(CustomersDto customersDto)
        {
            if (customersDto == null)
            {
                return BadRequest();
            }
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
