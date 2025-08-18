using System;
using System.Collections.Generic;

namespace PortalAPI.ViewModel
{
    enum StatusCode
    {
        NotModified = 304,
        NoContent = 204,
        ServiceUnAvailable = 503,
        OK = 200,
        NotFound = 404,
        Created = 201,
        Accepted = 202,
        EnternalServerError = 500,
        NotAcceptable = 406
    }
    public class VM_Resault
    {
        public int code { get; set; }
        public bool error { get; set; }
        public string message { get; set; }
        public List<object> data { get; set; }
    }
}
