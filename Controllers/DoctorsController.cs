using Microsoft.AspNetCore.Mvc;
using s21340_exam.Middlewares.ExceptionHandling;
using s21340_exam.Middlewares.TransactionsHandling;
using s21340_exam.Services;

namespace s21340_exam.Controllers;

[ApiController]
[Route("/api/doctors")]
public class DoctorsController : ControllerBase
{
    private readonly DoctorService _doctorService;

    public DoctorsController(DoctorService doctorService)
    {
        _doctorService = doctorService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(GlobalExceptionHandlerMiddleware.ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(GlobalExceptionHandlerMiddleware.ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetDoctorDetails(int id)
    {
        var result = await _doctorService.GetDoctorDetails(id);

        return Ok(result);
    }

    [Transactional]
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(GlobalExceptionHandlerMiddleware.ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(GlobalExceptionHandlerMiddleware.ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DeleteDoctor(int id)
    {
        await _doctorService.RemoveDoctorById(id);

        return NoContent();
    }
}