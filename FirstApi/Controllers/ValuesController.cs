using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values/5
        [HttpGet]
        public string Get(int id)
        {
            return "hello world";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// 两个整数相加
        /// </summary>
        /// <param name="num1">第一个整数</param>
        /// <param name="num2">第二个整数</param>
        /// <returns>累加结果</returns>
        [HttpGet]
        public ActionResult<int> Sum(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }

        [HttpPost]
        public ActionResult<responseResult> Sumn([FromForm]Param param)
        {
            return new responseResult() { result = (param.num1 + param.num2).ToString() };
        }

        /// <summary>
        /// 两数相减
        /// </summary>
        /// <param name="param">参数</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<responseResult> Subtract([FromForm]Param param)
        {
            return new responseResult() { result = (param.num1 - param.num2).ToString() };
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public ActionResult<responseResult> Put(int id, [FromForm]Param param)
        {
            return new responseResult() { result = "true" };
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<responseResult> Delete(int id)
        {
            return new responseResult() { result = "true" };
        }
    }
}