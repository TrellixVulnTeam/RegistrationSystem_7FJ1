﻿using RegistrationSystem.Enums;

namespace RegistrationSystem.Models
{
    public class Response
    {

        public Response(ResponseCode responseCode, string responseMessage, object dataSet )
        {
            ResponseCode = responseCode;
            ResponseMessage = responseMessage;
            DataSet = dataSet;
        }
        public ResponseCode ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public object DataSet { get; set; }
    }
}
