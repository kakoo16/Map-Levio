using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAP_PI.Web.Controllers
{
    public class AccountAPIController : ApiController
    {
        GestionUser us;

        public AccountAPIController()
        {
            us = new GestionUser();
        }

        // GET: api/AccountApi/5
        public HttpResponseMessage GetUsRoMemeber()
        {
            var re = Request;
            var headers = re.Headers;
            string token = "";

            if (headers.Contains("Member"))
            {
                token = headers.GetValues("Member").First();
            }

           Person u = us.getUserByRoleMember();
            var response = Request.CreateResponse(HttpStatusCode.OK, u);
            response.Headers.Add("token", token);

            return response;
        }


    }
}
