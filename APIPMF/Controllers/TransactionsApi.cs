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
using APIPMF.Services;

namespace APIPMF.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TransactionsApiController : ControllerBase
    {

        private readonly ITransactonsService _transactonsService;

        public TransactionsApiController(ITransactonsService transactonsService)
        {
            _transactonsService = transactonsService;
        }


        /// <summary>
        /// Auto categorize transactions
        /// </summary>
        /// <remarks>Auto categorizes transactions</remarks>
        /// <response code="200">OK - Transaction auto categorized</response>
        /// <response code="400">Your request was not constructed properly. Response contains the list of validation errors for each invalid element of your request. To learn more see general guidance on [validation](common-getstarted.html#validation).</response>
        /// <response code="0">Besides specific status codes above, other standard http [status codes](http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html) can be returned for each request. To learn more see general guidance on [error handling](common-getstarted.html#error-handling)</response>
        [HttpPost]
        [Route("/v1/pfm/transaction/auto-categorize")]
        
        public virtual IActionResult TransactionsAutoCategorize()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ValidationProblem));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ValidationProblem));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Categorize a transacation by id
        /// </summary>
        /// <remarks>Categorizes the transaction by id of the transaction</remarks>
        /// <param name="id">Transaction Id path parameter</param>
        /// <param name="body">Command to categorize transaction</param>
        /// <response code="200">OK - Transaction splitted</response>
        /// <response code="400">Your request was not constructed properly. Response contains the list of validation errors for each invalid element of your request. To learn more see general guidance on [validation](common-getstarted.html#validation).</response>
        /// <response code="440">Your request was well constructed but it could not be processed due to business policy.</response>
        /// <response code="0">Besides specific status codes above, other standard http [status codes](http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html) can be returned for each request. To learn more see general guidance on [error handling](common-getstarted.html#error-handling)</response>
        [HttpPost]
        [Route("/v1/pfm/transaction/{id}/categorize")]
      
        public virtual IActionResult TransactionsCategorize([FromRoute][Required]string id, [FromBody]TransactionCategorizeCommand body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ValidationProblem));

            //TODO: Uncomment the next line to return response 440 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(440, default(BusinessProblem));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ValidationProblem));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the list of transactions for current user
        /// </summary>
        /// <remarks>Gets the list of transactions for authorized user</remarks>
        /// <param name="transactionKind">Filter by transaction kind</param>
        /// <param name="startDate">Transactions that starts from date</param>
        /// <param name="endDate">Transactions that end until date</param>
        /// <param name="page">Page index. For more information see general guidance on [paging](common-getstarted.html#paging)</param>
        /// <param name="pageSize">Number of items on a page. For more information see general guidance on [paging](common-getstarted.html#paging)</param>
        /// <param name="sortBy">Attribute of the collection item to sort by. For more information see general guidance on [sorting](common-getstarted.html#sorting)</param>
        /// <param name="sortOrder">Sort order (&#x60;asc&#x60; or &#x60;desc&#x60;). Default is asc. For more information see general guidance on [sorting](common-getstarted.html#sorting)</param>
        /// <response code="200">OK</response>
        /// <response code="400">Your request was not constructed properly. Response contains the list of validation errors for each invalid element of your request. To learn more see general guidance on [validation](common-getstarted.html#validation).</response>
        /// <response code="0">Besides specific status codes above, other standard http [status codes](http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html) can be returned for each request. To learn more see general guidance on [error handling](common-getstarted.html#error-handling)</response>
        [HttpGet]
        [Route("/v1/pfm/transactions")]
        
        public virtual IActionResult TransactionsGetList([FromQuery]string transactionKind, [FromQuery]DateTime? startDate, [FromQuery]DateTime? endDate, [FromQuery]int? page, [FromQuery]int? pageSize, [FromQuery]string sortBy, [FromQuery]SortOrderEnum sortOrder)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TransactionPagedList));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ValidationProblem));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ValidationProblem));
            string exampleJson = null;
            exampleJson = "{\n  \"page-size\" : 20,\n  \"page\" : 1,\n  \"total-count\" : 100,\n  \"sort-by\" : \"date,catcode\",\n  \"sort-order\" : \"date,asc\",\n  \"items\" : [ {\n    \"id\" : 66229487,\n    \"beneficiary-name\" : \"Faculty of contemporary arts\",\n    \"date\" : \"1/1/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 187.20\",\n    \"description\" : \"Tuition\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 8299,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 15122088,\n    \"beneficiary-name\" : \"Glovo\",\n    \"date\" : \"1/1/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 44.30\",\n    \"description\" : \"Food delivery\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5811,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 71233330,\n    \"beneficiary-name\" : \"Glovo\",\n    \"date\" : \"1/1/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 17.00\",\n    \"description\" : \"Food delivery\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5811,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 24419286,\n    \"beneficiary-name\" : \"Claire Stevens\",\n    \"date\" : \"1/1/2021\",\n    \"direction\" : \"c\",\n    \"amount\" : \"??? 300.10\",\n    \"description\" : \"Monthly rent\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"dep\"\n  }, {\n    \"id\" : 31952674,\n    \"beneficiary-name\" : \"Josh\",\n    \"date\" : \"1/1/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 35.10\",\n    \"description\" : \"Allowance\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 76053069,\n    \"beneficiary-name\" : \"Hertz\",\n    \"date\" : \"1/1/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 11.60\",\n    \"description\" : \"Taxi\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 7519,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 67251535,\n    \"beneficiary-name\" : \"Book depository\",\n    \"date\" : \"1/2/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 15.60\",\n    \"description\" : \"Amazon Kindle subscription\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 51023898,\n    \"beneficiary-name\" : \"Table tenis club PingPong\",\n    \"date\" : \"1/2/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 12.30\",\n    \"description\" : \"Daily pool ticket\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5655,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 19088602,\n    \"beneficiary-name\" : \"Delhaize\",\n    \"date\" : \"1/3/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 33.50\",\n    \"description\" : \"Supermaket shopping\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5499,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 46251212,\n    \"beneficiary-name\" : \"Swimming school\",\n    \"date\" : \"1/3/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 22.00\",\n    \"description\" : \"Membership\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 38450379,\n    \"beneficiary-name\" : \"Blue moon spa\",\n    \"date\" : \"1/3/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 22.50\",\n    \"description\" : \"Massage\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 8050,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 40474619,\n    \"beneficiary-name\" : \"Adobe\",\n    \"date\" : \"1/3/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 20.10\",\n    \"description\" : \"Games\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5045,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 77280316,\n    \"beneficiary-name\" : \"MetLife\",\n    \"date\" : \"1/4/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 200.90\",\n    \"description\" : \"Life insurance premium\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 6300,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 62511511,\n    \"beneficiary-name\" : \"City parkings\",\n    \"date\" : \"1/5/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 2.30\",\n    \"description\" : \"Parking fee\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 7523,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 18709472,\n    \"beneficiary-name\" : \"A1 Telecom\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 6.90\",\n    \"description\" : \"Phone bill\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 56500502,\n    \"beneficiary-name\" : \"National Geographic\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 4.80\",\n    \"description\" : \"National Geographic\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5192,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 46134066,\n    \"beneficiary-name\" : \"Revolut\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 4.60\",\n    \"description\" : \"ATM withdrawal fee\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"fee\"\n  }, {\n    \"id\" : 28670410,\n    \"beneficiary-name\" : \"Wolt\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 48.40\",\n    \"description\" : \"Food delivery\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 5811,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 61393516,\n    \"beneficiary-name\" : \"Dental Plus\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 20.90\",\n    \"description\" : \"Doctor's appointment\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 8011,\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 31930196,\n    \"beneficiary-name\" : \"Claire Stevens\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"c\",\n    \"amount\" : \"??? 300.10\",\n    \"description\" : \"Monthly rent\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"dep\"\n  }, {\n    \"id\" : 25661064,\n    \"beneficiary-name\" : \"Swimming school\",\n    \"date\" : \"1/6/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 27.10\",\n    \"description\" : \"Membership\",\n    \"currency\" : \"USD\",\n    \"kind\" : \"pmt\"\n  }, {\n    \"id\" : 55836439,\n    \"beneficiary-name\" : \"Faculty of contemporary arts\",\n    \"date\" : \"1/7/2021\",\n    \"direction\" : \"d\",\n    \"amount\" : \"??? 185.50\",\n    \"description\" : \"Tuition\",\n    \"currency\" : \"USD\",\n    \"mcc\" : 8299,\n    \"kind\" : \"pmt\"\n  } ]\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TransactionPagedList>(exampleJson)
                        : default(TransactionPagedList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Import transactions
        /// </summary>
        /// <remarks>Imports transactions</remarks>
        /// <param name="body">Command to import transaction</param>
        /// <response code="200">OK - Transaction splitted</response>
        /// <response code="400">Your request was not constructed properly. Response contains the list of validation errors for each invalid element of your request. To learn more see general guidance on [validation](common-getstarted.html#validation).</response>
        /// <response code="440">Your request was well constructed but it could not be processed due to business policy.</response>
        /// <response code="0">Besides specific status codes above, other standard http [status codes](http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html) can be returned for each request. To learn more see general guidance on [error handling](common-getstarted.html#error-handling)</response>
        [HttpPost]
        [Route("/v1/pfm/transactions/import")]
        public virtual IActionResult TransactionsImport([FromBody]Transaction body)
        {
            Task<Transaction> transaction = _transactonsService.importTransaction(body);

            if(transaction == null)
            {
                return NotFound();
            }else
            {
                return Ok(transaction);
            }
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ValidationProblem));

            //TODO: Uncomment the next line to return response 440 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(440, default(BusinessProblem));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ValidationProblem));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Split transacation by id
        /// </summary>
        /// <remarks>Splits transaction by id of the transaction</remarks>
        /// <param name="id">Transaction Id path parameter</param>
        /// <param name="body">Command to split transaction</param>
        /// <response code="200">OK - Transaction splitted</response>
        /// <response code="400">Your request was not constructed properly. Response contains the list of validation errors for each invalid element of your request. To learn more see general guidance on [validation](common-getstarted.html#validation).</response>
        /// <response code="440">Your request was well constructed but it could not be processed due to business policy.</response>
        /// <response code="0">Besides specific status codes above, other standard http [status codes](http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html) can be returned for each request. To learn more see general guidance on [error handling](common-getstarted.html#error-handling)</response>
        [HttpPost]
        [Route("/v1/pfm/transaction/{id}/split")]
        public virtual IActionResult TransactionsSplit([FromRoute][Required]string id, [FromBody]SplitTransactionCommand body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ValidationProblem));

            //TODO: Uncomment the next line to return response 440 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(440, default(BusinessProblem));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(ValidationProblem));

            throw new NotImplementedException();
        }
    }
}
