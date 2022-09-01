using DSA.Sorting;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SortingController : ControllerBase
    {

        private readonly ILogger<SortingController> _logger;
        private readonly IBruteForceSort _bruteForce;

        public SortingController(ILogger<SortingController> logger, IBruteForceSort bruteForce)
        {
            _logger = logger;
            _bruteForce = bruteForce;
        }


        /// <summary>
        /// Uses a Brute Force Selection Sort to Sort a List of Integers
        /// </summary>
        /// <param name="unsortedArray">A list of integer values</param>
        /// <returns>The input list sorted in Ascending order</returns>
        /// <remarks>
        /// Sample request
        /// 
        /// 
        ///     POST /SelectionSort
        ///     
        ///        [8,6,4,2,9,1,0]
        ///     
        ///
        /// </remarks>
        /// <response code="200">Returns the sorted list</response>
        /// <response code="400">Sorting your list threw an error</response>
        [HttpPost("SelectionSort")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult SelectionSort(List<int> unsortedArray)
        {
            try
            {
                return Ok(_bruteForce.SelectionSort(unsortedArray));
            }
            catch(Exception ex)
            {
                 _logger.LogError($"Error proccessing Selection Sort Request {ex}");
                return BadRequest();
            }
            
        }

        /// <summary>
        /// Uses a Brute Force Bubble Sort to Sort a List of Integers
        /// </summary>
        /// <param name="unsortedArray">A list of integer values</param>
        /// <returns>The input list sorted in Ascending order</returns>
        /// <remarks>
        /// Sample request
        /// 
        /// 
        ///     POST /BubbleSort
        ///     
        ///        [8,6,4,2,9,1,0]
        ///     
        ///
        /// </remarks>
        /// <response code="200">Returns the sorted list</response>
        /// <response code="400">Sorting your list threw an error</response>
        [HttpPost("BubbleSort")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult BubbleSort(List<int> unsortedArray)
        {
            try
            {
                return Ok(_bruteForce.BubbleSort(unsortedArray));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error proccessing Bubble Sort Request {ex}");
                return BadRequest();
            }

        }
    }
}