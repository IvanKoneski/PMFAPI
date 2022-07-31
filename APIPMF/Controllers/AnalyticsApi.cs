/*
 * Personal Finance Management API
 *
 * Personal Finance Management API allows analyze of a client's spending patterns against pre-defined budgets over time 
 *
 * OpenAPI spec version: v1
 * Contact: aleksandar.milosevic@asseco-see.rs
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
//using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using APIPMF.Attributes;

using Microsoft.AspNetCore.Authorization;
using APIPMF.Models;

namespace APIPMF.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AnalyticsApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieve spending analytics by category or by subcategories witin category
        /// </summary>
        /// <remarks>Retrieves spending analytics by category or by subcategories witin category</remarks>
        /// <param name="catcode">Category code for filtering spendings</param>
        /// <param name="startDate">Transactions that starts from date</param>
        /// <param name="endDate">Transactions that end until date</param>
        /// <param name="direction">Filter by transaction kind</param>
        /// <response code="200">OK</response>
        /// <response code="400">Your request was not constructed properly. Response contains the list of validation errors for each invalid element of your request. To learn more see general guidance on [validation](common-getstarted.html#validation).</response>
        [HttpGet]
        [Route("/v1/pfm/spending-analytics")]
        [ValidateModelState]
        public virtual IActionResult SpendingsGet([FromQuery]string catcode, [FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate, [FromQuery]DirectionsEnum direction)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SpendingsByCategory));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ValidationProblem));
            string exampleJson = null;
            exampleJson = "{\n  \"groups\" : [ {\n    \"amount\" : 0.8008281904610115,\n    \"catcode\" : \"catcode\",\n    \"count\" : 6.027456183070403\n  }, {\n    \"amount\" : 0.8008281904610115,\n    \"catcode\" : \"catcode\",\n    \"count\" : 6.027456183070403\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SpendingsByCategory>(exampleJson)
                        : default(SpendingsByCategory);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
